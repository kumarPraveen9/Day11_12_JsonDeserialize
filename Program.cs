namespace InventoryJson1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "D:\\BridgeLabz\\RegularBatch\\VS_Code(programs)\\InventoryJson1\\Inventory.json";
            ReadData obj = new ReadData();
            var Data = obj.Read(path);

           
            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Rice is:");
            Console.WriteLine("--------------------");
           
                Console.WriteLine(Data.typesOfRice.name);
                Console.WriteLine(Data.typesOfRice.weight);
                Console.WriteLine(Data.typesOfRice.price);

            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Pulses is:");
            Console.WriteLine("--------------------");

            Console.WriteLine(Data.typesOfPulses.name);
            Console.WriteLine(Data.typesOfPulses.weight);
            Console.WriteLine(Data.typesOfPulses.price);





            Console.WriteLine("--------------------");

            Console.WriteLine("Types of Wheat is:");
            Console.WriteLine("--------------------");
            Console.WriteLine(Data.typesOfWheat.name);
            Console.WriteLine(Data.typesOfWheat.weight);
            Console.WriteLine(Data.typesOfWheat.price);


        }

    }
}