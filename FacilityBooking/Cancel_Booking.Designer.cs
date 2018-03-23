namespace WindowsFormsApp1
{
    partial class Cancel_Booking
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
            this.SearchBooking_TextBox = new System.Windows.Forms.TextBox();
            this.Bookings_Table = new System.Windows.Forms.DataGridView();
            this.CancelBooking_Btn = new System.Windows.Forms.Button();
            this.SearchBooking_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bookings_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBooking_TextBox
            // 
            this.SearchBooking_TextBox.Location = new System.Drawing.Point(34, 33);
            this.SearchBooking_TextBox.Multiline = true;
            this.SearchBooking_TextBox.Name = "SearchBooking_TextBox";
            this.SearchBooking_TextBox.Size = new System.Drawing.Size(224, 32);
            this.SearchBooking_TextBox.TabIndex = 0;
            // 
            // Bookings_Table
            // 
            this.Bookings_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bookings_Table.Location = new System.Drawing.Point(12, 82);
            this.Bookings_Table.Name = "Bookings_Table";
            this.Bookings_Table.RowTemplate.Height = 28;
            this.Bookings_Table.Size = new System.Drawing.Size(380, 181);
            this.Bookings_Table.TabIndex = 1;
            // 
            // CancelBooking_Btn
            // 
            this.CancelBooking_Btn.Location = new System.Drawing.Point(264, 285);
            this.CancelBooking_Btn.Name = "CancelBooking_Btn";
            this.CancelBooking_Btn.Size = new System.Drawing.Size(128, 35);
            this.CancelBooking_Btn.TabIndex = 2;
            this.CancelBooking_Btn.Text = "Cancel Booking";
            this.CancelBooking_Btn.UseVisualStyleBackColor = true;
            // 
            // SearchBooking_Btn
            // 
            this.SearchBooking_Btn.Location = new System.Drawing.Point(264, 33);
            this.SearchBooking_Btn.Name = "SearchBooking_Btn";
            this.SearchBooking_Btn.Size = new System.Drawing.Size(113, 32);
            this.SearchBooking_Btn.TabIndex = 3;
            this.SearchBooking_Btn.Text = "Find Booking";
            this.SearchBooking_Btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 332);
            this.Controls.Add(this.SearchBooking_Btn);
            this.Controls.Add(this.CancelBooking_Btn);
            this.Controls.Add(this.Bookings_Table);
            this.Controls.Add(this.SearchBooking_TextBox);
            this.Name = "Cancel_Booking";
            this.Text = "Cancel Booking";
            ((System.ComponentModel.ISupportInitialize)(this.Bookings_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBooking_TextBox;
        private System.Windows.Forms.DataGridView Bookings_Table;
        private System.Windows.Forms.Button CancelBooking_Btn;
        private System.Windows.Forms.Button SearchBooking_Btn;
    }
}