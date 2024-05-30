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
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o número da opção desejada\n\n\rMenu\r\n--------\r\n\r\n[1] - Celsius para Fahrenheit\r\n[2] - Fahrenheit para Celsius\r\n[3] - Celsius para Kelvin\r\n[4] - Kelvin para Celsius\r\n[5] - Fahrenheit para Kelvin\r\n[6] - Kelvin para Fahrenheit\r\n[0] - Finalizar");
                auxS = int.Parse(Console.ReadLine());
                switch (auxS)
                {
                    case 0:
                        Console.ReadKey();
                    break;
                    case 1:
                        CelsiusFahrenheit();
                    break;
                    case 2:
                        FahrenheitCelsius();
                    break;
                    case 3:
                        CelsiusKelvin();
                    break;
                    case 4:
                        KelvinCelsius();
                    break;
                    case 5:
                        FahrenheitKelvin();
                    break;
                    case 6:
                        KelvinFahrenheit();
                    break;
                    default:
                        auxS = 7;
                    break;
                }
                Console.Write("A temperatura convertida é: " + auxT);
            } while (auxS == 7);
            Console.ReadKey();  
        }
        public static double auxT;
        public static void PerguntaTemperatura()
        {
            Console.Write("Digite a temperatura que você deseja converter: ");
            auxT = int.Parse(Console.ReadLine());
        }
        public static void CelsiusFahrenheit()
        {
            PerguntaTemperatura();
            auxT = auxT*1.8 + 32;
        }
        public static void FahrenheitCelsius()
        {
            PerguntaTemperatura();
            auxT = (auxT - 32) / 1.8;
        }
        public static void CelsiusKelvin()
        {
            PerguntaTemperatura();
            auxT += 273.15;
        }
        public static void KelvinCelsius()
        {
            PerguntaTemperatura();
            auxT -= 273.15;
        }
        public static void FahrenheitKelvin()
        {
            PerguntaTemperatura();
            auxT = (auxT - 32) * 5 / 9 + 273.15;
        }
        public static void KelvinFahrenheit()
        {
            PerguntaTemperatura();
            auxT = (auxT - 273.15) * 9 / 5 + 32;
        }
    }
}
