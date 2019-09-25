using System;

namespace ConsoleApp1
{
    class Program
    {
        private int[,,] mat;

        public void Cargar(int n)
        {
            
            mat = new int[n, n,n];
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    for (int z = 0; z < n; z++)
                    {
                        mat[x, y, z] = 0;
                    }
                    
                }
            }
        }

        public void Imprimir()
        {
            for (int x = 0; x < mat.GetLength(0); x++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    for (int z = 0; z < mat.GetLength(2); z++)
                    {
                        Console.Write(mat[x, y,z] + " ");
                    }
                        
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar(3);
            ma.Imprimir();
            Console.ReadKey();
        }
    }
}
