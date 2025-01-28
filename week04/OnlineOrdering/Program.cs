using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    // Address class to represent a customer's address
    public class Address
    {
        // Properties
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }

        // Constructor
        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            StreetAddress = streetAddress;
            City = city;
            StateProvince = stateProvince;
            Country = country;
        }

        // Method to check if the address is in the USA
        public bool IsInUSA()
        {
            return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        // Method to return the full address as a string
        public string GetFullAddress()
        {
            return $"{StreetAddress}\n{City}, {StateProvince}\n{Country}";
        }
    }

    // Customer class to represent a customer
    public class Customer
    {
        // Properties
        public string Name { get; set; }
        public Address Address { get; set; }

        // Constructor
        public Customer(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        // Method to check if the customer is in the USA
        public bool IsInUSA()
        {
            return Address.IsInUSA();
        }
    }

    // Product class to represent a product
    public class Product
    {
        // Properties
        public string Name { get; set; }
        public string ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public Product(string name, string productId, double price, int quantity)
        {
            Name = name;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }

        // Method to calculate the total cost of the product
        public double GetTotalCost()
        {
            return Price * Quantity;
        }
    }

    // Order class to represent an order
    public class Order
    {
        // Properties
        private List<Product> Products { get; set; }
        private Customer Customer { get; set; }

        // Constructor
        public Order(Customer customer)
        {
            Customer = customer;
            Products = new List<Product>();
        }

        // Method to add a product to the order
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Method to calculate the total cost of the order
        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (var product in Products)
            {
                totalCost += product.GetTotalCost();
            }

            // Add shipping cost based on customer location
            if (Customer.IsInUSA())
            {
                totalCost += 5; // USA shipping cost
            }
            else
            {
                totalCost += 35; // International shipping cost
            }

            return totalCost;
        }

        // Method to generate a packing label
        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (var product in Products)
            {
                packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
            }
            return packingLabel;
        }

        // Method to generate a shipping label
        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create products
            Product product1 = new Product("Laptop", "P1001", 999.99, 1);
            Product product2 = new Product("Mouse", "P1002", 19.99, 2);
            Product product3 = new Product("Keyboard", "P1003", 49.99, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display order details
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
        }
    }
}