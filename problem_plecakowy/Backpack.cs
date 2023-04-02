using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Testy problem plecakowy"), InternalsVisibleTo("aplikacja_okienkowa")] 

namespace problem_plecakowy
{
    internal class Backpack
    {
        int capacity;
        public List<Items> lista;
        public int packed_weight;
        public Backpack(int howmanyitems, int capacity)
        {
            lista = new List<Items>();
            var random = new Random();
            for (int i = 0; i < howmanyitems; i++)
            {
                lista.Add(new Items(i, random.Next(1, 30), random.Next(0, 1200)));
            }
            this.capacity = capacity;
        }

        /*public void WriteToConsole()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].item_id + " " + lista[i].item_weight + " " + lista[i].item_value + "\n");
            }
        }*/

        public override string ToString()
        {
            string str = "";
            foreach (var item in lista)
            {
                str += "id: " + item.item_id + "     " + "waga: " + item.item_weight + "      " + "wartosc: " + item.item_value + Environment.NewLine;
            }
            return str;
        }

        public int getvalue(int index)
        {

            return lista[index].item_value;
        }
        public void sort(int howmanyitems)
        {
            lista = lista.OrderByDescending(item => item.item_value).ToList();
            /*var sorted_list = new List<Items>();
            sorted_list.Add(new Items(lista[0].item_id, lista[0].item_weight, lista[0].item_value));
            for (int j = 0; j < lista.Count; ++j) 
            {
                sorted_list.Add(new Items(lista[j].item_id, lista[j].item_weight, lista[j].item_value));
                for (int i = 0; i < sorted_list.Count - 2; ++i)
                {
                    Console.WriteLine(i);
                    if (lista[i + 1].item_value > lista[i].item_value)
                    {
                        sorted_list[i].item_value = lista[i + 1].item_value;
                        sorted_list[i].item_weight = lista[i + 1].item_weight;
                        sorted_list[i].item_id = lista[i + 1].item_id;
                        sorted_list[i+1].item_value = lista[i].item_value;
                        sorted_list[i+1].item_weight = lista[i].item_weight;
                        sorted_list[i+1].item_id = lista[i].item_id;

                    }
                    else
                    {
                        sorted_list[i].item_value = lista[i].item_value;
                        sorted_list[i].item_weight = lista[i].item_weight;
                        sorted_list[i].item_id = lista[i + 1].item_id;
                        sorted_list[i + 1].item_value = lista[i+1].item_value;
                        sorted_list[i + 1].item_weight = lista[i+1].item_weight;
                        sorted_list[i + 1].item_id = lista[i + 1].item_id;
                    }
                }
            }
            lista.Clear();
            lista.AddRange(sorted_list);*/
            //lista = sorted_list.ToList();
        }

        public void packing(int howmanyitems)
        {
            int actual_weight = 0;
            int i = 0;
            List<Items> packed_items = new List<Items>();
            for(actual_weight = 0;  actual_weight < capacity && i<lista.Count ; ++lista[i].item_weight,++i)
            {
                if (actual_weight + lista[i].item_weight <= capacity)
                {
                    actual_weight = actual_weight + lista[i].item_weight;
                    packed_items.Add(new Items(lista[i].item_id, lista[i].item_weight, lista[i].item_value));
                }
            }
            packed_weight = actual_weight;
            Backpack spakowany = new Backpack(howmanyitems, capacity);
            spakowany.lista.Clear();   
            spakowany.lista.AddRange(packed_items);
            Console.WriteLine(spakowany);
            Console.WriteLine("Ostateczna waga plecaka: " + packed_weight);
        }


    }
}
