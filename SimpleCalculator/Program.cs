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
            int a = AskForANumber();
            char op = AskForAnOperation();
            int b = AskForANumber();
            Console.WriteLine($"The result is {Calculate(op, a, b)}");
        }

        private static int AskForANumber()
        {
            int pnumberx = 0;
            while (true)
            {
                Console.WriteLine("Please provide a number! ");
                var input = Console.ReadLine();
                try
                {
                    pnumberx = int.Parse(input);
                    break;                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Message : {ex.Message}");
                }
            }
            return pnumberx;
        }
        
        
        private static char AskForAnOperation()
        {
            while (true) 
            {
                Console.WriteLine("Please provide an operator (one of +, -, *, /)!");
                var input = Console.ReadLine();
                var operatorx = char.Parse(input);
                if (operatorx !='+' && operatorx!= '-' && operatorx != '*' && operatorx != '/')
                {
                    Console.WriteLine("Error message:  (value is not +, -, *, /)!");
                    continue;
                }     
                return operatorx;
            }
            //throw new NotImplementedException();
        }

        private static int Calculate(char op, int a, int b)
        {
            int result = 0;
            
            switch (op)
            {
                case '+':                    
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
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
