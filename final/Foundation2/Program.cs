using System;
using System.Collections.Generic;

namespace Foundation2{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Order> shippingOrder = new List<Order>();
            // initialize products
            Product milk = new Product();
            milk.storeName("Milk");
            milk.storePrductId(123);
            milk.storeIndividualPrice(3.89);
            Product eggs = new Product();
            eggs.storeName("Eggs");
            eggs.storePrductId(963);
            eggs.storeIndividualPrice(2.50);
            Product bread = new Product();
            bread.storeName("Bread");
            bread.storePrductId(456);
            bread.storeIndividualPrice(1.25);
            Product TV = new Product();
            TV.storeName("TV");
            TV.storePrductId(789);
            TV.storeIndividualPrice(559.99);
            Customer Salley = new Customer();
            Salley.storeName("Salley Fraser");
            Salley.storeStreetAddress("123 W 456 S");
            Salley.storeCity("Rexburg");
            Salley.storeState("Idaho");
            Salley.storeCountry("USA");
            Order order1 = new Order();
            order1.storeCurrentCustomer(Salley);
            milk.storeQuantity(2);
            order1.addToProductList(milk);
            eggs.storeQuantity(4);
            order1.addToProductList(eggs);
            Customer Bob = new Customer();
            Bob.storeName("Bob Bagget");
            Bob.storeStreetAddress("456 W 789 S");
            Bob.storeCity("Paris");
            Bob.storeCountry("France");
            Order order2 = new Order();
            order2.storeCurrentCustomer(Bob);
            bread.storeQuantity(5);
            order2.addToProductList(bread);
            TV.storeQuantity(1);
            order2.addToProductList(TV);
            milk.storeQuantity(2);
            order2.addToProductList(milk);

            // testing my fuctionality
            //Console.WriteLine(order1.calcTotalCost());
            //Console.WriteLine(order2.calcTotalCost());
            //Console.WriteLine(order1.packingLabel());
            //Console.WriteLine(order2.packingLabel());
            //Console.WriteLine(order1.shippingLabel());
            //Console.WriteLine(order2.shippingLabel());
            shippingOrder.Add(order1);
            shippingOrder.Add(order2);
            foreach(Order currentOrder in shippingOrder){
                Console.WriteLine("Order for address: \n" + currentOrder.shippingLabel() + "\n");
                Console.WriteLine("Order contains: \n" + currentOrder.packingLabel() + "\n");
                Console.WriteLine("The total cost of order is: $" + currentOrder.calcTotalCost() + "\n");
            }
            
        }
    }
}