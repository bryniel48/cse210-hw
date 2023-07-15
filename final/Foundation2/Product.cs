using System;
using System.Collections.Generic;

namespace Foundation2{
    public class Product{
        private string name;
        private int productId;
        private double idvPrice;
        private double totalProductPrice;
        private int quantity;

        public void storeName(string _name){
            name = _name;
        }
        public void storePrductId(int _productId){
            productId = _productId;
        }
        public void storeIndividualPrice(double _idvPrice){
            idvPrice = _idvPrice;
        }
        public void storeTotalPrice(){
            priceOfProduct();
        }
        public void storeQuantity(int _quantity){
            quantity = _quantity;
        }
        public string getName(){
            return name;
        }
        public int getProductId(){
            return productId;
        }
        public double getIndividualPrice(){
            return idvPrice;
        }
        public double getTotalPrice(){
            priceOfProduct();
            return totalProductPrice;
        }
        public int getQuantity(){
            return quantity;
        }

        public void priceOfProduct(){
            double __idvPrice = getIndividualPrice();
            int __quantity = getQuantity();
            double _price = __idvPrice * __quantity;
            totalProductPrice = _price;
        }
    }
}
