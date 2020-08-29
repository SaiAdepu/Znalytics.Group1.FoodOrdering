using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;
namespace Znalytics.Grp1.FoodOrdering.DataAccessLayer
{
	/// <summary>
	/// Represents interface for the customer DataAccessLayer
	/// </summary>
	public interface ICustomerDataAccess
	{
		void AddCustomer(ICustomerDataAccess customer);
		public List<Customer> GetCustomers()
		{

		}
		void UpdateCustomerName(Customer customer);
		void UpdateCustomerMail(Customer customer);
		void UpdateCustomerPhoneNumber(Customer customer);
		void UpdateCustomerAddress(Customer customer);
		void UpdateCustomerPassword(Customer customer);

	}
}
