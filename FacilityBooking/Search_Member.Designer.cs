namespace WindowsFormsApp1
{
    partial class Search_Member
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
            this.SearchMem_Btn = new System.Windows.Forms.Button();
            this.MemSearch_TextBox = new System.Windows.Forms.TextBox();
            this.MemberDB_Table = new System.Windows.Forms.DataGridView();
            this.MemberSelectedOK_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDB_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMem_Btn
            // 
            this.SearchMem_Btn.Location = new System.Drawing.Point(475, 101);
            this.SearchMem_Btn.Name = "SearchMem_Btn";
            this.SearchMem_Btn.Size = new System.Drawing.Size(162, 30);
            this.SearchMem_Btn.TabIndex = 0;
            this.SearchMem_Btn.Text = "Search";
            this.SearchMem_Btn.UseVisualStyleBackColor = true;
            // 
            // MemSearch_TextBox
            // 
            this.MemSearch_TextBox.Location = new System.Drawing.Point(475, 65);
            this.MemSearch_TextBox.Multiline = true;
            this.MemSearch_TextBox.Name = "MemSearch_TextBox";
            this.MemSearch_TextBox.Size = new System.Drawing.Size(162, 30);
            this.MemSearch_TextBox.TabIndex = 1;
            // 
            // MemberDB_Table
            // 
            this.MemberDB_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDB_Table.Location = new System.Drawing.Point(21, 40);
            this.MemberDB_Table.Name = "MemberDB_Table";
            this.MemberDB_Table.RowTemplate.Height = 28;
            this.MemberDB_Table.Size = new System.Drawing.Size(432, 311);
            this.MemberDB_Table.TabIndex = 2;
            // 
            // MemberSelectedOK_Btn
            // 
            this.MemberSelectedOK_Btn.Location = new System.Drawing.Point(534, 320);
            this.MemberSelectedOK_Btn.Name = "MemberSelectedOK_Btn";
            this.MemberSelectedOK_Btn.Size = new System.Drawing.Size(103, 31);
            this.MemberSelectedOK_Btn.TabIndex = 3;
            this.MemberSelectedOK_Btn.Text = "OK";
            this.MemberSelectedOK_Btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find Member:";
            // 
            // Member_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberSelectedOK_Btn);
            this.Controls.Add(this.MemberDB_Table);
            this.Controls.Add(this.MemSearch_TextBox);
            this.Controls.Add(this.SearchMem_Btn);
            this.Name = "Member_Search";
            this.Text = "Search Member";
            ((System.ComponentModel.ISupportInitialize)(this.MemberDB_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchMem_Btn;
        private System.Windows.Forms.TextBox MemSearch_TextBox;
        private System.Windows.Forms.DataGridView MemberDB_Table;
        private System.Windows.Forms.Button MemberSelectedOK_Btn;
        private System.Windows.Forms.Label label1;
    }
}