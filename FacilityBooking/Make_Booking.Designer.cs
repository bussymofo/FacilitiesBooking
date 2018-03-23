namespace WindowsFormsApp1
{
    partial class Make_Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Availability_Table = new System.Windows.Forms.DataGridView();
            this.FindMemID_Btn = new System.Windows.Forms.Button();
            this.FindFacilityID_Btn = new System.Windows.Forms.Button();
            this.UpdateMem_Btn = new System.Windows.Forms.Button();
            this.AddMem_Btn = new System.Windows.Forms.Button();
            this.AddFacility_Bnt = new System.Windows.Forms.Button();
            this.CancelBooking_Btn = new System.Windows.Forms.Button();
            this.MemID_TextBox = new System.Windows.Forms.TextBox();
            this.MemName_TextBox = new System.Windows.Forms.TextBox();
            this.FacilityID_TextBox = new System.Windows.Forms.TextBox();
            this.FacilityName_TextBox = new System.Windows.Forms.TextBox();
            this.MakeBooking_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Availability_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Facility ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Facility Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available Slots";
            // 
            // Availability_Table
            // 
            this.Availability_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Availability_Table.Location = new System.Drawing.Point(29, 263);
            this.Availability_Table.Name = "Availability_Table";
            this.Availability_Table.RowTemplate.Height = 28;
            this.Availability_Table.Size = new System.Drawing.Size(603, 205);
            this.Availability_Table.TabIndex = 5;
            // 
            // FindMemID_Btn
            // 
            this.FindMemID_Btn.Location = new System.Drawing.Point(280, 44);
            this.FindMemID_Btn.Name = "FindMemID_Btn";
            this.FindMemID_Btn.Size = new System.Drawing.Size(35, 26);
            this.FindMemID_Btn.TabIndex = 6;
            this.FindMemID_Btn.Text = "...";
            this.FindMemID_Btn.UseVisualStyleBackColor = true;
            // 
            // FindFacilityID_Btn
            // 
            this.FindFacilityID_Btn.Location = new System.Drawing.Point(280, 129);
            this.FindFacilityID_Btn.Name = "FindFacilityID_Btn";
            this.FindFacilityID_Btn.Size = new System.Drawing.Size(35, 29);
            this.FindFacilityID_Btn.TabIndex = 7;
            this.FindFacilityID_Btn.Text = "...";
            this.FindFacilityID_Btn.UseVisualStyleBackColor = true;
            // 
            // UpdateMem_Btn
            // 
            this.UpdateMem_Btn.Location = new System.Drawing.Point(483, 84);
            this.UpdateMem_Btn.Name = "UpdateMem_Btn";
            this.UpdateMem_Btn.Size = new System.Drawing.Size(149, 31);
            this.UpdateMem_Btn.TabIndex = 8;
            this.UpdateMem_Btn.Text = "Update Member";
            this.UpdateMem_Btn.UseVisualStyleBackColor = true;
            // 
            // AddMem_Btn
            // 
            this.AddMem_Btn.Location = new System.Drawing.Point(483, 38);
            this.AddMem_Btn.Name = "AddMem_Btn";
            this.AddMem_Btn.Size = new System.Drawing.Size(149, 32);
            this.AddMem_Btn.TabIndex = 9;
            this.AddMem_Btn.Text = "Add Member";
            this.AddMem_Btn.UseVisualStyleBackColor = true;
            // 
            // AddFacility_Bnt
            // 
            this.AddFacility_Bnt.Location = new System.Drawing.Point(483, 129);
            this.AddFacility_Bnt.Name = "AddFacility_Bnt";
            this.AddFacility_Bnt.Size = new System.Drawing.Size(149, 29);
            this.AddFacility_Bnt.TabIndex = 10;
            this.AddFacility_Bnt.Text = "Add Facility";
            this.AddFacility_Bnt.UseVisualStyleBackColor = true;
            // 
            // CancelBooking_Btn
            // 
            this.CancelBooking_Btn.Location = new System.Drawing.Point(483, 172);
            this.CancelBooking_Btn.Name = "CancelBooking_Btn";
            this.CancelBooking_Btn.Size = new System.Drawing.Size(149, 31);
            this.CancelBooking_Btn.TabIndex = 11;
            this.CancelBooking_Btn.Text = "Cancel Booking";
            this.CancelBooking_Btn.UseVisualStyleBackColor = true;
            // 
            // MemID_TextBox
            // 
            this.MemID_TextBox.Location = new System.Drawing.Point(174, 44);
            this.MemID_TextBox.Name = "MemID_TextBox";
            this.MemID_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MemID_TextBox.TabIndex = 12;
            // 
            // MemName_TextBox
            // 
            this.MemName_TextBox.Location = new System.Drawing.Point(174, 89);
            this.MemName_TextBox.Name = "MemName_TextBox";
            this.MemName_TextBox.ReadOnly = true;
            this.MemName_TextBox.Size = new System.Drawing.Size(265, 26);
            this.MemName_TextBox.TabIndex = 13;
            // 
            // FacilityID_TextBox
            // 
            this.FacilityID_TextBox.Location = new System.Drawing.Point(174, 132);
            this.FacilityID_TextBox.Name = "FacilityID_TextBox";
            this.FacilityID_TextBox.Size = new System.Drawing.Size(100, 26);
            this.FacilityID_TextBox.TabIndex = 14;
            // 
            // FacilityName_TextBox
            // 
            this.FacilityName_TextBox.Location = new System.Drawing.Point(174, 177);
            this.FacilityName_TextBox.Name = "FacilityName_TextBox";
            this.FacilityName_TextBox.ReadOnly = true;
            this.FacilityName_TextBox.Size = new System.Drawing.Size(265, 26);
            this.FacilityName_TextBox.TabIndex = 15;
            // 
            // MakeBooking_Btn
            // 
            this.MakeBooking_Btn.Location = new System.Drawing.Point(505, 485);
            this.MakeBooking_Btn.Name = "MakeBooking_Btn";
            this.MakeBooking_Btn.Size = new System.Drawing.Size(127, 37);
            this.MakeBooking_Btn.TabIndex = 16;
            this.MakeBooking_Btn.Text = "Make Booking";
            this.MakeBooking_Btn.UseVisualStyleBackColor = true;
            // 
            // Make_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 534);
            this.Controls.Add(this.MakeBooking_Btn);
            this.Controls.Add(this.FacilityName_TextBox);
            this.Controls.Add(this.FacilityID_TextBox);
            this.Controls.Add(this.MemName_TextBox);
            this.Controls.Add(this.MemID_TextBox);
            this.Controls.Add(this.CancelBooking_Btn);
            this.Controls.Add(this.AddFacility_Bnt);
            this.Controls.Add(this.AddMem_Btn);
            this.Controls.Add(this.UpdateMem_Btn);
            this.Controls.Add(this.FindFacilityID_Btn);
            this.Controls.Add(this.FindMemID_Btn);
            this.Controls.Add(this.Availability_Table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Make_Booking";
            this.Text = "Make Booking";
            ((System.ComponentModel.ISupportInitialize)(this.Availability_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Availability_Table;
        private System.Windows.Forms.Button FindMemID_Btn;
        private System.Windows.Forms.Button FindFacilityID_Btn;
        private System.Windows.Forms.Button UpdateMem_Btn;
        private System.Windows.Forms.Button AddMem_Btn;
        private System.Windows.Forms.Button AddFacility_Bnt;
        private System.Windows.Forms.Button CancelBooking_Btn;
        private System.Windows.Forms.TextBox MemID_TextBox;
        private System.Windows.Forms.TextBox MemName_TextBox;
        private System.Windows.Forms.TextBox FacilityID_TextBox;
        private System.Windows.Forms.TextBox FacilityName_TextBox;
        private System.Windows.Forms.Button MakeBooking_Btn;
    }
}

