using System;

namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, i,n, c = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for( i = 0; i <n; i++)
            {
                string[] st = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(st[0]);
                y = Convert.ToInt32(st[1]);
                z = Convert.ToInt32(st[2]);

                if ((x == 1 && y == 1 && z == 1) ||
                (x == 0 && y == 1 && z == 1) ||
                (x == 1 && y == 1 && z == 0) ||
                (x == 1 && y == 0 && z == 1))
                    c = c + 1;

            }
            Console.WriteLine(c);
            
        }
    }
}
