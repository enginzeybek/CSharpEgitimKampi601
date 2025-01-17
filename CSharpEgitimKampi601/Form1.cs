using CSharpEgitimKampi601.Entities;
using CSharpEgitimKampi601.Services;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		CustomerOperation customerOperation = new CustomerOperation();
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var customer = new Customer()
			{
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerCity = txtCustomerCity.Text,
				CustomerBalance = decimal.Parse(txtBalance.Text),
				CustomerShoppingCount = int.Parse(txtShopping.Text)
			};

			customerOperation.AddCustomer(customer);

			MessageBox.Show("MÜŞTERİ EKLENDİ","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			List<Customer> Customers = customerOperation.GetAllCustomer();

			dataGridView1.DataSource = Customers;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string customerID = txtCustomerID.Text;

			customerOperation.deleteCustomer(customerID);

			MessageBox.Show("MÜŞTERİ SİLİNDİ");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string customerID = txtCustomerID.Text;
			var updatedValue = new Customer
			{
				CustomerName = txtCustomerName.Text,
				CustomerBalance = Convert.ToDecimal(txtBalance.Text),
				CustomerCity = txtCustomerCity.Text,
				CustomerShoppingCount = int.Parse(txtShopping.Text),
				CustomerSurname = txtCustomerSurname.Text,
				CustomerID = customerID
			};

			customerOperation.updateCustomer(updatedValue);

			MessageBox.Show("MÜŞTERİ GÜNCELLENDİ");
		}

		private void btnById_Click(object sender, EventArgs e)
		{
			string customerID = txtCustomerID.Text;
			Customer customer = customerOperation.GetCustomerById(customerID);
			dataGridView1.DataSource = new List<Customer> { customer };
		}
	}
}
