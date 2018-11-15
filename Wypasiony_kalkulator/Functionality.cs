using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypasiony_kalkulator
{
    public class Functionality
    {
        public static float Equals(string _znak, string _liczba1, string _liczba2)
        {
            float wynik = 0;
            switch (_znak)
            {
                case "+":
                    wynik = float.Parse(_liczba1) + float.Parse(_liczba2);
                    break;
                case "-":
                    wynik = float.Parse(_liczba1) - float.Parse(_liczba2);
                    break;
                case "*":
                    wynik = float.Parse(_liczba1) * float.Parse(_liczba2);
                    break;
                case "/":
                    wynik = float.Parse(_liczba1) / float.Parse(_liczba2);
                    break;
            }

            return wynik;
        }
    }
}
