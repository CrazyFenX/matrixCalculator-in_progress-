using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Lab1_var5
{
    public class rectMatrix
    {
        //Задание:
        /*
        5)Создать класс для сущности Прямоугольная Матрица, с характеристиками:
          размерность (M, N) и двумерный массив элементов. Реализовать конструкторы.
          Реализовать следующие методы:
            1. Задание матрицы случайным образов и вручную. (100%)
            2. Вычитание матриц (оператор -) (100%)
            3. Отображение матрицы на форме. (100%)
            4. Отображение транспонированной матрицы на форме. (100%)
            5. Вычисление обратной матрицы (унарный -) ()
        */

        public int heigh; //количество строк
        public int weigth; //количество столбцов

        public int[,] matrixArr; //массив-контейнер для хранения значений элементов матрицы

        public rectMatrix(int M, int N) //основной конструктор
        {
            this.heigh = M;
            this.weigth = N;
            this.matrixArr = new int[M, N];
        }

        public rectMatrix() //пустой конструктор
        {
            this.heigh = 0;
            this.weigth = 0;
            this.matrixArr = new int[0, 0];
        }

        public void randFilling()
        { 
            
        }

        public override string ToString()
        {
            string outStr = "";
            for (int i = 0; i < this.heigh; i++)
            {
                for (int j = 0; j < this.weigth; j++)
                {
                    outStr += Convert.ToString(this.matrixArr[i,j]);
                    outStr += " ";
                }
                outStr += "\n";
            }
            return outStr;
        }

        static public rectMatrix MatrixAddOperation(rectMatrix matrix1, rectMatrix matrix2)
        {
            rectMatrix outMatrix = new rectMatrix(matrix1.heigh, matrix1.weigth);
            try
            {
                if (matrix1.weigth != matrix2.weigth || matrix1.heigh != matrix2.heigh)
                {
                    throw new Exception("Матрицы разных размеров!\nМатематика пока такого не умеет\n¯\\_(ツ)_/¯");
                }
                else
                {
                    for (int i = 0; i < matrix1.heigh; i++)
                    {
                        for (int j = 0; j < matrix1.weigth; j++)
                        {
                            //MessageBox.Show($"элемент: ({i}, {j}) = {matrix1.matrixArr[i, j]} + {matrix2.matrixArr[i, j]}");
                            outMatrix.matrixArr[i, j] = matrix1.matrixArr[i, j] + matrix2.matrixArr[i, j];
                        }
                    }

                    return outMatrix;
                }
            }
            finally
            {
            }
        }

        static public rectMatrix MatrixDiffOperation(rectMatrix matrix1, rectMatrix matrix2)
        {
            rectMatrix outMatrix = new rectMatrix(matrix1.heigh, matrix1.weigth);
            try
            {
                if (matrix1.weigth != matrix2.weigth || matrix1.heigh != matrix2.heigh)
                {
                    throw new Exception("Матрицы разных размеров!\nМатематика пока такого не умеет\n¯\\_(ツ)_/¯");
                }
                else
                {
                    for (int i = 0; i < matrix1.heigh; i++)
                    {
                        for (int j = 0; j < matrix1.weigth; j++)
                        {
                            //MessageBox.Show($"элемент: ({i}, {j}) = {matrix1.matrixArr[i, j]} - {matrix2.matrixArr[i, j]}");
                            outMatrix.matrixArr[i, j] = matrix1.matrixArr[i, j] - matrix2.matrixArr[i, j];
                        }
                    }

                    return outMatrix;
                }
            }
            finally
            {
            }
        }

        static public rectMatrix MatrixMultOperation(rectMatrix matrix1, rectMatrix matrix2)
        {
            rectMatrix outMatrix = new rectMatrix(matrix1.heigh, matrix1.weigth);
            try
            {
                throw new Exception("Наше приложение пока такого не умеет :P");
                /*
                if (matrix1.weigth != matrix2.heigh)
                {
                    throw new Exception("Матрицы указанных размеров невозможно перемножать!\n Математика пока такого не умеет :P");
                }
                else
                {
                    for (int i = 0; i < matrix1.heigh; i++)
                    {
                        for (int j = 0; j < matrix1.weigth; j++)
                        {
                            //MessageBox.Show($"элемент: ({i}, {j}) = {matrix1.matrixArr[i, j]} + {matrix2.matrixArr[i, j]}");
                            outMatrix.matrixArr[i, j] = matrix1.matrixArr[i, j] + matrix2.matrixArr[i, j];
                        }
                    }

                    return outMatrix;
                }
                */
            }
            finally
            {
            }
        }

        static public rectMatrix MatrixTranspOperation(rectMatrix matrix1)
        {
            rectMatrix outMatrix = new rectMatrix(matrix1.heigh, matrix1.weigth);
            try
            {
                if (matrix1.weigth != matrix1.heigh)
                {
                    throw new Exception("Матрица указанного размера не транспонируема!\n Математика пока такого не умеет :P");
                }
                else
                {
                    for (int i = 0; i < matrix1.heigh; i++)
                    {
                        for (int j = 0; j < matrix1.weigth; j++)
                        {
                            //MessageBox.Show($"элемент: ({i}, {j}) = {matrix1.matrixArr[i, j]} + {matrix2.matrixArr[i, j]}");
                            outMatrix.matrixArr[i, j] = matrix1.matrixArr[j, i];
                        }
                    }

                    return outMatrix;
                }
            }
            finally
            {
            }
        }

        //Возвращает матрицу matrix без row-ой строки и col-того столбца, результат в newMatrix
        static public void getMatrixWithoutRowAndCol(int[,] matrixArr, int size, int row, int col, ref rectMatrix matrixOutput)
        {
            matrixOutput = new rectMatrix(size - 1, size - 1);
            int offsetRow = 0; //Смещение индекса строки в матрице
            int offsetCol = 0; //Смещение индекса столбца в матрице

            for (int i = 0; i < size - 1; i++)
            {
                //Пропустить row-ую строку
                if (i == row)
                {
                    offsetRow = 1; //Как только встретили строку, которую надо пропустить, делаем смещение для исходной матрицы
                }

                offsetCol = 0; //Обнулить смещение столбца
                for (int j = 0; j < size - 1; j++)
                {
                    //Пропустить col-ый столбец
                    if (j == col)
                    {
                        offsetCol = 1; //Встретили нужный столбец, проускаем его смещением
                    }
                    //MessageBox.Show(matrixArr[i + offsetRow, j + offsetCol].ToString());
                    matrixOutput.matrixArr[i, j] = matrixArr[i + offsetRow, j + offsetCol];
                }
            }
            //MessageBox.Show(matrixOutput.ToString());
            return;
        }
        //Вычисление определителя матрицы разложение по первой строке
        static public int matrixDet(int[,] matrixArr, int size)
        {
            int det = 0;
            int degree = 1; // (-1)^(1+j) из формулы определителя

            //Условие выхода из рекурсии
            if (size == 1)
            {
                return matrixArr[0, 0];
            }
            //Условие выхода из рекурсии
            else if (size == 2)
            {
                return matrixArr[0, 0] * matrixArr[1, 1] - matrixArr[0, 1] * matrixArr[1, 0];
            }
            else
            {
                //Матрица без строки и столбца
                rectMatrix newMatrix = new rectMatrix(size - 1, size - 1);
                
                //Раскладываем по 0-ой строке, цикл бежит по столбцам
                for (int j = 0; j < size; j++)
                {
                    //Удалить из матрицы i-ю строку и j-ый столбец
                    //Результат в newMatrix
                    getMatrixWithoutRowAndCol(matrixArr, size, 0, j, ref newMatrix);

                    //Рекурсивный вызов
                    //По формуле: сумма по j, (-1)^(1+j) * matrix[0][j] * minor_j (это и есть сумма из формулы)
                    //где minor_j - дополнительный минор элемента matrix[0][j]
                    // (напомню, что минор это определитель матрицы без 0-ой строки и j-го столбца)
                    det = det + (degree * matrixArr[0, j] * matrixDet(newMatrix.matrixArr, size - 1));
                    //"Накручиваем" степень множителя
                    degree = -degree;
                }

                //Чистим память на каждом шаге рекурсии(важно!)
                //for (int i = 0; i < size - 1; i++)
                //{
                //    delete[] newMatrix[i];
                //}
                //delete[] newMatrix;
            }

            return det;
        }

        static public Double[,] multScalar<T>(Double[,] inputArr, int h, int w, T scalar)
        {
            Double[,] outArray = new Double[h, w];
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++)
                    outArray[i, j] = Convert.ToDouble(inputArr[i, j]) * Convert.ToDouble(scalar);
            return outArray;
        }

        static public double[,] ToDoubleConverter(int[,] inputArr, int h, int w)
        {
            double[,] outArr = new double[h, w];
            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++)
                    outArr[i, j] = Convert.ToDouble(inputArr[i, j]);
            return outArr;
        }

        static public rectMatrix getMinorsMatrix(rectMatrix matrix)
        {
            rectMatrix outMatrix = new rectMatrix(matrix.heigh, matrix.weigth);
            rectMatrix minor = new rectMatrix(matrix.heigh - 1, matrix.weigth - 1);
            int determinator = 0;

            for (int i = 0; i < matrix.heigh; i++)
                for (int j = 0; j < matrix.weigth; j++)
                {
                    rectMatrix.getMatrixWithoutRowAndCol(matrix.matrixArr, matrix.heigh, i, j, ref minor);
                    MessageBox.Show(minor.ToString());
                    determinator = rectMatrix.matrixDet(minor.matrixArr, matrix.heigh - 1);
                    MessageBox.Show($"{determinator}");
                    outMatrix.matrixArr[i, j] = determinator;
                }

            return outMatrix;
        }
    }
}
