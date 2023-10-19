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
            FLPcontainerCRUD = new FlowLayoutPanel();
            BTcreate = new Button();
            BTread = new Button();
            BTupdate = new Button();
            BTdellete = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            CBXtype = new CheckBox();
            CBXnum = new CheckBox();
            CBXdtServ = new CheckBox();
            CBXloc = new CheckBox();
            BTfilter = new Button();
            label1 = new Label();
            bindingSourceMateriel = new BindingSource(components);
            TLPmat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVmat).BeginInit();
            FLPcontainerCRUD.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMateriel).BeginInit();
            SuspendLayout();
            // 
            // TLPmat
            // 
            TLPmat.ColumnCount = 1;
            TLPmat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.759037F));
            TLPmat.Controls.Add(DGVmat, 0, 0);
            TLPmat.Controls.Add(FLPcontainerCRUD, 0, 1);
            TLPmat.Controls.Add(tableLayoutPanel1, 0, 2);
            TLPmat.Dock = DockStyle.Fill;
            TLPmat.Location = new Point(0, 0);
            TLPmat.Name = "TLPmat";
            TLPmat.RowCount = 3;
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8795185F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 19.8795185F));
            TLPmat.RowStyles.Add(new RowStyle(SizeType.Percent, 60.240963F));
            TLPmat.Size = new Size(800, 450);
            TLPmat.TabIndex = 0;
            // 
            // DGVmat
            // 
            DGVmat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmat.Dock = DockStyle.Fill;
            DGVmat.Location = new Point(3, 3);
            DGVmat.Name = "DGVmat";
            DGVmat.RowHeadersWidth = 72;
            DGVmat.RowTemplate.Height = 37;
            DGVmat.Size = new Size(794, 83);
            DGVmat.TabIndex = 0;
            // 
            // FLPcontainerCRUD
            // 
            FLPcontainerCRUD.Controls.Add(BTcreate);
            FLPcontainerCRUD.Controls.Add(BTread);
            FLPcontainerCRUD.Controls.Add(BTupdate);
            FLPcontainerCRUD.Controls.Add(BTdellete);
            FLPcontainerCRUD.Location = new Point(3, 92);
            FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            FLPcontainerCRUD.Size = new Size(767, 83);
            FLPcontainerCRUD.TabIndex = 1;
            // 
            // BTcreate
            // 
            BTcreate.Location = new Point(3, 3);
            BTcreate.Name = "BTcreate";
            BTcreate.Size = new Size(131, 40);
            BTcreate.TabIndex = 0;
            BTcreate.Text = "CREATE";
            BTcreate.UseVisualStyleBackColor = true;
            // 
            // BTread
            // 
            BTread.Location = new Point(140, 3);
            BTread.Name = "BTread";
            BTread.Size = new Size(131, 40);
            BTread.TabIndex = 1;
            BTread.Text = "READ";
            BTread.UseVisualStyleBackColor = true;
            // 
            // BTupdate
            // 
            BTupdate.Location = new Point(277, 3);
            BTupdate.Name = "BTupdate";
            BTupdate.Size = new Size(131, 40);
            BTupdate.TabIndex = 2;
            BTupdate.Text = "UPDATE";
            BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTdellete
            // 
            BTdellete.Location = new Point(414, 3);
            BTdellete.Name = "BTdellete";
            BTdellete.Size = new Size(131, 40);
            BTdellete.TabIndex = 3;
            BTdellete.Text = "DELETE";
            BTdellete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(CBXtype, 0, 1);
            tableLayoutPanel1.Controls.Add(CBXnum, 0, 2);
            tableLayoutPanel1.Controls.Add(CBXdtServ, 0, 3);
            tableLayoutPanel1.Controls.Add(CBXloc, 0, 4);
            tableLayoutPanel1.Controls.Add(BTfilter, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 181);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1333332F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1333332F));
            tableLayoutPanel1.Size = new Size(354, 257);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // CBXtype
            // 
            CBXtype.AutoSize = true;
            CBXtype.Location = new Point(130, 47);
            CBXtype.Margin = new Padding(130, 3, 3, 3);
            CBXtype.Name = "CBXtype";
            CBXtype.Size = new Size(79, 34);
            CBXtype.TabIndex = 1;
            CBXtype.Text = "type";
            CBXtype.UseVisualStyleBackColor = true;
            // 
            // CBXnum
            // 
            CBXnum.AutoSize = true;
            CBXnum.Location = new Point(130, 91);
            CBXnum.Margin = new Padding(130, 3, 3, 3);
            CBXnum.Name = "CBXnum";
            CBXnum.Size = new Size(189, 34);
            CBXnum.TabIndex = 2;
            CBXnum.Text = "numéro de série";
            CBXnum.UseVisualStyleBackColor = true;
            CBXnum.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // CBXdtServ
            // 
            CBXdtServ.AutoSize = true;
            CBXdtServ.Location = new Point(130, 135);
            CBXdtServ.Margin = new Padding(130, 3, 3, 3);
            CBXdtServ.Name = "CBXdtServ";
            CBXdtServ.Size = new Size(221, 34);
            CBXdtServ.TabIndex = 3;
            CBXdtServ.Text = "date de mise en service";
            CBXdtServ.UseVisualStyleBackColor = true;
            // 
            // CBXloc
            // 
            CBXloc.AutoSize = true;
            CBXloc.Location = new Point(130, 179);
            CBXloc.Margin = new Padding(130, 3, 3, 3);
            CBXloc.Name = "CBXloc";
            CBXloc.Size = new Size(148, 30);
            CBXloc.TabIndex = 4;
            CBXloc.Text = "Localisation";
            CBXloc.UseVisualStyleBackColor = true;
            // 
            // BTfilter
            // 
            BTfilter.Location = new Point(100, 215);
            BTfilter.Margin = new Padding(100, 3, 3, 3);
            BTfilter.Name = "BTfilter";
            BTfilter.Size = new Size(131, 39);
            BTfilter.TabIndex = 0;
            BTfilter.Text = "TRIER";
            BTfilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 30);
            label1.TabIndex = 5;
            label1.Text = "Trier par";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TLPmat);
            Name = "Form2";
            Text = "Materiel";
            TLPmat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVmat).EndInit();
            FLPcontainerCRUD.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button BTfilter;
        private CheckBox CBXtype;
        private CheckBox CBXnum;
        private CheckBox CBXdtServ;
        private CheckBox CBXloc;
        private Label label1;
        private BindingSource bindingSourceMateriel;
    }
}