using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryListManangement
{
    public class ReadData
    {

        public InventoryModel Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryModel>(json);

                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

 
    }
}
