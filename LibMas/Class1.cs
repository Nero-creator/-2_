using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMas
{
    public class Mass
    {

        /// <summary>
        /// Заполняет массив случайными значениями в диапазоне от -9 до 9
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] Rand(int n)
        {
            Random Rnd = new Random();
            int[] mas = new int[n];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Rnd.Next(-9, 9);
            }

            return mas;
        }

        /// <summary>
        /// Очищает одномерный массив случайными значениями
        /// </summary>
        /// <param name="mas"></param>
        public void ClearMass(ref int[] mas)
        {
            for (int t = 0; t < mas.Length; t++)
            {
                mas[t] = 0;
            }
        }
    }
    
}
