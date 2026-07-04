using System;

namespace _02_atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstração  de operadores de atribuição em C#
            //int a = 10; // Declaração e inicialização da variável a com o valor 10
            int a = 10;
            Console.WriteLine($"Valor de a: {a}");

            // Operadores de atribuição
            // a = a + 2;
            a += 2;
            Console.WriteLine($"Valor de a após a += 2: {a}");

            //a = a - 2;
            a -= 2;
            Console.WriteLine($"Valor de a após a -= 2: {a}");

            //a *= 3; // Equivalente a = a * 3;
            a *= 3;
            Console.WriteLine($"Valor de a após a *= 3: {a}");

            //a /= 2; // Equivalente a = a / 2; // O operador /= divide o valor de a por 2 e atribui o resultado a 'a'
            a /= 2;
            Console.WriteLine($"Valor de a após a /= 2: {a}");

            //a %= 3; // Equivalente a = a % 3; // O operador %= calcula o resto da divisão de a por 3 e atribui o resultado a 'a'
            a %= 3;
            Console.WriteLine($"Valor de a após a %= 3: {a}");

            string letras = "ABC";
            Console.WriteLine($"Valor de letras: {letras}");

            letras += "DEF"; // Equivalente a letras = letras + "DEF"; // O operador += concatena a string "DEF" ao valor atual de 'letras'
            Console.WriteLine($"Valor de letras após letras += \"DEF\": {letras}");
            Console.WriteLine("----------------------------------");

            // Incremento e Decremento
            int b = 10;
            Console.WriteLine($"Valor de b: {b}");
            b++;
            Console.WriteLine($"Valor de b após b++: {b}"); // Incrementa o valor de b em 1

            int c = 10;
            Console.WriteLine($"Valor de c: {c}");
            c--;
            Console.WriteLine($"Valor de c após c--: {c}"); // Decrementa o valor de c em 1

        }
    }
}