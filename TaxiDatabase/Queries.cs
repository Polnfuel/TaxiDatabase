using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiDatabase
{
    public partial class Queries : Form
    {
        private readonly Database database;
        public Queries(Database database)
        {
            InitializeComponent();
            this.database = database;
            FillDriversComboBox();
            FillCarsComboBox();
        }
        private void FillDriversComboBox()
        {
            using (SqlConnection cn = database.CreateConnection())
            {
                cn.Open();
                string strSQL = @"SELECT DriverID, FullName FROM Drivers";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                DataTable t = new DataTable();
                da.Fill(t);

                DriversComboBox.DataSource = t;
                DriversComboBox.DisplayMember = "FullName";
                DriversComboBox.ValueMember = "DriverID";
            }
        }
        private void FillCarsComboBox()
        {
            using (SqlConnection cn = database.CreateConnection())
            {
                cn.Open();
                string strSQL = @"SELECT CarID, Brand + ' ' + Model + ' ' + LicensePlate AS Car FROM Cars";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                DataTable t = new DataTable();
                da.Fill(t);

                CarsComboBox.DataSource = t;
                CarsComboBox.DisplayMember = "Car";
                CarsComboBox.ValueMember = "CarID";
            }
        }

        private void DriverFindButton_Click(object sender, EventArgs e)
        {
            int id = (int)DriversComboBox.SelectedValue;
            string strSQL = $"SELECT Drivers.FullName, Cars.LicensePlate, Orders.PickupLocation, Orders.DropoffLocation, Orders.PickupTime, Orders.ReturnTime, Orders.Amount FROM Drivers INNER JOIN Orders ON Drivers.DriverID = Orders.DriverID INNER JOIN Cars ON Orders.CarID = Cars.CarID WHERE (Drivers.DriverID = {id})";
            UpdateDataGridView(strSQL);
        }

        private void CarFindButton_Click(object sender, EventArgs e)
        {
            int id = (int)CarsComboBox.SelectedValue;
            string strSQL = $"SELECT Cars.Brand + N' ' + Cars.Model + N' ' + Cars.LicensePlate AS Car, Drivers.FullName, Orders.PickupLocation, Orders.DropoffLocation, Orders.PickupTime, Orders.ReturnTime, Orders.Amount FROM Cars INNER JOIN Orders ON Cars.CarID = Orders.CarID INNER JOIN Drivers ON Orders.DriverID = Drivers.DriverID WHERE  (Cars.CarID = {id})";
            UpdateDataGridView(strSQL);
        }

        private void DateFindButton_Click(object sender, EventArgs e)
        {
            DateTime date = DatePicker.Value.Date;
            string strSQL = $"SELECT Orders.PickupTime, Orders.ReturnTime, Drivers.FullName, Cars.Brand + N' ' + Cars.Model AS Car, Orders.PickupLocation, Orders.DropoffLocation, Orders.Amount FROM Cars INNER JOIN Orders ON Cars.CarID = Orders.CarID INNER JOIN Drivers ON Orders.DriverID = Drivers.DriverID WHERE  (CAST(Orders.PickupTime AS date) = '{date}')";
            UpdateDataGridView(strSQL);
        }
        private void UpdateDataGridView(string strSQL)
        {
            using (SqlConnection cn = database.CreateConnection())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
                DataTable t = new DataTable();
                da.Fill(t);
                QueryDataGridView.DataSource = null;
                QueryDataGridView.Columns.Clear();
                QueryDataGridView.DataSource = t.DefaultView;
            }
        }
    }
}
