using System;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator();
        }
        static void SimpleCalculator()
        {
            while (true)
            {
                try
                {
                    int a = AskForANumber();
                    
                    if (a == -1)
                    {
                        return;
                    }
                    char op = AskForAnOperation();
                    if (op == 'q')
                    {
                        return;
                    }

                    int b = AskForANumber();
                    if (b == -1)
                    {
                        return;
                    }
                
                    Console.WriteLine($"The result is {Calculate(op, a, b)}");
                    Console.WriteLine($" ");
                    Console.WriteLine($"---------------- Ú J ----------------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"----> Error message: {ex.Message}");
                }
            }
        }

        //private static int AskForANumber()
        //{
        //    int result = 0;
        //    while (true)
        //    {
        //        Console.WriteLine("Please provide a number or quit -1: ");
        //        var input = Console.ReadLine();
        //            result = int.Parse(input);
        //            break;                   
        //    }
        //    return result;
        //}

        private static int AskForANumber()
        {
            int result = 0;
            Console.WriteLine("Please provide a number or quit -1: ");
            while (!int.TryParse(Console.ReadLine(), out result))
            { 
                Console.WriteLine("Invalid input. Please provide a number!");
            }
            return result;
        }


    private static char AskForAnOperation()
        {
            while (true) 
            {
                Console.WriteLine("Please provide an operator (one of +, -, *, /)!  quit - q");
                var input = Console.ReadLine();
                var result  = char.Parse(input);
                
                if (result != '+' && result != '-' && result != '*' && result != '/' &&  result != 'q' )
                {
                    Console.WriteLine($"----> Error message:  ({result}) value is not +,  -, *, /!");
                    continue;
                }     
                return result;
            }
            //throw new NotImplementedException();
        }

        private static int Calculate(char p_op, int p_a, int p_b)
        {
            int result = 0;
            
            switch (p_op)
            {
                case '+':                    
                    result = p_a + p_b;
                    break;
                case '-':
                    result = p_a - p_b;
                    break;
                case '*':
                    result = p_a * p_b;
                    break;
                case '/':
                        result = p_a / p_b;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
            
        }
    }
}
