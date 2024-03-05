using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole
{
    public class Pizza
    {
        #region Instance fields
        private string _name;
        private string _topping;
        private int _price;
        private string _size;


        #endregion

        #region Constructor
        public Pizza(string name, string topping, int price, string size)
        {
            _name = name; 
            _topping = topping;
            _price = price;
            _size = size;

        }


        #endregion

        #region Properties
        
        public string Name 
        {  
            get { return _name; } 
            set { _name = value; }
        }
        
        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Name: {Name} - Price: {Price}";

        }

        #endregion
    }
}
