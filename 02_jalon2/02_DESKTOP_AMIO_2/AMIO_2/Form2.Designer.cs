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
            BTfiltre = new Button();
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
            LBfltrNameMat = new Label();
            LBfltrDTserv = new Label();
            LBfltrEndgarantee = new Label();
            LNfltrOwnerName = new Label();
            TXTfltrMatName = new TextBox();
            DTPfltrServiceDat = new DateTimePicker();
            DTPfltrEndDat = new DateTimePicker();
            TXTfltrOwnerName = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            LBfiltrBy = new Label();
            LBmodif = new Label();
            bindingSourceMateriel = new BindingSource(components);
            TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmat).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            FLPcontainerCRUD.SuspendLayout();
            tlPInput.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMateriel).BeginInit();
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
            TLPmat.Margin = new Padding(3, 4, 3, 4);
            TLPmat.Name = "TLPmat";
            TLPmat.RowCount = 4;
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 22.41379F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 36.2068977F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 41.48707F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            TLPmat.Size = new Size(1255, 928);
            TLPmat.TabIndex = 0;
            TLPmat.Paint += TLPmat_Paint;
            // 
            // DGVmat
            // 
            DGVmat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmat.Location = new Point(3, 4);
            DGVmat.Margin = new Padding(3, 4, 3, 4);
            DGVmat.Name = "DGVmat";
            DGVmat.RowHeadersWidth = 72;
            DGVmat.RowTemplate.Height = 37;
            DGVmat.Size = new Size(1248, 171);
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
            tableLayoutPanel1.Controls.Add(BTfiltre, 4, 0);
            tableLayoutPanel1.Controls.Add(BTdellete, 3, 0);
            tableLayoutPanel1.Location = new Point(94, 803);
            tableLayoutPanel1.Margin = new Padding(94, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1158, 121);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // BTupdate
            // 
            BTupdate.Image = Properties.Resources.refresh_arrow_15461;
            BTupdate.ImageAlign = ContentAlignment.BottomCenter;
            BTupdate.Location = new Point(423, 20);
            BTupdate.Margin = new Padding(17, 20, 17, 20);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(100, 61);
            BTupdate.TabIndex = 2;
            BTupdate.Text = "UPDATE";
            BTupdate.TextAlign = ContentAlignment.TopCenter;
            BTupdate.UseVisualStyleBackColor = true;
            BTupdate.Click += BTupdate_Click;
            // 
            // BTread
            // 
            BTread.Image = Properties.Resources.read;
            BTread.ImageAlign = ContentAlignment.BottomCenter;
            BTread.Location = new Point(208, 20);
            BTread.Margin = new Padding(17, 20, 17, 20);
            BTread.Name = "BTread";
            BTread.Size = new Size(100, 61);
            BTread.TabIndex = 1;
            BTread.Text = "READ";
            BTread.TextAlign = ContentAlignment.TopCenter;
            BTread.UseVisualStyleBackColor = true;
            BTread.Click += BTread_Click;
            // 
            // BTcreate
            // 
            BTcreate.Image = Properties.Resources.create;
            BTcreate.ImageAlign = ContentAlignment.BottomCenter;
            BTcreate.Location = new Point(17, 20);
            BTcreate.Margin = new Padding(17, 20, 17, 20);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(100, 61);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "CREATE";
            BTcreate.TextAlign = ContentAlignment.TopCenter;
            BTcreate.UseVisualStyleBackColor = true;
            BTcreate.Click += BTcreate_Click;
            // 
            // BTfiltre
            // 
            BTfiltre.Image = (Image)resources.GetObject("BTfiltre.Image");
            BTfiltre.ImageAlign = ContentAlignment.BottomCenter;
            BTfiltre.Location = new Point(821, 20);
            BTfiltre.Margin = new Padding(17, 20, 17, 20);
            BTfiltre.Name = "BTfiltre";
            BTfiltre.Size = new Size(254, 61);
            BTfiltre.TabIndex = 4;
            BTfiltre.Text = "APPLIQUER LE FILTRE";
            BTfiltre.TextAlign = ContentAlignment.TopCenter;
            BTfiltre.UseVisualStyleBackColor = true;
            // 
            // BTdellete
            // 
            BTdellete.Image = (Image)resources.GetObject("BTdellete.Image");
            BTdellete.ImageAlign = ContentAlignment.BottomCenter;
            BTdellete.Location = new Point(631, 20);
            BTdellete.Margin = new Padding(17, 20, 17, 20);
            BTdellete.Name = "BTdellete";
            BTdellete.Size = new Size(100, 61);
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
            FLPcontainerCRUD.Location = new Point(3, 477);
            FLPcontainerCRUD.Margin = new Padding(3, 4, 3, 4);
            FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            FLPcontainerCRUD.Size = new Size(1249, 313);
            FLPcontainerCRUD.TabIndex = 1;
            // 
            // tlPInput
            // 
            tlPInput.ColumnCount = 4;
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9714279F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.02857F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 236F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 371F));
            tlPInput.Controls.Add(TXTname, 1, 0);
            tlPInput.Controls.Add(LBmatName, 0, 0);
            tlPInput.Controls.Add(DTPservDat, 1, 1);
            tlPInput.Controls.Add(LBgserviceDat, 0, 1);
            tlPInput.Controls.Add(DTPendGarantee, 1, 2);
            tlPInput.Controls.Add(LBendGarantee, 0, 2);
            tlPInput.Controls.Add(LBownerName, 0, 3);
            tlPInput.Controls.Add(TXTowner, 1, 3);
            tlPInput.Controls.Add(LBfltrNameMat, 2, 0);
            tlPInput.Controls.Add(LBfltrDTserv, 2, 1);
            tlPInput.Controls.Add(LBfltrEndgarantee, 2, 2);
            tlPInput.Controls.Add(LNfltrOwnerName, 2, 3);
            tlPInput.Controls.Add(TXTfltrMatName, 3, 0);
            tlPInput.Controls.Add(DTPfltrServiceDat, 3, 1);
            tlPInput.Controls.Add(DTPfltrEndDat, 3, 2);
            tlPInput.Controls.Add(TXTfltrOwnerName, 3, 3);
            tlPInput.Location = new Point(0, 4);
            tlPInput.Margin = new Padding(0, 4, 3, 4);
            tlPInput.Name = "tlPInput";
            tlPInput.RowCount = 5;
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlPInput.Size = new Size(1252, 294);
            tlPInput.TabIndex = 4;
            tlPInput.Paint += tlPInput_Paint;
            // 
            // TXTname
            // 
            TXTname.Dock = DockStyle.Fill;
            TXTname.Location = new Point(176, 4);
            TXTname.Margin = new Padding(3, 4, 3, 4);
            TXTname.Name = "TXTname";
            TXTname.Size = new Size(465, 35);
            TXTname.TabIndex = 4;
            // 
            // LBmatName
            // 
            LBmatName.Anchor = AnchorStyles.Left;
            LBmatName.AutoSize = true;
            LBmatName.Location = new Point(3, 17);
            LBmatName.Name = "LBmatName";
            LBmatName.Size = new Size(166, 30);
            LBmatName.TabIndex = 1;
            LBmatName.Text = "nom du matériel";
            // 
            // DTPservDat
            // 
            DTPservDat.Dock = DockStyle.Fill;
            DTPservDat.Location = new Point(176, 68);
            DTPservDat.Margin = new Padding(3, 4, 3, 4);
            DTPservDat.Name = "DTPservDat";
            DTPservDat.Size = new Size(465, 35);
            DTPservDat.TabIndex = 6;
            // 
            // LBgserviceDat
            // 
            LBgserviceDat.Anchor = AnchorStyles.Left;
            LBgserviceDat.AutoSize = true;
            LBgserviceDat.Location = new Point(3, 66);
            LBgserviceDat.Name = "LBgserviceDat";
            LBgserviceDat.Size = new Size(167, 60);
            LBgserviceDat.TabIndex = 2;
            LBgserviceDat.Text = "date de mise en service";
            // 
            // DTPendGarantee
            // 
            DTPendGarantee.Dock = DockStyle.Fill;
            DTPendGarantee.Location = new Point(176, 132);
            DTPendGarantee.Margin = new Padding(3, 4, 3, 4);
            DTPendGarantee.Name = "DTPendGarantee";
            DTPendGarantee.Size = new Size(465, 35);
            DTPendGarantee.TabIndex = 7;
            // 
            // LBendGarantee
            // 
            LBendGarantee.Anchor = AnchorStyles.Left;
            LBendGarantee.AutoSize = true;
            LBendGarantee.Location = new Point(3, 130);
            LBendGarantee.Name = "LBendGarantee";
            LBendGarantee.Size = new Size(148, 60);
            LBendGarantee.TabIndex = 3;
            LBendGarantee.Text = "date de fin de garantie";
            // 
            // LBownerName
            // 
            LBownerName.Anchor = AnchorStyles.Left;
            LBownerName.AutoSize = true;
            LBownerName.Location = new Point(3, 194);
            LBownerName.Name = "LBownerName";
            LBownerName.Size = new Size(120, 60);
            LBownerName.TabIndex = 9;
            LBownerName.Text = "nom du propriétaire";
            LBownerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TXTowner
            // 
            TXTowner.AcceptsReturn = true;
            TXTowner.Dock = DockStyle.Fill;
            TXTowner.Location = new Point(176, 196);
            TXTowner.Margin = new Padding(3, 4, 3, 4);
            TXTowner.Name = "TXTowner";
            TXTowner.Size = new Size(465, 35);
            TXTowner.TabIndex = 5;
            TXTowner.TextChanged += TXTowner_TextChanged;
            // 
            // LBfltrNameMat
            // 
            LBfltrNameMat.Anchor = AnchorStyles.Right;
            LBfltrNameMat.AutoSize = true;
            LBfltrNameMat.Location = new Point(706, 17);
            LBfltrNameMat.Name = "LBfltrNameMat";
            LBfltrNameMat.Size = new Size(171, 30);
            LBfltrNameMat.TabIndex = 10;
            LBfltrNameMat.Text = " nom de matériel";
            // 
            // LBfltrDTserv
            // 
            LBfltrDTserv.Anchor = AnchorStyles.Right;
            LBfltrDTserv.AutoSize = true;
            LBfltrDTserv.Location = new Point(647, 81);
            LBfltrDTserv.Name = "LBfltrDTserv";
            LBfltrDTserv.Size = new Size(230, 30);
            LBfltrDTserv.TabIndex = 11;
            LBfltrDTserv.Text = "date de mise en service";
            // 
            // LBfltrEndgarantee
            // 
            LBfltrEndgarantee.Anchor = AnchorStyles.Right;
            LBfltrEndgarantee.AutoSize = true;
            LBfltrEndgarantee.Location = new Point(653, 145);
            LBfltrEndgarantee.Name = "LBfltrEndgarantee";
            LBfltrEndgarantee.Size = new Size(224, 30);
            LBfltrEndgarantee.TabIndex = 12;
            LBfltrEndgarantee.Text = "date de fin de garantie";
            // 
            // LNfltrOwnerName
            // 
            LNfltrOwnerName.Anchor = AnchorStyles.Right;
            LNfltrOwnerName.AutoSize = true;
            LNfltrOwnerName.Location = new Point(680, 209);
            LNfltrOwnerName.Name = "LNfltrOwnerName";
            LNfltrOwnerName.Size = new Size(197, 30);
            LNfltrOwnerName.TabIndex = 13;
            LNfltrOwnerName.Text = "nom de propriétaire";
            // 
            // TXTfltrMatName
            // 
            TXTfltrMatName.Dock = DockStyle.Fill;
            TXTfltrMatName.Location = new Point(883, 3);
            TXTfltrMatName.Margin = new Padding(3, 3, 3, 30);
            TXTfltrMatName.Name = "TXTfltrMatName";
            TXTfltrMatName.Size = new Size(366, 35);
            TXTfltrMatName.TabIndex = 14;
            // 
            // DTPfltrServiceDat
            // 
            DTPfltrServiceDat.Dock = DockStyle.Fill;
            DTPfltrServiceDat.Location = new Point(883, 67);
            DTPfltrServiceDat.Name = "DTPfltrServiceDat";
            DTPfltrServiceDat.Size = new Size(366, 35);
            DTPfltrServiceDat.TabIndex = 15;
            // 
            // DTPfltrEndDat
            // 
            DTPfltrEndDat.Location = new Point(883, 131);
            DTPfltrEndDat.Name = "DTPfltrEndDat";
            DTPfltrEndDat.Size = new Size(215, 35);
            DTPfltrEndDat.TabIndex = 16;
            // 
            // TXTfltrOwnerName
            // 
            TXTfltrOwnerName.Dock = DockStyle.Fill;
            TXTfltrOwnerName.Location = new Point(883, 195);
            TXTfltrOwnerName.Name = "TXTfltrOwnerName";
            TXTfltrOwnerName.Size = new Size(366, 35);
            TXTfltrOwnerName.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.2962341F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.703764F));
            tableLayoutPanel2.Controls.Add(LBfiltrBy, 1, 0);
            tableLayoutPanel2.Controls.Add(LBmodif, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 182);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1249, 283);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LBfiltrBy
            // 
            LBfiltrBy.Anchor = AnchorStyles.None;
            LBfiltrBy.AutoSize = true;
            LBfiltrBy.Location = new Point(1016, 226);
            LBfiltrBy.Margin = new Padding(3, 200, 3, 0);
            LBfiltrBy.Name = "LBfiltrBy";
            LBfiltrBy.Size = new Size(94, 30);
            LBfiltrBy.TabIndex = 1;
            LBfiltrBy.Text = "Filter par";
            LBfiltrBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBmodif
            // 
            LBmodif.Anchor = AnchorStyles.None;
            LBmodif.AutoSize = true;
            LBmodif.Location = new Point(295, 226);
            LBmodif.Margin = new Padding(0, 200, 30, 0);
            LBmodif.Name = "LBmodif";
            LBmodif.Size = new Size(257, 30);
            LBmodif.TabIndex = 0;
            LBmodif.Text = "MODIFIER LES MATERIELS";
            LBmodif.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 928);
            Controls.Add(TLPmat);
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)bindingSourceMateriel).EndInit();
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
        private BindingSource bindingSourceMateriel;
        private TableLayoutPanel tlPInput;
        private Label LBmatName;
        private Label LBgserviceDat;
        private Label LBendGarantee;
        private TextBox TXTname;
        private TextBox TXTowner;
        private DateTimePicker DTPservDat;
        private DateTimePicker DTPendGarantee;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTfiltre;
        private Label LBownerName;
        private Label LBfltrDTserv;
        private Label LBfltrEndgarantee;
        private Label LBfltrNameMat;
        private Label LNfltrOwnerName;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LBmodif;
        private Label LBfiltrBy;
        private TextBox TXTfltrMatName;
        private DateTimePicker DTPfltrServiceDat;
        private DateTimePicker DTPfltrEndDat;
        private TextBox TXTfltrOwnerName;
    }
}