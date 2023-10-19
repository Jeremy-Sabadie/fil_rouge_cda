namespace AMIO_jalon2
{
    partial class GestionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLPBt = new System.Windows.Forms.FlowLayoutPanel();
            this.BtCreate = new System.Windows.Forms.Button();
            this.BtRead = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BSmatériel = new System.Windows.Forms.BindingSource(this.components);
            this.TLPchoiceFilter = new System.Windows.Forms.TableLayoutPanel();
            this.CBXtype = new System.Windows.Forms.CheckBox();
            this.CBXserialNumber = new System.Windows.Forms.CheckBox();
            this.CBXacquisitionDate = new System.Windows.Forms.CheckBox();
            this.CBXlocation = new System.Windows.Forms.CheckBox();
            this.LBtype = new System.Windows.Forms.Label();
            this.LBNumber = new System.Windows.Forms.Label();
            this.LBAcquisitionDate = new System.Windows.Forms.Label();
            this.LBlocation = new System.Windows.Forms.Label();
            this.tLPMain.SuspendLayout();
            this.flowLPBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSmatériel)).BeginInit();
            this.TLPchoiceFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.Controls.Add(this.flowLPBt, 0, 2);
            this.tLPMain.Controls.Add(this.dataGridView1, 0, 0);
            this.tLPMain.Controls.Add(this.TLPchoiceFilter, 0, 3);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 4;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tLPMain.Size = new System.Drawing.Size(800, 450);
            this.tLPMain.TabIndex = 0;
            // 
            // flowLPBt
            // 
            this.flowLPBt.Controls.Add(this.BtCreate);
            this.flowLPBt.Controls.Add(this.BtRead);
            this.flowLPBt.Controls.Add(this.BtUpdate);
            this.flowLPBt.Controls.Add(this.BtDelete);
            this.flowLPBt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLPBt.Location = new System.Drawing.Point(3, 233);
            this.flowLPBt.Name = "flowLPBt";
            this.flowLPBt.Size = new System.Drawing.Size(794, 98);
            this.flowLPBt.TabIndex = 0;
            // 
            // BtCreate
            // 
            this.BtCreate.Location = new System.Drawing.Point(153, 23);
            this.BtCreate.Margin = new System.Windows.Forms.Padding(153, 23, 3, 3);
            this.BtCreate.Name = "BtCreate";
            this.BtCreate.Size = new System.Drawing.Size(95, 43);
            this.BtCreate.TabIndex = 0;
            this.BtCreate.Text = "CREATE";
            this.BtCreate.UseVisualStyleBackColor = true;
            this.BtCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtRead
            // 
            this.BtRead.Location = new System.Drawing.Point(284, 23);
            this.BtRead.Margin = new System.Windows.Forms.Padding(33, 23, 3, 3);
            this.BtRead.Name = "BtRead";
            this.BtRead.Size = new System.Drawing.Size(95, 43);
            this.BtRead.TabIndex = 1;
            this.BtRead.Text = "READ";
            this.BtRead.UseVisualStyleBackColor = true;
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(415, 23);
            this.BtUpdate.Margin = new System.Windows.Forms.Padding(33, 23, 3, 3);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(95, 43);
            this.BtUpdate.TabIndex = 2;
            this.BtUpdate.Text = "UPDATE";
            this.BtUpdate.UseVisualStyleBackColor = true;
            // 
            // BtDelete
            // 
            this.BtDelete.Location = new System.Drawing.Point(546, 23);
            this.BtDelete.Margin = new System.Windows.Forms.Padding(33, 23, 3, 3);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(95, 43);
            this.BtDelete.TabIndex = 3;
            this.BtDelete.Text = "DELETE";
            this.BtDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(794, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // TLPchoiceFilter
            // 
            this.TLPchoiceFilter.ColumnCount = 2;
            this.TLPchoiceFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.54386F));
            this.TLPchoiceFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.45614F));
            this.TLPchoiceFilter.Controls.Add(this.CBXtype, 1, 0);
            this.TLPchoiceFilter.Controls.Add(this.CBXserialNumber, 1, 1);
            this.TLPchoiceFilter.Controls.Add(this.CBXacquisitionDate, 1, 2);
            this.TLPchoiceFilter.Controls.Add(this.CBXlocation, 1, 3);
            this.TLPchoiceFilter.Controls.Add(this.LBtype, 0, 0);
            this.TLPchoiceFilter.Controls.Add(this.LBNumber, 0, 1);
            this.TLPchoiceFilter.Controls.Add(this.LBAcquisitionDate, 0, 2);
            this.TLPchoiceFilter.Controls.Add(this.LBlocation, 0, 3);
            this.TLPchoiceFilter.Location = new System.Drawing.Point(3, 337);
            this.TLPchoiceFilter.Name = "TLPchoiceFilter";
            this.TLPchoiceFilter.RowCount = 4;
            this.TLPchoiceFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPchoiceFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPchoiceFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPchoiceFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPchoiceFilter.Size = new System.Drawing.Size(285, 110);
            this.TLPchoiceFilter.TabIndex = 2;
            // 
            // CBXtype
            // 
            this.CBXtype.AutoSize = true;
            this.CBXtype.Location = new System.Drawing.Point(110, 3);
            this.CBXtype.Name = "CBXtype";
            this.CBXtype.Size = new System.Drawing.Size(50, 19);
            this.CBXtype.TabIndex = 0;
            this.CBXtype.Text = "Type";
            this.CBXtype.UseVisualStyleBackColor = true;
            // 
            // CBXserialNumber
            // 
            this.CBXserialNumber.AutoSize = true;
            this.CBXserialNumber.Location = new System.Drawing.Point(110, 38);
            this.CBXserialNumber.Name = "CBXserialNumber";
            this.CBXserialNumber.Size = new System.Drawing.Size(98, 19);
            this.CBXserialNumber.TabIndex = 1;
            this.CBXserialNumber.Text = "serial number";
            this.CBXserialNumber.UseVisualStyleBackColor = true;
            // 
            // CBXacquisitionDate
            // 
            this.CBXacquisitionDate.AutoSize = true;
            this.CBXacquisitionDate.Location = new System.Drawing.Point(110, 73);
            this.CBXacquisitionDate.Name = "CBXacquisitionDate";
            this.CBXacquisitionDate.Size = new System.Drawing.Size(120, 14);
            this.CBXacquisitionDate.TabIndex = 2;
            this.CBXacquisitionDate.Text = "date d\'acquisition";
            this.CBXacquisitionDate.UseVisualStyleBackColor = true;
            // 
            // CBXlocation
            // 
            this.CBXlocation.AutoSize = true;
            this.CBXlocation.Location = new System.Drawing.Point(110, 93);
            this.CBXlocation.Name = "CBXlocation";
            this.CBXlocation.Size = new System.Drawing.Size(72, 14);
            this.CBXlocation.TabIndex = 3;
            this.CBXlocation.Text = "Location";
            this.CBXlocation.UseVisualStyleBackColor = true;
            // 
            // LBtype
            // 
            this.LBtype.AutoSize = true;
            this.LBtype.Location = new System.Drawing.Point(3, 0);
            this.LBtype.Name = "LBtype";
            this.LBtype.Size = new System.Drawing.Size(31, 15);
            this.LBtype.TabIndex = 4;
            this.LBtype.Text = "Type";
            // 
            // LBNumber
            // 
            this.LBNumber.AutoSize = true;
            this.LBNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBNumber.Location = new System.Drawing.Point(3, 35);
            this.LBNumber.Name = "LBNumber";
            this.LBNumber.Size = new System.Drawing.Size(80, 15);
            this.LBNumber.TabIndex = 5;
            this.LBNumber.Text = "Serial number";
            // 
            // LBAcquisitionDate
            // 
            this.LBAcquisitionDate.AutoSize = true;
            this.LBAcquisitionDate.Location = new System.Drawing.Point(3, 70);
            this.LBAcquisitionDate.Name = "LBAcquisitionDate";
            this.LBAcquisitionDate.Size = new System.Drawing.Size(101, 15);
            this.LBAcquisitionDate.TabIndex = 6;
            this.LBAcquisitionDate.Text = "date d\'acquisition";
            // 
            // LBlocation
            // 
            this.LBlocation.AutoSize = true;
            this.LBlocation.Location = new System.Drawing.Point(3, 90);
            this.LBlocation.Name = "LBlocation";
            this.LBlocation.Size = new System.Drawing.Size(53, 15);
            this.LBlocation.TabIndex = 7;
            this.LBlocation.Text = "Location";
            // 
            // GestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tLPMain);
            this.Name = "GestionForm";
            this.Text = "Form1";
            this.tLPMain.ResumeLayout(false);
            this.flowLPBt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSmatériel)).EndInit();
            this.TLPchoiceFilter.ResumeLayout(false);
            this.TLPchoiceFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tLPMain;
        private FlowLayoutPanel flowLPBt;
        private Button BtCreate;
        private Button BtRead;
        private Button BtUpdate;
        private Button BtDelete;
        private DataGridView dataGridView1;
        private BindingSource BSmatériel;
        private TableLayoutPanel TLPchoiceFilter;
        private CheckBox CBXtype;
        private CheckBox CBXserialNumber;
        private CheckBox CBXacquisitionDate;
        private CheckBox CBXlocation;
        private Label LBtype;
        private Label LBNumber;
        private Label LBAcquisitionDate;
        private Label LBlocation;
    }
}