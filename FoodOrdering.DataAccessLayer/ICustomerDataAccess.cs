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
		void AddCustomer(ICustomerDataAccess customer);
		public List<Customer> GetCustomers();
		
		
		
		void UpdateCustomerName(Customer customer);
		void UpdateCustomerEmail(Customer customer);
		void UpdateCustomerPhoneNumber(Customer customer);
		void UpdateCustomerAddress(Customer customer);
		void UpdateCustomerPassword(Customer customer);

	}
}
