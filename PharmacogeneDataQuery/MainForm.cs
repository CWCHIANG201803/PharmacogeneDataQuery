using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PharmacogeneDataQuery
{
    public partial class Form_textRead : Form
    {
        // declare person object with type PersonalRecord
        private PersonalRecord person = new PersonalRecord();

        // declare PATH object with DIR_Path_Entity
        private DIR_Path_Entity PATH = new DIR_Path_Entity();

        private List<string[]> GeneInfoList = new List<string[]>();
        private string DatabasebName = "PharmcogeneCombine.mdb";

        public Form_textRead()
        {
            InitializeComponent();
            btnQueryDrugInfo.Enabled = false;
            btnClearQuery.Enabled = false;
            btnSearchGene.Enabled = false;
            btnClearSearchTxt.Enabled = false;
            txtBoxDrugNameInput.Enabled = false;
        }



        // event function maps to "Read Gene Info"
        private void btnReadGeneInfo_Click(object sender, EventArgs e)
        {
            LstViewSample.Items.Clear();
            LoadGeneInfoData();
            btnQueryDrugInfo.Enabled = true;

        }

        private void LoadGeneInfoData()
        {
            // string[] is an string array
            // this statement is to get a file list in PATH.DIR_DATA_INPUT
            string[] INPUT_FILE_LIST = Directory.GetFiles(PATH.DIR_DATA_INPUT);

            // this is a demo, only one input case in the input directory
            // so I just take index=0 case
            string _FilePath = INPUT_FILE_LIST[0];

            GeneInfoList.Clear();

            try
            {
                // this section is dealing with input text data in the input directory.
                using (System.IO.StreamReader FILE_STREAM = new System.IO.StreamReader(_FilePath))
                {
                    // GeneInfoList用來記載外部檔案中讀取進來的資訊，
                    // 最終他會把資料存到Personal record,所以只需要當local variable
                    string DATA_LINE;
                    while ((DATA_LINE = FILE_STREAM.ReadLine()) != null)
                    {
                        GeneInfoList.Add(DATA_LINE.Split('\t'));
                        // item maps to the windows Input Gene Info.
                        // in ListViewItem, we have primary column and secondary column
                        //primary column is the 1st column; secondary column are those columns aside from the primary column

                        // fill item in the primary column
                        ListViewItem item = new ListViewItem(DATA_LINE.Split('\t')[0]);
                        // fill item in the secondary column
                        // in this case, we only have one column in the secondary column.
                        item.SubItems.Add(DATA_LINE.Split('\t')[1]);

                        // fill the data into the Control element.
                        LstViewSample.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                //when something wrong occurs, display the message
                Console.WriteLine(ex.Message);
            }

        }

        // event function corresponds to "Read DB Data" button
        private void btnReadDB_Click(object sender, EventArgs e)
        {
            GridViewDbData.ClearSelection();
            LoadDbData();
        }

        private void LoadDbData()
        {
            // sql command => take all columns in database
            string SQLcommand = string.Format(@"SELECT * FROM TablePharmacogene");

            // connection string
            string connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Path.Combine(PATH.DIR_DATA_SOURCE, DatabasebName));


            // this is for database connect
            // traditionally, when retrieving data from database, 
            // "open", "read/write", "close" three actions
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection
                OleDbCommand cmd = new OleDbCommand(SQLcommand, connection);
                // Open the connection and execute the select command. 
                // sometimes errors may occur, so use try ... catch to deal with exception
                try
                {
                    // Open connecton  
                    connection.Open();

                    // refer to this
                    // https://dotblogs.com.tw/yc421206/2009/07/12/9355
                    OleDbDataAdapter a = new OleDbDataAdapter(cmd);

                    // DataTable is a datatype which form is like worksheet in excel.
                    DataTable dt = new DataTable();


                    a.SelectCommand = cmd;

                    a.Fill(dt);

                    // GridViewDbData corresponds to the component in the windows
                    // which demonstrates data in database.
                    GridViewDbData.DataSource = dt;

                    // auto resize column
                    GridViewDbData.AutoResizeColumns();
                }
                catch (Exception ex)
                {

                    // when error occurs, display ex.Message
                    Console.WriteLine(ex.Message);
                }
            }
        }




        private void btnQueryDrugInfo_Click(object sender, EventArgs e)
        {
            LstViewQuery.Items.Clear();
            RetrieveDrugInfoBaseOnSample();
            btnClearQuery.Enabled = true;
            btnSearchGene.Enabled = true;
            btnClearSearchTxt.Enabled = true;
            txtBoxDrugNameInput.Enabled = true;
        }


        private void RetrieveDrugInfoBaseOnSample()
        {
            // connecting with database
            string connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Path.Combine(PATH.DIR_DATA_SOURCE, DatabasebName));
            person.AccessDrugGeneRecordList.Clear();

            // 這個string array list是用來紀錄那些沒有找到資料的GeneInfo
            List<string[]> GeneInfoNotFound = new List<string[]>();

            // 下command存取database 中的 gene info
            List<string> GeneNameFromDB = ReadGeneName(connectionString);
            int indexCount = 1;

            foreach (string[] GeneInfo in GeneInfoList)
            {
                string targetGeneName = GeneInfo[0];
                string targetGenoType = GeneInfo[1];
                List<string> GenoTypeFromDB = ReadGenoType(connectionString, targetGeneName);

                if (GeneNameFromDB.FindIndex(item => (item == targetGeneName)) < 0 || GenoTypeFromDB.FindIndex(item => (item == targetGenoType)) < 0)
                {
                    // 代表沒有找到gene 
                    GeneInfoNotFound.Add(new string[] { targetGeneName, targetGenoType });
                }
                else
                {
                    // 有找到gene,但仍要進一步檢查genotype

                    List<string[]> DrugInfoFromDB = ReadDrugInfo(connectionString, targetGeneName, targetGenoType);

                    foreach (string[] xx in DrugInfoFromDB)
                    {
                        person.AccessDrugGeneRecordList.Add(xx);

                        ListViewItem item = new ListViewItem(xx[0]);
                        for (int i = 1; i < xx.Length; i++)
                            item.SubItems.Add(xx[i]);
                        LstViewQuery.Items.Add(item);
                        indexCount++;
                    }
                }
            }
        }

        // normal function to get GeneName
        private List<string> ReadGeneName(string _connectionString)
        {
            List<string> data = new List<string>();

            string SQLcommand = string.Format(@"SELECT DISTINCT GeneName FROM TablePharmacogene");
            // read gene infor
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQLcommand, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            data.Add(reader["GeneName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return data;
        }

        // normal function to get GenoType
        private List<string> ReadGenoType(string _connectionString, string _GeneName)
        {

            List<string> data = new List<string>();
            string SQLcommand_GenoType = string.Format(@"SELECT DISTINCT GenoType FROM TablePharmacogene WHERE GeneName='{0}'", _GeneName);
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQLcommand_GenoType, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            data.Add(reader["GenoType"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return data;
        }

        // normal function to get Drug Information
        private List<string[]> ReadDrugInfo(string _connectionString, string _GeneName, string _GenoType)
        {

            List<string[]> DrugData = new List<string[]>();

            string SQLcommand_DrugInfo = string.Format(@"SELECT ATC_CODE,DrugName,PHENOTYPE,ACTIVITY_SCORE,Message FROM TablePharmacogene WHERE GeneName='{0}' AND GenoType='{1}'", _GeneName, _GenoType);

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQLcommand_DrugInfo, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            string[] SingleData = new string[] { _GeneName, _GenoType, reader["DrugName"].ToString(), reader["ATC_CODE"].ToString(), reader["PHENOTYPE"].ToString(), reader["ACTIVITY_SCORE"].ToString(), reader["Message"].ToString() };
                            //Console.Write("{0}\t{1}\n", SingleData[0], SingleData[1]);
                            DrugData.Add(SingleData);
                            count++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return DrugData;
        }

        // this event function corresponeds to data "Find" button in the tab "Drug Search"
        private void button1_Click(object sender, EventArgs e)
        {
            LstViewGene.Items.Clear();
            string DrugName = string.Empty;
            DrugName = txtBoxDrugNameInput.Text;
            // when the string is empty
            if (!string.IsNullOrEmpty(DrugName))
            {

                var drugQuery = from drugInfo in person.AccessDrugGeneRecordList
                                where drugInfo[2].Contains(DrugName)
                                orderby drugInfo[2]
                                select drugInfo;
                if(drugQuery.Count() >0)
                {
                    // fill data into ListView with specified index order
                    foreach (string[] xx in drugQuery)
                    {
                        ListViewItem item = new ListViewItem(xx[2]);
                        int[] Order = { 3, 0, 1, 4, 5 };
                        foreach (int index in Order)
                            item.SubItems.Add(xx[index]);
                        LstViewGene.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("your key word is error!","Input Error");
                }
            }
            else
            {
                // when text is empty 
                MessageBox.Show("please give the drug name", "Empty String");
            }
        }

        // this event function corresponeds to data "Clear" button in the Drug Search page
        private void btnClearSearchTxt_Click(object sender, EventArgs e)
        {
            txtBoxDrugNameInput.Text = string.Empty;
            LstViewGene.Items.Clear();
            this.LstViewGene.Visible = true;
        }

        private void btnClearQUery_Click(object sender, EventArgs e)
        {
            LstViewSample.Items.Clear();
            LstViewQuery.Items.Clear();
            GridViewDbData.ClearSelection();
            btnSearchGene.Enabled = false;
            btnClearSearchTxt.Enabled = false;
            txtBoxDrugNameInput.Enabled = false;
        }
    }
}
