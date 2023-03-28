namespace Dars_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int long_Number = 0;
            string longstr = "";
            int Number2 = 0;
            
            do
            {   
                enter_number:
                Console.WriteLine("Enter number : ");
                string enter_string = Console.ReadLine();
                bool check1 = int.TryParse(enter_string, out  Number2);
                if (!check1)
                {
                    Console.WriteLine($"Error : {enter_string}");
                    Console.WriteLine("Try Again ! ");
                    goto enter_number;
                }
                else
                {
                    int enter_long_Number = 0;
                    for (int i = 0; i <= enter_string.Length; i++)
                    {
                        enter_long_Number++;
                    }
                    if (long_Number < enter_long_Number)
                    {
                        longstr = enter_string;
                        long_Number = enter_long_Number;                       
                    }
                }
            } while (Number2 != 0);            
                 Console.WriteLine($"Long Number : {longstr}");                    
        }
    }  
 }

