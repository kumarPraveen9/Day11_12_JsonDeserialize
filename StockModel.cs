using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class StockModel
    {
        public List<CommonStocks> commonStocks;
        public List<PreferredStocks> preferredStocks;
        public List<HybridStocks> hybridStocks;

    }

    public class PreferredStocks
    {
        public string sharename;
        public int numberOfShare;
        public int sharePrice;
    }

    public class CommonStocks
    {
        public string sharename;
        public int numberOfShare;
        public int sharePrice;
    }

    public class HybridStocks
    {
        public string sharename;
        public int numberOfShare;
        public int sharePrice;
    }

 
}
