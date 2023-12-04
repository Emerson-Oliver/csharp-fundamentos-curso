using System;

namespace ExercicioResolvido1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;

            string[] s1 = Console.ReadLine().Split(' ');
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);

            A = new int[M, N];

            for (int index=0; index <M; index +=1)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j=0; j<N; j +=1)
                {
                    A[index, j] = int.Parse(s[j]);
                }
            }

            for (int index=0; index<M; index +=1)
            {
                for(int j=0; j<N; j +=1)
                {
                    Console.Write(A[index, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
