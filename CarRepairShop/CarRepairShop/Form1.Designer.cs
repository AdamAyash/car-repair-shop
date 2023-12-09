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
            this.components = new System.ComponentModel.Container();
            this.databaseConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RMBInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.RMBUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.RMBDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.RMBPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowClients24h = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMinAndMaxPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUnpaidCars = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPaidCars = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTop3MostRepairedBrands = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowClientWithMostPays = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadDataCars = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadDataClients = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadDataRepairs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.databaseConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseConnectionBindingSource
            // 
            this.databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(728, 503);
            this.dataGridView2.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RMBInsert,
            this.RMBUpdate,
            this.RMBDelete,
            this.RMBPreview});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 92);
            // 
            // RMBInsert
            // 
            this.RMBInsert.Name = "RMBInsert";
            this.RMBInsert.Size = new System.Drawing.Size(115, 22);
            this.RMBInsert.Text = "Insert";
            this.RMBInsert.Click += new System.EventHandler(this.RMBInsert_Click);
            // 
            // RMBUpdate
            // 
            this.RMBUpdate.Name = "RMBUpdate";
            this.RMBUpdate.Size = new System.Drawing.Size(115, 22);
            this.RMBUpdate.Text = "Update";
            this.RMBUpdate.Click += new System.EventHandler(this.RMBUpdate_Click);
            // 
            // RMBDelete
            // 
            this.RMBDelete.Name = "RMBDelete";
            this.RMBDelete.Size = new System.Drawing.Size(115, 22);
            this.RMBDelete.Text = "Delete";
            this.RMBDelete.Click += new System.EventHandler(this.RMBDelete_Click);
            // 
            // RMBPreview
            // 
            this.RMBPreview.Name = "RMBPreview";
            this.RMBPreview.Size = new System.Drawing.Size(115, 22);
            this.RMBPreview.Text = "Preview";
            this.RMBPreview.Click += new System.EventHandler(this.RMBPreview_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowClients24h,
            this.ShowMinAndMaxPrice,
            this.ShowUnpaidCars,
            this.ShowPaidCars,
            this.ShowTop3MostRepairedBrands,
            this.ShowClientWithMostPays});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Spravki";
            // 
            // ShowClients24h
            // 
            this.ShowClients24h.Name = "ShowClients24h";
            this.ShowClients24h.Size = new System.Drawing.Size(252, 22);
            this.ShowClients24h.Text = "Show Clients 24h";
            // 
            // ShowMinAndMaxPrice
            // 
            this.ShowMinAndMaxPrice.Name = "ShowMinAndMaxPrice";
            this.ShowMinAndMaxPrice.Size = new System.Drawing.Size(252, 22);
            this.ShowMinAndMaxPrice.Text = "Show Min/Max Price";
            // 
            // ShowUnpaidCars
            // 
            this.ShowUnpaidCars.Name = "ShowUnpaidCars";
            this.ShowUnpaidCars.Size = new System.Drawing.Size(252, 22);
            this.ShowUnpaidCars.Text = "Show Unpaid Cars";
            // 
            // ShowPaidCars
            // 
            this.ShowPaidCars.Name = "ShowPaidCars";
            this.ShowPaidCars.Size = new System.Drawing.Size(252, 22);
            this.ShowPaidCars.Text = "Show Paid Cars";
            // 
            // ShowTop3MostRepairedBrands
            // 
            this.ShowTop3MostRepairedBrands.Name = "ShowTop3MostRepairedBrands";
            this.ShowTop3MostRepairedBrands.Size = new System.Drawing.Size(252, 22);
            this.ShowTop3MostRepairedBrands.Text = "Show Top 3 Most Repaired Brands";
            // 
            // ShowClientWithMostPays
            // 
            this.ShowClientWithMostPays.Name = "ShowClientWithMostPays";
            this.ShowClientWithMostPays.Size = new System.Drawing.Size(252, 22);
            this.ShowClientWithMostPays.Text = "Show Client With Most Pays";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadDataCars,
            this.LoadDataClients,
            this.LoadDataRepairs});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem2.Text = "Load Data";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // LoadDataCars
            // 
            this.LoadDataCars.Name = "LoadDataCars";
            this.LoadDataCars.Size = new System.Drawing.Size(180, 22);
            this.LoadDataCars.Text = "Cars";
            this.LoadDataCars.Click += new System.EventHandler(this.LoadDataCars_Click);
            // 
            // LoadDataClients
            // 
            this.LoadDataClients.Name = "LoadDataClients";
            this.LoadDataClients.Size = new System.Drawing.Size(180, 22);
            this.LoadDataClients.Text = "Clients";
            this.LoadDataClients.Click += new System.EventHandler(this.LoadDataClients_Click);
            // 
            // LoadDataRepairs
            // 
            this.LoadDataRepairs.Name = "LoadDataRepairs";
            this.LoadDataRepairs.Size = new System.Drawing.Size(180, 22);
            this.LoadDataRepairs.Text = "Repairs";
            this.LoadDataRepairs.Click += new System.EventHandler(this.LoadDataRepairs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 527);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.databaseConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource databaseConnectionBindingSource;
        private DataGridView dataGridView2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ShowClients24h;
        private ToolStripMenuItem ShowMinAndMaxPrice;
        private ToolStripMenuItem ShowUnpaidCars;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem RMBInsert;
        private ToolStripMenuItem RMBUpdate;
        private ToolStripMenuItem RMBDelete;
        private ToolStripMenuItem LoadDataCars;
        private ToolStripMenuItem LoadDataClients;
        private ToolStripMenuItem LoadDataRepairs;
        private ToolStripMenuItem ShowPaidCars;
        private ToolStripMenuItem ShowTop3MostRepairedBrands;
        private ToolStripMenuItem ShowClientWithMostPays;
        private ToolStripMenuItem RMBPreview;
    }
}