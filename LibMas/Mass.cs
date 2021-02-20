using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMas
{
    public class Mass
    {
        /// <summary>
        /// Заполнение двухмерного массива случайными числами
        /// </summary>
        /// <param name="matr"></param>>
        public static void FillMatr(DataGridView matr)
        {
            Random rnd = new Random();

            for(int j = 0; j < matr.RowCount; j++)
            {
                for(int i = 0; i < matr.ColumnCount; i++)
                {
                    matr[j, i].Value = rnd.Next(-100, 100);
                }
            }
        }
        /// <summary>
        /// Очищение двухмерного массива
        /// </summary>
        /// <param name="matr"></param>
        public static void ClearMatr(DataGridView matr)
        {
            for (int j = 0; j < matr.RowCount; j++)
            {
                for (int i = 0; i < matr.ColumnCount; i++)
                {
                    matr[j, i].Value = 0;
                }
            }
        }
        /// <summary>
        /// Сохранение двухмерного массива в файл
        /// </summary>
        /// <param name="mas">сохраняемый одномерный массив</param>
        /// <param name="path">путь к файлу</param>
        public static void SaveMatr(DataGridView matr)
        {
            //Создание объекта диалогового окна для сохранения
            SaveFileDialog save = new SaveFileDialog();

            //Установка стандартных свойств
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* |Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";

            //Если пользователь нажал ОК
            if (save.ShowDialog() == DialogResult.OK)
            {
                //Создаем поток для работы с файлом и указываем ему имя файла
                StreamWriter file = new StreamWriter(save.FileName);

                //Записываем размер матрицы в файл
                file.WriteLine(matr.ColumnCount);
                file.WriteLine(matr.RowCount);

                //Записываем элемент массива в файл
                for (int j = 0; j < matr.RowCount; j++)
                {
                    for (int i = 0; i < matr.ColumnCount; i++)
                    {
                        file.WriteLine(matr[j, i].Value);
                    }
                }
                file.Close();
            }
        }
        /// <summary>
        /// Открытие двухмерного масиива из файла
        /// </summary>
        /// <param name="mas">открываемый одномерный массив</param>
        /// <param name="path">путь к файлу</param>
        public static void OpenArray(DataGridView matr)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Установка стандартных свойств
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* |Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";

            //Если пользователь нажал ОК
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Создаем поток для работы с файлом и указываем ему имя файла
                StreamReader file = new StreamReader(open.FileName);
                matr.ColumnCount = Convert.ToInt32(file.ReadLine());
                for (int j = 0; j < matr.RowCount; j++)
                {
                    for (int i = 0; i < matr.ColumnCount; i++)
                    {
                        matr[j, i].Value = Convert.ToInt32(file.ReadLine());
                    }
                }
                file.Close();
            }
        }
        /// <summary>
        /// Заполняет массив случайными значениями
        /// </summary>
        /// <param name="array">одномерный массив для заполнения</param>
        /// <returns></returns>
        public static void FillArray(DataGridView array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.ColumnCount; i++)
            {
               array[i, 0].Value = rnd.Next(-100, 100);
            }
            
        }


        /// <summary>
        /// Очищает одномерный массив случайными значениями
        /// </summary>
        /// <param name="mas"></param>
        public static void ClearMass(DataGridView array)
        {
            for (int i = 0; i < array.ColumnCount; i++)
            {
                array[i, 0].Value = 0;
            }
        }

        /// <summary>
        /// Сохранение одномерного массива в файл
        /// </summary>
        /// <param name="mas">сохраняемый одномерный массив</param>
        /// <param name="path">путь к файлу</param>
        public static void SaveArray(DataGridView array)
        {
            //Создание объекта диалогового окна для сохранения
            SaveFileDialog save = new SaveFileDialog();

            //Установка стандартных свойств
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* |Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";
            
            //Если пользователь нажал ОК
            if (save.ShowDialog() == DialogResult.OK)
            {
                //Создаем поток для работы с файлом и указываем ему имя файла
                StreamWriter file = new StreamWriter(save.FileName);

                //Записываем размер массива в файл
                file.WriteLine(array.ColumnCount);

                //Записываем элемент массива в файл
                for(int i = 0; i < array.ColumnCount; i++)
                {
                    file.WriteLine(array[i,0].Value);
                }
                file.Close();
            }
        }


        /// <summary>
        /// Открытие одномерного масиива из файла
        /// </summary>
        /// <param name="mas">открываемый одномерный массив</param>
        /// <param name="path">путь к файлу</param>
        public static void OpenMatr(DataGridView array)
        {
            OpenFileDialog open = new OpenFileDialog();
            //Установка стандартных свойств
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* |Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";

            //Если пользователь нажал ОК
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Создаем поток для работы с файлом и указываем ему имя файла
                StreamReader file = new StreamReader(open.FileName);
                array.ColumnCount = Convert.ToInt32(file.ReadLine());
                for(int i = 0; i < array.ColumnCount; i++)
                {
                    array[i, 0].Value = Convert.ToInt32(file.ReadLine());
                }
                file.Close();
            }
        }
    }
}