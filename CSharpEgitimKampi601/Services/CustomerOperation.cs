using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
	public class CustomerOperation
	{
		public void AddCustomer(Customer customer) // istersek DTO'da kullanabiliriz.
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomerCollection();

			var document = new BsonDocument
			{
				{"CustomerName",customer.CustomerName},
				{"CustomerSurname",customer.CustomerSurname},
				{"CustomerCity",customer.CustomerCity},
				{"CustomerBalance",customer.CustomerBalance},
				{"CustomerShoppingCount",customer.CustomerShoppingCount}
			};

			customerCollection.InsertOne(document);
		}

		public List<Customer> GetAllCustomer() 
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomerCollection();

			var customers = customerCollection.Find(new BsonDocument()).ToList();
			List<Customer> customerList = new List<Customer>();
			foreach (var c in customers)
			{
				customerList.Add(new Customer
				{
					CustomerID = c["_id"].ToString(),
					CustomerName = c["CustomerName"].ToString(),
					CustomerSurname = c["CustomerSurname"].ToString(),
					CustomerCity = c["CustomerCity"].ToString(),
					CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),
					CustomerShoppingCount = int.Parse(c["CustomerShoppingCount"].ToString())
				});
			}

			return customerList;
		}

		public void deleteCustomer(string id)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomerCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
			customerCollection.DeleteOne(filter);
		}

		public void updateCustomer(Customer customer)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomerCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerID));
			var updatedValue = Builders<BsonDocument>.Update
				.Set("CustomerName", customer.CustomerName)
				.Set("CustomerSurname", customer.CustomerSurname)
				.Set("CustomerCity", customer.CustomerCity)
				.Set("CustomerBalance", customer.CustomerBalance)
				.Set("CustomerShoppingCount", customer.CustomerShoppingCount);

			customerCollection.UpdateOne(filter,updatedValue);
		}

		public Customer GetCustomerById(string id)
		{
			var connection = new MongoDbConnection();
			var customerCollection = connection.GetCustomerCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(id));
			var result = customerCollection.Find(filter).FirstOrDefault();
			return new Customer
			{
				CustomerBalance = int.Parse(result["CustomerBalance"].ToString()),
				CustomerCity = result["CustomerCity"].ToString(),
				CustomerName = result["CustomerName"].ToString(),
				CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
				CustomerSurname = result["CustomerSurname"].ToString()
			};
			
		}

		
	}
}
