using StockManagement;

namespace StockManagement
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            int z = 1;


            int total = 0, total1 = 0, total2 = 0;
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
                total1 += val;
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
                total2 += val;
                Console.WriteLine("The total stcok for " + Info.hybridStocks[i].numberOfShare + " share is : " + val);
                Console.WriteLine();

            }
            Console.WriteLine("The  total value for Hybrid Stocks is : {0}", total2);
            Console.WriteLine();
           
            
            
            
            
            Console.WriteLine("enter the filename to accout");
            string fileName = Console.ReadLine();

            stockAccount stock49 = new stockAccount(fileName);
            Console.WriteLine(stock49.to_string());


            while (z > 0)
            {
                Console.WriteLine("\nEnter a number to do which operation:");
                Console.WriteLine("1)addAccount\t2)printReport\t3)valueOf\t4)buy\t5)sell\t6)EXIT");
                int r = Convert.ToInt32(Console.ReadLine());


                switch (r)
                {
                    case 1:
                        stock49.addAccount();
                        break;
                    case 2:
                        stock49.printReport();

                        break;

                    case 3:
                        stock49.valueOf();
                        break;
                    case 4:
                        Console.WriteLine("enter the value of symbol to add the share to accout");
                        string val = Console.ReadLine();
                        Console.WriteLine("enter the value of amount to add the share to accout");
                        int n = Convert.ToInt16(Console.ReadLine());
                        stock49.buy(n,val);
                        break;
                    case 5:
                        Console.WriteLine("enter the value of symbol to sell the share to accout");
                        string vall = Console.ReadLine();
                        Console.WriteLine("enter the value of amount to sell the share to accout");
                        int n1 = Convert.ToInt16(Console.ReadLine());
                        stock49.sell(n1, vall);
                        break;
                    case 6:
                        z = 0;
                        break;
                    default:
                        Console.WriteLine("Oops a valid number to do which operation:");
                        break;

                }
            }
        }
    
    }
}
