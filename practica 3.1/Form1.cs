using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int N) && N > 0)
            {
                int[] array = new int[N];
                int oddNumber = 1;

                for (int i = 0; i < N; i++)
                {
                    array[i] = oddNumber;
                    oddNumber += 2; // Увеличиваем на 2 для получения следующего нечетного числа
                }

                // Выводим элементы массива на форму
                string result = string.Join(", ", array);
                MessageBox.Show($"Сформированный массив: {result}", "Результат");
            }
            else
            {
                MessageBox.Show("Введите корректное целое число N (> 0)", "Ошибка");
            }
        }
    }
}
