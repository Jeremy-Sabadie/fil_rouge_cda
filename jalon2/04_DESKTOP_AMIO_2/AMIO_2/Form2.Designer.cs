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
            TLPmat = new TableLayoutPanel();
            DGVmat = new DataGridView();
            TLPsort = new TableLayoutPanel();
            CBXid = new CheckBox();
            CBXname = new CheckBox();
            CBXdtServiceDat = new CheckBox();
            CBXendGarantee = new CheckBox();
            BTsort = new Button();
            label1 = new Label();
            FLPcontainerCRUD = new FlowLayoutPanel();
            BTcreate = new Button();
            BTread = new Button();
            BTupdate = new Button();
            BTdellete = new Button();
            bindingSourceMateriel = new BindingSource(components);
            tlPInput = new TableLayoutPanel();
            LBname = new Label();
            LBservDat = new Label();
            LBgarantee = new Label();
            LBowner = new Label();
            TXTname = new TextBox();
            TXTowner = new TextBox();
            DTPservDat = new DateTimePicker();
            DTPendGarantee = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmat).BeginInit();
            TLPsort.SuspendLayout();
            FLPcontainerCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMateriel).BeginInit();
            tlPInput.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TLPmat
            // 
            TLPmat.ColumnCount = 1;
            TLPmat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.75904F));
            TLPmat.Controls.Add(DGVmat, 0, 0);
            TLPmat.Controls.Add(TLPsort, 0, 3);
            TLPmat.Controls.Add(FLPcontainerCRUD, 0, 1);
            TLPmat.Controls.Add(tableLayoutPanel1, 0, 2);
            TLPmat.Dock = DockStyle.Fill;
            TLPmat.Location = new Point(0, 0);
            TLPmat.Margin = new Padding(3, 4, 3, 4);
            TLPmat.Name = "TLPmat";
            TLPmat.RowCount = 4;
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 19.87952F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 39.86014F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 40.27972F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Absolute, 211F));
            TLPmat.Size = new Size(1255, 928);
            TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            DGVmat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmat.Dock = DockStyle.Fill;
            DGVmat.Location = new Point(3, 4);
            DGVmat.Margin = new Padding(3, 4, 3, 4);
            DGVmat.Name = "DGVmat";
            DGVmat.RowHeadersWidth = 72;
            DGVmat.RowTemplate.Height = 37;
            DGVmat.Size = new Size(1249, 134);
            DGVmat.TabIndex = 0;
            // 
            // TLPsort
            // 
            TLPsort.ColumnCount = 1;
            TLPsort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPsort.Controls.Add(CBXid, 0, 1);
            TLPsort.Controls.Add(CBXname, 0, 2);
            TLPsort.Controls.Add(CBXdtServiceDat, 0, 3);
            TLPsort.Controls.Add(CBXendGarantee, 0, 4);
            TLPsort.Controls.Add(BTsort, 0, 5);
            TLPsort.Controls.Add(label1, 0, 0);
            TLPsort.Location = new Point(3, 719);
            TLPsort.Margin = new Padding(3, 4, 3, 4);
            TLPsort.Name = "TLPsort";
            TLPsort.RowCount = 6;
            TLPsort.RowStyles.Add(new RowStyle(SizeType.Percent, 17.13333F));
            TLPsort.RowStyles.Add(new RowStyle(SizeType.Percent, 17.13333F));
            TLPsort.RowStyles.Add(new RowStyle(SizeType.Percent, 17.13333F));
            TLPsort.RowStyles.Add(new RowStyle(SizeType.Percent, 17.13333F));
            TLPsort.RowStyles.Add(new RowStyle(SizeType.Percent, 14.33333F));
            TLPsort.RowStyles.Add(new RowStyle(SizeType.Percent, 17.13333F));
            TLPsort.Size = new Size(798, 205);
            TLPsort.TabIndex = 2;
            // 
            // CBXid
            // 
            CBXid.AutoSize = true;
            CBXid.Location = new Point(200, 39);
            CBXid.Margin = new Padding(200, 4, 3, 4);
            CBXid.Name = "CBXid";
            CBXid.Size = new Size(56, 27);
            CBXid.TabIndex = 1;
            CBXid.Text = "id";
            CBXid.UseVisualStyleBackColor = true;
            // 
            // CBXname
            // 
            CBXname.AutoSize = true;
            CBXname.Location = new Point(200, 74);
            CBXname.Margin = new Padding(200, 4, 3, 4);
            CBXname.Name = "CBXname";
            CBXname.Size = new Size(81, 27);
            CBXname.TabIndex = 2;
            CBXname.Text = "nom";
            CBXname.UseVisualStyleBackColor = true;
            CBXname.CheckedChanged += CBXnum_CheckedChanged;
            // 
            // CBXdtServiceDat
            // 
            CBXdtServiceDat.AutoSize = true;
            CBXdtServiceDat.Location = new Point(200, 109);
            CBXdtServiceDat.Margin = new Padding(200, 4, 3, 4);
            CBXdtServiceDat.Name = "CBXdtServiceDat";
            CBXdtServiceDat.Size = new Size(256, 27);
            CBXdtServiceDat.TabIndex = 3;
            CBXdtServiceDat.Text = "date de mise en service";
            CBXdtServiceDat.UseVisualStyleBackColor = true;
            // 
            // CBXendGarantee
            // 
            CBXendGarantee.AutoSize = true;
            CBXendGarantee.Location = new Point(200, 144);
            CBXendGarantee.Margin = new Padding(200, 4, 3, 4);
            CBXendGarantee.Name = "CBXendGarantee";
            CBXendGarantee.Size = new Size(239, 21);
            CBXendGarantee.TabIndex = 4;
            CBXendGarantee.Text = "date de fin de garanti";
            CBXendGarantee.UseVisualStyleBackColor = true;
            // 
            // BTsort
            // 
            BTsort.Location = new Point(99, 173);
            BTsort.Margin = new Padding(99, 4, 3, 4);
            BTsort.Name = "BTsort";
            BTsort.Size = new Size(130, 28);
            BTsort.TabIndex = 0;
            BTsort.Text = "TRIER";
            BTsort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(792, 30);
            label1.TabIndex = 5;
            label1.Text = "Trier par";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FLPcontainerCRUD
            // 
            FLPcontainerCRUD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FLPcontainerCRUD.Controls.Add(tlPInput);
            FLPcontainerCRUD.Location = new Point(3, 174);
            FLPcontainerCRUD.Margin = new Padding(3, 4, 3, 4);
            FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            FLPcontainerCRUD.Size = new Size(1249, 221);
            FLPcontainerCRUD.TabIndex = 1;
            FLPcontainerCRUD.Paint += FLPcontainerCRUD_Paint;
            // 
            // BTcreate
            // 
            BTcreate.Location = new Point(30, 20);
            BTcreate.Margin = new Padding(30, 20, 15, 0);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(110, 40);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "CREATE";
            BTcreate.UseVisualStyleBackColor = true;
            // 
            // BTread
            // 
            BTread.Location = new Point(185, 20);
            BTread.Margin = new Padding(30, 20, 15, 0);
            BTread.Name = "BTread";
            BTread.Size = new Size(107, 40);
            BTread.TabIndex = 1;
            BTread.Text = "READ";
            BTread.UseVisualStyleBackColor = true;
            // 
            // BTupdate
            // 
            BTupdate.Location = new Point(337, 20);
            BTupdate.Margin = new Padding(30, 20, 15, 0);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(130, 40);
            BTupdate.TabIndex = 2;
            BTupdate.Text = "UPDATE";
            BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTdellete
            // 
            BTdellete.Location = new Point(507, 20);
            BTdellete.Margin = new Padding(15, 20, 15, 0);
            BTdellete.Name = "BTdellete";
            BTdellete.Size = new Size(130, 40);
            BTdellete.TabIndex = 3;
            BTdellete.Text = "DELETE";
            BTdellete.UseVisualStyleBackColor = true;
            // 
            // tlPInput
            // 
            tlPInput.ColumnCount = 2;
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8625946F));
            tlPInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1374054F));
            tlPInput.Controls.Add(LBname, 0, 0);
            tlPInput.Controls.Add(LBservDat, 0, 1);
            tlPInput.Controls.Add(LBgarantee, 0, 2);
            tlPInput.Controls.Add(LBowner, 0, 3);
            tlPInput.Controls.Add(TXTname, 1, 0);
            tlPInput.Controls.Add(TXTowner, 1, 3);
            tlPInput.Controls.Add(DTPservDat, 1, 1);
            tlPInput.Controls.Add(DTPendGarantee, 1, 2);
            tlPInput.Location = new Point(3, 3);
            tlPInput.Name = "tlPInput";
            tlPInput.RowCount = 4;
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tlPInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlPInput.Size = new Size(676, 218);
            tlPInput.TabIndex = 4;
            // 
            // LBname
            // 
            LBname.AutoSize = true;
            LBname.Location = new Point(3, 0);
            LBname.Name = "LBname";
            LBname.Size = new Size(166, 30);
            LBname.TabIndex = 0;
            LBname.Text = "nom du matériel";
            // 
            // LBservDat
            // 
            LBservDat.AutoSize = true;
            LBservDat.Location = new Point(3, 60);
            LBservDat.Name = "LBservDat";
            LBservDat.Size = new Size(230, 30);
            LBservDat.TabIndex = 1;
            LBservDat.Text = "date de mise en service";
            LBservDat.Click += label3_Click;
            // 
            // LBgarantee
            // 
            LBgarantee.AutoSize = true;
            LBgarantee.Location = new Point(3, 120);
            LBgarantee.Name = "LBgarantee";
            LBgarantee.Size = new Size(224, 30);
            LBgarantee.TabIndex = 2;
            LBgarantee.Text = "date de fin de garentie";
            // 
            // LBowner
            // 
            LBowner.AutoSize = true;
            LBowner.Location = new Point(3, 175);
            LBowner.Name = "LBowner";
            LBowner.Size = new Size(222, 43);
            LBowner.TabIndex = 3;
            LBowner.Text = "nom du proriétaire du matériel";
            // 
            // TXTname
            // 
            TXTname.Location = new Point(258, 3);
            TXTname.Name = "TXTname";
            TXTname.Size = new Size(175, 35);
            TXTname.TabIndex = 4;
            // 
            // TXTowner
            // 
            TXTowner.AcceptsReturn = true;
            TXTowner.Location = new Point(258, 178);
            TXTowner.Name = "TXTowner";
            TXTowner.Size = new Size(175, 35);
            TXTowner.TabIndex = 5;
            // 
            // DTPservDat
            // 
            DTPservDat.Location = new Point(258, 63);
            DTPservDat.Name = "DTPservDat";
            DTPservDat.Size = new Size(350, 35);
            DTPservDat.TabIndex = 6;
            // 
            // DTPendGarantee
            // 
            DTPendGarantee.Location = new Point(258, 123);
            DTPendGarantee.Name = "DTPendGarantee";
            DTPendGarantee.Size = new Size(350, 35);
            DTPendGarantee.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.5619965F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.9178753F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.52013F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 272F));
            tableLayoutPanel1.Controls.Add(BTdellete, 3, 0);
            tableLayoutPanel1.Controls.Add(BTupdate, 2, 0);
            tableLayoutPanel1.Controls.Add(BTread, 1, 0);
            tableLayoutPanel1.Controls.Add(BTcreate, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 430);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(766, 140);
            tableLayoutPanel1.TabIndex = 3;
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
            TLPsort.ResumeLayout(false);
            TLPsort.PerformLayout();
            FLPcontainerCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMateriel).EndInit();
            tlPInput.ResumeLayout(false);
            tlPInput.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private TableLayoutPanel TLPsort;
        private Button BTsort;
        private CheckBox CBXid;
        private CheckBox CBXname;
        private CheckBox CBXdtServiceDat;
        private CheckBox CBXendGarantee;
        private Label label1;
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
    }
}