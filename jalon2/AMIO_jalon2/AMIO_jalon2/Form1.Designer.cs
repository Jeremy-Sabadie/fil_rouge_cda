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
            components = new System.ComponentModel.Container();
            tLPMain = new TableLayoutPanel();
            flowLPBt = new FlowLayoutPanel();
            BtCreate = new Button();
            BtRead = new Button();
            BtUpdate = new Button();
            BtDelete = new Button();
            dataGridView1 = new DataGridView();
            TLPchoiceFilter = new TableLayoutPanel();
            BSmatériel = new BindingSource(components);
            CBXlocation = new CheckBox();
            BTfilter = new Button();
            FLPbtFilter = new FlowLayoutPanel();
            CBXacquisitionDate = new CheckBox();
            CBXserialNumber = new CheckBox();
            CBXtype = new CheckBox();
            tLPMain.SuspendLayout();
            flowLPBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TLPchoiceFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSmatériel).BeginInit();
            FLPbtFilter.SuspendLayout();
            SuspendLayout();
            // 
            // tLPMain
            // 
            tLPMain.ColumnCount = 1;
            tLPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tLPMain.Controls.Add(dataGridView1, 0, 0);
            tLPMain.Controls.Add(TLPchoiceFilter, 0, 3);
            tLPMain.Controls.Add(flowLPBt, 0, 1);
            tLPMain.Dock = DockStyle.Fill;
            tLPMain.Location = new Point(0, 0);
            tLPMain.Margin = new Padding(5, 6, 5, 6);
            tLPMain.Name = "tLPMain";
            tLPMain.RowCount = 5;
            tLPMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            tLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 345F));
            tLPMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tLPMain.Size = new Size(1371, 900);
            tLPMain.TabIndex = 0;
            tLPMain.Paint += tLPMain_Paint;
            // 
            // flowLPBt
            // 
            flowLPBt.Controls.Add(BtCreate);
            flowLPBt.Controls.Add(BtRead);
            flowLPBt.Controls.Add(BtUpdate);
            flowLPBt.Controls.Add(BtDelete);
            flowLPBt.Dock = DockStyle.Fill;
            flowLPBt.Location = new Point(5, 250);
            flowLPBt.Margin = new Padding(5, 6, 5, 6);
            flowLPBt.Name = "flowLPBt";
            flowLPBt.Size = new Size(1361, 145);
            flowLPBt.TabIndex = 0;
            // 
            // BtCreate
            // 
            BtCreate.Location = new Point(262, 46);
            BtCreate.Margin = new Padding(262, 46, 5, 6);
            BtCreate.Name = "BtCreate";
            BtCreate.Size = new Size(163, 86);
            BtCreate.TabIndex = 0;
            BtCreate.Text = "CREATE";
            BtCreate.UseVisualStyleBackColor = true;
            BtCreate.Click += button1_Click;
            // 
            // BtRead
            // 
            BtRead.Location = new Point(487, 46);
            BtRead.Margin = new Padding(57, 46, 5, 6);
            BtRead.Name = "BtRead";
            BtRead.Size = new Size(163, 86);
            BtRead.TabIndex = 1;
            BtRead.Text = "READ";
            BtRead.UseVisualStyleBackColor = true;
            // 
            // BtUpdate
            // 
            BtUpdate.Location = new Point(712, 46);
            BtUpdate.Margin = new Padding(57, 46, 5, 6);
            BtUpdate.Name = "BtUpdate";
            BtUpdate.Size = new Size(163, 86);
            BtUpdate.TabIndex = 2;
            BtUpdate.Text = "UPDATE";
            BtUpdate.UseVisualStyleBackColor = true;
            // 
            // BtDelete
            // 
            BtDelete.Location = new Point(937, 46);
            BtDelete.Margin = new Padding(57, 46, 5, 6);
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(163, 86);
            BtDelete.TabIndex = 3;
            BtDelete.Text = "DELETE";
            BtDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 6);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1361, 232);
            dataGridView1.TabIndex = 1;
            // 
            // TLPchoiceFilter
            // 
            TLPchoiceFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TLPchoiceFilter.ColumnCount = 2;
            TLPchoiceFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.4614258F));
            TLPchoiceFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.5385742F));
            TLPchoiceFilter.Controls.Add(CBXtype, 1, 0);
            TLPchoiceFilter.Controls.Add(CBXserialNumber, 1, 1);
            TLPchoiceFilter.Controls.Add(CBXacquisitionDate, 1, 2);
            TLPchoiceFilter.Controls.Add(FLPbtFilter, 1, 4);
            TLPchoiceFilter.Controls.Add(CBXlocation, 1, 3);
            TLPchoiceFilter.Location = new Point(5, 511);
            TLPchoiceFilter.Margin = new Padding(5, 6, 5, 6);
            TLPchoiceFilter.Name = "TLPchoiceFilter";
            TLPchoiceFilter.RowCount = 5;
            TLPchoiceFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 46.3917542F));
            TLPchoiceFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 53.6082458F));
            TLPchoiceFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            TLPchoiceFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            TLPchoiceFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TLPchoiceFilter.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            TLPchoiceFilter.Size = new Size(1361, 234);
            TLPchoiceFilter.TabIndex = 2;
            // 
            // CBXlocation
            // 
            CBXlocation.AutoSize = true;
            CBXlocation.Location = new Point(719, 121);
            CBXlocation.Margin = new Padding(5, 6, 5, 6);
            CBXlocation.Name = "CBXlocation";
            CBXlocation.Size = new Size(118, 32);
            CBXlocation.TabIndex = 3;
            CBXlocation.Text = "Location";
            CBXlocation.UseVisualStyleBackColor = true;
            // 
            // BTfilter
            // 
            BTfilter.Location = new Point(103, 3);
            BTfilter.Margin = new Padding(103, 3, 3, 3);
            BTfilter.Name = "BTfilter";
            BTfilter.Size = new Size(131, 40);
            BTfilter.TabIndex = 8;
            BTfilter.Text = "FILTRER";
            BTfilter.UseVisualStyleBackColor = true;
            // 
            // FLPbtFilter
            // 
            TLPchoiceFilter.SetColumnSpan(FLPbtFilter, 2);
            FLPbtFilter.Controls.Add(BTfilter);
            FLPbtFilter.Location = new Point(3, 187);
            FLPbtFilter.Name = "FLPbtFilter";
            FLPbtFilter.Size = new Size(1355, 44);
            FLPbtFilter.TabIndex = 3;
            // 
            // CBXacquisitionDate
            // 
            CBXacquisitionDate.AutoSize = true;
            CBXacquisitionDate.Location = new Point(719, 75);
            CBXacquisitionDate.Margin = new Padding(5, 6, 5, 6);
            CBXacquisitionDate.Name = "CBXacquisitionDate";
            CBXacquisitionDate.Size = new Size(203, 34);
            CBXacquisitionDate.TabIndex = 2;
            CBXacquisitionDate.Text = "date d'acquisition";
            CBXacquisitionDate.UseVisualStyleBackColor = true;
            // 
            // CBXserialNumber
            // 
            CBXserialNumber.AutoSize = true;
            CBXserialNumber.Location = new Point(719, 38);
            CBXserialNumber.Margin = new Padding(5, 6, 5, 6);
            CBXserialNumber.Name = "CBXserialNumber";
            CBXserialNumber.Size = new Size(165, 25);
            CBXserialNumber.TabIndex = 1;
            CBXserialNumber.Text = "serial number";
            CBXserialNumber.UseVisualStyleBackColor = true;
            // 
            // CBXtype
            // 
            CBXtype.AutoSize = true;
            CBXtype.Location = new Point(719, 6);
            CBXtype.Margin = new Padding(5, 6, 5, 6);
            CBXtype.Name = "CBXtype";
            CBXtype.Size = new Size(82, 20);
            CBXtype.TabIndex = 0;
            CBXtype.Text = "Type";
            CBXtype.UseVisualStyleBackColor = true;
            CBXtype.CheckedChanged += CBXtype_CheckedChanged;
            // 
            // GestionForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(tLPMain);
            Margin = new Padding(5, 6, 5, 6);
            Name = "GestionForm";
            Text = "Form1";
            tLPMain.ResumeLayout(false);
            flowLPBt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TLPchoiceFilter.ResumeLayout(false);
            TLPchoiceFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BSmatériel).EndInit();
            FLPbtFilter.ResumeLayout(false);
            ResumeLayout(false);
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
        private FlowLayoutPanel FLPbtFilter;
        private Button BTfilter;
        private CheckBox CBXlocation;
    }
}