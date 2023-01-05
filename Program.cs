using StockManagement;

namespace StockManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            int total = 0,total1=0,total2=0;
            string path = "D:\\BridgeLabz\\RegularBatch\\VS_Code(programs)\\StockManagement\\Stock.json";
            ReadData obj = new ReadData();
            var Info = obj.Read(path);

           
            Console.WriteLine("--------------------");

            Console.WriteLine("Common Stock share : ");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Info.commonStocks.Count; i++)
            {
                Console.WriteLine(Info.commonStocks[i].sharename);
                Console.WriteLine(Info.commonStocks[i].numberOfShare);
                Console.WriteLine(Info.commonStocks[i].sharePrice);

                int val = Info.commonStocks[i].numberOfShare * Info.commonStocks[i].sharePrice;
                total += val;
                Console.WriteLine("The total stcok for " + Info.commonStocks[i].numberOfShare + " shares is : " + val);
                Console.WriteLine();
                
            }
            Console.WriteLine("The  total value for Common Stocks is : {0}", total);
            Console.WriteLine();
            
            Console.WriteLine("--------------------");
            Console.WriteLine("Preferred Stock share : ");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Info.preferredStocks.Count; i++)
            {
                Console.WriteLine(Info.preferredStocks[i].sharename);
                Console.WriteLine(Info.preferredStocks[i].numberOfShare);
                Console.WriteLine(Info.preferredStocks[i].sharePrice);

                int val = Info.preferredStocks[i].numberOfShare * Info.preferredStocks[i].sharePrice;
                total1+= val;
                Console.WriteLine("The  total stcok for " + Info.preferredStocks[i].numberOfShare + " share is : " + val);
                Console.WriteLine();
            
            }
            Console.WriteLine("The  total value for Preferred Stocks is : {0}", total1);
            Console.WriteLine();


            Console.WriteLine("--------------------");
            Console.WriteLine("Hybrid Stock share : ");
            Console.WriteLine("--------------------");

            for (int i = 0; i < Info.hybridStocks.Count; i++)
            {
                Console.WriteLine(Info.hybridStocks[i].sharename);
                Console.WriteLine(Info.hybridStocks[i].numberOfShare);
                Console.WriteLine(Info.hybridStocks[i].sharePrice);

                int val = Info.hybridStocks[i].numberOfShare * Info.hybridStocks[i].sharePrice;
                total2+= val;
                Console.WriteLine("The total stcok for " + Info.hybridStocks[i].numberOfShare + " share is : " + val);
                Console.WriteLine();
                
            }
            Console.WriteLine("The  total value for Hybrid Stocks is : {0}", total2);
            Console.WriteLine();
        }
    }
}