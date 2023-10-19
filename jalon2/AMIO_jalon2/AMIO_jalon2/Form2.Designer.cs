namespace AMIO_jalon2
{
    partial class FormConnection
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
            TLPconnection = new TableLayoutPanel();
            LBmail = new Label();
            TXTmail = new TextBox();
            TXTpassword = new TextBox();
            Lbpassword = new Label();
            BtIdentify = new Button();
            TLPconnection.SuspendLayout();
            SuspendLayout();
            // 
            // TLPconnection
            // 
            TLPconnection.ColumnCount = 2;
            TLPconnection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPconnection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPconnection.Controls.Add(LBmail, 0, 0);
            TLPconnection.Controls.Add(TXTmail, 1, 0);
            TLPconnection.Controls.Add(TXTpassword, 1, 1);
            TLPconnection.Controls.Add(Lbpassword, 0, 1);
            TLPconnection.Location = new Point(393, 260);
            TLPconnection.Margin = new Padding(5, 6, 5, 6);
            TLPconnection.Name = "TLPconnection";
            TLPconnection.RowCount = 2;
            TLPconnection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPconnection.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPconnection.Size = new Size(557, 176);
            TLPconnection.TabIndex = 0;
            // 
            // LBmail
            // 
            LBmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBmail.AutoSize = true;
            LBmail.Location = new Point(210, 0);
            LBmail.Margin = new Padding(5, 0, 5, 0);
            LBmail.Name = "LBmail";
            LBmail.Size = new Size(63, 30);
            LBmail.TabIndex = 0;
            LBmail.Text = "email";
            LBmail.TextAlign = ContentAlignment.TopRight;
            // 
            // TXTmail
            // 
            TXTmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TXTmail.Location = new Point(283, 26);
            TXTmail.Margin = new Padding(5, 6, 5, 6);
            TXTmail.Name = "TXTmail";
            TXTmail.Size = new Size(269, 35);
            TXTmail.TabIndex = 2;
            // 
            // TXTpassword
            // 
            TXTpassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TXTpassword.Location = new Point(283, 114);
            TXTpassword.Margin = new Padding(5, 6, 5, 6);
            TXTpassword.Name = "TXTpassword";
            TXTpassword.Size = new Size(269, 35);
            TXTpassword.TabIndex = 3;
            // 
            // Lbpassword
            // 
            Lbpassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbpassword.AutoSize = true;
            Lbpassword.Location = new Point(173, 88);
            Lbpassword.Margin = new Padding(5, 0, 5, 0);
            Lbpassword.Name = "Lbpassword";
            Lbpassword.Size = new Size(100, 30);
            Lbpassword.TabIndex = 1;
            Lbpassword.Text = "password";
            Lbpassword.TextAlign = ContentAlignment.TopRight;
            // 
            // BtIdentify
            // 
            BtIdentify.Location = new Point(566, 480);
            BtIdentify.Margin = new Padding(5, 6, 5, 6);
            BtIdentify.Name = "BtIdentify";
            BtIdentify.Size = new Size(189, 66);
            BtIdentify.TabIndex = 1;
            BtIdentify.Text = "SE CONNECTER";
            BtIdentify.UseVisualStyleBackColor = true;
            // 
            // FormConnection
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1371, 900);
            Controls.Add(BtIdentify);
            Controls.Add(TLPconnection);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormConnection";
            Text = "Form2";
            TLPconnection.ResumeLayout(false);
            TLPconnection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPconnection;
        private Label LBmail;
        private TextBox TXTmail;
        private TextBox TXTpassword;
        private Label Lbpassword;
        private Button BtIdentify;
    }
}