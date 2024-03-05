using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole
{
     public class Customer
    {
        #region Instance fields

        private string _name;
        private string _email;
        private string _phoneNumber;

        #endregion

        #region Constructor
        public Customer(string name , string email, string phonenumber)
        {
            _name = name;
            _email = email;
            _phoneNumber = phonenumber;
       
        }

        #endregion

        #region Properties

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public string Email 
        { 
            get { return _email; } 
            set {  _email = value; } 
        }

        public string Phonenumber 
        { 
            get { return _phoneNumber;}
            set { _phoneNumber = value;}
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Name: {Name}";

        }

        #endregion
    }
}
