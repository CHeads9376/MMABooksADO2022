using System;

namespace MMABooksBusinessClasses
{
    public class Customer
    {
        // there are several warnings in this file related to nullable properties and return values.
        // you can ignore them
        public Customer() { }

        public Customer(int id, string name, string address, string city, string state, string zipcode)
        {
            CustomerID = id;
            Name = name;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;
        }

        private int customerID;
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipcode;


        public int CustomerID 
        {
            get
            { 
                return customerID;
            }
                
            set
            {
                if (value > 0)
                    customerID = value;
                else
                    throw new ArgumentOutOfRangeException("Customer I must be a positive integer");

            }
                
        }

        public string Name 
        { 
            get
            {
                return name;
            }

             set
            {
                if (value.Length > 0 && value.Length <= 100)
                    name = value;
                else throw new ArgumentOutOfRangeException("Must be at least one Character");
            }
                
                
                
        }

        public string Address 
        {
            get
            {
                return address;
            } 
                
                
            set
            {
                if (value != null)
                    address = value;
                else throw new InvalidOperationException("Must have a street Address");

            }
            
            
        }

        public string City 
        {
            get
            { 
                return city;
            }
                
            set
            {
                if (value != null)
                    city = value;
                else throw new InvalidOperationException("City must entered");
            }
                
                
                
        }

        public string State 
        {
            
            get
            {
                return state;
            }

            set
            {
                if (value != null)
                    state = value;
                else throw new InvalidOperationException("State entered must be two characters");
            }

            

        }

        public string ZipCode 
        {
            get
            {
                return ZipCode;
            }

            set
            {
                if (value == null)
                    throw new InvalidOperationException("Zipcode must be numeric");
                   
              
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
