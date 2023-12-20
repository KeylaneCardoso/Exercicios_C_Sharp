using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_C_Sharp.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}\n");
        }

        public void Somar(double x, double y){
            Console.WriteLine($"{x} + {y} = {x + y}\n");
        }

        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}\n");
        }

        public void Subtrair(double x, double y){
            Console.WriteLine($"{x} - {y} = {x - y}\n");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} x {y} = {x*y}\n");
        }

        public void Multiplicar(double x, double y){
            Console.WriteLine($"{x} x {y} = {x*y}\n");
        }

        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x/y}\n");
        }

        public void Dividir(double x, double y){
            Console.WriteLine($"{x} / {y} = {x/y}\n");
        }

        public void Potencia(int x, int y){
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}\n");
        }

        public void RaizQuadrada(double x){
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Sqrt(x)}\n");
        }

        public void Seno(double a){
            double radiano = a * Math.PI / 180;
            Console.WriteLine($"O seno de {a} é {Math.Sin(radiano)}\n");
        }

        public void Coseno(double a){
            double radiano = a * Math.PI / 180;
            Console.WriteLine($"O Coseno de {a} é {Math.Cos(radiano)}\n");
        }

        public void Tangente(double a){
            double radiano = a * Math.PI / 180;
            Console.WriteLine($"A Tangente de {a} é {Math.Tan(radiano)}\n");
        }

        public void FuncaoQuadrada(double a, double b, double c){
            double delta = (Math.Pow(b, 2)) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta))/2*a;
            double x2 = (-b - Math.Sqrt(delta))/2*a;

            if (delta < 0){
                Console.WriteLine($"Essa função possui delta = {delta}, e não possui raízes reais\n");
            }
            else if (delta == 0){
                Console.WriteLine($"As raízes dessa função são iguais, seu valor é {x1}\n");
            }
            else {
                Console.WriteLine($"As raízes dessa função são:\nx1 = {x1}\nx2 = {x2}\n");
            }
        }
    }
}