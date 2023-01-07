using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class stockAccount
    {
        private string filename;
        public  List<Commpanyshares> share=new List<Commpanyshares>();
        private int amount1;
        private string symbol1;
        public stockAccount(string filename)
        {
            this.filename = filename;
            
        }
        public string to_string()
        {
          return "the filename is : "+this.filename;
        }
        public void addAccount()
        { 
           Commpanyshares commpanyshares=new Commpanyshares();
            Console.WriteLine("enter the stock symbol");
            commpanyshares.symbol = Console.ReadLine();
            Console.WriteLine("enter the stock numberof shares");
            commpanyshares.numberOfshares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the DateTime");
            commpanyshares.DateTime = Console.ReadLine();
            share.Add(commpanyshares);

        }
        public void printReport()
        {
            foreach(var i in share)
            {
                Console.WriteLine(i.symbol);
                Console.WriteLine(i.numberOfshares);
                Console.WriteLine(i.DateTime);
                Console.WriteLine("------------------");
            }
        }

        public void valueOf()
        {
            Console.WriteLine("enter the value of symbol to display");
            string val=Console.ReadLine();
          
            foreach(var i in share)
            {
                if(i.symbol==val)
                {
                    Console.WriteLine(i.symbol);
                    Console.WriteLine(i.numberOfshares);
                    Console.WriteLine(i.DateTime);

                }
            }
        }

        public void buy(int amount, string symbol)
        {
            amount1= amount;
            symbol1 = symbol;
            buy1();
        }
         public void buy1()
        { 
            int temp = 0;
            
            Commpanyshares com1 = new Commpanyshares();
            foreach (var i in share)
            {
                if (i.symbol == symbol1)
                {
                    temp=i.numberOfshares;
                    
                    i.numberOfshares = amount1 + temp;
                    Console.WriteLine("\nupdated value of amount to buy the share to accout is : {0}",i.numberOfshares);
                    
                }
            }
        }
        public void sell(int amount, string symbol)
        {

            amount1 = amount;
            symbol1 = symbol;
            sell1();
        }
        public void sell1()
        {
            int temp1 = 0;

            Commpanyshares com1 = new Commpanyshares();
            foreach (var i in share)
            {
                if (i.symbol == symbol1)
                {
                    temp1=i.numberOfshares;

                    i.numberOfshares = temp1-amount1;
                    Console.WriteLine("\nupdated value of amount to sell the share to accout is : {0}", i.numberOfshares);

                }
            }
        }

    }
}
