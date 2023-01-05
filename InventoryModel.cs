using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryListManangement
{
    public class InventoryModel
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPuslses> typesOfPulses;
        public List<TypesOfWheat> typesOfWheat;

    }

    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfPuslses
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }


} 
