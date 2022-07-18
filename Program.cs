using System;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X Position: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y Position: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Runner p = new Runner(x,y);
            char[,] arr = new char[5,5];
            Console.Clear();
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    arr[i, j] = 'X';
                }
            }
            while(true)
            {
                arr[p.x, p.y] = 'O';
                if (p.x <= 3)
                {
                    p.RunX();
                }
                else if (p.x == 4 && p.y !=4)
                {
                    p.x = 0;
                    p.RunY();
                }
                else if (p.y == 4 && p.x == 4)
                {
                  for(int i=0;i<5;i++)
                    {
                        for (int j = 0; j < 5;j++)
                        {
                            arr[i, j] = 'X';
                            p.RunR();
                        }
                    }
                }
                for(int i=0;i<5;i++)
                {
                    for(int j=0;j<5;j++)
                    {
                        Console.Write(arr[i,j]+" ");
                    }
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(1000);
                Console.Clear();                
            }
        }
    }
}
