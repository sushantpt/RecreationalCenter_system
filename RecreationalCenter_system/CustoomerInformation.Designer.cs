namespace RecreationalCenter_system
{
    partial class CustoomerInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustoomerInformation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAdultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedExitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csvPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.csvPropertiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csvPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csvPropertiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNODataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.totalAdultsDataGridViewTextBoxColumn,
            this.totalKidsDataGridViewTextBoxColumn,
            this.entryTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.expectedExitDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.csvPropertiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(304, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNODataGridViewTextBoxColumn
            // 
            this.phoneNODataGridViewTextBoxColumn.DataPropertyName = "PhoneNO";
            this.phoneNODataGridViewTextBoxColumn.HeaderText = "PhoneNO";
            this.phoneNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNODataGridViewTextBoxColumn.Name = "phoneNODataGridViewTextBoxColumn";
            this.phoneNODataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAdultsDataGridViewTextBoxColumn
            // 
            this.totalAdultsDataGridViewTextBoxColumn.DataPropertyName = "TotalAdults";
            this.totalAdultsDataGridViewTextBoxColumn.HeaderText = "TotalAdults";
            this.totalAdultsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAdultsDataGridViewTextBoxColumn.Name = "totalAdultsDataGridViewTextBoxColumn";
            this.totalAdultsDataGridViewTextBoxColumn.Visible = false;
            this.totalAdultsDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalKidsDataGridViewTextBoxColumn
            // 
            this.totalKidsDataGridViewTextBoxColumn.DataPropertyName = "TotalKids";
            this.totalKidsDataGridViewTextBoxColumn.HeaderText = "TotalKids";
            this.totalKidsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalKidsDataGridViewTextBoxColumn.Name = "totalKidsDataGridViewTextBoxColumn";
            this.totalKidsDataGridViewTextBoxColumn.Visible = false;
            this.totalKidsDataGridViewTextBoxColumn.Width = 125;
            // 
            // entryTimeDataGridViewTextBoxColumn
            // 
            this.entryTimeDataGridViewTextBoxColumn.DataPropertyName = "EntryTime";
            this.entryTimeDataGridViewTextBoxColumn.HeaderText = "EntryTime";
            this.entryTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entryTimeDataGridViewTextBoxColumn.Name = "entryTimeDataGridViewTextBoxColumn";
            this.entryTimeDataGridViewTextBoxColumn.Visible = false;
            this.entryTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Visible = false;
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // expectedExitDataGridViewTextBoxColumn
            // 
            this.expectedExitDataGridViewTextBoxColumn.DataPropertyName = "ExpectedExit";
            this.expectedExitDataGridViewTextBoxColumn.HeaderText = "ExpectedExit";
            this.expectedExitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expectedExitDataGridViewTextBoxColumn.Name = "expectedExitDataGridViewTextBoxColumn";
            this.expectedExitDataGridViewTextBoxColumn.Visible = false;
            this.expectedExitDataGridViewTextBoxColumn.Width = 125;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.Visible = false;
            this.entryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Visible = false;
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // csvPropertiesBindingSource
            // 
            this.csvPropertiesBindingSource.DataSource = typeof(RecreationalCenter_system.CsvProperties);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Xyz Recreational Center";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Visitors name and phone numbers:";
            // 
            // csvPropertiesBindingSource1
            // 
            this.csvPropertiesBindingSource1.DataSource = typeof(RecreationalCenter_system.CsvProperties);
            // 
            // CustoomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustoomerInformation";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.EmployeeInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csvPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csvPropertiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource csvPropertiesBindingSource;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAdultsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalKidsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entryTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expectedExitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private Label label3;
        private Label label1;
        private BindingSource csvPropertiesBindingSource1;
    }
}