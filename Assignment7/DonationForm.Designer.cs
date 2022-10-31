namespace Assignment7
{
    partial class DonationForm
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
            this.grp_DonorID = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmb_SampleType = new System.Windows.Forms.ComboBox();
            this.txt_EthicalPerimit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_addDonor = new System.Windows.Forms.Button();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SOP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ClinicCenter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DonationDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_DonorID.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_DonorID
            // 
            this.grp_DonorID.Controls.Add(this.btn_Cancel);
            this.grp_DonorID.Controls.Add(this.cmb_SampleType);
            this.grp_DonorID.Controls.Add(this.txt_EthicalPerimit);
            this.grp_DonorID.Controls.Add(this.label6);
            this.grp_DonorID.Controls.Add(this.btn_addDonor);
            this.grp_DonorID.Controls.Add(this.txt_Comment);
            this.grp_DonorID.Controls.Add(this.label5);
            this.grp_DonorID.Controls.Add(this.txt_SOP);
            this.grp_DonorID.Controls.Add(this.label4);
            this.grp_DonorID.Controls.Add(this.label3);
            this.grp_DonorID.Controls.Add(this.txt_ClinicCenter);
            this.grp_DonorID.Controls.Add(this.label2);
            this.grp_DonorID.Controls.Add(this.dtp_DonationDate);
            this.grp_DonorID.Controls.Add(this.label1);
            this.grp_DonorID.Location = new System.Drawing.Point(34, 46);
            this.grp_DonorID.Name = "grp_DonorID";
            this.grp_DonorID.Size = new System.Drawing.Size(739, 748);
            this.grp_DonorID.TabIndex = 0;
            this.grp_DonorID.TabStop = false;
            this.grp_DonorID.Text = "Donor ID";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(41, 684);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(193, 40);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmb_SampleType
            // 
            this.cmb_SampleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SampleType.FormattingEnabled = true;
            this.cmb_SampleType.Location = new System.Drawing.Point(345, 248);
            this.cmb_SampleType.Name = "cmb_SampleType";
            this.cmb_SampleType.Size = new System.Drawing.Size(350, 38);
            this.cmb_SampleType.TabIndex = 13;
            // 
            // txt_EthicalPerimit
            // 
            this.txt_EthicalPerimit.Location = new System.Drawing.Point(345, 408);
            this.txt_EthicalPerimit.Name = "txt_EthicalPerimit";
            this.txt_EthicalPerimit.Size = new System.Drawing.Size(350, 35);
            this.txt_EthicalPerimit.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ethical Permit #:";
            // 
            // btn_addDonor
            // 
            this.btn_addDonor.Location = new System.Drawing.Point(502, 684);
            this.btn_addDonor.Name = "btn_addDonor";
            this.btn_addDonor.Size = new System.Drawing.Size(193, 40);
            this.btn_addDonor.TabIndex = 10;
            this.btn_addDonor.Text = "Register Donation";
            this.btn_addDonor.UseVisualStyleBackColor = true;
            this.btn_addDonor.Click += new System.EventHandler(this.btn_addDonor_Click);
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(162, 476);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(533, 184);
            this.txt_Comment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comment:";
            // 
            // txt_SOP
            // 
            this.txt_SOP.Location = new System.Drawing.Point(435, 330);
            this.txt_SOP.Name = "txt_SOP";
            this.txt_SOP.Size = new System.Drawing.Size(260, 35);
            this.txt_SOP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Standard Operation Procedure (SOP) #:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sample Type:";
            // 
            // txt_ClinicCenter
            // 
            this.txt_ClinicCenter.Location = new System.Drawing.Point(345, 170);
            this.txt_ClinicCenter.Name = "txt_ClinicCenter";
            this.txt_ClinicCenter.Size = new System.Drawing.Size(350, 35);
            this.txt_ClinicCenter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Sampling) Clinic Center:";
            // 
            // dtp_DonationDate
            // 
            this.dtp_DonationDate.Location = new System.Drawing.Point(345, 87);
            this.dtp_DonationDate.Name = "dtp_DonationDate";
            this.dtp_DonationDate.Size = new System.Drawing.Size(350, 35);
            this.dtp_DonationDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Donation/Operation:";
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(808, 824);
            this.Controls.Add(this.grp_DonorID);
            this.MaximumSize = new System.Drawing.Size(832, 888);
            this.MinimumSize = new System.Drawing.Size(832, 888);
            this.Name = "DonationForm";
            this.Text = "Donation Form";
            this.grp_DonorID.ResumeLayout(false);
            this.grp_DonorID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp_DonorID;
        private Button btn_addDonor;
        private TextBox txt_Comment;
        private Label label5;
        private TextBox txt_SOP;
        private Label label4;
        private Label label3;
        private TextBox txt_ClinicCenter;
        private Label label2;
        private DateTimePicker dtp_DonationDate;
        private Label label1;
        private TextBox txt_EthicalPerimit;
        private Label label6;
        private ComboBox cmb_SampleType;
        private Button btn_Cancel;
    }
}