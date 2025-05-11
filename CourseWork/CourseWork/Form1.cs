using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetMatrixSize(3);
        }
        

        private void matrix_size_ValueChanged(object sender, EventArgs e)
        {
            SetMatrixSize((int)matrix_size.Value);
        }

        private void SetMatrixSize(int size)
        {
            orig_matrix.Columns.Clear();

            // Добавляем столбцы для коэффициентов
            for (int i = 0; i < size; i++)
            {
                orig_matrix.Columns.Add($"col{i}", $"x{i + 1}");
                orig_matrix.Columns[i].Width = 60;
            }

            // Добавляем столбец для правых частей
            orig_matrix.Columns.Add("colRHS", "Свободный член");
            orig_matrix.Columns[size].Width = 80;

            // Устанавливаем количество строк
            orig_matrix.Rows.Clear();
            orig_matrix.Rows.Add(size);

            // Подписываем строки
            for (int i = 0; i < size; i++)
            {
                orig_matrix.Rows[i].HeaderCell.Value = $"Ур. {i + 1}";
            }
            orig_matrix.RowHeadersWidth = 80;
        }
        
        private void button_rnd_value_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int size = (int)matrix_size.Value;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size + 1; j++)
                {
                    orig_matrix[j, i].Value = rnd.Next(-10, 10);
                }
            }
        }

        //private void button_rnd_value_Click(object sender, EventArgs e)
        //{
        //    Random rnd = new Random();
        //    int size = (int)matrix_size.Value;

        //    for (int i = 0; i < size; i++)
        //    {
        //        for (int j = 0; j < size + 1; j++)
        //        {
        //            orig_matrix[j, i].Value = rnd.Next(-10, 10);
        //        }
        //    }
        //}


        private void textBox_ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            try
            {
                int size = (int)matrix_size.Value;
                Matrix matrix = new Matrix(size, size + 1);

                // Заполняем матрицу из DataGridView
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size + 1; j++)
                    {
                        if (orig_matrix[j, i].Value == null || !double.TryParse(orig_matrix[j, i].Value.ToString(), out double value))
                        {
                            throw new ArgumentException($"Неверное значение в строке {i + 1}, столбце {j + 1}");
                        }
                        matrix[i, j] = value;
                    }
                }

                // Решаем систему
                double[] solution = GaussianSolver.Solve(matrix);

                // Выводим результаты
                textBox_ans.Text = "Решение системы:\r\n";
                for (int i = 0; i < solution.Length; i++)
                {
                    textBox_ans.Text += $"x{i + 1} = {solution[i]:F6}\r\n";
                }

                // Проверка решения
                textBox_ans.Text += "\r\nПроверка:\r\n";
                for (int i = 0; i < size; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < size; j++)
                    {
                        sum += matrix[i, j] * solution[j];
                    }
                    textBox_ans.Text += $"Ур.{i + 1}: {sum:F2} = {matrix[i, size]:F2} {(Math.Abs(sum - matrix[i, size]) < 1e-6 ? "✓" : "✗")}\r\n";
                }
            }
            catch (Exception ex)
            {
                textBox_ans.Text = $"Ошибка: {ex.Message}";
            }
        }

        
    }
}
