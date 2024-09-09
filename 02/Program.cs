
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace GoingShopping
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<Person> persons = new List<Person>();
                List<Product> products = new List<Product>();

                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                float wallet = float.Parse(input[1]);
                Person person = new Person(name, wallet);
                persons.Add(person);

                line();

                string[] input1 = Console.ReadLine().Split(' ');
                string Productname = input1[0];
                float cost = float.Parse(input1[1]);
                Product product = new Product(Productname, cost);
                products.Add(product);

                string command = null;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] input2 = command.Split();
                    Person person1 = persons.First(p => p.getName() == input2[0]);
                    Product product1 = products.First(p => p.getProductName() == input2[1]);

                    Console.WriteLine(person1.AddProductToBag(product1));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void line()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
