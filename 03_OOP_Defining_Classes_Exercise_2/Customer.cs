using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_2
{
    public class Customer
    {

        static void Main(string[] args)
        {
        }

        public Customer(int customerID, string firstName, string lastName, int yearsAsCustomer)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            YearsAsCustomer = yearsAsCustomer;
        }

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsAsCustomer { get; set; }

        public string SendCustomerMessage()
        {
            return "This is the customer message";
        }

    }
}
