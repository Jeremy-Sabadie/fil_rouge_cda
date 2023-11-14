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
            this.FLPcontainerCRUD = new System.Windows.Forms.FlowLayoutPanel();
            this.BTcreate = new System.Windows.Forms.Button();
            this.BTread = new System.Windows.Forms.Button();
            this.BTupdate = new System.Windows.Forms.Button();
            this.BTdellete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBXid = new System.Windows.Forms.CheckBox();
            this.CBXname = new System.Windows.Forms.CheckBox();
            this.CBXdtServiceDat = new System.Windows.Forms.CheckBox();
            this.CBXendGarantee = new System.Windows.Forms.CheckBox();
            this.BTsort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceMateriel = new System.Windows.Forms.BindingSource(this.components);
            this.TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmat)).BeginInit();
            this.FLPcontainerCRUD.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriel)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPmat
            // 
            this.TLPmat.ColumnCount = 1;
            this.TLPmat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.75904F));
            this.TLPmat.Controls.Add(this.DGVmat, 0, 0);
            this.TLPmat.Controls.Add(this.FLPcontainerCRUD, 0, 1);
            this.TLPmat.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.TLPmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPmat.Location = new System.Drawing.Point(0, 0);
            this.TLPmat.Margin = new System.Windows.Forms.Padding(2);
            this.TLPmat.Name = "TLPmat";
            this.TLPmat.RowCount = 3;
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87952F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.87952F));
            this.TLPmat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.24096F));
            this.TLPmat.Size = new System.Drawing.Size(830, 464);
            this.TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            this.DGVmat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVmat.Location = new System.Drawing.Point(2, 2);
            this.DGVmat.Margin = new System.Windows.Forms.Padding(2);
            this.DGVmat.Name = "DGVmat";
            this.DGVmat.RowHeadersWidth = 72;
            this.DGVmat.RowTemplate.Height = 37;
            this.DGVmat.Size = new System.Drawing.Size(826, 88);
            this.DGVmat.TabIndex = 0;
            // 
            // FLPcontainerCRUD
            // 
            this.FLPcontainerCRUD.Controls.Add(this.BTcreate);
            this.FLPcontainerCRUD.Controls.Add(this.BTread);
            this.FLPcontainerCRUD.Controls.Add(this.BTupdate);
            this.FLPcontainerCRUD.Controls.Add(this.BTdellete);
            this.FLPcontainerCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPcontainerCRUD.Location = new System.Drawing.Point(2, 94);
            this.FLPcontainerCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            this.FLPcontainerCRUD.Size = new System.Drawing.Size(826, 88);
            this.FLPcontainerCRUD.TabIndex = 1;
            // 
            // BTcreate
            // 
            this.BTcreate.Location = new System.Drawing.Point(2, 2);
            this.BTcreate.Margin = new System.Windows.Forms.Padding(2);
            this.BTcreate.Name = "BTcreate";
            this.BTcreate.Size = new System.Drawing.Size(76, 20);
            this.BTcreate.TabIndex = 0;
            this.BTcreate.Text = "CREATE";
            this.BTcreate.UseVisualStyleBackColor = true;
            // 
            // BTread
            // 
            this.BTread.Location = new System.Drawing.Point(82, 2);
            this.BTread.Margin = new System.Windows.Forms.Padding(2);
            this.BTread.Name = "BTread";
            this.BTread.Size = new System.Drawing.Size(76, 20);
            this.BTread.TabIndex = 1;
            this.BTread.Text = "READ";
            this.BTread.UseVisualStyleBackColor = true;
            // 
            // BTupdate
            // 
            this.BTupdate.Location = new System.Drawing.Point(162, 2);
            this.BTupdate.Margin = new System.Windows.Forms.Padding(2);
            this.BTupdate.Name = "BTupdate";
            this.BTupdate.Size = new System.Drawing.Size(76, 20);
            this.BTupdate.TabIndex = 2;
            this.BTupdate.Text = "UPDATE";
            this.BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTdellete
            // 
            this.BTdellete.Location = new System.Drawing.Point(242, 2);
            this.BTdellete.Margin = new System.Windows.Forms.Padding(2);
            this.BTdellete.Name = "BTdellete";
            this.BTdellete.Size = new System.Drawing.Size(76, 20);
            this.BTdellete.TabIndex = 3;
            this.BTdellete.Text = "DELETE";
            this.BTdellete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.CBXid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CBXname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBXdtServiceDat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBXendGarantee, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BTsort, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 186);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 201);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CBXid
            // 
            this.CBXid.AutoSize = true;
            this.CBXid.Location = new System.Drawing.Point(76, 36);
            this.CBXid.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXid.Name = "CBXid";
            this.CBXid.Size = new System.Drawing.Size(36, 19);
            this.CBXid.TabIndex = 1;
            this.CBXid.Text = "id";
            this.CBXid.UseVisualStyleBackColor = true;
            // 
            // CBXname
            // 
            this.CBXname.AutoSize = true;
            this.CBXname.Location = new System.Drawing.Point(76, 70);
            this.CBXname.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXname.Name = "CBXname";
            this.CBXname.Size = new System.Drawing.Size(51, 19);
            this.CBXname.TabIndex = 2;
            this.CBXname.Text = "nom";
            this.CBXname.UseVisualStyleBackColor = true;
            this.CBXname.CheckedChanged += new System.EventHandler(this.CBXnum_CheckedChanged);
            // 
            // CBXdtServiceDat
            // 
            this.CBXdtServiceDat.AutoSize = true;
            this.CBXdtServiceDat.Location = new System.Drawing.Point(76, 104);
            this.CBXdtServiceDat.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXdtServiceDat.Name = "CBXdtServiceDat";
            this.CBXdtServiceDat.Size = new System.Drawing.Size(148, 19);
            this.CBXdtServiceDat.TabIndex = 3;
            this.CBXdtServiceDat.Text = "date de mise en service";
            this.CBXdtServiceDat.UseVisualStyleBackColor = true;
            // 
            // CBXendGarantee
            // 
            this.CBXendGarantee.AutoSize = true;
            this.CBXendGarantee.Location = new System.Drawing.Point(76, 138);
            this.CBXendGarantee.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXendGarantee.Name = "CBXendGarantee";
            this.CBXendGarantee.Size = new System.Drawing.Size(138, 19);
            this.CBXendGarantee.TabIndex = 4;
            this.CBXendGarantee.Text = "date de fin de garanti";
            this.CBXendGarantee.UseVisualStyleBackColor = true;
            // 
            // BTsort
            // 
            this.BTsort.Location = new System.Drawing.Point(58, 166);
            this.BTsort.Margin = new System.Windows.Forms.Padding(58, 2, 2, 2);
            this.BTsort.Name = "BTsort";
            this.BTsort.Size = new System.Drawing.Size(76, 20);
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
            this.label1.Size = new System.Drawing.Size(289, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trier par";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 464);
            this.Controls.Add(this.TLPmat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Materiel";
            this.TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmat)).EndInit();
            this.FLPcontainerCRUD.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTsort;
        private CheckBox CBXid;
        private CheckBox CBXname;
        private CheckBox CBXdtServiceDat;
        private CheckBox CBXendGarantee;
        private Label label1;
        private BindingSource bindingSourceMateriel;
    }
}