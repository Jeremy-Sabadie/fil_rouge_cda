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
            this.BSmatériel = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtFilter = new System.Windows.Forms.Button();
            this.tLPMain.SuspendLayout();
            this.flowLPBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSmatériel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.Controls.Add(this.flowLPBt, 0, 2);
            this.tLPMain.Controls.Add(this.dataGridView1, 0, 0);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 3;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tLPMain.Size = new System.Drawing.Size(800, 450);
            this.tLPMain.TabIndex = 0;
            // 
            // flowLPBt
            // 
            this.flowLPBt.Controls.Add(this.BtCreate);
            this.flowLPBt.Controls.Add(this.BtRead);
            this.flowLPBt.Controls.Add(this.BtUpdate);
            this.flowLPBt.Controls.Add(this.BtDelete);
            this.flowLPBt.Controls.Add(this.BtFilter);
            this.flowLPBt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLPBt.Location = new System.Drawing.Point(3, 352);
            this.flowLPBt.Name = "flowLPBt";
            this.flowLPBt.Size = new System.Drawing.Size(794, 95);
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
            this.dataGridView1.Size = new System.Drawing.Size(794, 166);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtFilter
            // 
            this.BtFilter.Location = new System.Drawing.Point(677, 23);
            this.BtFilter.Margin = new System.Windows.Forms.Padding(33, 23, 3, 3);
            this.BtFilter.Name = "BtFilter";
            this.BtFilter.Size = new System.Drawing.Size(95, 43);
            this.BtFilter.TabIndex = 4;
            this.BtFilter.Text = "FILTRER par status";
            this.BtFilter.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.BSmatériel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tLPMain;
        private FlowLayoutPanel flowLPBt;
        private Button BtCreate;
        private Button BtRead;
        private Button BtUpdate;
        private Button BtDelete;
        private Button BtFilter;
        private DataGridView dataGridView1;
        private BindingSource BSmatériel;
    }
}