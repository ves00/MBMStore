using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        // auto-implemented properties
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        //fields
        private List<string> PhoneNumbers = new List<string>();
        public DateTime Birthdate;
        private int Age;
        //auto-implemnted property
        public List<Invoice> Invoices { get; set; }


        // properties
        public List<string> phoneNumbers
        {
            get { return PhoneNumbers; }
        }        public DateTime birthdate
        {
            get { return Birthdate; }
            set
            {
                DateTime now = DateTime.Now;
                if (value > now || value < now.AddYears(-120))
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    Birthdate = value;
                }
            }
        }        public int age
        {
            get
            {
                DateTime now = DateTime.Now;
                int Age;                Age = now.Year - Birthdate.Year;

                if (now.Month < Birthdate.Month || (now.Month == Birthdate.Month && now.Day < Birthdate.Day))
                {
                    Age--;
                }

                return Age;
            }
        }

        // constructors
        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city, DateTime birthdate)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address = address;
            this.Zip = zip;
            this.City = city;
            this.Birthdate = birthdate;
            this.Age = age;
        }


        // methods
        public void AddPhoneNumber(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }
    }
}
