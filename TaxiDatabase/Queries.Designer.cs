namespace TaxiDatabase
{
    partial class Queries
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
            this.label1 = new System.Windows.Forms.Label();
            this.DriversComboBox = new System.Windows.Forms.ComboBox();
            this.CarsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.QueryDataGridView = new System.Windows.Forms.DataGridView();
            this.DriverFindButton = new System.Windows.Forms.Button();
            this.CarFindButton = new System.Windows.Forms.Button();
            this.DateFindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказы водителя";
            // 
            // DriversComboBox
            // 
            this.DriversComboBox.FormattingEnabled = true;
            this.DriversComboBox.Location = new System.Drawing.Point(289, 9);
            this.DriversComboBox.Name = "DriversComboBox";
            this.DriversComboBox.Size = new System.Drawing.Size(279, 24);
            this.DriversComboBox.TabIndex = 1;
            // 
            // CarsComboBox
            // 
            this.CarsComboBox.FormattingEnabled = true;
            this.CarsComboBox.Location = new System.Drawing.Point(289, 63);
            this.CarsComboBox.Name = "CarsComboBox";
            this.CarsComboBox.Size = new System.Drawing.Size(279, 24);
            this.CarsComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заказы машины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Заказы за число";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(289, 129);
            this.DatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(279, 22);
            this.DatePicker.TabIndex = 5;
            // 
            // QueryDataGridView
            // 
            this.QueryDataGridView.AllowUserToAddRows = false;
            this.QueryDataGridView.AllowUserToDeleteRows = false;
            this.QueryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.QueryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.QueryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryDataGridView.Location = new System.Drawing.Point(63, 191);
            this.QueryDataGridView.Name = "QueryDataGridView";
            this.QueryDataGridView.RowHeadersWidth = 51;
            this.QueryDataGridView.RowTemplate.Height = 24;
            this.QueryDataGridView.Size = new System.Drawing.Size(631, 300);
            this.QueryDataGridView.TabIndex = 6;
            // 
            // DriverFindButton
            // 
            this.DriverFindButton.Location = new System.Drawing.Point(574, 9);
            this.DriverFindButton.Name = "DriverFindButton";
            this.DriverFindButton.Size = new System.Drawing.Size(75, 24);
            this.DriverFindButton.TabIndex = 7;
            this.DriverFindButton.Text = "Найти";
            this.DriverFindButton.UseVisualStyleBackColor = true;
            this.DriverFindButton.Click += new System.EventHandler(this.DriverFindButton_Click);
            // 
            // CarFindButton
            // 
            this.CarFindButton.Location = new System.Drawing.Point(574, 64);
            this.CarFindButton.Name = "CarFindButton";
            this.CarFindButton.Size = new System.Drawing.Size(75, 24);
            this.CarFindButton.TabIndex = 8;
            this.CarFindButton.Text = "Найти";
            this.CarFindButton.UseVisualStyleBackColor = true;
            this.CarFindButton.Click += new System.EventHandler(this.CarFindButton_Click);
            // 
            // DateFindButton
            // 
            this.DateFindButton.Location = new System.Drawing.Point(574, 128);
            this.DateFindButton.Name = "DateFindButton";
            this.DateFindButton.Size = new System.Drawing.Size(75, 24);
            this.DateFindButton.TabIndex = 9;
            this.DateFindButton.Text = "Найти";
            this.DateFindButton.UseVisualStyleBackColor = true;
            this.DateFindButton.Click += new System.EventHandler(this.DateFindButton_Click);
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.DateFindButton);
            this.Controls.Add(this.CarFindButton);
            this.Controls.Add(this.DriverFindButton);
            this.Controls.Add(this.QueryDataGridView);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DriversComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Queries";
            this.Text = "Queries";
            ((System.ComponentModel.ISupportInitialize)(this.QueryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DriversComboBox;
        private System.Windows.Forms.ComboBox CarsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataGridView QueryDataGridView;
        private System.Windows.Forms.Button DriverFindButton;
        private System.Windows.Forms.Button CarFindButton;
        private System.Windows.Forms.Button DateFindButton;
    }
}