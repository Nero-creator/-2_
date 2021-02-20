using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_2
{
    public class Task1
    {
        public static int Composition(DataGridView array,out int proizv)//1
        {
            proizv = 1;
            for (int i = 0; i < array.ColumnCount; i++)
            {
                proizv *= Convert.ToInt32(array[i, 0].Value);
            }
            return proizv;
        }
    }
}
