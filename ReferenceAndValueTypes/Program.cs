﻿using System;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Halil";
            person2 = person1;
            person1.FirstName = "Arslan";
            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            customer.FirstName = "İbrahim";
            customer.CreditCardNumber = "12156468";
            Employee employee = new Employee();
            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeNumber { get; set; }

        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
}
