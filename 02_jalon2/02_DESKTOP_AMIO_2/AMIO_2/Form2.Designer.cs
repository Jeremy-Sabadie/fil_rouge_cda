namespace AMIO_2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TLPmat = new System.Windows.Forms.TableLayoutPanel();
            this.DGVmat = new System.Windows.Forms.DataGridView();
            this.FLPcontainerCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.tlPInput = new System.Windows.Forms.TableLayoutPanel();
            this.LBname = new System.Windows.Forms.Label();
            this.LBservDat = new System.Windows.Forms.Label();
            this.LBgarantee = new System.Windows.Forms.Label();
            this.LBowner = new System.Windows.Forms.Label();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.TXTowner = new System.Windows.Forms.TextBox();
            this.DTPservDat = new System.Windows.Forms.DateTimePicker();
            this.DTPendGarantee = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTdellete = new System.Windows.Forms.Button();
            this.BTupdate = new System.Windows.Forms.Button();
            this.BTread = new System.Windows.Forms.Button();
            this.BTcreate = new System.Windows.Forms.Button();
            this.BTfiltre = new System.Windows.Forms.Button();
            this.bindingSourceMateriel = new System.Windows.Forms.BindingSource(this.components);
            this.TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmat)).BeginInit();
            this.FLPcontainerCRUD.SuspendLayout();
            this.tlPInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriel)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPmat
            // 
            this.TLPmat.ColumnCount = 1;
            this.TLPmat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPmat.Controls.Add(this.DGVmat, 0, 0);
            this.TLPmat.Controls.Add(this.FLPcontainerCRUD, 0, 1);
            this.TLPmat.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.TLPmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPmat.Location = new System.Drawing.Point(0, 0);
            this.TLPmat.Margin = new System.Windows.Forms.Padding(2);
            this.TLPmat.Name = "TLPmat";
            this.TLPmat.RowCount = 3;
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.41379F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.30172F));
            this.TLPmat.Size = new System.Drawing.Size(732, 464);
            this.TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            this.DGVmat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmat.Location = new System.Drawing.Point(2, 2);
            this.DGVmat.Margin = new System.Windows.Forms.Padding(2);
            this.DGVmat.Name = "DGVmat";
            this.DGVmat.RowHeadersWidth = 72;
            this.DGVmat.RowTemplate.Height = 37;
            this.DGVmat.Size = new System.Drawing.Size(728, 100);
            this.DGVmat.TabIndex = 0;
            // 
            // FLPcontainerCRUD
            // 
            this.FLPcontainerCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPcontainerCRUD.Controls.Add(this.tlPInput);
            this.FLPcontainerCRUD.Location = new System.Drawing.Point(2, 108);
            this.FLPcontainerCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            this.FLPcontainerCRUD.Size = new System.Drawing.Size(728, 163);
            this.FLPcontainerCRUD.TabIndex = 1;
            // 
            // tlPInput
            // 
            this.tlPInput.ColumnCount = 2;
            this.tlPInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.86259F));
            this.tlPInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.13741F));
            this.tlPInput.Controls.Add(this.LBname, 0, 0);
            this.tlPInput.Controls.Add(this.LBservDat, 0, 1);
            this.tlPInput.Controls.Add(this.LBgarantee, 0, 2);
            this.tlPInput.Controls.Add(this.LBowner, 0, 3);
            this.tlPInput.Controls.Add(this.TXTname, 1, 0);
            this.tlPInput.Controls.Add(this.TXTowner, 1, 3);
            this.tlPInput.Controls.Add(this.DTPservDat, 1, 1);
            this.tlPInput.Controls.Add(this.DTPendGarantee, 1, 2);
            this.tlPInput.Location = new System.Drawing.Point(60, 2);
            this.tlPInput.Margin = new System.Windows.Forms.Padding(60, 2, 2, 2);
            this.tlPInput.Name = "tlPInput";
            this.tlPInput.RowCount = 4;
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlPInput.Size = new System.Drawing.Size(410, 161);
            this.tlPInput.TabIndex = 4;
            // 
            // LBname
            // 
            this.LBname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBname.AutoSize = true;
            this.LBname.Location = new System.Drawing.Point(58, 0);
            this.LBname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBname.Name = "LBname";
            this.LBname.Size = new System.Drawing.Size(95, 15);
            this.LBname.TabIndex = 0;
            this.LBname.Text = "nom du matériel";
            // 
            // LBservDat
            // 
            this.LBservDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBservDat.AutoSize = true;
            this.LBservDat.Location = new System.Drawing.Point(24, 45);
            this.LBservDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBservDat.Name = "LBservDat";
            this.LBservDat.Size = new System.Drawing.Size(129, 15);
            this.LBservDat.TabIndex = 1;
            this.LBservDat.Text = "date de mise en service";
            // 
            // LBgarantee
            // 
            this.LBgarantee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBgarantee.AutoSize = true;
            this.LBgarantee.Location = new System.Drawing.Point(28, 91);
            this.LBgarantee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBgarantee.Name = "LBgarantee";
            this.LBgarantee.Size = new System.Drawing.Size(125, 15);
            this.LBgarantee.TabIndex = 2;
            this.LBgarantee.Text = "date de fin de garentie";
            // 
            // LBowner
            // 
            this.LBowner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBowner.AutoSize = true;
            this.LBowner.Location = new System.Drawing.Point(27, 128);
            this.LBowner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBowner.Name = "LBowner";
            this.LBowner.Size = new System.Drawing.Size(126, 30);
            this.LBowner.TabIndex = 3;
            this.LBowner.Text = "nom du proriétaire du matériel";
            // 
            // TXTname
            // 
            this.TXTname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTname.Location = new System.Drawing.Point(157, 2);
            this.TXTname.Margin = new System.Windows.Forms.Padding(2);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(251, 23);
            this.TXTname.TabIndex = 4;
            // 
            // TXTowner
            // 
            this.TXTowner.AcceptsReturn = true;
            this.TXTowner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTowner.Location = new System.Drawing.Point(157, 130);
            this.TXTowner.Margin = new System.Windows.Forms.Padding(2);
            this.TXTowner.Name = "TXTowner";
            this.TXTowner.Size = new System.Drawing.Size(251, 23);
            this.TXTowner.TabIndex = 5;
            // 
            // DTPservDat
            // 
            this.DTPservDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPservDat.Location = new System.Drawing.Point(157, 47);
            this.DTPservDat.Margin = new System.Windows.Forms.Padding(2);
            this.DTPservDat.Name = "DTPservDat";
            this.DTPservDat.Size = new System.Drawing.Size(251, 23);
            this.DTPservDat.TabIndex = 6;
            // 
            // DTPendGarantee
            // 
            this.DTPendGarantee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPendGarantee.Location = new System.Drawing.Point(157, 93);
            this.DTPendGarantee.Margin = new System.Windows.Forms.Padding(2);
            this.DTPendGarantee.Name = "DTPendGarantee";
            this.DTPendGarantee.Size = new System.Drawing.Size(251, 23);
            this.DTPendGarantee.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BTdellete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTupdate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTread, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTcreate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTfiltre, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 278);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(55, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 80);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BTdellete
            // 
            this.BTdellete.Location = new System.Drawing.Point(337, 10);
            this.BTdellete.Margin = new System.Windows.Forms.Padding(10);
            this.BTdellete.Name = "BTdellete";
            this.BTdellete.Size = new System.Drawing.Size(80, 43);
            this.BTdellete.TabIndex = 3;
            this.BTdellete.Text = "DELETE";
            this.BTdellete.UseVisualStyleBackColor = true;
            // 
            // BTupdate
            // 
            this.BTupdate.Image = global::AMIO_2.Properties.Resources.refresh_arrow_15461;
            this.BTupdate.Location = new System.Drawing.Point(228, 10);
            this.BTupdate.Margin = new System.Windows.Forms.Padding(10);
            this.BTupdate.Name = "BTupdate";
            this.BTupdate.Size = new System.Drawing.Size(80, 43);
            this.BTupdate.TabIndex = 2;
            this.BTupdate.Text = "UPDATE";
            this.BTupdate.UseVisualStyleBackColor = true;
            this.BTupdate.Click += new System.EventHandler(this.BTupdate_Click);
            // 
            // BTread
            // 
            this.BTread.Image = ((System.Drawing.Image)(resources.GetObject("BTread.Image")));
            this.BTread.Location = new System.Drawing.Point(119, 10);
            this.BTread.Margin = new System.Windows.Forms.Padding(10);
            this.BTread.Name = "BTread";
            this.BTread.Size = new System.Drawing.Size(80, 43);
            this.BTread.TabIndex = 1;
            this.BTread.Text = "READ";
            this.BTread.UseVisualStyleBackColor = true;
            this.BTread.Click += new System.EventHandler(this.BTread_Click);
            // 
            // BTcreate
            // 
            this.BTcreate.Location = new System.Drawing.Point(10, 10);
            this.BTcreate.Margin = new System.Windows.Forms.Padding(10);
            this.BTcreate.Name = "BTcreate";
            this.BTcreate.Size = new System.Drawing.Size(80, 50);
            this.BTcreate.TabIndex = 0;
            this.BTcreate.Text = "CREATE";
            this.BTcreate.UseVisualStyleBackColor = true;
            this.BTcreate.Click += new System.EventHandler(this.BTcreate_Click);
            // 
            // BTfiltre
            // 
            this.BTfiltre.Location = new System.Drawing.Point(446, 10);
            this.BTfiltre.Margin = new System.Windows.Forms.Padding(10);
            this.BTfiltre.Name = "BTfiltre";
            this.BTfiltre.Size = new System.Drawing.Size(80, 43);
            this.BTfiltre.TabIndex = 4;
            this.BTfiltre.Text = "FILTER";
            this.BTfiltre.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 464);
            this.Controls.Add(this.TLPmat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Materiel";
            this.TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmat)).EndInit();
            this.FLPcontainerCRUD.ResumeLayout(false);
            this.tlPInput.ResumeLayout(false);
            this.tlPInput.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel TLPmat;
        private DataGridView DGVmat;
        private FlowLayoutPanel FLPcontainerCRUD;
        private Button BTcreate;
        private Button BTread;
        private Button BTupdate;
        private Button BTdellete;
        private BindingSource bindingSourceMateriel;
        private TableLayoutPanel tlPInput;
        private Label LBname;
        private Label LBservDat;
        private Label LBgarantee;
        private Label LBowner;
        private TextBox TXTname;
        private TextBox TXTowner;
        private DateTimePicker DTPservDat;
        private DateTimePicker DTPendGarantee;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTfiltre;
    }
}