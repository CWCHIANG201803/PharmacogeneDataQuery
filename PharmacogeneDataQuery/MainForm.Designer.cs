namespace PharmacogeneDataQuery
{
    partial class Form_textRead
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReadGeneInfo = new System.Windows.Forms.Button();
            this.LstViewSample = new System.Windows.Forms.ListView();
            this.colGeneName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGenoType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabInputAndQueryDrug = new System.Windows.Forms.TabPage();
            this.LstViewQuery = new System.Windows.Forms.ListView();
            this.queryColGeneName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryColGenoType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryDrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryATCCOde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryPhenoType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryActivityScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lbl_QueriedData = new System.Windows.Forms.Label();
            this.Lbl_DatabaseSource = new System.Windows.Forms.Label();
            this.Lbl_InputGeneInfo = new System.Windows.Forms.Label();
            this.btnQueryDrugInfo = new System.Windows.Forms.Button();
            this.GridViewDbData = new System.Windows.Forms.DataGridView();
            this.btnReadDB = new System.Windows.Forms.Button();
            this.btnClearQuery = new System.Windows.Forms.Button();
            this.TabSearchGenotypeInfo = new System.Windows.Forms.TabPage();
            this.btnClearSearchTxt = new System.Windows.Forms.Button();
            this.LabelUseTip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LstViewGene = new System.Windows.Forms.ListView();
            this.qDrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qGeneName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qATCCODE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qGenoType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qPhenotype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qActivityScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchGene = new System.Windows.Forms.Button();
            this.txtBoxDrugNameInput = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.TabInputAndQueryDrug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDbData)).BeginInit();
            this.TabSearchGenotypeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadGeneInfo
            // 
            this.btnReadGeneInfo.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btnReadGeneInfo.Location = new System.Drawing.Point(17, 328);
            this.btnReadGeneInfo.Name = "btnReadGeneInfo";
            this.btnReadGeneInfo.Size = new System.Drawing.Size(194, 42);
            this.btnReadGeneInfo.TabIndex = 2;
            this.btnReadGeneInfo.Text = "Read GeneInfo";
            this.btnReadGeneInfo.UseVisualStyleBackColor = true;
            this.btnReadGeneInfo.Click += new System.EventHandler(this.btnReadGeneInfo_Click);
            // 
            // LstViewSample
            // 
            this.LstViewSample.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewSample.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGeneName,
            this.colGenoType});
            this.LstViewSample.FullRowSelect = true;
            this.LstViewSample.Location = new System.Drawing.Point(17, 38);
            this.LstViewSample.MultiSelect = false;
            this.LstViewSample.Name = "LstViewSample";
            this.LstViewSample.Scrollable = false;
            this.LstViewSample.ShowItemToolTips = true;
            this.LstViewSample.Size = new System.Drawing.Size(208, 255);
            this.LstViewSample.TabIndex = 2;
            this.LstViewSample.UseCompatibleStateImageBehavior = false;
            this.LstViewSample.View = System.Windows.Forms.View.Details;
            // 
            // colGeneName
            // 
            this.colGeneName.Text = "Gene Name";
            this.colGeneName.Width = 90;
            // 
            // colGenoType
            // 
            this.colGenoType.Text = "GenoType";
            this.colGenoType.Width = 80;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabInputAndQueryDrug);
            this.tabControl.Controls.Add(this.TabSearchGenotypeInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1441, 871);
            this.tabControl.TabIndex = 3;
            // 
            // TabInputAndQueryDrug
            // 
            this.TabInputAndQueryDrug.BackColor = System.Drawing.SystemColors.Control;
            this.TabInputAndQueryDrug.Controls.Add(this.LstViewQuery);
            this.TabInputAndQueryDrug.Controls.Add(this.Lbl_QueriedData);
            this.TabInputAndQueryDrug.Controls.Add(this.Lbl_DatabaseSource);
            this.TabInputAndQueryDrug.Controls.Add(this.Lbl_InputGeneInfo);
            this.TabInputAndQueryDrug.Controls.Add(this.btnQueryDrugInfo);
            this.TabInputAndQueryDrug.Controls.Add(this.GridViewDbData);
            this.TabInputAndQueryDrug.Controls.Add(this.LstViewSample);
            this.TabInputAndQueryDrug.Controls.Add(this.btnReadDB);
            this.TabInputAndQueryDrug.Controls.Add(this.btnReadGeneInfo);
            this.TabInputAndQueryDrug.Controls.Add(this.btnClearQuery);
            this.TabInputAndQueryDrug.Location = new System.Drawing.Point(4, 25);
            this.TabInputAndQueryDrug.Name = "TabInputAndQueryDrug";
            this.TabInputAndQueryDrug.Padding = new System.Windows.Forms.Padding(3);
            this.TabInputAndQueryDrug.Size = new System.Drawing.Size(1433, 842);
            this.TabInputAndQueryDrug.TabIndex = 0;
            this.TabInputAndQueryDrug.Text = "Input Data";
            // 
            // LstViewQuery
            // 
            this.LstViewQuery.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.queryColGeneName,
            this.queryColGenoType,
            this.queryDrugName,
            this.queryATCCOde,
            this.queryPhenoType,
            this.queryActivityScore,
            this.queryMessage});
            this.LstViewQuery.FullRowSelect = true;
            this.LstViewQuery.Location = new System.Drawing.Point(231, 327);
            this.LstViewQuery.Name = "LstViewQuery";
            this.LstViewQuery.Size = new System.Drawing.Size(971, 483);
            this.LstViewQuery.TabIndex = 7;
            this.LstViewQuery.UseCompatibleStateImageBehavior = false;
            this.LstViewQuery.View = System.Windows.Forms.View.Details;
            // 
            // queryColGeneName
            // 
            this.queryColGeneName.Text = "Gene Name";
            this.queryColGeneName.Width = 101;
            // 
            // queryColGenoType
            // 
            this.queryColGenoType.Text = "Geno Type";
            this.queryColGenoType.Width = 96;
            // 
            // queryDrugName
            // 
            this.queryDrugName.Text = "Drug Name";
            this.queryDrugName.Width = 107;
            // 
            // queryATCCOde
            // 
            this.queryATCCOde.Text = "ATC Code";
            this.queryATCCOde.Width = 109;
            // 
            // queryPhenoType
            // 
            this.queryPhenoType.Text = "PHENOTYPE";
            this.queryPhenoType.Width = 108;
            // 
            // queryActivityScore
            // 
            this.queryActivityScore.Text = "Activity Score";
            // 
            // queryMessage
            // 
            this.queryMessage.Text = "Message";
            // 
            // Lbl_QueriedData
            // 
            this.Lbl_QueriedData.AutoSize = true;
            this.Lbl_QueriedData.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lbl_QueriedData.Location = new System.Drawing.Point(226, 297);
            this.Lbl_QueriedData.Name = "Lbl_QueriedData";
            this.Lbl_QueriedData.Size = new System.Drawing.Size(139, 27);
            this.Lbl_QueriedData.TabIndex = 6;
            this.Lbl_QueriedData.Text = "Query Result";
            // 
            // Lbl_DatabaseSource
            // 
            this.Lbl_DatabaseSource.AutoSize = true;
            this.Lbl_DatabaseSource.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lbl_DatabaseSource.Location = new System.Drawing.Point(226, 8);
            this.Lbl_DatabaseSource.Name = "Lbl_DatabaseSource";
            this.Lbl_DatabaseSource.Size = new System.Drawing.Size(177, 27);
            this.Lbl_DatabaseSource.TabIndex = 6;
            this.Lbl_DatabaseSource.Text = "Data in Database";
            // 
            // Lbl_InputGeneInfo
            // 
            this.Lbl_InputGeneInfo.AutoSize = true;
            this.Lbl_InputGeneInfo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Lbl_InputGeneInfo.Location = new System.Drawing.Point(12, 2);
            this.Lbl_InputGeneInfo.Name = "Lbl_InputGeneInfo";
            this.Lbl_InputGeneInfo.Size = new System.Drawing.Size(172, 27);
            this.Lbl_InputGeneInfo.TabIndex = 6;
            this.Lbl_InputGeneInfo.Text = "Input Gene Info.";
            // 
            // btnQueryDrugInfo
            // 
            this.btnQueryDrugInfo.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btnQueryDrugInfo.Location = new System.Drawing.Point(17, 476);
            this.btnQueryDrugInfo.Name = "btnQueryDrugInfo";
            this.btnQueryDrugInfo.Size = new System.Drawing.Size(194, 48);
            this.btnQueryDrugInfo.TabIndex = 4;
            this.btnQueryDrugInfo.Text = "Query";
            this.btnQueryDrugInfo.UseVisualStyleBackColor = true;
            this.btnQueryDrugInfo.Click += new System.EventHandler(this.btnQueryDrugInfo_Click);
            // 
            // GridViewDbData
            // 
            this.GridViewDbData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewDbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDbData.Location = new System.Drawing.Point(231, 38);
            this.GridViewDbData.Name = "GridViewDbData";
            this.GridViewDbData.RowTemplate.Height = 27;
            this.GridViewDbData.Size = new System.Drawing.Size(971, 255);
            this.GridViewDbData.TabIndex = 3;
            // 
            // btnReadDB
            // 
            this.btnReadDB.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btnReadDB.Location = new System.Drawing.Point(17, 402);
            this.btnReadDB.Name = "btnReadDB";
            this.btnReadDB.Size = new System.Drawing.Size(194, 42);
            this.btnReadDB.TabIndex = 2;
            this.btnReadDB.Text = "Read DB Data";
            this.btnReadDB.UseVisualStyleBackColor = true;
            this.btnReadDB.Click += new System.EventHandler(this.btnReadDB_Click);
            // 
            // btnClearQuery
            // 
            this.btnClearQuery.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btnClearQuery.Location = new System.Drawing.Point(17, 550);
            this.btnClearQuery.Name = "btnClearQuery";
            this.btnClearQuery.Size = new System.Drawing.Size(194, 42);
            this.btnClearQuery.TabIndex = 1;
            this.btnClearQuery.Text = "Clear";
            this.btnClearQuery.Click += new System.EventHandler(this.btnClearQUery_Click);
            // 
            // TabSearchGenotypeInfo
            // 
            this.TabSearchGenotypeInfo.BackColor = System.Drawing.SystemColors.Control;
            this.TabSearchGenotypeInfo.Controls.Add(this.btnClearSearchTxt);
            this.TabSearchGenotypeInfo.Controls.Add(this.LabelUseTip);
            this.TabSearchGenotypeInfo.Controls.Add(this.label1);
            this.TabSearchGenotypeInfo.Controls.Add(this.LstViewGene);
            this.TabSearchGenotypeInfo.Controls.Add(this.btnSearchGene);
            this.TabSearchGenotypeInfo.Controls.Add(this.txtBoxDrugNameInput);
            this.TabSearchGenotypeInfo.Location = new System.Drawing.Point(4, 25);
            this.TabSearchGenotypeInfo.Name = "TabSearchGenotypeInfo";
            this.TabSearchGenotypeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabSearchGenotypeInfo.Size = new System.Drawing.Size(1433, 842);
            this.TabSearchGenotypeInfo.TabIndex = 1;
            this.TabSearchGenotypeInfo.Text = "DrugSearch";
            // 
            // btnClearSearchTxt
            // 
            this.btnClearSearchTxt.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.btnClearSearchTxt.Location = new System.Drawing.Point(554, 143);
            this.btnClearSearchTxt.Name = "btnClearSearchTxt";
            this.btnClearSearchTxt.Size = new System.Drawing.Size(97, 42);
            this.btnClearSearchTxt.TabIndex = 4;
            this.btnClearSearchTxt.Text = "&Clear";
            this.btnClearSearchTxt.UseVisualStyleBackColor = true;
            this.btnClearSearchTxt.Click += new System.EventHandler(this.btnClearSearchTxt_Click);
            // 
            // LabelUseTip
            // 
            this.LabelUseTip.AutoSize = true;
            this.LabelUseTip.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LabelUseTip.Location = new System.Drawing.Point(23, 88);
            this.LabelUseTip.Name = "LabelUseTip";
            this.LabelUseTip.Size = new System.Drawing.Size(336, 22);
            this.LabelUseTip.TabIndex = 3;
            this.LabelUseTip.Text = "For example, you can type \'amitriptyline\' ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(23, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Drug Name";
            // 
            // LstViewGene
            // 
            this.LstViewGene.BackColor = System.Drawing.SystemColors.Control;
            this.LstViewGene.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qDrugName,
            this.qGeneName,
            this.qATCCODE,
            this.qGenoType,
            this.qPhenotype,
            this.qActivityScore});
            this.LstViewGene.FullRowSelect = true;
            this.LstViewGene.Location = new System.Drawing.Point(27, 229);
            this.LstViewGene.Name = "LstViewGene";
            this.LstViewGene.Size = new System.Drawing.Size(846, 248);
            this.LstViewGene.TabIndex = 2;
            this.LstViewGene.UseCompatibleStateImageBehavior = false;
            this.LstViewGene.View = System.Windows.Forms.View.Details;
            // 
            // qDrugName
            // 
            this.qDrugName.Text = "Drug Name";
            this.qDrugName.Width = 80;
            // 
            // qGeneName
            // 
            this.qGeneName.Text = "Gene Name";
            this.qGeneName.Width = 90;
            // 
            // qATCCODE
            // 
            this.qATCCODE.Text = "ATC Code";
            this.qATCCODE.Width = 85;
            // 
            // qGenoType
            // 
            this.qGenoType.Text = "Geno Type";
            this.qGenoType.Width = 80;
            // 
            // qPhenotype
            // 
            this.qPhenotype.Text = "Phenotype";
            this.qPhenotype.Width = 80;
            // 
            // qActivityScore
            // 
            this.qActivityScore.Text = "Activity Score";
            this.qActivityScore.Width = 110;
            // 
            // btnSearchGene
            // 
            this.btnSearchGene.Location = new System.Drawing.Point(411, 143);
            this.btnSearchGene.Name = "btnSearchGene";
            this.btnSearchGene.Size = new System.Drawing.Size(114, 42);
            this.btnSearchGene.TabIndex = 1;
            this.btnSearchGene.Text = "&Search";
            this.btnSearchGene.UseVisualStyleBackColor = true;
            this.btnSearchGene.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxDrugNameInput
            // 
            this.txtBoxDrugNameInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxDrugNameInput.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.txtBoxDrugNameInput.Location = new System.Drawing.Point(27, 149);
            this.txtBoxDrugNameInput.Name = "txtBoxDrugNameInput";
            this.txtBoxDrugNameInput.Size = new System.Drawing.Size(365, 31);
            this.txtBoxDrugNameInput.TabIndex = 0;
            // 
            // Form_textRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1441, 871);
            this.Controls.Add(this.tabControl);
            this.Name = "Form_textRead";
            this.Text = "Pharmacogene Data Query Model";
            this.tabControl.ResumeLayout(false);
            this.TabInputAndQueryDrug.ResumeLayout(false);
            this.TabInputAndQueryDrug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDbData)).EndInit();
            this.TabSearchGenotypeInfo.ResumeLayout(false);
            this.TabSearchGenotypeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReadGeneInfo;
        private System.Windows.Forms.ListView LstViewSample;
        private System.Windows.Forms.ColumnHeader colGeneName;
        private System.Windows.Forms.ColumnHeader colGenoType;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TabInputAndQueryDrug;
        private System.Windows.Forms.TabPage TabSearchGenotypeInfo;
        private System.Windows.Forms.DataGridView GridViewDbData;
        private System.Windows.Forms.Button btnQueryDrugInfo;
        private System.Windows.Forms.Label Lbl_QueriedData;
        private System.Windows.Forms.Label Lbl_DatabaseSource;
        private System.Windows.Forms.Label Lbl_InputGeneInfo;
        private System.Windows.Forms.ListView LstViewQuery;
        private System.Windows.Forms.ColumnHeader queryColGeneName;
        private System.Windows.Forms.ColumnHeader queryColGenoType;
        private System.Windows.Forms.ColumnHeader queryDrugName;
        private System.Windows.Forms.ColumnHeader queryATCCOde;
        private System.Windows.Forms.ColumnHeader queryPhenoType;
        private System.Windows.Forms.ColumnHeader queryActivityScore;
        private System.Windows.Forms.ColumnHeader queryMessage;
        private System.Windows.Forms.TextBox txtBoxDrugNameInput;
        private System.Windows.Forms.ListView LstViewGene;
        private System.Windows.Forms.Button btnSearchGene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader qDrugName;
        private System.Windows.Forms.ColumnHeader qGeneName;
        private System.Windows.Forms.ColumnHeader qATCCODE;
        private System.Windows.Forms.ColumnHeader qGenoType;
        private System.Windows.Forms.ColumnHeader qPhenotype;
        private System.Windows.Forms.ColumnHeader qActivityScore;
        private System.Windows.Forms.Button btnReadDB;
        private System.Windows.Forms.Label LabelUseTip;
        private System.Windows.Forms.Button btnClearSearchTxt;
        private System.Windows.Forms.Button btnClearQuery;
    }
}

