namespace AnimalFerm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Chicken chicken = new Chicken(name, age);
            if (age > 5 && age < 15)
            {
                Console.WriteLine(
                    "Chicken {0} (age {1}) can produce {2} eggs per day.",
                    name,
                    age,
                    chicken.ProductPerDay());
            }
            else
            {
                Console.WriteLine("Age should be between 0 and 15.");
            }


        }
    }
}
