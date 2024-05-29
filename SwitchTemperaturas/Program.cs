using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auxS;
            Console.WriteLine("Digite o número da opção desejada\n\n\rMenu\r\n--------\r\n\r\n[1] - Celsius para Fahrenheit\r\n[2] - Fahrenheit para Celsius\r\n[3] - Celsius para Kelvin\r\n[4] - Kelvin para Celsius\r\n[5] - Fahrenheit para Kelvin\r\n[6] - Kelvin para Fahrenheit\r\n[0] - Finalizar");
            auxS = int.Parse(Console.ReadLine());
            switch (auxS)
            {
                case 0:
                    Console.ReadKey();
                break;
                case 1:
                break;
                case 2:
                break;
                case 3:
                    break;
                case 4:
                    break;
                    case 5:
                    break;
                    case 6:
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
