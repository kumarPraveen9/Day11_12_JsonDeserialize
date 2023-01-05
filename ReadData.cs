using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockManagement
{
    public class ReadData
    {

        public StockModel Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockModel>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
         }


    }
}
