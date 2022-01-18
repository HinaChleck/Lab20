using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
//-метод получает входным параметром переменную типа double;
//-метод возвращает значение типа double, которое является результатом вычисления.
 
//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-длину окружности по формуле D = 2 * π* R;
//-площадь круга по формуле S = π* R²;
//-объем шара.Формула V = 4 / 3 * π * R³.

//Методы должны быть объявлены как статические.

namespace Lab20
{
    
    internal class Program
    {

        delegate double DelegateRound(double k);
            static double Round(double r)
            {
                return 2 * Math.PI * r;

            }
            static double Circle(double r)
            {
                return Math.PI * r*r;
            }
            static double Ball(double r)
            {
                return 4/3*Math.PI * r * r * r;
            }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите радиус круга:");
            string t=Console.ReadLine();
            if (double.TryParse(t, out double r))
            {
                DelegateRound delegateRound = new DelegateRound(Round);
                Console.WriteLine("Длина окружности " + delegateRound(r));
                delegateRound += Circle;
                Console.WriteLine("Площадь круга " + delegateRound(r));
                delegateRound += Ball;
                Console.WriteLine("Объем шара " + delegateRound(r));
            }
            else
                Console.WriteLine("Введено некорректное значение радиуса");
            Console.ReadKey();
        }
    }
}
