namespace CarRepairShop
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            databaseConnectionBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            RMBInsert = new ToolStripMenuItem();
            RMBUpdate = new ToolStripMenuItem();
            RMBDelete = new ToolStripMenuItem();
            RMBPreview = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ShowClients24h = new ToolStripMenuItem();
            ShowMinAndMaxPrice = new ToolStripMenuItem();
            ShowUnpaidCars = new ToolStripMenuItem();
            ShowPaidCars = new ToolStripMenuItem();
            ShowTop3MostRepairedBrands = new ToolStripMenuItem();
            ShowClientWithMostPays = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            LoadDataCars = new ToolStripMenuItem();
            LoadDataClients = new ToolStripMenuItem();
            LoadDataRepairs = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(660, 278);
            dataGridView1.TabIndex = 0;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ContextMenuStrip = contextMenuStrip1;
            dataGridView2.Location = new Point(87, 105);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(631, 425);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellMouseClick += dataGridView2_CellMouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { RMBInsert, RMBUpdate, RMBDelete, RMBPreview });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(130, 100);
            // 
            // RMBInsert
            // 
            RMBInsert.Name = "RMBInsert";
            RMBInsert.Size = new Size(129, 24);
            RMBInsert.Text = "Insert";
            RMBInsert.Click += RMBInsert_Click;
            // 
            // RMBUpdate
            // 
            RMBUpdate.Name = "RMBUpdate";
            RMBUpdate.Size = new Size(129, 24);
            RMBUpdate.Text = "Update";
            RMBUpdate.Click += RMBUpdate_Click;
            // 
            // RMBDelete
            // 
            RMBDelete.Name = "RMBDelete";
            RMBDelete.Size = new Size(129, 24);
            RMBDelete.Text = "Delete";
            RMBDelete.Click += RMBDelete_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(806, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ShowClients24h, ShowMinAndMaxPrice, ShowUnpaidCars, ShowPaidCars, ShowTop3MostRepairedBrands, ShowClientWithMostPays });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 24);
            toolStripMenuItem1.Text = "Spravki";
            // 
            // ShowClients24h
            // 
            ShowClients24h.Name = "ShowClients24h";
            ShowClients24h.Size = new Size(319, 26);
            ShowClients24h.Text = "Show Clients 24h";
            ShowClients24h.Click += ShowClients24h_Click;
            // 
            // ShowMinAndMaxPrice
            // 
            ShowMinAndMaxPrice.Name = "ShowMinAndMaxPrice";
            ShowMinAndMaxPrice.Size = new Size(319, 26);
            ShowMinAndMaxPrice.Text = "Show Min/Max Price";
            ShowMinAndMaxPrice.Click += ShowMinAndMaxPrice_Click;
            // 
            // ShowUnpaidCars
            // 
            ShowUnpaidCars.Name = "ShowUnpaidCars";
            ShowUnpaidCars.Size = new Size(319, 26);
            ShowUnpaidCars.Text = "Show Unpaid Cars";
            ShowUnpaidCars.Click += ShowUnpaidCars_Click;
            // 
            // ShowPaidCars
            // 
            ShowPaidCars.Name = "ShowPaidCars";
            ShowPaidCars.Size = new Size(319, 26);
            ShowPaidCars.Text = "Show Paid Cars";
            ShowPaidCars.Click += ShowPaidCars_Click;
            // 
            // ShowTop3MostRepairedBrands
            // 
            ShowTop3MostRepairedBrands.Name = "ShowTop3MostRepairedBrands";
            ShowTop3MostRepairedBrands.Size = new Size(319, 26);
            ShowTop3MostRepairedBrands.Text = "Show Top 3 Most Repaired Brands";
            ShowTop3MostRepairedBrands.Click += ShowTop3MostRepairedBrands_Click;
            // 
            // ShowClientWithMostPays
            // 
            ShowClientWithMostPays.Name = "ShowClientWithMostPays";
            ShowClientWithMostPays.Size = new Size(319, 26);
            ShowClientWithMostPays.Text = "Show Client With Most Pays";
            ShowClientWithMostPays.Click += ShowClientWithMostPays_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { LoadDataCars, LoadDataClients, LoadDataRepairs });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(92, 24);
            toolStripMenuItem2.Text = "Load Data";
            // 
            // LoadDataCars
            // 
            LoadDataCars.Name = "LoadDataCars";
            LoadDataCars.Size = new Size(141, 26);
            LoadDataCars.Text = "Cars";
            LoadDataCars.Click += LoadDataCars_Click;
            // 
            // LoadDataClients
            // 
            LoadDataClients.Name = "LoadDataClients";
            LoadDataClients.Size = new Size(141, 26);
            LoadDataClients.Text = "Clients";
            LoadDataClients.Click += LoadDataClients_Click;
            // 
            // LoadDataRepairs
            // 
            LoadDataRepairs.Name = "LoadDataRepairs";
            LoadDataRepairs.Size = new Size(141, 26);
            LoadDataRepairs.Text = "Repairs";
            LoadDataRepairs.Click += LoadDataRepairs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 708);
            Controls.Add(dataGridView2);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource databaseConnectionBindingSource;
        private DataGridView dataGridView2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ShowClients24h;
        private ToolStripMenuItem ShowMinAndMaxPrice;
        private ToolStripMenuItem ShowUnpaidCars;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}