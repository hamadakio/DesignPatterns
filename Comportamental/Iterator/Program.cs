using System;

namespace Iterator
{
    class Program
    {
        //fornece uma maneira de acessar os elementos de um objeto agregado sequencialmente 
        //sem expor sua representacao subjacente
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "Item1";
            aggregate[1] = "Item2";
            aggregate[2] = "Item3";
            aggregate[3] = "Item4";

            Iterator iterator = aggregate.CreateIterator();

            Console.WriteLine("Interagindo com a coleçao :");
            object item = iterator.First();

            while (item != null)
            {
                Console.WriteLine(item);
                Console.WriteLine("---{0}", iterator.CurrentItem()); ;
                item = iterator.Next();
            }

        }
    }
}
