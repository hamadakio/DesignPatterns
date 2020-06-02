using System;

namespace Strategy
{
    class Program
    {   //encapsula um algoritimo dentro de uma classe
        static void Main(string[] args)
        {
            SortedList students = new SortedList();

            students.Add("Aluno1");
            students.Add("Aluno3");
            students.Add("Aluno5");
            students.Add("Aluno4");
            students.Add("Aluno2");

            students.setSortStrategy(new QuickSort());
            students.Sort();

            students.setSortStrategy(new ShellSort());
            students.Sort();

            students.setSortStrategy(new MergeSort());
            students.Sort();

        }
    }
}
