using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, s, a, p, ch, zn, e, z;
            int n, k;
        m1: Console.WriteLine(" Введiть значення x");
            x = double.Parse((Console.ReadLine())); 
            e = Math.E;     // Задання числа e
            Console.WriteLine('\t' + "Промiжнi результати" + '\n');
            k = 0;      // Номер ітерації
            s = 0; p = 1;
            n = 1;
            a = 1;   // Перший член ряду
            z = x / 2;
            while (Math.Abs(a) >= 0.000001)
            {
                s += a;     // Поточна сума ряду 
                ch = (n * n + 1) * Math.Pow(x, n); // Розрахунок чисельника
                p = p * n; // Знаходження факторіалу 
                zn = p * Math.Pow(2, n);     // Знаменник
                a = ch / zn;     // Поточний член ряду 
                n++;
                k++;     // Номер ітерації
                s++;     // Лічильник ітерацій
                Console.WriteLine('\t' + " Iтерацiя №"
            + k + '\n' + " a=" + a + " s=" + s + '\n');
            }
            y = (z * z + z + 1) * Math.Pow(e, x); // Безпосереднє обчислення y = (z^2+z+1)*e^x
            Console.WriteLine('\t' + "РЕЗУЛЬТАТИ:" + '\n'
            + " Сума ряду S =" + s + '\n' +
            " Кiлькiсть членiв ряду = " + k + '\n'
            + " Функцiя y = (z^2+z+1)*e^x=" + y + '\n');
            Console.WriteLine('\n' + " Для повторного вводу"
            + "натиснiть будь - яку кнопку" + '\n'
            + " Для завершення програми натиснiть Enter.");
            string rep = Console.ReadLine();
            if (rep != "") goto m1;
        }
    }
}
