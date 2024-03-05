using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaConsole
{
    public class Order
    {
        #region Instance fields

        private string _orderNumber;
        private string _paymentMethod;
        private int _pizzaPrice;
        private int _deliverycost;
        private double _totalPrice;
        Pizza pizza;
        Customer customer;


        #endregion

        #region Constructor

        public Order(string orderNumber, string paymentMethod, int pizzaPrice, Pizza p, Customer c)
        {
            _orderNumber = orderNumber;
            _paymentMethod = paymentMethod;
            _pizzaPrice = pizzaPrice;
            _deliverycost = 40;
            _totalPrice = 0;
            this.pizza = p;
            this.customer = c;
        }

        #endregion

        #region Properties

        public string OrderNumber
        {
            get { return _orderNumber; }
            set { _orderNumber = value; }
        }

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }  

        public int PizzaPrice
        {
            get { return _pizzaPrice; }
            set { _pizzaPrice = value; }
        }

        public int Delivery 
        { 
            get { return _deliverycost; } 
            set {  _deliverycost = value; } 
        }

        public double TotalPrice 
        { 
            get { return _totalPrice; } 
            set { _totalPrice = value;} 
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Customer: {customer.Name} - Pizza: {pizza.Name} - Pizzacost: {pizza.Price} DKK - Deliverycost: {Delivery} DKK - Total: {CalculateTotalPrice()} DKK";

        }

        public double CalculateTotalPrice()
        {
            return pizza.Price + Delivery;
        }

        #endregion
    }
}
