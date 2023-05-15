using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.WriteLine("Calculadora de Kevin Guaña");
            Console.WriteLine("-----------------------");

            Console.Write("Ingrese el Primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la operación que desee realizar (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            Console.Write("Ingrese el Seguno número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: La divicion entre cero no es Valida");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Error: Operacion no reconocida");
                    return;
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + result);
        }
    }
}
