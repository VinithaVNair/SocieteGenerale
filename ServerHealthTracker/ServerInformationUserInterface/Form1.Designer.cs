namespace ServerInformationUserInterface
{
    partial class Form1
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
            this.ServerGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.InformationGridView = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessorUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoryUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerGridView
            // 
            this.ServerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ServerName});
            this.ServerGridView.Location = new System.Drawing.Point(0, 0);
            this.ServerGridView.Name = "ServerGridView";
            this.ServerGridView.RowTemplate.Height = 24;
            this.ServerGridView.Size = new System.Drawing.Size(1420, 1000);
            this.ServerGridView.TabIndex = 0;
            this.ServerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServerGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // ServerName
            // 
            this.ServerName.HeaderText = "Server Name";
            this.ServerName.Name = "ServerName";
            this.ServerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InformationGridView
            // 
            this.InformationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InformationGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InformationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InformationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.HostName,
            this.ProcessorUsage,
            this.MemoryUsage,
            this.Time});
            this.InformationGridView.Location = new System.Drawing.Point(12, 199);
            this.InformationGridView.Name = "InformationGridView";
            this.InformationGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.InformationGridView.RowTemplate.Height = 24;
            this.InformationGridView.Size = new System.Drawing.Size(719, 213);
            this.InformationGridView.TabIndex = 4;
            this.InformationGridView.Visible = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "S No";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Width = 64;
            // 
            // HostName
            // 
            this.HostName.HeaderText = "Server Name";
            this.HostName.Name = "HostName";
            this.HostName.Width = 110;
            // 
            // ProcessorUsage
            // 
            this.ProcessorUsage.HeaderText = "Processor Usage";
            this.ProcessorUsage.Name = "ProcessorUsage";
            this.ProcessorUsage.Width = 134;
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.HeaderText = "Memory Usage";
            this.MemoryUsage.Name = "MemoryUsage";
            this.MemoryUsage.Width = 121;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InformationGridView);
            this.Controls.Add(this.ServerGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ServerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServerGridView;
        private System.Windows.Forms.DataGridView InformationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessorUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewLinkColumn ServerName;
    }
}

