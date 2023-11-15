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
            TLPMain = new TableLayoutPanel();
            TLPformConnection = new TableLayoutPanel();
            TXTpassword = new TextBox();
            LBpassword = new Label();
            textBox1 = new TextBox();
            LBid = new Label();
            LBconnection = new Label();
            textBox2 = new TextBox();
            BTvalid = new Button();
            TLPMain.SuspendLayout();
            TLPformConnection.SuspendLayout();
            SuspendLayout();
            // 
            // TLPMain
            // 
            TLPMain.ColumnCount = 1;
            TLPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPMain.Controls.Add(TLPformConnection, 0, 0);
            TLPMain.Controls.Add(textBox2, 0, 2);
            TLPMain.Controls.Add(BTvalid, 0, 1);
            TLPMain.Dock = DockStyle.Fill;
            TLPMain.Location = new Point(0, 0);
            TLPMain.Margin = new Padding(3, 4, 3, 4);
            TLPMain.Name = "TLPMain";
            TLPMain.RowCount = 3;
            TLPMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            TLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLPMain.Size = new Size(801, 450);
            TLPMain.TabIndex = 0;
            // 
            // TLPformConnection
            // 
            TLPformConnection.ColumnCount = 2;
            TLPformConnection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.03226F));
            TLPformConnection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.96774F));
            TLPformConnection.Controls.Add(TXTpassword, 1, 4);
            TLPformConnection.Controls.Add(LBpassword, 1, 3);
            TLPformConnection.Controls.Add(textBox1, 1, 2);
            TLPformConnection.Controls.Add(LBid, 1, 1);
            TLPformConnection.Controls.Add(LBconnection, 1, 0);
            TLPformConnection.Location = new Point(3, 4);
            TLPformConnection.Margin = new Padding(3, 4, 3, 4);
            TLPformConnection.Name = "TLPformConnection";
            TLPformConnection.RowCount = 5;
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 25.19084F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 23.36065F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 17.62295F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 14.34426F));
            TLPformConnection.RowStyles.Add(new RowStyle(SizeType.Percent, 19.26229F));
            TLPformConnection.Size = new Size(413, 242);
            TLPformConnection.TabIndex = 0;
            // 
            // TXTpassword
            // 
            TXTpassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TXTpassword.Location = new Point(81, 197);
            TXTpassword.Margin = new Padding(3, 4, 3, 4);
            TXTpassword.Name = "TXTpassword";
            TXTpassword.Size = new Size(329, 35);
            TXTpassword.TabIndex = 5;
            // 
            // LBpassword
            // 
            LBpassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LBpassword.AutoSize = true;
            LBpassword.Location = new Point(81, 163);
            LBpassword.Name = "LBpassword";
            LBpassword.Size = new Size(329, 30);
            LBpassword.TabIndex = 1;
            LBpassword.Text = "Mot de passe";
            LBpassword.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(81, 127);
            textBox1.Margin = new Padding(3, 10, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 35);
            textBox1.TabIndex = 2;
            // 
            // LBid
            // 
            LBid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LBid.AutoSize = true;
            LBid.Location = new Point(81, 87);
            LBid.Name = "LBid";
            LBid.Size = new Size(329, 30);
            LBid.TabIndex = 0;
            LBid.Text = "email";
            LBid.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LBconnection
            // 
            LBconnection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LBconnection.AutoSize = true;
            LBconnection.Location = new Point(81, 30);
            LBconnection.Margin = new Padding(3, 30, 3, 0);
            LBconnection.Name = "LBconnection";
            LBconnection.Size = new Size(329, 30);
            LBconnection.TabIndex = 4;
            LBconnection.Text = "CONNECTION";
            LBconnection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 460);
            textBox2.Margin = new Padding(3, 30, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(795, 35);
            textBox2.TabIndex = 3;
            // 
            // BTvalid
            // 
            BTvalid.Location = new Point(170, 270);
            BTvalid.Margin = new Padding(170, 20, 3, 4);
            BTvalid.Name = "BTvalid";
            BTvalid.Size = new Size(130, 40);
            BTvalid.TabIndex = 1;
            BTvalid.Text = "VALIDER";
            BTvalid.UseVisualStyleBackColor = true;
            BTvalid.Click += BTvalid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(TLPMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Connection";
            TLPMain.ResumeLayout(false);
            TLPMain.PerformLayout();
            TLPformConnection.ResumeLayout(false);
            TLPformConnection.PerformLayout();
            ResumeLayout(false);
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