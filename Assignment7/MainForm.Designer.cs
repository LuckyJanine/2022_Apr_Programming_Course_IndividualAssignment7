namespace Assignment7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addMore = new System.Windows.Forms.Button();
            this.cmb_AgeRange = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstv_DonorList = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.Age = new System.Windows.Forms.ColumnHeader();
            this.Sample = new System.Windows.Forms.ColumnHeader();
            this.NumOfLines = new System.Windows.Forms.ColumnHeader();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_registerLine = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_Clone = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_registerBatch = new System.Windows.Forms.Button();
            this.txt_NoVails = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_LabJournal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_FrozenDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CellLineID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Passage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_CellType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DonorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_deriveCells = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addMore);
            this.groupBox1.Controls.Add(this.cmb_AgeRange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Gender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donor";
            // 
            // btn_addMore
            // 
            this.btn_addMore.Location = new System.Drawing.Point(367, 222);
            this.btn_addMore.Name = "btn_addMore";
            this.btn_addMore.Size = new System.Drawing.Size(200, 57);
            this.btn_addMore.TabIndex = 5;
            this.btn_addMore.Text = "Add Donation";
            this.btn_addMore.UseVisualStyleBackColor = true;
            this.btn_addMore.Click += new System.EventHandler(this.btn_addMore_Click);
            // 
            // cmb_AgeRange
            // 
            this.cmb_AgeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AgeRange.FormattingEnabled = true;
            this.cmb_AgeRange.Location = new System.Drawing.Point(330, 135);
            this.cmb_AgeRange.Name = "cmb_AgeRange";
            this.cmb_AgeRange.Size = new System.Drawing.Size(237, 38);
            this.cmb_AgeRange.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age Range (when donate): ";
            // 
            // txt_Gender
            // 
            this.txt_Gender.Location = new System.Drawing.Point(330, 65);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(237, 35);
            this.txt_Gender.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender (eg. XX or XY):";
            // 
            // lstv_DonorList
            // 
            this.lstv_DonorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Gender,
            this.Age,
            this.Sample,
            this.NumOfLines});
            this.lstv_DonorList.FullRowSelect = true;
            this.lstv_DonorList.Location = new System.Drawing.Point(29, 376);
            this.lstv_DonorList.MultiSelect = false;
            this.lstv_DonorList.Name = "lstv_DonorList";
            this.lstv_DonorList.Size = new System.Drawing.Size(634, 330);
            this.lstv_DonorList.TabIndex = 1;
            this.lstv_DonorList.UseCompatibleStateImageBehavior = false;
            this.lstv_DonorList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gender.Width = 90;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 150;
            // 
            // Sample
            // 
            this.Sample.Text = "Starting Sample";
            this.Sample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sample.Width = 190;
            // 
            // NumOfLines
            // 
            this.NumOfLines.Text = "# Cell Lines";
            this.NumOfLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfLines.Width = 120;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(29, 724);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(189, 58);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Information";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(252, 724);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 58);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "(donor) Drop out";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_registerLine);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmb_Clone);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_registerBatch);
            this.groupBox2.Controls.Add(this.txt_NoVails);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_LabJournal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtp_FrozenDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_CellLineID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_Passage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmb_CellType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_DonorID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(685, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 737);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cell line Registration (Cell Banking)";
            // 
            // btn_registerLine
            // 
            this.btn_registerLine.Location = new System.Drawing.Point(376, 355);
            this.btn_registerLine.Name = "btn_registerLine";
            this.btn_registerLine.Size = new System.Drawing.Size(230, 48);
            this.btn_registerLine.TabIndex = 21;
            this.btn_registerLine.Text = "Register (cell) Line";
            this.btn_registerLine.UseVisualStyleBackColor = true;
            this.btn_registerLine.Click += new System.EventHandler(this.btn_registerLine_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(242, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "(Click on this input box to generate cell ID)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(265, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 30);
            this.label12.TabIndex = 19;
            this.label12.Text = "(DonorID_CellType_Clone)";
            // 
            // cmb_Clone
            // 
            this.cmb_Clone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Clone.FormattingEnabled = true;
            this.cmb_Clone.Location = new System.Drawing.Point(265, 171);
            this.cmb_Clone.Name = "cmb_Clone";
            this.cmb_Clone.Size = new System.Drawing.Size(176, 38);
            this.cmb_Clone.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "Clone #";
            // 
            // btn_registerBatch
            // 
            this.btn_registerBatch.Location = new System.Drawing.Point(376, 671);
            this.btn_registerBatch.Name = "btn_registerBatch";
            this.btn_registerBatch.Size = new System.Drawing.Size(231, 51);
            this.btn_registerBatch.TabIndex = 16;
            this.btn_registerBatch.Text = "Register (cell) Batch";
            this.btn_registerBatch.UseVisualStyleBackColor = true;
            this.btn_registerBatch.Click += new System.EventHandler(this.btn_registerBatch_Click);
            // 
            // txt_NoVails
            // 
            this.txt_NoVails.Location = new System.Drawing.Point(265, 556);
            this.txt_NoVails.Name = "txt_NoVails";
            this.txt_NoVails.Size = new System.Drawing.Size(175, 35);
            this.txt_NoVails.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "No. of Vials this batch: ";
            // 
            // txt_LabJournal
            // 
            this.txt_LabJournal.Location = new System.Drawing.Point(265, 614);
            this.txt_LabJournal.Name = "txt_LabJournal";
            this.txt_LabJournal.Size = new System.Drawing.Size(341, 35);
            this.txt_LabJournal.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lab Journal #";
            // 
            // dtp_FrozenDate
            // 
            this.dtp_FrozenDate.Location = new System.Drawing.Point(266, 498);
            this.dtp_FrozenDate.Name = "dtp_FrozenDate";
            this.dtp_FrozenDate.Size = new System.Drawing.Size(341, 35);
            this.dtp_FrozenDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Frozen Date: ";
            // 
            // txt_CellLineID
            // 
            this.txt_CellLineID.ForeColor = System.Drawing.Color.Black;
            this.txt_CellLineID.Location = new System.Drawing.Point(266, 268);
            this.txt_CellLineID.Name = "txt_CellLineID";
            this.txt_CellLineID.Size = new System.Drawing.Size(341, 35);
            this.txt_CellLineID.TabIndex = 7;
            this.txt_CellLineID.Click += new System.EventHandler(this.txt_CellLineID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(137, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cell Line:";
            // 
            // txt_Passage
            // 
            this.txt_Passage.Location = new System.Drawing.Point(266, 434);
            this.txt_Passage.Name = "txt_Passage";
            this.txt_Passage.Size = new System.Drawing.Size(175, 35);
            this.txt_Passage.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Passage Number:";
            // 
            // cmb_CellType
            // 
            this.cmb_CellType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CellType.FormattingEnabled = true;
            this.cmb_CellType.Location = new System.Drawing.Point(266, 108);
            this.cmb_CellType.Name = "cmb_CellType";
            this.cmb_CellType.Size = new System.Drawing.Size(262, 38);
            this.cmb_CellType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cell Type: ";
            // 
            // txt_DonorID
            // 
            this.txt_DonorID.Location = new System.Drawing.Point(266, 52);
            this.txt_DonorID.Name = "txt_DonorID";
            this.txt_DonorID.Size = new System.Drawing.Size(175, 35);
            this.txt_DonorID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "(Internal) Donor ID: ";
            // 
            // btn_deriveCells
            // 
            this.btn_deriveCells.Location = new System.Drawing.Point(458, 724);
            this.btn_deriveCells.Name = "btn_deriveCells";
            this.btn_deriveCells.Size = new System.Drawing.Size(205, 58);
            this.btn_deriveCells.TabIndex = 5;
            this.btn_deriveCells.Text = "Derive (Cell line)";
            this.btn_deriveCells.UseVisualStyleBackColor = true;
            this.btn_deriveCells.Click += new System.EventHandler(this.btn_deriveCells_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 805);
            this.Controls.Add(this.btn_deriveCells);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lstv_DonorList);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1393, 869);
            this.MinimumSize = new System.Drawing.Size(1393, 869);
            this.Name = "MainForm";
            this.Text = "Cell Banking Registry App <by Lingjie Tao>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmb_AgeRange;
        private Label label2;
        private TextBox txt_Gender;
        private Label label1;
        private ListView lstv_DonorList;
        private ColumnHeader ID;
        private ColumnHeader Gender;
        private ColumnHeader Age;
        private ColumnHeader Sample;
        private ColumnHeader NumOfLines;
        private Button btn_edit;
        private Button btn_delete;
        private GroupBox groupBox2;
        private TextBox txt_NoVails;
        private Label label10;
        private TextBox txt_LabJournal;
        private Label label8;
        private DateTimePicker dtp_FrozenDate;
        private Label label7;
        private TextBox txt_CellLineID;
        private Label label6;
        private TextBox txt_Passage;
        private Label label5;
        private ComboBox cmb_CellType;
        private Label label4;
        private TextBox txt_DonorID;
        private Label label3;
        private Button btn_registerBatch;
        private Button btn_deriveCells;
        private Label label11;
        private ComboBox cmb_Clone;
        private Label label12;
        private Button btn_addMore;
        private Label label9;
        private Button btn_registerLine;
    }
}