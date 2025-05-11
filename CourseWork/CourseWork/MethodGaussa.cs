using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public static class GaussianSolver
    {
        public static double[] Solve(Matrix matrix)
        {
            if (matrix.Rows != matrix.Columns - 1)
            {
                throw new ArgumentException("Матрица должна быть расширенной матрицей системы (n x n+1)");
            }

            int n = matrix.Rows;

            // Прямой ход метода Гаусса
            for (int k = 0; k < n; k++)
            {
                // Поиск ведущего элемента в текущем столбце
                int maxRow = k;
                double maxVal = Math.Abs(matrix[k, k]);

                for (int i = k + 1; i < n; i++)
                {
                    if (Math.Abs(matrix[i, k]) > maxVal)
                    {
                        maxVal = Math.Abs(matrix[i, k]);
                        maxRow = i;
                    }
                }

                // Перестановка строк, если необходимо
                if (maxRow != k)
                {
                    for (int j = k; j <= n; j++)
                    {
                        double temp = matrix[k, j];
                        matrix[k, j] = matrix[maxRow, j];
                        matrix[maxRow, j] = temp;
                    }
                }

                // Проверка на вырожденность системы
                if (Math.Abs(matrix[k, k]) < 1e-10)
                {
                    throw new InvalidOperationException("Система вырождена или имеет бесконечное количество решений");
                }

                // Нормализация текущей строки
                double div = matrix[k, k];
                for (int j = k; j <= n; j++)
                {
                    matrix[k, j] /= div;
                }

                // Исключение переменной из остальных уравнений
                for (int i = 0; i < n; i++)
                {
                    if (i != k)
                    {
                        double factor = matrix[i, k];
                        for (int j = k; j <= n; j++)
                        {
                            matrix[i, j] -= factor * matrix[k, j];
                        }
                    }
                }
            }

            // Извлечение решения
            double[] solution = new double[n];
            for (int i = 0; i < n; i++)
            {
                solution[i] = matrix[i, n];
            }

            return solution;
        }
    }
}

