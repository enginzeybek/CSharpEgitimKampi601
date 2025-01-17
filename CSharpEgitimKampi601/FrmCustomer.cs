using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5433;Database=Customer;userId=postgres;Password=1";

		public void GetAllCustomer()
		{
			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "select * from customers";

			NpgsqlCommand command = new NpgsqlCommand(query, connection);

			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);

			dataGridView1.DataSource = dataTable;

			connection.Close();
		}
		private void btnList_Click(object sender, EventArgs e)
		{
			GetAllCustomer();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string Name = txtCustomerName.Text;

			string SurName = txtCustomerSurname.Text;

			string City = txtCustomerCity.Text;

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "insert into customers (customername,customersurname,customercity) values (@Customername,@Customersurname,@Customercity)";

			var command = new NpgsqlCommand(query, connection);

			command.Parameters.AddWithValue("@Customername", Name);
			command.Parameters.AddWithValue("@Customersurname", SurName);
			command.Parameters.AddWithValue("@Customercity", City);

			command.ExecuteNonQuery();

			MessageBox.Show("Veri Eklendi");

			connection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int CustomerId = int.Parse(txtCustomerID.Text);

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "delete from customers where customerid = @CustomerId";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@CustomerId", CustomerId);

			command.ExecuteNonQuery();

			MessageBox.Show("Veri Silindi");

			connection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int CustomerId = Convert.ToInt32(txtCustomerID.Text);

			string Name = txtCustomerName.Text;

			string SurName = txtCustomerSurname.Text;

			string City = txtCustomerCity.Text;

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "update customers set customername = @Customername,customersurname = @Customersurname,customercity = @Customercity where customerid = @Customerid";

			var command = new NpgsqlCommand(query, connection);

			command.Parameters.AddWithValue("@Customername", Name);
			command.Parameters.AddWithValue("@Customersurname", SurName);
			command.Parameters.AddWithValue("@Customercity", City);
			command.Parameters.AddWithValue("@Customerid", CustomerId);

			command.ExecuteNonQuery();

			MessageBox.Show("Veri Güncellendi");

			connection.Close();

			
		}

		private void btnById_Click(object sender, EventArgs e)
		{
			int CustomerId = Convert.ToInt32(txtCustomerID.Text);

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "select * from customers where customerid = @Customerid";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@Customerid", CustomerId);

			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);

			dataGridView1.DataSource = dataTable;

			connection.Close();
		}
	}
}
