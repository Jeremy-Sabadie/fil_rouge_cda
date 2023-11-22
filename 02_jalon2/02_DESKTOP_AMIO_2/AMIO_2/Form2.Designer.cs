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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            TLPmat = new TableLayoutPanel();
            DGVmat = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            BTupdate = new Button();
            BTread = new Button();
            BTcreate = new Button();
            BTdellete = new Button();
            FLPcontainerCRUD = new FlowLayoutPanel();
            tlPInput = new TableLayoutPanel();
            TXTname = new TextBox();
            LBmatName = new Label();
            DTPservDat = new DateTimePicker();
            LBgserviceDat = new Label();
            DTPendGarantee = new DateTimePicker();
            LBendGarantee = new Label();
            LBownerName = new Label();
            TXTowner = new TextBox();
            CBcategory = new ComboBox();
            LBfltrNameMat = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            LBmodif = new Label();
            BSmateriel = new BindingSource(components);
            BSuser = new BindingSource(components);
            TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmat).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            FLPcontainerCRUD.SuspendLayout();
            tlPInput.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSmateriel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSuser).BeginInit();
            SuspendLayout();
            // 
            // TLPmat
            // 
            TLPmat.ColumnCount = 1;
            TLPmat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPmat.Controls.Add(DGVmat, 0, 0);
            TLPmat.Controls.Add(tableLayoutPanel1, 0, 3);
            TLPmat.Controls.Add(FLPcontainerCRUD, 0, 2);
            TLPmat.Controls.Add(tableLayoutPanel2, 0, 1);
            TLPmat.Dock = DockStyle.Fill;
            TLPmat.Location = new Point(0, 0);
            TLPmat.Margin = new Padding(2);
            TLPmat.Name = "TLPmat";
            TLPmat.RowCount = 4;
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 22.41379F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 36.2068977F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 41.48707F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            TLPmat.Size = new Size(732, 464);
            TLPmat.TabIndex = 0;
            TLPmat.Paint += TLPmat_Paint;
            // 
            // DGVmat
            // 
            DGVmat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmat.Location = new Point(2, 2);
            DGVmat.Margin = new Padding(2);
            DGVmat.Name = "DGVmat";
            DGVmat.RowHeadersWidth = 72;
            DGVmat.RowTemplate.Height = 37;
            DGVmat.Size = new Size(728, 85);
            DGVmat.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5333328F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.044445F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.4939556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.483593F));
            tableLayoutPanel1.Controls.Add(BTupdate, 2, 0);
            tableLayoutPanel1.Controls.Add(BTread, 1, 0);
            tableLayoutPanel1.Controls.Add(BTcreate, 0, 0);
            tableLayoutPanel1.Controls.Add(BTdellete, 3, 0);
            tableLayoutPanel1.Location = new Point(55, 401);
            tableLayoutPanel1.Margin = new Padding(55, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(675, 60);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // BTupdate
            // 
            BTupdate.Image = (Image)resources.GetObject("BTupdate.Image");
            BTupdate.ImageAlign = ContentAlignment.BottomCenter;
            BTupdate.Location = new Point(246, 10);
            BTupdate.Margin = new Padding(10);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(91, 40);
            BTupdate.TabIndex = 2;
            BTupdate.Text = "UPDATE";
            BTupdate.TextAlign = ContentAlignment.TopCenter;
            BTupdate.UseVisualStyleBackColor = true;
            BTupdate.Click += BTupdate_Click;
            // 
            // BTread
            // 
            BTread.Image = (Image)resources.GetObject("BTread.Image");
            BTread.ImageAlign = ContentAlignment.BottomCenter;
            BTread.Location = new Point(121, 10);
            BTread.Margin = new Padding(10);
            BTread.Name = "BTread";
            BTread.Size = new Size(91, 40);
            BTread.TabIndex = 1;
            BTread.Text = "READ";
            BTread.TextAlign = ContentAlignment.TopCenter;
            BTread.UseVisualStyleBackColor = true;
            BTread.Click += BTread_Click;
            // 
            // BTcreate
            // 
            BTcreate.Image = (Image)resources.GetObject("BTcreate.Image");
            BTcreate.ImageAlign = ContentAlignment.BottomCenter;
            BTcreate.Location = new Point(10, 10);
            BTcreate.Margin = new Padding(10);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(91, 40);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "CREATE";
            BTcreate.TextAlign = ContentAlignment.TopCenter;
            BTcreate.UseVisualStyleBackColor = true;
            BTcreate.Click += BTcreate_Click;
            // 
            // BTdellete
            // 
            BTdellete.Image = (Image)resources.GetObject("BTdellete.Image");
            BTdellete.ImageAlign = ContentAlignment.BottomCenter;
            BTdellete.Location = new Point(367, 10);
            BTdellete.Margin = new Padding(10);
            BTdellete.Name = "BTdellete";
            BTdellete.Size = new Size(91, 40);
            BTdellete.TabIndex = 3;
            BTdellete.Text = "DELETE";
            BTdellete.TextAlign = ContentAlignment.TopCenter;
            BTdellete.UseVisualStyleBackColor = true;
            BTdellete.Click += BTdellete_Click;
            // 
            // FLPcontainerCRUD
            // 
            FLPcontainerCRUD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FLPcontainerCRUD.Controls.Add(tlPInput);
            FLPcontainerCRUD.Location = new Point(2, 237);
            FLPcontainerCRUD.Margin = new Padding(2);
            FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            FLPcontainerCRUD.Size = new Size(728, 156);
            FLPcontainerCRUD.TabIndex = 1;
            // 
            // tlPInput
            // 
            tlPInput.ColumnCount = 3;
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9714279F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.02857F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tlPInput.Controls.Add(TXTname, 1, 0);
            tlPInput.Controls.Add(LBmatName, 0, 0);
            tlPInput.Controls.Add(DTPservDat, 1, 1);
            tlPInput.Controls.Add(LBgserviceDat, 0, 1);
            tlPInput.Controls.Add(DTPendGarantee, 1, 2);
            tlPInput.Controls.Add(LBendGarantee, 0, 2);
            tlPInput.Controls.Add(LBownerName, 0, 3);
            tlPInput.Controls.Add(TXTowner, 1, 3);
            tlPInput.Controls.Add(CBcategory, 2, 1);
            tlPInput.Controls.Add(LBfltrNameMat, 2, 0);
            tlPInput.Location = new Point(0, 2);
            tlPInput.Margin = new Padding(0, 2, 2, 2);
            tlPInput.Name = "tlPInput";
            tlPInput.RowCount = 4;
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.Size = new Size(730, 147);
            tlPInput.TabIndex = 4;
            tlPInput.Paint += tlPInput_Paint;
            // 
            // TXTname
            // 
            TXTname.Dock = DockStyle.Fill;
            TXTname.Location = new Point(161, 2);
            TXTname.Margin = new Padding(2);
            TXTname.Name = "TXTname";
            TXTname.Size = new Size(428, 23);
            TXTname.TabIndex = 4;
            // 
            // LBmatName
            // 
            LBmatName.Anchor = AnchorStyles.Left;
            LBmatName.AutoSize = true;
            LBmatName.Location = new Point(2, 10);
            LBmatName.Margin = new Padding(2, 0, 2, 0);
            LBmatName.Name = "LBmatName";
            LBmatName.Size = new Size(95, 15);
            LBmatName.TabIndex = 1;
            LBmatName.Text = "nom du matériel";
            // 
            // DTPservDat
            // 
            DTPservDat.Dock = DockStyle.Fill;
            DTPservDat.Location = new Point(161, 38);
            DTPservDat.Margin = new Padding(2);
            DTPservDat.Name = "DTPservDat";
            DTPservDat.Size = new Size(428, 23);
            DTPservDat.TabIndex = 6;
            DTPservDat.ValueChanged += DTPservDat_ValueChanged;
            // 
            // LBgserviceDat
            // 
            LBgserviceDat.Anchor = AnchorStyles.Left;
            LBgserviceDat.AutoSize = true;
            LBgserviceDat.Location = new Point(2, 46);
            LBgserviceDat.Margin = new Padding(2, 0, 2, 0);
            LBgserviceDat.Name = "LBgserviceDat";
            LBgserviceDat.Size = new Size(129, 15);
            LBgserviceDat.TabIndex = 2;
            LBgserviceDat.Text = "date de mise en service";
            // 
            // DTPendGarantee
            // 
            DTPendGarantee.Dock = DockStyle.Fill;
            DTPendGarantee.Location = new Point(161, 74);
            DTPendGarantee.Margin = new Padding(2);
            DTPendGarantee.Name = "DTPendGarantee";
            DTPendGarantee.Size = new Size(428, 23);
            DTPendGarantee.TabIndex = 7;
            // 
            // LBendGarantee
            // 
            LBendGarantee.Anchor = AnchorStyles.Left;
            LBendGarantee.AutoSize = true;
            LBendGarantee.Location = new Point(2, 82);
            LBendGarantee.Margin = new Padding(2, 0, 2, 0);
            LBendGarantee.Name = "LBendGarantee";
            LBendGarantee.Size = new Size(125, 15);
            LBendGarantee.TabIndex = 3;
            LBendGarantee.Text = "date de fin de garantie";
            // 
            // LBownerName
            // 
            LBownerName.Anchor = AnchorStyles.Left;
            LBownerName.AutoSize = true;
            LBownerName.Location = new Point(2, 120);
            LBownerName.Margin = new Padding(2, 0, 2, 0);
            LBownerName.Name = "LBownerName";
            LBownerName.Size = new Size(113, 15);
            LBownerName.TabIndex = 9;
            LBownerName.Text = "nom du propriétaire";
            LBownerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TXTowner
            // 
            TXTowner.AcceptsReturn = true;
            TXTowner.Dock = DockStyle.Fill;
            TXTowner.Location = new Point(161, 110);
            TXTowner.Margin = new Padding(2);
            TXTowner.Name = "TXTowner";
            TXTowner.Size = new Size(428, 23);
            TXTowner.TabIndex = 5;
            TXTowner.TextChanged += TXTowner_TextChanged;
            // 
            // CBcategory
            // 
            CBcategory.FormattingEnabled = true;
            CBcategory.Location = new Point(593, 38);
            CBcategory.Margin = new Padding(2);
            CBcategory.Name = "CBcategory";
            CBcategory.Size = new Size(125, 23);
            CBcategory.TabIndex = 11;
            // 
            // LBfltrNameMat
            // 
            LBfltrNameMat.Anchor = AnchorStyles.Right;
            LBfltrNameMat.AutoSize = true;
            LBfltrNameMat.Location = new Point(609, 10);
            LBfltrNameMat.Margin = new Padding(2, 0, 2, 0);
            LBfltrNameMat.Name = "LBfltrNameMat";
            LBfltrNameMat.Size = new Size(119, 15);
            LBfltrNameMat.TabIndex = 10;
            LBfltrNameMat.Text = "catégorie du matériel";
            LBfltrNameMat.Click += LBfltrNameMat_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.2962341F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.703764F));
            tableLayoutPanel2.Controls.Add(LBmodif, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 91);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(728, 140);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LBmodif
            // 
            LBmodif.Anchor = AnchorStyles.None;
            LBmodif.AutoSize = true;
            LBmodif.Location = new Point(175, 112);
            LBmodif.Margin = new Padding(0, 100, 18, 0);
            LBmodif.Name = "LBmodif";
            LBmodif.Size = new Size(142, 15);
            LBmodif.TabIndex = 0;
            LBmodif.Text = "MODIFIER LES MATERIELS";
            LBmodif.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 464);
            Controls.Add(TLPmat);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Materiel";
            Load += Form2_Load;
            TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVmat).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            FLPcontainerCRUD.ResumeLayout(false);
            tlPInput.ResumeLayout(false);
            tlPInput.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BSmateriel).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPmat;
        private DataGridView DGVmat;
        private FlowLayoutPanel FLPcontainerCRUD;
        private Button BTcreate;
        private Button BTread;
        private Button BTupdate;
        private Button BTdellete;
        private TableLayoutPanel tlPInput;
        private Label LBmatName;
        private Label LBgserviceDat;
        private TextBox TXTname;
        private DateTimePicker DTPservDat;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LBfltrNameMat;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LBmodif;
        private ComboBox CBcategory;
        private DateTimePicker DTPendGarantee;
        private Label LBendGarantee;
        private Label LBownerName;
        private TextBox TXTowner;
        private BindingSource BSmateriel;
        private BindingSource BSuser;
    }
}