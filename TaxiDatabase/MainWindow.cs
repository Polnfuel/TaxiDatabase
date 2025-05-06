using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaxiDatabase
{
    struct Field
    {
        public Label label;
        public TextBox textBox;
        public Field(Label lbl, TextBox txtBx)
        {
            label = lbl;
            textBox = txtBx;
        }
    }
    public partial class MainWindow : Form
    {
        Database database;
        Field[] fields;
        int ID;
        string nameTable = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            FillFields();
        }

        private void FillFields()
        {
            fields = new Field[7];
            fields[0] = new Field(label3, textBox1);
            fields[1] = new Field(label5, textBox2);
            fields[2] = new Field(label6, textBox3);
            fields[3] = new Field(label7, textBox4);
            fields[4] = new Field(label8, textBox5);
            fields[5] = new Field(label9, textBox6);
            fields[6] = new Field(label10, textBox7);
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i].label.Visible = false;
                fields[i].textBox.Visible = false;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DatabaseFilePath == "")
            {
                OpenDatabaseDialog.InitialDirectory = "";
                OpenDatabaseDialog.FileName = "";
                OpenDatabaseDialog.Filter = "Database files (*.mdf)|*.mdf";

                if (OpenDatabaseDialog.ShowDialog() == DialogResult.OK)
                {
                    string dbFilePath = OpenDatabaseDialog.FileName;
                    string dbDataSource = DataSourceTextBox.Text;

                    database = new Database(dbDataSource, dbFilePath);

                    using (SqlConnection cn = database.CreateConnection())
                    {
                        try
                        {
                            cn.Open();
                            MessageBox.Show("База данных успешно подключена");
                            Properties.Settings.Default.DatabaseFilePath = dbFilePath;
                            Properties.Settings.Default.DataSource = dbDataSource;
                            Properties.Settings.Default.Save();
                            AddTables();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                if (database == null)
                {
                    database = new Database(Properties.Settings.Default.DataSource, Properties.Settings.Default.DatabaseFilePath);
                }
                //MessageBox.Show("База данных готова к работе");
                AddTables();
            }
        }
        
        private void AddTables()
        {
            TablesComboBox.Items.Clear();
            using (SqlConnection cn = database.CreateConnection())
            {
                cn.Open();
                string strSQL = @"
                    SELECT TABLE_SCHEMA, TABLE_NAME
                    FROM INFORMATION_SCHEMA.TABLES
                    WHERE TABLE_TYPE = 'BASE TABLE'";
                SqlCommand cmd = new SqlCommand(strSQL, cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name = rdr.GetString(1);
                    TablesComboBox.Items.Add(name);
                }
            }
        }

        private void UpdateDataGridView()
        {
            using (SqlConnection cn = database.CreateConnection())
            {
                cn.Open();
                string strSQL = $"SELECT * FROM {nameTable}";
                DataTable t = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                int rows = da.Fill(t);
                switch (nameTable)
                {
                    case "Cars":
                        database.CarsLength = rows;
                        break;
                    case "Drivers":
                        database.DrivesLength = rows;
                        break;
                    case "Orders":
                        database.OrdersLength = rows;
                        break;
                }
                TablesGridView.DataSource = null;
                TablesGridView.Columns.Clear();
                TablesGridView.DataSource = t.DefaultView;

                TablesGridView_CellClick(this, new DataGridViewCellEventArgs(0, 0));
            }
        }
        
        private void TablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTable = TablesComboBox.Items[TablesComboBox.SelectedIndex].ToString();
            UpdateDataGridView();
        }

        private void TablesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = TablesGridView.CurrentRow;
            int id;
            string strSQL = string.Empty;
            switch (nameTable)
            {
                case "Cars":
                    id = (int)row.Cells["CarID"].Value;
                    strSQL = "SELECT * FROM Cars WHERE CarID=" + id.ToString();
                    break;
                case "Drivers":
                    id = (int)row.Cells["DriverID"].Value;
                    strSQL = "SELECT * FROM Drivers WHERE DriverID=" + id.ToString();
                    break;
                case "Orders":
                    id = (int)row.Cells["OrderID"].Value;
                    strSQL = "SELECT * FROM Orders WHERE OrderID=" + id.ToString();
                    break;
                default:
                    return;
            }
            ID = id;
            using (SqlConnection cn = database.CreateConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                DataTable t = new DataTable(nameTable);
                da.Fill(t);
                DataRow dtRow = t.Rows[0];
                FillTextBoxes(dtRow);
            }
        }
        
        private void FillTextBoxes(DataRow dtRow)
        {
            for (int i = 0; i < fields.Length; i++)
            {
                fields[i].label.Visible = true;
                fields[i].textBox.Visible = true;
            }
            switch (nameTable)
            {
                case "Cars":
                    fields[0].label.Text = "Марка авто";
                    fields[0].textBox.Text = dtRow[1].ToString();
                    fields[1].label.Text = "Модель авто";
                    fields[1].textBox.Text = dtRow[2].ToString();
                    fields[2].label.Text = "Номер авто";
                    fields[2].textBox.Text = dtRow[3].ToString();
                    fields[3].label.Text = "Год выпуска";
                    fields[3].textBox.Text = dtRow[4].ToString();
                    fields[4].label.Visible = false;
                    fields[4].textBox.Visible = false;
                    fields[5].label.Visible = false;
                    fields[5].textBox.Visible = false;
                    fields[6].label.Visible = false;
                    fields[6].textBox.Visible = false;
                    break;
                case "Drivers":
                    fields[0].label.Text = "ФИО";
                    fields[0].textBox.Text = dtRow[1].ToString();
                    fields[1].label.Text = "Номер прав";
                    fields[1].textBox.Text = dtRow[2].ToString();
                    fields[2].label.Text = "Номер телефона";
                    fields[2].textBox.Text = dtRow[3].ToString();
                    fields[3].label.Visible = false;
                    fields[3].textBox.Visible = false;
                    fields[4].label.Visible = false;
                    fields[4].textBox.Visible = false;
                    fields[5].label.Visible = false;
                    fields[5].textBox.Visible = false;
                    fields[6].label.Visible = false;
                    fields[6].textBox.Visible = false;
                    break;
                case "Orders":
                    fields[0].label.Text = "ID водителя";
                    fields[0].textBox.Text = dtRow[1].ToString();
                    fields[1].label.Text = "ID авто";
                    fields[1].textBox.Text = dtRow[2].ToString();
                    fields[2].label.Text = "Откуда";
                    fields[2].textBox.Text = dtRow[3].ToString();
                    fields[3].label.Text = "Куда";
                    fields[3].textBox.Text = dtRow[4].ToString();
                    fields[4].label.Text = "Со скольки";
                    fields[4].textBox.Text = dtRow[5].ToString();
                    fields[5].label.Text = "До скольки";
                    fields[5].textBox.Text = dtRow[6].ToString();
                    fields[6].label.Text = "Стоимость";
                    fields[6].textBox.Text = dtRow[7].ToString();
                    break;
            }
        }
        
        private void InsertButton_Click(object sender, EventArgs e)
        {
            string strSQL = string.Empty, values;
            switch (nameTable)
            {
                case "Cars":
                    values = $"N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}', {textBox4.Text}";
                    strSQL = $"INSERT INTO [dbo].[Cars] VALUES ({values})";
                    break;
                case "Drivers":
                    values = $"N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}'";
                    strSQL = $"INSERT INTO [dbo].[Drivers] VALUES ({values})";
                    break;
                case "Orders":
                    values = $"{textBox1.Text}, {textBox2.Text}, N'{textBox3.Text}', N'{textBox4.Text}', CAST(N'{textBox5.Text}' AS SmallDateTime), CAST(N'{textBox6.Text}' AS SmallDateTime), CAST({textBox7.Text.Replace(",", ".")} AS Decimal(10, 2))";
                    strSQL = $"INSERT INTO [dbo].[Orders] VALUES ({values})";
                    break;
            }
            using (SqlConnection cn = database.CreateConnection())
            {
                cn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                    switch (nameTable)
                    {
                        case "Cars":
                            database.CarsLength++;
                            break;
                        case "Drivers":
                            database.DrivesLength++;
                            break;
                        case "Orders":
                            database.OrdersLength++;
                            break;
                    }
                    DataTable t = new DataTable(nameTable);
                    da.Fill(t);
                    da.Update(t);
                    if (MessageBox.Show("Запись успешно добавлена") == DialogResult.OK)
                    {
                        UpdateDataGridView();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = database.CreateConnection())
            {
                string strSQL = string.Empty;
                SqlCommand cmd = null;
                switch (nameTable)
                {
                    case "Cars":
                        strSQL = "UPDATE Cars SET Brand = @Brand, Model = @Model, LicensePlate = @LicensePlate, Year = @Year WHERE CarID = @CarID";
                        cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Brand", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Model", textBox2.Text);
                        cmd.Parameters.AddWithValue("@LicensePlate", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Year", textBox4.Text);
                        cmd.Parameters.AddWithValue("@CarID", ID);
                        break;
                    case "Drivers":
                        strSQL = "UPDATE Drivers SET FullName = @FullName, LicenseNumber = @LicenseNumber, Phone = @Phone WHERE DriverID = @DriverID";
                        cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@LicenseNumber", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
                        cmd.Parameters.AddWithValue("@DriverID", ID);
                        break;
                    case "Orders":
                        strSQL = "UPDATE Orders SET DriverID = @DriverID, CarID = @CarID, PickupLocation = @PickupLocation, DropoffLocation = @DropoffLocation, PickupTime = @PickupTime, ReturnTime = @ReturnTime, Amount = @Amount WHERE OrderID = @OrderID";
                        cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@DriverID", textBox1.Text);
                        cmd.Parameters.AddWithValue("@CarID", textBox2.Text);
                        cmd.Parameters.AddWithValue("@PickupLocation", textBox3.Text);
                        cmd.Parameters.AddWithValue("@DropoffLocation", textBox4.Text);
                        cmd.Parameters.AddWithValue("@PickupTime", textBox5.Text);
                        cmd.Parameters.AddWithValue("@ReturnTime", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(textBox7.Text));
                        cmd.Parameters.AddWithValue("@OrderID", ID);
                        break;
                }
                cn.Open();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        if (MessageBox.Show("Запись успешно обновлена") == DialogResult.OK)
                        {
                            UpdateDataGridView();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = database.CreateConnection())
            {
                string strSQL = string.Empty;
                SqlCommand cmd = null;
                switch (nameTable)
                {
                    case "Cars":
                        strSQL = "DELETE FROM Cars WHERE CarID = @CarID";
                        cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CarID", ID);
                        break;
                    case "Drivers":
                        strSQL = "DELETE FROM Drivers WHERE DriverID = @DriverID";
                        cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@DriverID", ID);
                        break;
                    case "Orders":
                        strSQL = "DELETE FROM Orders WHERE OrderID = @OrderID";
                        cmd = new SqlCommand(strSQL, cn);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@OrderID", ID);
                        break;
                }
                cn.Open();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                    {
                        if (MessageBox.Show("Запись успешно удалена") == DialogResult.OK)
                        {
                            UpdateDataGridView();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                Queries window = new Queries(database);
                window.Show();
            }
            else
            {
                MessageBox.Show("Сперва подключитесь к базе данных");
            }
        }
    }
}
