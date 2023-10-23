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
            this.CBXtype = new System.Windows.Forms.CheckBox();
            this.CBXnum = new System.Windows.Forms.CheckBox();
            this.CBXdtServ = new System.Windows.Forms.CheckBox();
            this.CBXloc = new System.Windows.Forms.CheckBox();
            this.BTfilter = new System.Windows.Forms.Button();
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
            this.TLPmat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.DGVmat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.FLPcontainerCRUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FLPcontainerCRUD.Name = "FLPcontainerCRUD";
            this.FLPcontainerCRUD.Size = new System.Drawing.Size(826, 88);
            this.FLPcontainerCRUD.TabIndex = 1;
            // 
            // BTcreate
            // 
            this.BTcreate.Location = new System.Drawing.Point(2, 2);
            this.BTcreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTcreate.Name = "BTcreate";
            this.BTcreate.Size = new System.Drawing.Size(76, 20);
            this.BTcreate.TabIndex = 0;
            this.BTcreate.Text = "CREATE";
            this.BTcreate.UseVisualStyleBackColor = true;
            // 
            // BTread
            // 
            this.BTread.Location = new System.Drawing.Point(82, 2);
            this.BTread.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTread.Name = "BTread";
            this.BTread.Size = new System.Drawing.Size(76, 20);
            this.BTread.TabIndex = 1;
            this.BTread.Text = "READ";
            this.BTread.UseVisualStyleBackColor = true;
            // 
            // BTupdate
            // 
            this.BTupdate.Location = new System.Drawing.Point(162, 2);
            this.BTupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTupdate.Name = "BTupdate";
            this.BTupdate.Size = new System.Drawing.Size(76, 20);
            this.BTupdate.TabIndex = 2;
            this.BTupdate.Text = "UPDATE";
            this.BTupdate.UseVisualStyleBackColor = true;
            // 
            // BTdellete
            // 
            this.BTdellete.Location = new System.Drawing.Point(242, 2);
            this.BTdellete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tableLayoutPanel1.Controls.Add(this.CBXtype, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CBXnum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBXdtServ, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBXloc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BTfilter, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 186);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.13333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CBXtype
            // 
            this.CBXtype.AutoSize = true;
            this.CBXtype.Location = new System.Drawing.Point(76, 23);
            this.CBXtype.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXtype.Name = "CBXtype";
            this.CBXtype.Size = new System.Drawing.Size(49, 17);
            this.CBXtype.TabIndex = 1;
            this.CBXtype.Text = "type";
            this.CBXtype.UseVisualStyleBackColor = true;
            // 
            // CBXnum
            // 
            this.CBXnum.AutoSize = true;
            this.CBXnum.Location = new System.Drawing.Point(76, 44);
            this.CBXnum.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXnum.Name = "CBXnum";
            this.CBXnum.Size = new System.Drawing.Size(111, 17);
            this.CBXnum.TabIndex = 2;
            this.CBXnum.Text = "numéro de série";
            this.CBXnum.UseVisualStyleBackColor = true;
            // 
            // CBXdtServ
            // 
            this.CBXdtServ.AutoSize = true;
            this.CBXdtServ.Location = new System.Drawing.Point(76, 65);
            this.CBXdtServ.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXdtServ.Name = "CBXdtServ";
            this.CBXdtServ.Size = new System.Drawing.Size(128, 17);
            this.CBXdtServ.TabIndex = 3;
            this.CBXdtServ.Text = "date de mise en service";
            this.CBXdtServ.UseVisualStyleBackColor = true;
            // 
            // CBXloc
            // 
            this.CBXloc.AutoSize = true;
            this.CBXloc.Location = new System.Drawing.Point(76, 86);
            this.CBXloc.Margin = new System.Windows.Forms.Padding(76, 2, 2, 2);
            this.CBXloc.Name = "CBXloc";
            this.CBXloc.Size = new System.Drawing.Size(89, 14);
            this.CBXloc.TabIndex = 4;
            this.CBXloc.Text = "Localisation";
            this.CBXloc.UseVisualStyleBackColor = true;
            // 
            // BTfilter
            // 
            this.BTfilter.Location = new System.Drawing.Point(58, 104);
            this.BTfilter.Margin = new System.Windows.Forms.Padding(58, 2, 2, 2);
            this.BTfilter.Name = "BTfilter";
            this.BTfilter.Size = new System.Drawing.Size(76, 20);
            this.BTfilter.TabIndex = 0;
            this.BTfilter.Text = "TRIER";
            this.BTfilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Button BTfilter;
        private CheckBox CBXtype;
        private CheckBox CBXnum;
        private CheckBox CBXdtServ;
        private CheckBox CBXloc;
        private Label label1;
        private BindingSource bindingSourceMateriel;
    }
}