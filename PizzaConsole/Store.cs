using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole
{
    public class Store
    {
        public void Start()
        {
            Pizza pizza1 = new Pizza("Prosciutto", "Tomatosauce, Cheese, Ham,", 70, "Normal size");
            Pizza pizza2 = new Pizza("Salad", "Tomatosauce, Cheese, Kebab, Salad, Dressing", 78, "Normal size");
            Pizza pizza3 = new Pizza("Mexicana", "Tomatosauce, Cheese, Kebab, Chicken, Jalapenos, Chili, Tacosauce", 83, "Normal size");

            Customer customer1 = new Customer("Jens Jensen", "Jens@gmail.dk", "42656545");
            Customer customer2 = new Customer("Mohammed karim", "mok@gmail.dk", "30536121");
            Customer customer3 = new Customer("Lis kristensen", "LisK@gmail.dk", "12512368");


            Order order1 = new Order("35", "CreditCard", 70, pizza1, customer1);
            Order order2 = new Order("36", "CreditCard", 78, pizza2, customer2);
            Order order3 = new Order("37", "CreditCard", 83, pizza3, customer3);


            


            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);

            

        }
    }
    

}
