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
            this.TLPconnection = new System.Windows.Forms.TableLayoutPanel();
            this.LBmail = new System.Windows.Forms.Label();
            this.Lbpassword = new System.Windows.Forms.Label();
            this.TXTmail = new System.Windows.Forms.TextBox();
            this.TXTpassword = new System.Windows.Forms.TextBox();
            this.BtIdentify = new System.Windows.Forms.Button();
            this.TLPconnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPconnection
            // 
            this.TLPconnection.ColumnCount = 2;
            this.TLPconnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPconnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPconnection.Controls.Add(this.LBmail, 0, 0);
            this.TLPconnection.Controls.Add(this.TXTmail, 1, 0);
            this.TLPconnection.Controls.Add(this.TXTpassword, 1, 1);
            this.TLPconnection.Controls.Add(this.Lbpassword, 0, 1);
            this.TLPconnection.Location = new System.Drawing.Point(229, 130);
            this.TLPconnection.Name = "TLPconnection";
            this.TLPconnection.RowCount = 2;
            this.TLPconnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPconnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPconnection.Size = new System.Drawing.Size(325, 88);
            this.TLPconnection.TabIndex = 0;
            // 
            // LBmail
            // 
            this.LBmail.AutoSize = true;
            this.LBmail.Location = new System.Drawing.Point(3, 0);
            this.LBmail.Name = "LBmail";
            this.LBmail.Size = new System.Drawing.Size(36, 15);
            this.LBmail.TabIndex = 0;
            this.LBmail.Text = "email";
            this.LBmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lbpassword
            // 
            this.Lbpassword.AutoSize = true;
            this.Lbpassword.Location = new System.Drawing.Point(3, 44);
            this.Lbpassword.Name = "Lbpassword";
            this.Lbpassword.Size = new System.Drawing.Size(57, 15);
            this.Lbpassword.TabIndex = 1;
            this.Lbpassword.Text = "password";
            this.Lbpassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TXTmail
            // 
            this.TXTmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTmail.Location = new System.Drawing.Point(165, 10);
            this.TXTmail.Name = "TXTmail";
            this.TXTmail.Size = new System.Drawing.Size(157, 23);
            this.TXTmail.TabIndex = 2;
            // 
            // TXTpassword
            // 
            this.TXTpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTpassword.Location = new System.Drawing.Point(165, 54);
            this.TXTpassword.Name = "TXTpassword";
            this.TXTpassword.Size = new System.Drawing.Size(157, 23);
            this.TXTpassword.TabIndex = 3;
            // 
            // BtIdentify
            // 
            this.BtIdentify.Location = new System.Drawing.Point(330, 240);
            this.BtIdentify.Name = "BtIdentify";
            this.BtIdentify.Size = new System.Drawing.Size(110, 33);
            this.BtIdentify.TabIndex = 1;
            this.BtIdentify.Text = "SE CONNECTER";
            this.BtIdentify.UseVisualStyleBackColor = true;
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtIdentify);
            this.Controls.Add(this.TLPconnection);
            this.Name = "FormConnection";
            this.Text = "Form2";
            this.TLPconnection.ResumeLayout(false);
            this.TLPconnection.PerformLayout();
            this.ResumeLayout(false);

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