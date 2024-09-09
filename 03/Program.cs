namespace _03
{
    class Program
    {
        static void Main()
        {
            try
            {
                string[] input2 = Console.ReadLine().Split(' ');
                string pizza = input2[0];
                string NamePizza = input2[1];

                // ------------------------------------------------- // 

                string[] input = Console.ReadLine().Split(' ');

                string name = input[0];
                string typeofflour = input[1];
                string BakingTechnique = input[2];
                float weight = float.Parse(input[3]);

                Dough dough = new Dough(typeofflour, BakingTechnique, weight);
                dough.Weight = weight;
                dough.BAKING = BakingTechnique;
                dough.TYPE = typeofflour;

                float total = dough.CaloriesToGram();

                // ------------------------------------------------- // 

                string command = null;
                int count = 0;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] input1 = command.Split(' ');
                    string name1 = input1[0];
                    string topping = input1[1];
                    float weight1 = float.Parse(input1[2]);

                    if (count >= 10)
                    {
                        Console.WriteLine("Number of toppings should be in range [0..10].");
                        break;
                    }            

                    Topping toppings = new Topping(topping, weight1);
                    toppings.TOPPING = topping;
                    toppings.WEIGHT = weight1;

                    float total1 = toppings.Calculation();
                    total += total1;

                    count++;         
                }
                if (count != 10)
                {
                    Console.WriteLine($"Pizza {NamePizza} - {total} Calories.");
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}