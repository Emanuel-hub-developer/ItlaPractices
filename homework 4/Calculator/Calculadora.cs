using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   
        class Calculadora
        {
            private List<decimal> typedNumbers = new List<decimal>();

            public void DisplayHeader()
            {
                Console.WriteLine("Please Type the option number that you want");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Sum, \n2. Subtract,  \n3. Multiplication,  \n4. Division,  \n5. Exit");
            }

            public decimal Sum()
            {
                decimal result = 0;
                foreach (decimal number in typedNumbers)
                {
                    result += number;
                }
                return result;
            }

            public decimal Subtract()
            {
                if (typedNumbers.Count == 0) return 0;
                decimal result = typedNumbers[0];
                for (int i = 1; i < typedNumbers.Count; i++)
                {
                    result -= typedNumbers[i];
                }
                return result;
            }

            public decimal Multiply()
            {
                if (typedNumbers.Count == 0) return 0;
                decimal result = 1;
                foreach (decimal number in typedNumbers)
                {
                    result *= number;
                }
                return result;
            }

            public decimal Divide()
            {
                if (typedNumbers.Count == 0) return 0;
                decimal result = typedNumbers[0];
                for (int i = 1; i < typedNumbers.Count; i++)
                {
                    if (typedNumbers[i] == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    result /= typedNumbers[i];
                }
                return result;
            }

            public void ClearNumbers()
            {
                typedNumbers.Clear();
            }

            public void AddNumber(decimal number)
            {
                typedNumbers.Add(number);
            }
        }
    }
    

