namespace PizzaConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting PizzaStore app");
            Store store = new Store();
            store.Start();

        }

    }
}
