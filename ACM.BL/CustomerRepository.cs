using System;

namespace CMS.BusinessLayer
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // Код загрузки клиента
            Customer customer = new Customer(customerId);

            // Временный заглушечный код для примера
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            // Код сохранения клиента
            return true;
        }
    }
}