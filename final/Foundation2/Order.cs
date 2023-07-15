using System;
using System.Collections.Generic;

namespace Foundation2{
    public class Order{
        private Customer currentCostumer = new Customer();
        private Product currentProdcut = new Product();
        private List<Product> productList = new List<Product>();
        public void addToProductList(Product newProduct){
            productList.Add(newProduct);
        }
        public void storeCurrentCustomer(Customer person){
            currentCostumer = person;
        }
        public double calcTotalCost(){
            double totalCost = 0;
            foreach(Product theProdcut in productList){
                totalCost += theProdcut.getTotalPrice();
                //Console.WriteLine(theProdcut.getTotalPrice());
            }
            if (currentCostumer.USAFinder() == true){
                totalCost += 5;
            }
            else{
                totalCost += 35;
            }
            return totalCost;
        }
        public string shippingLabel(){
            string shippingLabel = currentCostumer.getShippingAddress();
            return shippingLabel;
        }
        public string packingLabel(){
            string packingLabel = "";
            foreach(Product currentProdcut in productList){
                string name = currentProdcut.getName();
                int id = currentProdcut.getProductId();
                int quantity = currentProdcut.getQuantity();
                packingLabel += (name + ": ID number " + id + ": Amount ordered: (" + quantity + ")\n");
            }

            return packingLabel;
        }
    }
}