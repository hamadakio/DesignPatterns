using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy SortStrategy;

        public void setSortStrategy(SortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        public void Add(string nome)
        {
            _list.Add(nome);
        }

        public void Sort()
        {
            SortStrategy.Sort(_list);

            foreach (string item in _list)
            {
                Console.WriteLine(" {0} \n",item);
            }
        }


    }
}
