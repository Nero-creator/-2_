using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public class Task1
    {
        public int Composition(int[] mas)
        {
            int proizv = mas[0];//Заполнили 1 элемент
            for (int i = 1; i < mas.Length; i++)//расчет производится со 2го элемента
            {
                proizv *= mas[i];
            }
            return proizv;
        }
    }
}
