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
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}

		string connectionString = "Server=localhost;port=5433;Database=Customer;userId=postgres;Password=1";

		public void EmployeeList()
		{
			NpgsqlConnection connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "select * from employees";

			NpgsqlCommand command = new NpgsqlCommand(query, connection);

			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);

			dataGridView1.DataSource = dataTable;

			connection.Close();
		}

		public void DepartmentList()
		{
			NpgsqlConnection connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "select * from departments";

			NpgsqlCommand command = new NpgsqlCommand(query, connection);

			NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);

			cmbDepartments.DisplayMember = "departmentname";
			cmbDepartments.ValueMember = "departmentid";
			cmbDepartments.DataSource = dataTable;

			connection.Close();
		}
		private void btnList_Click(object sender, EventArgs e)
		{
			EmployeeList();
		}

		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			EmployeeList();

			DepartmentList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string employeeName = txtEmployeeName.Text;
			string employeeSurname = txtEmployeeSurname.Text;
			decimal employeeSalary = decimal.Parse(txtSalary.Text);
			int departmentSelected = int.Parse(cmbDepartments.SelectedValue.ToString());

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "insert into employees (employeename,employeesurname,employeesalary,departmentid) values (@Employeename,@Employeesurname,@Employeesalary,@Departmentid)";

			NpgsqlCommand command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@Employeename",employeeName);
			command.Parameters.AddWithValue("@Employeesurname", employeeSurname);
			command.Parameters.AddWithValue("@Employeesalary", employeeSalary);
			command.Parameters.AddWithValue("@Departmentid", departmentSelected);

			command.ExecuteNonQuery();

			MessageBox.Show("Veri Eklendi","Ekleme İşlemi",MessageBoxButtons.OK, MessageBoxIcon.Information);

			connection.Close();
				
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int EmployeeId = int.Parse(txtEmployeeID.Text);

			string EmployeeName = txtEmployeeName.Text;
			string EmployeeSurname = txtEmployeeSurname.Text;
			decimal EmployeeSalary = decimal.Parse(txtSalary.Text);
			int DepartmentId = int.Parse(cmbDepartments.SelectedValue.ToString());

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "update employees set employeename = @Employeename, employeesurname = @Employeesurname,employeesalary = @Employeesalary,departmentid = @Departmentid where employeeid =@Employeeid";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@Employeename", EmployeeName);
			command.Parameters.AddWithValue("@Employeesurname", EmployeeSurname);
			command.Parameters.AddWithValue("@Employeesalary", EmployeeSalary);
			command.Parameters.AddWithValue("@Departmentid", DepartmentId);
			command.Parameters.AddWithValue("@Employeeid", EmployeeId);

			command.ExecuteNonQuery();

			MessageBox.Show("Veri Güncellendi","Güncelleme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);

			connection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int EmployeeId = int.Parse(txtEmployeeID.Text);

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "delete from employees where employeeid = @Employeeid";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@Employeeid", EmployeeId);

			command.ExecuteNonQuery();

			MessageBox.Show("Veri Silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

			connection.Close();

		}

		private void btnById_Click(object sender, EventArgs e)
		{
			int EmployeeId = Convert.ToInt32(txtEmployeeID.Text);

			var connection = new NpgsqlConnection(connectionString);

			connection.Open();

			string query = "select * from employees where employeeid = @Employeeid Order By employeename";

			var command = new NpgsqlCommand(query,connection);

			command.Parameters.AddWithValue("@Employeeid", EmployeeId);

			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

			DataTable dataTable = new DataTable();

			dataAdapter.Fill(dataTable);

			dataGridView1.DataSource = dataTable;

			connection.Close();
		}
	}
}
