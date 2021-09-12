namespace ChaoticCallCenterV2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.GenderGroup = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadOther = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.CompDropDownBox = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblHappy = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.RadNo = new System.Windows.Forms.RadioButton();
            this.RadYes = new System.Windows.Forms.RadioButton();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblIDText = new System.Windows.Forms.Label();
            this.chkArchive = new System.Windows.Forms.CheckBox();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.gbxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.GenderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResults
            // 
            this.gbxResults.Controls.Add(this.dgvResults);
            this.gbxResults.Location = new System.Drawing.Point(318, 234);
            this.gbxResults.Name = "gbxResults";
            this.gbxResults.Size = new System.Drawing.Size(349, 192);
            this.gbxResults.TabIndex = 76;
            this.gbxResults.TabStop = false;
            this.gbxResults.Text = "Results";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(29, 26);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(276, 150);
            this.dgvResults.TabIndex = 46;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(123, 348);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(327, 198);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(122, 20);
            this.txtSearch.TabIndex = 74;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(324, 168);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(186, 13);
            this.lblSearch.TabIndex = 73;
            this.lblSearch.Text = "Please Enter First Name or Last Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(455, 198);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(406, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 71;
            this.lblID.Text = "..";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 69;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(72, 110);
            this.BirthDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(200, 20);
            this.BirthDate.TabIndex = 68;
            this.BirthDate.Value = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            // 
            // GenderGroup
            // 
            this.GenderGroup.Controls.Add(this.radMale);
            this.GenderGroup.Controls.Add(this.RadFemale);
            this.GenderGroup.Controls.Add(this.RadOther);
            this.GenderGroup.Location = new System.Drawing.Point(12, 132);
            this.GenderGroup.Name = "GenderGroup";
            this.GenderGroup.Size = new System.Drawing.Size(200, 38);
            this.GenderGroup.TabIndex = 67;
            this.GenderGroup.TabStop = false;
            this.GenderGroup.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(6, 14);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 6;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Location = new System.Drawing.Point(60, 14);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(59, 17);
            this.RadFemale.TabIndex = 7;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Location = new System.Drawing.Point(125, 16);
            this.RadOther.Name = "RadOther";
            this.RadOther.Size = new System.Drawing.Size(51, 17);
            this.RadOther.TabIndex = 8;
            this.RadOther.TabStop = true;
            this.RadOther.Text = "Other";
            this.RadOther.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(42, 319);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 66;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 348);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CompDropDownBox
            // 
            this.CompDropDownBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompDropDownBox.FormattingEnabled = true;
            this.CompDropDownBox.Items.AddRange(new object[] {
            "Telstra",
            "Optus",
            "Vodofone",
            "Virgin Mobile",
            "Dodo"});
            this.CompDropDownBox.Location = new System.Drawing.Point(66, 234);
            this.CompDropDownBox.Name = "CompDropDownBox";
            this.CompDropDownBox.Size = new System.Drawing.Size(127, 21);
            this.CompDropDownBox.TabIndex = 64;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(42, 377);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 63;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(42, 290);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 61;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(66, 208);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 20);
            this.txtComment.TabIndex = 58;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(9, 234);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 57;
            this.lblCompany.Text = "Company";
            // 
            // lblHappy
            // 
            this.lblHappy.AutoSize = true;
            this.lblHappy.Location = new System.Drawing.Point(9, 179);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(85, 13);
            this.lblHappy.TabIndex = 56;
            this.lblHappy.Text = "Are You Happy?";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(72, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 55;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(72, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 54;
            // 
            // RadNo
            // 
            this.RadNo.AutoSize = true;
            this.RadNo.Location = new System.Drawing.Point(154, 179);
            this.RadNo.Name = "RadNo";
            this.RadNo.Size = new System.Drawing.Size(39, 17);
            this.RadNo.TabIndex = 53;
            this.RadNo.TabStop = true;
            this.RadNo.Text = "No";
            this.RadNo.UseVisualStyleBackColor = true;
            // 
            // RadYes
            // 
            this.RadYes.AutoSize = true;
            this.RadYes.Location = new System.Drawing.Point(105, 179);
            this.RadYes.Name = "RadYes";
            this.RadYes.Size = new System.Drawing.Size(43, 17);
            this.RadYes.TabIndex = 52;
            this.RadYes.TabStop = true;
            this.RadYes.Text = "Yes";
            this.RadYes.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(9, 208);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 51;
            this.lblComment.Text = "Comment";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 116);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 50;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(2, 77);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 49;
            this.lblLast.Text = "Last Name";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(2, 36);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(57, 13);
            this.lblFirst.TabIndex = 48;
            this.lblFirst.Text = "First Name";
            // 
            // lblIDText
            // 
            this.lblIDText.AutoSize = true;
            this.lblIDText.Location = new System.Drawing.Point(379, 33);
            this.lblIDText.Name = "lblIDText";
            this.lblIDText.Size = new System.Drawing.Size(21, 13);
            this.lblIDText.TabIndex = 78;
            this.lblIDText.Text = "ID:";
            // 
            // chkArchive
            // 
            this.chkArchive.AutoSize = true;
            this.chkArchive.Location = new System.Drawing.Point(418, 436);
            this.chkArchive.Name = "chkArchive";
            this.chkArchive.Size = new System.Drawing.Size(92, 17);
            this.chkArchive.TabIndex = 79;
            this.chkArchive.Text = "Show Archive";
            this.chkArchive.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(123, 377);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 23);
            this.btnArchive.TabIndex = 80;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(520, 432);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAll.TabIndex = 81;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 477);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.chkArchive);
            this.Controls.Add(this.lblIDText);
            this.Controls.Add(this.gbxResults);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.GenderGroup);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CompDropDownBox);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblHappy);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.RadNo);
            this.Controls.Add(this.RadYes);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Name = "frmMain";
            this.Text = "ChaoticCallCenterV2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.GenderGroup.ResumeLayout(false);
            this.GenderGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.GroupBox GenderGroup;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadOther;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox CompDropDownBox;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblHappy;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton RadNo;
        private System.Windows.Forms.RadioButton RadYes;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblIDText;
        private System.Windows.Forms.CheckBox chkArchive;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnLoadAll;
    }
}

