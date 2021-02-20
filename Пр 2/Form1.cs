using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_2;
using LibMas;

namespace Пр_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int proizv = 0;
        /// <summary>
        /// Об авторе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\n" +
                "Студент группы ИСП-31\n" +
                "Князев Максим Алексеевич");
        }
        /// <summary>
        /// Задание
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ввести n целых чисел(>0 или <0)\n" +
                "Найти произведение чисел\n" +
                "Результат вывести на экран");
        }
        /// <summary>
        /// Выйти из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Сохранить массив
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Mass.SaveArray(Table);
        }
        /// <summary>
        /// Стандартные значения для массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Table.ColumnCount = 5;
            Table.RowCount = 1;
        }
        /// <summary>
        /// Загрузить массив
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btdLoad_Click_1(object sender, EventArgs e)
        {
            Mass.OpenArray(Table);
        }
        /// <summary>
        /// Выбор значений пользователем из NumericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            Table.ColumnCount = Convert.ToInt32(NumUpDown.Value);
        }
        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\n" +
                "Студент группы ИСП-31\n" +
                "Князев Максим Алексеевич\n" +
                "Задание:\n"+
                "Ввести n целых чисел(>0 или <0)\n" +
                "Найти произведение чисел\n" +
                "Результат вывести на экран");
        }
        /// <summary>
        /// Расчитать произведение чисел в массиве из функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            Task1.Composition(Table, out proizv);
            txtProizv.Text = Convert.ToString(proizv);
        }
        /// <summary>
        /// Выйти из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Заполнить массив из функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFill_Click(object sender, EventArgs e)
        {
            Mass.FillArray(Table);
            txtProizv.Clear();
        }
        /// <summary>
        /// Очистить массив
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>??
        private void btnReset_Click(object sender, EventArgs e)
        {
            Mass.ClearMass(Table);
        }
    }
}
