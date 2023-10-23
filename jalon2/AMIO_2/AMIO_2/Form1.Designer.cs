namespace AMIO_2
{
    partial class Form1
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
            this.TLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.TLPformConnection = new System.Windows.Forms.TableLayoutPanel();
            this.TXTpassword = new System.Windows.Forms.TextBox();
            this.LBpassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBid = new System.Windows.Forms.Label();
            this.LBconnection = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BTvalid = new System.Windows.Forms.Button();
            this.TLPMain.SuspendLayout();
            this.TLPformConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMain
            // 
            this.TLPMain.ColumnCount = 1;
            this.TLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMain.Controls.Add(this.TLPformConnection, 0, 0);
            this.TLPMain.Controls.Add(this.textBox2, 0, 2);
            this.TLPMain.Controls.Add(this.BTvalid, 0, 1);
            this.TLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMain.Location = new System.Drawing.Point(0, 0);
            this.TLPMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TLPMain.Name = "TLPMain";
            this.TLPMain.RowCount = 3;
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.TLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLPMain.Size = new System.Drawing.Size(467, 225);
            this.TLPMain.TabIndex = 0;
            // 
            // TLPformConnection
            // 
            this.TLPformConnection.ColumnCount = 2;
            this.TLPformConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.03226F));
            this.TLPformConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.96774F));
            this.TLPformConnection.Controls.Add(this.TXTpassword, 1, 4);
            this.TLPformConnection.Controls.Add(this.LBpassword, 1, 3);
            this.TLPformConnection.Controls.Add(this.textBox1, 1, 2);
            this.TLPformConnection.Controls.Add(this.LBid, 1, 1);
            this.TLPformConnection.Controls.Add(this.LBconnection, 1, 0);
            this.TLPformConnection.Location = new System.Drawing.Point(2, 2);
            this.TLPformConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TLPformConnection.Name = "TLPformConnection";
            this.TLPformConnection.RowCount = 5;
            this.TLPformConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.19084F));
            this.TLPformConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.36065F));
            this.TLPformConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.62295F));
            this.TLPformConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34426F));
            this.TLPformConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.26229F));
            this.TLPformConnection.Size = new System.Drawing.Size(241, 121);
            this.TLPformConnection.TabIndex = 0;
            // 
            // TXTpassword
            // 
            this.TXTpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTpassword.Location = new System.Drawing.Point(47, 98);
            this.TXTpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTpassword.Name = "TXTpassword";
            this.TXTpassword.Size = new System.Drawing.Size(192, 23);
            this.TXTpassword.TabIndex = 5;
            // 
            // LBpassword
            // 
            this.LBpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBpassword.AutoSize = true;
            this.LBpassword.Location = new System.Drawing.Point(47, 81);
            this.LBpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBpassword.Name = "LBpassword";
            this.LBpassword.Size = new System.Drawing.Size(192, 15);
            this.LBpassword.TabIndex = 1;
            this.LBpassword.Text = "Mot de passe";
            this.LBpassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(47, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 2;
            // 
            // LBid
            // 
            this.LBid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBid.AutoSize = true;
            this.LBid.Location = new System.Drawing.Point(47, 43);
            this.LBid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBid.Name = "LBid";
            this.LBid.Size = new System.Drawing.Size(192, 15);
            this.LBid.TabIndex = 0;
            this.LBid.Text = "email";
            this.LBid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LBconnection
            // 
            this.LBconnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBconnection.AutoSize = true;
            this.LBconnection.Location = new System.Drawing.Point(47, 15);
            this.LBconnection.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.LBconnection.Name = "LBconnection";
            this.LBconnection.Size = new System.Drawing.Size(192, 15);
            this.LBconnection.TabIndex = 4;
            this.LBconnection.Text = "CONNECTION";
            this.LBconnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(2, 230);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 15, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(463, 23);
            this.textBox2.TabIndex = 3;
            // 
            // BTvalid
            // 
            this.BTvalid.Location = new System.Drawing.Point(99, 135);
            this.BTvalid.Margin = new System.Windows.Forms.Padding(99, 10, 2, 2);
            this.BTvalid.Name = "BTvalid";
            this.BTvalid.Size = new System.Drawing.Size(76, 20);
            this.BTvalid.TabIndex = 1;
            this.BTvalid.Text = "VALIDER";
            this.BTvalid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 225);
            this.Controls.Add(this.TLPMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Connection";
            this.TLPMain.ResumeLayout(false);
            this.TLPMain.PerformLayout();
            this.TLPformConnection.ResumeLayout(false);
            this.TLPformConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPMain;
        private TableLayoutPanel TLPformConnection;
        private Label LBid;
        private Label LBpassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LBconnection;
        private Button BTvalid;
        private TextBox TXTpassword;
    }
}