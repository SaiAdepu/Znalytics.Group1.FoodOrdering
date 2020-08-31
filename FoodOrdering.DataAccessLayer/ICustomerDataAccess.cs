using System;
using System.Collections.Generic;
using FoodOrdering.Entities;
namespace FoodOrdering.DataAccessLayer
{
	/// <summary>
	/// Represents interface for the customer DataAccessLayer
	/// </summary>
	public interface ICustomerDataAccess
	{
		//method to add customer
		void AddCustomer(Customer customer);
		//method to view existing customers
		public List<Customer> GetCustomers();
		//method to update customer name
        void UpdateCustomerName(Customer customer);
		//method to update customer email
		void UpdateCustomerEmail(Customer customer);
		//method to update customer phone number
		void UpdateCustomerPhoneNumber(Customer customer);
		//method to update customer address
		void UpdateCustomerAddress(Customer customer);
		//method to update customer Password
		void UpdateCustomerPassword(Customer customer);
		//method to delete the customer
		void DeleteCustomer(Customer customer);

	}
}
