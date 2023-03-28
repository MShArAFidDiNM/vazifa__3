namespace find_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Row : ");
            int row, col;
            row = int.Parse(Console.ReadLine());
            Console.Write("Col : ");
            col = int.Parse(Console.ReadLine());
            int h, m;
            h = (row / 2) ;
            m = (col / 2) ;
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if ((!(i==j &&i + j== col-1))&&(i == h || j == m ))
                    {
                    Console.Write(" * ");
                    }
                    else
                    {
                       Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}