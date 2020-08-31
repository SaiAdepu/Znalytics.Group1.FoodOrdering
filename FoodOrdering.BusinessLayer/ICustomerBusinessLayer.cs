using System;
using System.Collections.Generic;
using FoodOrdering.Entities;
namespace FoodOrdering.BusinessLayer
{
    /// <summary>
    /// Represents the interface of the customerBusinessLayer
    /// </summary>
    public interface ICustomerBusinessLayer
    {
        //Adding customer details
        void AddCustomer(Customer customer);
        //Viewing existing details
        void ViewCustomer(Customer customer);
        //Updating customer name
        void UpdateCustomerName(Customer customer);
        //updating customer Email
        void UpdateCustomerEmail(Customer customer);
        //updating customer phone number
        void UpdateCustomerPhoneNumber(Customer customer);
        //updating customer Address
        void UpdateCustomerAddress(Customer customer);
        //updating customer password
        void UpdateCustomerPassword(Customer customer);
        //deleting the customer
        void DeleteCustomer(Customer customer);
    }
}