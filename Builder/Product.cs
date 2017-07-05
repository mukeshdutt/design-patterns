using System.Collections.Generic;

namespace Builder
{
    // Product
    public class Vehicle
    {
        public string Body { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();            
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Model : {Model}");
            System.Console.WriteLine($"Body : {Body}");
            System.Console.WriteLine($"Engine : {Engine}");
            System.Console.WriteLine($"Transmission : {Transmission}");
            System.Console.WriteLine("Accessories :");

            foreach (var item in Accessories)
            {
                System.Console.WriteLine($"\t {item}");
            }
        }
    }
}