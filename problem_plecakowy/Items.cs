using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_plecakowy
{
    internal class Items
    {
        public int item_id;
        public int item_weight;
        public int item_value;
        public Items(int item_id, int weight, int value)
        {
            this.item_id = item_id;
            item_weight = weight;
            item_value = value;
        }

    }
}
