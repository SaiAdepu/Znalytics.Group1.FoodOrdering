using System;
using System.Collections.Generic;
using FoodOrdering.Entities;
namespace FoodOrdering.BusinessLayer
{

    public interface ICustomerBusinessLayer
    {
        //Adding details
        void AddCustomer(Customer customer);
        //Viewing existing details
        void ViewCustomer(Customer customer);
        //Updating customer details
        void UpdateCustomerName(Customer customer);
        void UpdateCustomerEmail(Customer customer);
        void UpdateCustomerPhoneNumber(Customer customer);
        void UpdateCustomerAddress(Customer customer);
        void UpdateCustomerPassword(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}