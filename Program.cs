using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Aprendendo{
    class Program {
        static void Main(string[] args) {
        
            segundoGrau();

            Console.Write("Digite sua idade: ");
            var idade = int.Parse(Console.ReadLine());
            if (idade >= 1 && idade <= 12) {
                Console.WriteLine("Criança");
            } else if (idade > 12 && idade <= 18) {
                Console.WriteLine("Adolescente");
            } else if (idade > 18 && idade <= 50) {
                Console.WriteLine("Adulto");
            } else {
                Console.WriteLine("Idoso");
            }
            
            Console.ReadLine();
        }


        static void segundoGrau(){

            Console.WriteLine("Vamos calcular a faunção do segundo grau!!");
            
            // Valor de delta
            Console.Write("Digite o valor de A: ");
            var A = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            var B = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            var C = float.Parse(Console.ReadLine());

            //DELTA CALCULO
            double b = Math.Pow(B, 2);
            var c = -4 * (A * C);
            var delta = b + c;
            Console.WriteLine("Delta = " + delta);

            // CALCULO BHASKARA
            Console.Write("Digite o valor de B: ");
            var b2 = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de delta: ");
            var delta2 = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de A: ");
            var a2 = float.Parse(Console.ReadLine());

            //CALCULO X1 E X2
            var b22 = -b2 - Convert.ToSingle(Math.Sqrt(delta2));
            var ar = 2 * a2;
            var res = b22 / ar;
            Console.WriteLine("X1 = " + res);

            var b23 = -b2 + Convert.ToSingle(Math.Sqrt(delta2));
            var ar1 = 2 * a2;
            var res1 = b23 / ar1;
            Console.WriteLine("X1 = " + res1);
           
           

        }

        
       
    }
}
