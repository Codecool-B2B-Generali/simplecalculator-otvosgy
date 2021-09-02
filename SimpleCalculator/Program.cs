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

                int a = AskForANumber();
                if (a == 0)
                {
                    return;
                }
                char op = AskForAnOperation();
                if (op == 'q')
                {
                    return;
                }

                int b = AskForANumber();
                if (b == 0)
                {
                    return;
                }
                Console.WriteLine($"The result is {Calculate(op, a, b)}");
            }
        }

        private static int AskForANumber()
        {
            int result = 0;
            while (true)
            {
                Console.WriteLine("Please provide a number: ");
                var input = Console.ReadLine();
                try
                {
                    result = int.Parse(input);
                    break;                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"----> Error message: {ex.Message}");
                }
            }
            return result;
        }
        
        
        private static char AskForAnOperation()
        {
            while (true) 
            {
                Console.WriteLine("Please provide an operator (one of +, -, *, /)!  quit - q");
                var input = Console.ReadLine();
                var result = char.Parse(input);
                if (result != '+' && result != '-' && result != '*' && result != '/' &&  result != 'q' )
                {
                    Console.WriteLine($"----> Error message:  ({result}) value is not +, -, *, /!");
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
            // throw new NotImplementedException();
        }
    }
}
