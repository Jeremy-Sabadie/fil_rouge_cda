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
            this.TLPmat = new System.Windows.Forms.TableLayoutPanel();
            this.DGVmat = new System.Windows.Forms.DataGridView();
            this.TLPsort = new System.Windows.Forms.TableLayoutPanel();
            this.CBXid = new System.Windows.Forms.CheckBox();
            this.CBXname = new System.Windows.Forms.CheckBox();
            this.CBXdtServiceDat = new System.Windows.Forms.CheckBox();
            this.CBXendGarantee = new System.Windows.Forms.CheckBox();
            this.BTsort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.bindingSourceMateriel = new System.Windows.Forms.BindingSource(this.components);
            this.TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmat)).BeginInit();
            this.TLPsort.SuspendLayout();
            this.FLPcontainerCRUD.SuspendLayout();
            this.tlPInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriel)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPmat
            // 
            this.TLPmat.ColumnCount = 1;
            this.TLPmat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.75904F));
            this.TLPmat.Controls.Add(this.DGVmat, 0, 0);
            this.TLPmat.Controls.Add(this.TLPsort, 0, 3);
            this.TLPmat.Controls.Add(this.FLPcontainerCRUD, 0, 1);
            this.TLPmat.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.TLPmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPmat.Location = new System.Drawing.Point(0, 0);
            this.TLPmat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TLPmat.Name = "TLPmat";
            this.TLPmat.RowCount = 4;
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87952F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.86014F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.27972F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.TLPmat.Size = new System.Drawing.Size(732, 464);
            this.TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            this.DGVmat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVmat.Location = new System.Drawing.Point(2, 2);
            this.DGVmat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVmat.Name = "DGVmat";
            this.DGVmat.RowHeadersWidth = 72;
            this.DGVmat.RowTemplate.Height = 37;
            this.DGVmat.Size = new System.Drawing.Size(728, 67);
            this.DGVmat.TabIndex = 0;
            // 
            // TLPsort
            // 
            this.TLPsort.ColumnCount = 1;
            this.TLPsort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPsort.Controls.Add(this.CBXid, 0, 1);
            this.TLPsort.Controls.Add(this.CBXname, 0, 2);
            this.TLPsort.Controls.Add(this.CBXdtServiceDat, 0, 3);
            this.TLPsort.Controls.Add(this.CBXendGarantee, 0, 4);
            this.TLPsort.Controls.Add(this.BTsort, 0, 5);
            this.TLPsort.Controls.Add(this.label1, 0, 0);
            this.TLPsort.Location = new System.Drawing.Point(2, 359);
            this.TLPsort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TLPsort.Name = "TLPsort";
            this.TLPsort.RowCount = 6;
            this.TLPsort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.TLPsort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.TLPsort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.TLPsort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.TLPsort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33333F));
            this.TLPsort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.TLPsort.Size = new System.Drawing.Size(465, 102);
            this.TLPsort.TabIndex = 2;
            // 
            // CBXid
            // 
            this.CBXid.AutoSize = true;
            this.CBXid.Location = new System.Drawing.Point(117, 19);
            this.CBXid.Margin = new System.Windows.Forms.Padding(117, 2, 2, 2);
            this.CBXid.Name = "CBXid";
            this.CBXid.Size = new System.Drawing.Size(36, 13);
            this.CBXid.TabIndex = 1;
            this.CBXid.Text = "id";
            this.CBXid.UseVisualStyleBackColor = true;
            // 
            // CBXname
            // 
            this.CBXname.AutoSize = true;
            this.CBXname.Location = new System.Drawing.Point(117, 36);
            this.CBXname.Margin = new System.Windows.Forms.Padding(117, 2, 2, 2);
            this.CBXname.Name = "CBXname";
            this.CBXname.Size = new System.Drawing.Size(51, 13);
            this.CBXname.TabIndex = 2;
            this.CBXname.Text = "nom";
            this.CBXname.UseVisualStyleBackColor = true;
            // 
            // CBXdtServiceDat
            // 
            this.CBXdtServiceDat.AutoSize = true;
            this.CBXdtServiceDat.Location = new System.Drawing.Point(117, 53);
            this.CBXdtServiceDat.Margin = new System.Windows.Forms.Padding(117, 2, 2, 2);
            this.CBXdtServiceDat.Name = "CBXdtServiceDat";
            this.CBXdtServiceDat.Size = new System.Drawing.Size(148, 13);
            this.CBXdtServiceDat.TabIndex = 3;
            this.CBXdtServiceDat.Text = "date de mise en service";
            this.CBXdtServiceDat.UseVisualStyleBackColor = true;
            // 
            // CBXendGarantee
            // 
            this.CBXendGarantee.AutoSize = true;
            this.CBXendGarantee.Location = new System.Drawing.Point(117, 70);
            this.CBXendGarantee.Margin = new System.Windows.Forms.Padding(117, 2, 2, 2);
            this.CBXendGarantee.Name = "CBXendGarantee";
            this.CBXendGarantee.Size = new System.Drawing.Size(138, 10);
            this.CBXendGarantee.TabIndex = 4;
            this.CBXendGarantee.Text = "date de fin de garanti";
            this.CBXendGarantee.UseVisualStyleBackColor = true;
            // 
            // BTsort
            // 
            this.BTsort.Location = new System.Drawing.Point(58, 84);
            this.BTsort.Margin = new System.Windows.Forms.Padding(58, 2, 2, 2);
            this.BTsort.Name = "BTsort";
            this.BTsort.Size = new System.Drawing.Size(76, 14);
            this.BTsort.TabIndex = 0;
            this.BTsort.Text = "TRIER";
            this.BTsort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trier par";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FLPcontainerCRUD
            // 
            this.FLPcontainerCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPcontainerCRUD.Controls.Add(this.tlPInput);
            this.FLPcontainerCRUD.Location = new System.Drawing.Point(2, 87);
            this.FLPcontainerCRUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            this.FLPcontainerCRUD.Size = new System.Drawing.Size(728, 110);
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
            this.tlPInput.Location = new System.Drawing.Point(2, 2);
            this.tlPInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlPInput.Name = "tlPInput";
            this.tlPInput.RowCount = 4;
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlPInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlPInput.Size = new System.Drawing.Size(394, 109);
            this.tlPInput.TabIndex = 4;
            // 
            // LBname
            // 
            this.LBname.AutoSize = true;
            this.LBname.Location = new System.Drawing.Point(2, 0);
            this.LBname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBname.Name = "LBname";
            this.LBname.Size = new System.Drawing.Size(95, 15);
            this.LBname.TabIndex = 0;
            this.LBname.Text = "nom du matériel";
            // 
            // LBservDat
            // 
            this.LBservDat.AutoSize = true;
            this.LBservDat.Location = new System.Drawing.Point(2, 30);
            this.LBservDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBservDat.Name = "LBservDat";
            this.LBservDat.Size = new System.Drawing.Size(129, 15);
            this.LBservDat.TabIndex = 1;
            this.LBservDat.Text = "date de mise en service";
            // 
            // LBgarantee
            // 
            this.LBgarantee.AutoSize = true;
            this.LBgarantee.Location = new System.Drawing.Point(2, 60);
            this.LBgarantee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBgarantee.Name = "LBgarantee";
            this.LBgarantee.Size = new System.Drawing.Size(125, 15);
            this.LBgarantee.TabIndex = 2;
            this.LBgarantee.Text = "date de fin de garentie";
            // 
            // LBowner
            // 
            this.LBowner.AutoSize = true;
            this.LBowner.Location = new System.Drawing.Point(2, 88);
            this.LBowner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBowner.Name = "LBowner";
            this.LBowner.Size = new System.Drawing.Size(126, 21);
            this.LBowner.TabIndex = 3;
            this.LBowner.Text = "nom du proriétaire du matériel";
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(151, 2);
            this.TXTname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(104, 23);
            this.TXTname.TabIndex = 4;
            // 
            // TXTowner
            // 
            this.TXTowner.AcceptsReturn = true;
            this.TXTowner.Location = new System.Drawing.Point(151, 90);
            this.TXTowner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTowner.Name = "TXTowner";
            this.TXTowner.Size = new System.Drawing.Size(104, 23);
            this.TXTowner.TabIndex = 5;
            // 
            // DTPservDat
            // 
            this.DTPservDat.Location = new System.Drawing.Point(151, 32);
            this.DTPservDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPservDat.Name = "DTPservDat";
            this.DTPservDat.Size = new System.Drawing.Size(206, 23);
            this.DTPservDat.TabIndex = 6;
            // 
            // DTPendGarantee
            // 
            this.DTPendGarantee.Location = new System.Drawing.Point(151, 62);
            this.DTPendGarantee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPendGarantee.Name = "DTPendGarantee";
            this.DTPendGarantee.Size = new System.Drawing.Size(206, 23);
            this.DTPendGarantee.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.562F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.91788F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.52013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Controls.Add(this.BTdellete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTupdate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTread, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTcreate, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 215);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 70);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BTdellete
            // 
            this.BTdellete.Location = new System.Drawing.Point(296, 10);
            this.BTdellete.Margin = new System.Windows.Forms.Padding(9, 10, 9, 0);
            this.BTdellete.Name = "BTdellete";
            this.BTdellete.Size = new System.Drawing.Size(76, 20);
            this.BTdellete.TabIndex = 3;
            this.BTdellete.Text = "DELETE";
            this.BTdellete.UseVisualStyleBackColor = true;
            // 
            // BTupdate
            // 
            this.BTupdate.Location = new System.Drawing.Point(197, 10);
            this.BTupdate.Margin = new System.Windows.Forms.Padding(18, 10, 9, 0);
            this.BTupdate.Name = "BTupdate";
            this.BTupdate.Size = new System.Drawing.Size(76, 20);
            this.BTupdate.TabIndex = 2;
            this.BTupdate.Text = "UPDATE";
            this.BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTread
            // 
            this.BTread.Location = new System.Drawing.Point(108, 10);
            this.BTread.Margin = new System.Windows.Forms.Padding(18, 10, 9, 0);
            this.BTread.Name = "BTread";
            this.BTread.Size = new System.Drawing.Size(62, 20);
            this.BTread.TabIndex = 1;
            this.BTread.Text = "READ";
            this.BTread.UseVisualStyleBackColor = true;
            // 
            // BTcreate
            // 
            this.BTcreate.Location = new System.Drawing.Point(18, 10);
            this.BTcreate.Margin = new System.Windows.Forms.Padding(18, 10, 9, 0);
            this.BTcreate.Name = "BTcreate";
            this.BTcreate.Size = new System.Drawing.Size(63, 20);
            this.BTcreate.TabIndex = 0;
            this.BTcreate.Text = "CREATE";
            this.BTcreate.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 464);
            this.Controls.Add(this.TLPmat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Materiel";
            this.TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmat)).EndInit();
            this.TLPsort.ResumeLayout(false);
            this.TLPsort.PerformLayout();
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