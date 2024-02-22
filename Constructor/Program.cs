// See https://aka.ms/new-console-template for more information
using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args) 
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Merve", LastName = "Altınışık", City = "Paris"};

            Customer customer2 = new Customer (2,"Henry", "Valley","ocean");

            Customer customer3 = new Customer();
            customer3.Id = 3;
           
            Console.WriteLine (customer2.FirstName);
        }

       


    }

    class Customer
    {
        public Customer()       //overloading
        {
            
        }
        public Customer(int id,string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}