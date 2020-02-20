using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        // constructor
        static Repository()
        {
            // customers
            Customer customer1 = new Customer(0, "Veselin", "Veselinov", "Langgade 65", "8920", "Randers NV", new DateTime(1996, 02, 08));
            Customer customer2 = new Customer(1, "Milan", "Georgiev", "Langgade 4", "8920", "Randers NV", new DateTime(1996, 02, 04));
            Customer customer3 = new Customer(2, "Ivan", "Ivanov", "Molleskovvej 4", "8270", "Hojbjerg", new DateTime(1992, 03, 14));
            Customer customer4 = new Customer(3, "Georgi", "Georgiev", "Holmevej 221", "8270", "Hojbjerg", new DateTime(1995, 10, 03));
            Customer customer5 = new Customer(4, "Todor", "Bojinov", "Holme Byvej 26", "8270", "Hojbjerg", new DateTime(1991, 01, 17));
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);
            Customers.Add(customer5);

            customer1.AddPhoneNumber("(+45) 71797783");
            customer1.AddPhoneNumber("(+45) 71456760");
            customer1.AddPhoneNumber("(+45) 74180569");
            customer2.AddPhoneNumber("(+45) 71807783");
            customer2.AddPhoneNumber("(+45) 71808783");
            customer3.AddPhoneNumber("(+45) 71806583");
            customer3.AddPhoneNumber("(+45) 71124766");
            customer4.AddPhoneNumber("(+45) 55801667");
            customer4.AddPhoneNumber("(+45) 61831870");
            customer4.AddPhoneNumber("(+45) 74646233");
            customer5.AddPhoneNumber("(+45) 61404617");



            // books
            Book book1 = new Book(0, "The Hunger Games:Trilogy", 9.99M, "book0.jpg", "Suzanne Collins", 2008);
            Book book2 = new Book(1, "The Da Vinci Code", 9.49M, "book1.jpg", "Dan Brownn", 2003);
            Book book3 = new Book(2, "Harry Potter: The Prisoner of Azkaban", 29.99M, "book2.jpg", "J. K. Rowling", 1997);
            book1.Category = "Book";
            book2.Category = "Book";
            book3.Category = "Book";
            Products.Add(book1);
            Products.Add(book2);
            Products.Add(book3);


            // movies
            Movie movie1 = new Movie(3, "Need for Speed", 134.00M, "NeedforSpeed.jpg", "Scott Waugh");
            Movie movie2 = new Movie(4, "Deadpool", 187.50M, "deadpool.jpg", "James Gunn");
            Movie movie3 = new Movie(5, "Forrest Gump", 15.50M, "forrest-gump.jpg", "Robert Zemeckis");
            Movie movie4 = new Movie(6, "Gladiator", 11.99M, "gladiator.jpg", "Ridley Scott");
            Movie movie5 = new Movie(7, "Jungle Book", 21.99M, "JungleBook.jpg", "Jon Favreau");
            movie1.Category = "Movie";
            movie2.Category = "Movie";
            movie3.Category = "Movie";
            movie4.Category = "Movie";
            movie5.Category = "Movie";
            Products.Add(movie1);
            Products.Add(movie2);
            Products.Add(movie3);
            Products.Add(movie4);
            Products.Add(movie5);


            // music cds
            MusicCD CD1 = new MusicCD(8, "Revival", 11.39M, "cd1.jpg", "Eminem", 2017);
            MusicCD CD2 = new MusicCD(9, "Southpaw", 16.43M, "cd2.jpg", "Eminem", 2015);
            MusicCD CD3 = new MusicCD(10, "8 Mile", 22.99M, "cd3.jpg", "Eminem", 2002);
            CD1.Category = "MusicCD";
            CD2.Category = "MusicCD";
            CD3.Category = "MusicCD";
            Products.Add(CD1);
            Products.Add(CD2);
            Products.Add(CD3);


            CD1.AddTrack("Walk on Water", "Marshall Mathers", new TimeSpan(0, 5, 04));
            CD1.AddTrack("Believe", "Mathers", new TimeSpan(0, 5, 15));
            CD1.AddTrack("Chloraseptic", "Mathers", new TimeSpan(0, 5, 01));
            CD1.AddTrack("Untouchable", "Mathers", new TimeSpan(0, 6, 10));
            CD1.AddTrack("River", "Mathers", new TimeSpan(0, 3, 41));
            CD1.AddTrack("Framed", "David John Byron", new TimeSpan(0, 4, 13));

            CD2.AddTrack("Kings Never Die", "Marshall Mathers", new TimeSpan(0, 4, 56));
            CD2.AddTrack("Beast (Southpaw Remix)", "Dominick Wickliffe", new TimeSpan(0, 4, 39));
            CD2.AddTrack("This Corner", "Denaun Porter", new TimeSpan(0, 3, 53));
            CD2.AddTrack("What About the Rest of Us", "Jo-Vaughn Virginie", new TimeSpan(0, 4, 12));
            CD2.AddTrack("Raw", "Ryan Montgomery", new TimeSpan(0, 3, 40));
            CD2.AddTrack("R.N.S.", "O'Shea Jackson", new TimeSpan(0, 3, 39));

            CD3.AddTrack("Lose Yourself", "Marshall Mathers", new TimeSpan(0, 5, 20));
            CD3.AddTrack("Love Me", "Mathers", new TimeSpan(0, 4, 30));
            CD3.AddTrack("8 Mile", "Mathers", new TimeSpan(0, 5, 57));
            CD3.AddTrack("Adrenaline Rush", "Andy Thelusma", new TimeSpan(0, 3, 48));
            CD3.AddTrack("Places to Go", "Mathers", new TimeSpan(0, 4, 15));
            CD3.AddTrack("Rap Game", "Mathers", new TimeSpan(0, 5, 53));
            CD3.AddTrack("8 Miles and Runnin", "Shaun Carter", new TimeSpan(0, 4, 08));
            CD3.AddTrack("Spit Shine", "Alvin Joiner", new TimeSpan(0, 3, 39));
            CD3.AddTrack("Wanksta", "Michael Clervoix", new TimeSpan(0, 3, 38));


            // invoices
            Invoice invoice1 = new Invoice(0, new DateTime(2018, 5, 1, 8, 30, 52), customer1);
            Invoice invoice2 = new Invoice(1, DateTime.Now, customer2);
            invoice1.AddOrderItem(CD1, 2);
            invoice1.AddOrderItem(book1, 5);
            invoice1.AddOrderItem(movie5, 5);
            invoice2.AddOrderItem(movie1, 1);
            invoice2.AddOrderItem(movie3, 1);
            invoice2.AddOrderItem(CD1, 1);
            invoice2.AddOrderItem(CD2, 1);
            invoice2.AddOrderItem(CD3, 1);

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
        }
    }
}

