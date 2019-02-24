using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacogeneDataQuery
{

        // 這個物件的目的
        // 是記錄一個患者所有pharmacy-gene 紀錄的資訊
        // 所以應該要有patient ID(string)
        // 所有pharmacy-gene 的資訊(list)
        // 這裡可以參考一下.pptx
        class PersonalRecord
        {
            // constructor
            public PersonalRecord()
            {
                DrugGeneRecordList = new List<string[]>();
                this.patientID = string.Empty;
            }

            // ID是從上一步輸出的表格讀得的
            public string AccessID
            {
                get { return patientID; }
                set { this.patientID = value; }
            }

            public List<string[]> AccessDrugGeneRecordList
            {
                get { return DrugGeneRecordList; }
                set { this.DrugGeneRecordList = value; }
            }

            private string patientID;
            // DrugGenerecordList
            // 這是用來記錄subject每一個Gene-genotype對應的藥品資料
            // 而這個List之中每一個元素代表的就是一筆基因藥品的資料

            private List<string[]> DrugGeneRecordList;


        }
    
}
