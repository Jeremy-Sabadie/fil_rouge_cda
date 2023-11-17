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
            FLPcontainerCRUD = new FlowLayoutPanel();
            tlPInput = new TableLayoutPanel();
            LBmatNumber = new Label();
            LBmatName = new Label();
            LBgserviceDat = new Label();
            LBendGarantee = new Label();
            TXTowner = new TextBox();
            DTPendGarantee = new DateTimePicker();
            DTPservDat = new DateTimePicker();
            TXTname = new TextBox();
            NUDmatNumber = new NumericUpDown();
            LBownerName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            BTdellete = new Button();
            BTupdate = new Button();
            BTread = new Button();
            BTcreate = new Button();
            BTfiltre = new Button();
            bindingSourceMateriel = new BindingSource(components);
            TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmat).BeginInit();
            FLPcontainerCRUD.SuspendLayout();
            tlPInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDmatNumber).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMateriel).BeginInit();
            SuspendLayout();
            // 
            // TLPmat
            // 
            TLPmat.ColumnCount = 1;
            TLPmat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPmat.Controls.Add(DGVmat, 0, 0);
            TLPmat.Controls.Add(FLPcontainerCRUD, 0, 1);
            TLPmat.Controls.Add(tableLayoutPanel1, 0, 2);
            TLPmat.Dock = DockStyle.Fill;
            TLPmat.Location = new Point(0, 0);
            TLPmat.Margin = new Padding(3, 4, 3, 4);
            TLPmat.Name = "TLPmat";
            TLPmat.RowCount = 3;
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 22.41379F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6939659F));
            TLPmat.Size = new Size(1255, 928);
            TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            DGVmat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmat.Location = new Point(3, 4);
            DGVmat.Margin = new Padding(3, 4, 3, 4);
            DGVmat.Name = "DGVmat";
            DGVmat.RowHeadersWidth = 72;
            DGVmat.RowTemplate.Height = 37;
            DGVmat.Size = new Size(1248, 199);
            DGVmat.TabIndex = 0;
            // 
            // FLPcontainerCRUD
            // 
            FLPcontainerCRUD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FLPcontainerCRUD.Controls.Add(tlPInput);
            FLPcontainerCRUD.Location = new Point(3, 216);
            FLPcontainerCRUD.Margin = new Padding(3, 4, 3, 4);
            FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            FLPcontainerCRUD.Size = new Size(1249, 445);
            FLPcontainerCRUD.TabIndex = 1;
            // 
            // tlPInput
            // 
            tlPInput.ColumnCount = 2;
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.86259F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.13741F));
            tlPInput.Controls.Add(LBmatNumber, 0, 0);
            tlPInput.Controls.Add(LBmatName, 0, 1);
            tlPInput.Controls.Add(LBgserviceDat, 0, 2);
            tlPInput.Controls.Add(LBendGarantee, 0, 3);
            tlPInput.Controls.Add(TXTowner, 1, 4);
            tlPInput.Controls.Add(DTPendGarantee, 1, 3);
            tlPInput.Controls.Add(DTPservDat, 1, 2);
            tlPInput.Controls.Add(TXTname, 1, 1);
            tlPInput.Controls.Add(NUDmatNumber, 1, 0);
            tlPInput.Controls.Add(LBownerName, 0, 4);
            tlPInput.Location = new Point(103, 4);
            tlPInput.Margin = new Padding(103, 4, 3, 4);
            tlPInput.Name = "tlPInput";
            tlPInput.RowCount = 5;
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlPInput.Size = new Size(706, 441);
            tlPInput.TabIndex = 4;
            // 
            // LBmatNumber
            // 
            LBmatNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBmatNumber.AutoSize = true;
            LBmatNumber.Location = new Point(68, 0);
            LBmatNumber.Name = "LBmatNumber";
            LBmatNumber.Size = new Size(196, 30);
            LBmatNumber.TabIndex = 0;
            LBmatNumber.Text = "numéro du matériel";
            // 
            // LBmatName
            // 
            LBmatName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBmatName.AutoSize = true;
            LBmatName.Location = new Point(98, 101);
            LBmatName.Name = "LBmatName";
            LBmatName.Size = new Size(166, 30);
            LBmatName.TabIndex = 1;
            LBmatName.Text = "nom du matériel";
            // 
            // LBgserviceDat
            // 
            LBgserviceDat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBgserviceDat.AutoSize = true;
            LBgserviceDat.Location = new Point(34, 202);
            LBgserviceDat.Name = "LBgserviceDat";
            LBgserviceDat.Size = new Size(230, 30);
            LBgserviceDat.TabIndex = 2;
            LBgserviceDat.Text = "date de mise en service";
            // 
            // LBendGarantee
            // 
            LBendGarantee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBendGarantee.AutoSize = true;
            LBendGarantee.Location = new Point(40, 303);
            LBendGarantee.Name = "LBendGarantee";
            LBendGarantee.Size = new Size(224, 30);
            LBendGarantee.TabIndex = 3;
            LBendGarantee.Text = "date de fin de garantie";
            // 
            // TXTowner
            // 
            TXTowner.AcceptsReturn = true;
            TXTowner.Location = new Point(270, 408);
            TXTowner.Margin = new Padding(3, 4, 3, 4);
            TXTowner.Name = "TXTowner";
            TXTowner.Size = new Size(431, 35);
            TXTowner.TabIndex = 5;
            TXTowner.TextChanged += TXTowner_TextChanged;
            // 
            // DTPendGarantee
            // 
            DTPendGarantee.Dock = DockStyle.Fill;
            DTPendGarantee.Location = new Point(270, 307);
            DTPendGarantee.Margin = new Padding(3, 4, 3, 4);
            DTPendGarantee.Name = "DTPendGarantee";
            DTPendGarantee.Size = new Size(433, 35);
            DTPendGarantee.TabIndex = 7;
            // 
            // DTPservDat
            // 
            DTPservDat.Dock = DockStyle.Fill;
            DTPservDat.Location = new Point(270, 206);
            DTPservDat.Margin = new Padding(3, 4, 3, 4);
            DTPservDat.Name = "DTPservDat";
            DTPservDat.Size = new Size(433, 35);
            DTPservDat.TabIndex = 6;
            // 
            // TXTname
            // 
            TXTname.Dock = DockStyle.Fill;
            TXTname.Location = new Point(270, 105);
            TXTname.Margin = new Padding(3, 4, 3, 4);
            TXTname.Name = "TXTname";
            TXTname.Size = new Size(433, 35);
            TXTname.TabIndex = 4;
            // 
            // NUDmatNumber
            // 
            NUDmatNumber.Dock = DockStyle.Fill;
            NUDmatNumber.Location = new Point(270, 3);
            NUDmatNumber.Name = "NUDmatNumber";
            NUDmatNumber.Size = new Size(433, 35);
            NUDmatNumber.TabIndex = 8;
            // 
            // LBownerName
            // 
            LBownerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LBownerName.AutoSize = true;
            LBownerName.Location = new Point(66, 404);
            LBownerName.Name = "LBownerName";
            LBownerName.Size = new Size(198, 30);
            LBownerName.TabIndex = 9;
            LBownerName.Text = "nom du propriétaire";
            LBownerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(BTdellete, 3, 0);
            tableLayoutPanel1.Controls.Add(BTupdate, 2, 0);
            tableLayoutPanel1.Controls.Add(BTread, 1, 0);
            tableLayoutPanel1.Controls.Add(BTcreate, 0, 0);
            tableLayoutPanel1.Controls.Add(BTfiltre, 4, 0);
            tableLayoutPanel1.Location = new Point(94, 674);
            tableLayoutPanel1.Margin = new Padding(94, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(941, 160);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // BTdellete
            // 
            BTdellete.Location = new Point(581, 20);
            BTdellete.Margin = new Padding(17, 20, 17, 20);
            BTdellete.Name = "BTdellete";
            BTdellete.Size = new Size(137, 86);
            BTdellete.TabIndex = 3;
            BTdellete.Text = "DELETE";
            BTdellete.TextAlign = ContentAlignment.TopCenter;
            BTdellete.UseVisualStyleBackColor = true;
            BTdellete.Click += BTdellete_Click;
            // 
            // BTupdate
            // 
            BTupdate.Image = Properties.Resources.refresh_arrow_15461;
            BTupdate.Location = new Point(393, 20);
            BTupdate.Margin = new Padding(17, 20, 17, 20);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(137, 86);
            BTupdate.TabIndex = 2;
            BTupdate.Text = "UPDATE";
            BTupdate.TextAlign = ContentAlignment.TopCenter;
            BTupdate.UseVisualStyleBackColor = true;
            BTupdate.Click += BTupdate_Click;
            // 
            // BTread
            // 
            BTread.Image = (Image)resources.GetObject("BTread.Image");
            BTread.Location = new Point(205, 20);
            BTread.Margin = new Padding(17, 20, 17, 20);
            BTread.Name = "BTread";
            BTread.Size = new Size(137, 86);
            BTread.TabIndex = 1;
            BTread.Text = "READ";
            BTread.TextAlign = ContentAlignment.TopCenter;
            BTread.UseVisualStyleBackColor = true;
            BTread.Click += BTread_Click;
            // 
            // BTcreate
            // 
            BTcreate.Location = new Point(17, 20);
            BTcreate.Margin = new Padding(17, 20, 17, 20);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(137, 100);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "CREATE";
            BTcreate.UseVisualStyleBackColor = true;
            BTcreate.Click += BTcreate_Click;
            // 
            // BTfiltre
            // 
            BTfiltre.Location = new Point(769, 20);
            BTfiltre.Margin = new Padding(17, 20, 17, 20);
            BTfiltre.Name = "BTfiltre";
            BTfiltre.Size = new Size(137, 86);
            BTfiltre.TabIndex = 4;
            BTfiltre.Text = "FILTER";
            BTfiltre.TextAlign = ContentAlignment.TopCenter;
            BTfiltre.UseVisualStyleBackColor = true;
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
            TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVmat).EndInit();
            FLPcontainerCRUD.ResumeLayout(false);
            tlPInput.ResumeLayout(false);
            tlPInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDmatNumber).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label LBmatNumber;
        private Label LBmatName;
        private Label LBgserviceDat;
        private Label LBendGarantee;
        private TextBox TXTname;
        private TextBox TXTowner;
        private DateTimePicker DTPservDat;
        private DateTimePicker DTPendGarantee;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTfiltre;
        private NumericUpDown NUDmatNumber;
        private Label LBownerName;
    }
}