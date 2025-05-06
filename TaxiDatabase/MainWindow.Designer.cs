using System.Windows.Forms;
using System.Drawing;

namespace TaxiDatabase
{
    partial class MainWindow
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.OpenDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.DataSourceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TablesGridView = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных такси";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(536, 37);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(119, 30);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DataSourceTextBox
            // 
            this.DataSourceTextBox.Location = new System.Drawing.Point(381, 41);
            this.DataSourceTextBox.Name = "DataSourceTextBox";
            this.DataSourceTextBox.Size = new System.Drawing.Size(149, 22);
            this.DataSourceTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя сервера";
            // 
            // TablesGridView
            // 
            this.TablesGridView.AllowUserToAddRows = false;
            this.TablesGridView.AllowUserToDeleteRows = false;
            this.TablesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TablesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TablesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TablesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesGridView.Location = new System.Drawing.Point(12, 124);
            this.TablesGridView.Name = "TablesGridView";
            this.TablesGridView.RowHeadersWidth = 51;
            this.TablesGridView.RowTemplate.Height = 24;
            this.TablesGridView.Size = new System.Drawing.Size(596, 343);
            this.TablesGridView.TabIndex = 6;
            this.TablesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablesGridView_CellClick);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(641, 473);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(87, 31);
            this.InsertButton.TabIndex = 7;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(318, 94);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(121, 24);
            this.TablesComboBox.TabIndex = 9;
            this.TablesComboBox.SelectedIndexChanged += new System.EventHandler(this.TablesComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(146, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите таблицу";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(668, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(668, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(668, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(668, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 22);
            this.textBox4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(747, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(668, 336);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 22);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(668, 389);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(220, 22);
            this.textBox6.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(668, 445);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(220, 22);
            this.textBox7.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(747, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "label10";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(734, 473);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 31);
            this.UpdateButton.TabIndex = 24;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(827, 473);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 31);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(253, 491);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(87, 31);
            this.QueryButton.TabIndex = 26;
            this.QueryButton.Text = "Запросы";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 547);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TablesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.TablesGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataSourceTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)(this.TablesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ConnectButton;
        private OpenFileDialog OpenDatabaseDialog;
        private TextBox DataSourceTextBox;
        private Label label2;
        private DataGridView TablesGridView;
        private Button InsertButton;
        private ComboBox TablesComboBox;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox7;
        private Label label10;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button QueryButton;
    }
}