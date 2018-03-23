namespace WindowsFormsApp1
{
    partial class New_Member
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MemberFN_TextBox = new System.Windows.Forms.TextBox();
            this.MemberLN_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.PostalCode_TextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Male_RadBtn = new System.Windows.Forms.RadioButton();
            this.Fem_RadBtn = new System.Windows.Forms.RadioButton();
            this.SubmitNewMember_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number:";
            // 
            // MemberFN_TextBox
            // 
            this.MemberFN_TextBox.Location = new System.Drawing.Point(197, 52);
            this.MemberFN_TextBox.Name = "MemberFN_TextBox";
            this.MemberFN_TextBox.Size = new System.Drawing.Size(224, 26);
            this.MemberFN_TextBox.TabIndex = 8;
            // 
            // MemberLN_TextBox
            // 
            this.MemberLN_TextBox.Location = new System.Drawing.Point(197, 104);
            this.MemberLN_TextBox.Name = "MemberLN_TextBox";
            this.MemberLN_TextBox.Size = new System.Drawing.Size(224, 26);
            this.MemberLN_TextBox.TabIndex = 9;
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(197, 199);
            this.Address_TextBox.Multiline = true;
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(224, 33);
            this.Address_TextBox.TabIndex = 11;
            // 
            // PostalCode_TextBox
            // 
            this.PostalCode_TextBox.Location = new System.Drawing.Point(197, 258);
            this.PostalCode_TextBox.Name = "PostalCode_TextBox";
            this.PostalCode_TextBox.Size = new System.Drawing.Size(100, 26);
            this.PostalCode_TextBox.TabIndex = 12;
            // 
            // PhoneNumber_TextBox
            // 
            this.PhoneNumber_TextBox.Location = new System.Drawing.Point(197, 308);
            this.PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            this.PhoneNumber_TextBox.Size = new System.Drawing.Size(169, 26);
            this.PhoneNumber_TextBox.TabIndex = 13;
            // 
            // Male_RadBtn
            // 
            this.Male_RadBtn.AutoSize = true;
            this.Male_RadBtn.Location = new System.Drawing.Point(197, 157);
            this.Male_RadBtn.Name = "Male_RadBtn";
            this.Male_RadBtn.Size = new System.Drawing.Size(68, 24);
            this.Male_RadBtn.TabIndex = 14;
            this.Male_RadBtn.TabStop = true;
            this.Male_RadBtn.Text = "Male";
            this.Male_RadBtn.UseVisualStyleBackColor = true;
            this.Male_RadBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Fem_RadBtn
            // 
            this.Fem_RadBtn.AutoSize = true;
            this.Fem_RadBtn.Location = new System.Drawing.Point(334, 157);
            this.Fem_RadBtn.Name = "Fem_RadBtn";
            this.Fem_RadBtn.Size = new System.Drawing.Size(87, 24);
            this.Fem_RadBtn.TabIndex = 15;
            this.Fem_RadBtn.TabStop = true;
            this.Fem_RadBtn.Text = "Female";
            this.Fem_RadBtn.UseVisualStyleBackColor = true;
            // 
            // SubmitNewMember_Btn
            // 
            this.SubmitNewMember_Btn.Location = new System.Drawing.Point(145, 378);
            this.SubmitNewMember_Btn.Name = "SubmitNewMember_Btn";
            this.SubmitNewMember_Btn.Size = new System.Drawing.Size(192, 61);
            this.SubmitNewMember_Btn.TabIndex = 16;
            this.SubmitNewMember_Btn.Text = "Create New Member";
            this.SubmitNewMember_Btn.UseVisualStyleBackColor = true;
            // 
            // New_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 460);
            this.Controls.Add(this.SubmitNewMember_Btn);
            this.Controls.Add(this.Fem_RadBtn);
            this.Controls.Add(this.Male_RadBtn);
            this.Controls.Add(this.PhoneNumber_TextBox);
            this.Controls.Add(this.PostalCode_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.MemberLN_TextBox);
            this.Controls.Add(this.MemberFN_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "New_Member";
            this.Text = "Add New Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MemberFN_TextBox;
        private System.Windows.Forms.TextBox MemberLN_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.TextBox PostalCode_TextBox;
        private System.Windows.Forms.TextBox PhoneNumber_TextBox;
        private System.Windows.Forms.RadioButton Male_RadBtn;
        private System.Windows.Forms.RadioButton Fem_RadBtn;
        private System.Windows.Forms.Button SubmitNewMember_Btn;
    }
}