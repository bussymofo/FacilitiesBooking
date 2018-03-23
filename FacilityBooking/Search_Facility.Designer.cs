namespace WindowsFormsApp1
{
    partial class Facility_Search
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
            this.FacilityDB_Table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFacility_Btn = new System.Windows.Forms.Button();
            this.FacilitySearch_TextBox = new System.Windows.Forms.TextBox();
            this.FacilitySelectedOK_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacilityDB_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilityDB_Table
            // 
            this.FacilityDB_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilityDB_Table.Location = new System.Drawing.Point(21, 40);
            this.FacilityDB_Table.Name = "FacilityDB_Table";
            this.FacilityDB_Table.RowTemplate.Height = 28;
            this.FacilityDB_Table.Size = new System.Drawing.Size(432, 311);
            this.FacilityDB_Table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Facility";
            // 
            // SearchFacility_Btn
            // 
            this.SearchFacility_Btn.Location = new System.Drawing.Point(475, 101);
            this.SearchFacility_Btn.Name = "SearchFacility_Btn";
            this.SearchFacility_Btn.Size = new System.Drawing.Size(162, 30);
            this.SearchFacility_Btn.TabIndex = 2;
            this.SearchFacility_Btn.Text = "Search";
            this.SearchFacility_Btn.UseVisualStyleBackColor = true;
            // 
            // FacilitySearch_TextBox
            // 
            this.FacilitySearch_TextBox.Location = new System.Drawing.Point(475, 65);
            this.FacilitySearch_TextBox.Multiline = true;
            this.FacilitySearch_TextBox.Name = "FacilitySearch_TextBox";
            this.FacilitySearch_TextBox.Size = new System.Drawing.Size(162, 30);
            this.FacilitySearch_TextBox.TabIndex = 3;
            // 
            // FacilitySelectedOK_Btn
            // 
            this.FacilitySelectedOK_Btn.Location = new System.Drawing.Point(534, 320);
            this.FacilitySelectedOK_Btn.Name = "FacilitySelectedOK_Btn";
            this.FacilitySelectedOK_Btn.Size = new System.Drawing.Size(103, 31);
            this.FacilitySelectedOK_Btn.TabIndex = 4;
            this.FacilitySelectedOK_Btn.Text = "OK";
            this.FacilitySelectedOK_Btn.UseVisualStyleBackColor = true;
            // 
            // Facility_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 384);
            this.Controls.Add(this.FacilitySelectedOK_Btn);
            this.Controls.Add(this.FacilitySearch_TextBox);
            this.Controls.Add(this.SearchFacility_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacilityDB_Table);
            this.Name = "Facility_Search";
            this.Text = "Search Facility";
            ((System.ComponentModel.ISupportInitialize)(this.FacilityDB_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FacilityDB_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchFacility_Btn;
        private System.Windows.Forms.TextBox FacilitySearch_TextBox;
        private System.Windows.Forms.Button FacilitySelectedOK_Btn;
    }
}