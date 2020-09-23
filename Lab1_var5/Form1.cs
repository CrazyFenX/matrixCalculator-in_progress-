using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1_var5
{
    public partial class Form1 : Form
    {
        rectMatrix matrix1;

        rectMatrix matrix2;

        rectMatrix outMatrix;

        TextBox[,] matrixElementList1;

        TextBox[,] matrixElementList2;

        public Form1()
        {
            InitializeComponent();

            TextBox[,] matrixElementList1 = new TextBox[0,0];

            TextBox[,] matrixElementList2 = new TextBox[0, 0]; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void randomFilling_button_Click(object sender, EventArgs e)
        {
            try
            {
                AutoFilling(heighMatrixFirst_textBox.Text, weightMatrixFirst_textBox.Text, matrix1, panelOfElements1, ref matrixElementList1);
                RandFillTextBoxes(matrixElementList1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Усе погано... Что-то пошло не так.\n¯\\_(ツ)_/¯\nСообщение: " + ex.Message);
            }
        }

        private void handFilling_button_Click(object sender, EventArgs e)
        {
            AutoFilling(heighMatrixFirst_textBox.Text, weightMatrixFirst_textBox.Text, matrix1, panelOfElements1,ref matrixElementList1);
        }

        public void AutoFilling(string Height, string Weight, rectMatrix matrix, Panel panel, ref TextBox[,] textBoxesList)
        {
            if (Height != "" && Weight != "")
            {
                int height = Convert.ToInt32(Height);
                int weight = Convert.ToInt32(Weight);

                //matrix = new rectMatrix(height, weight);

                //TextBox[,] textBoxes = new TextBox[height, weight];

                textBoxesList = new TextBox[height, weight];

                panel.Controls.Clear();

                try
                {
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < weight; j++)
                        {
                            TextBox textbox1;

                            panel.Controls.Add(textbox1 = new TextBox()
                            {
                                Name = "element [" + i.ToString() + "," + j.ToString() + "]_textBox",
                                Location = new Point(45 * (j) + 15 * (j + 1), 24 * (i) + 15 * (i + 1)),
                                Size = new Size(55, 34),
                                Font = new Font("", 14)
                            });

                            textBoxesList[i, j] = textbox1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Усе погано...\n" + ex.Message);
                }
            }
            else
                MessageBox.Show("Поля размера заполнены некорректно!");
        }

        public string ShowArr(int height, int weight, int[,] inputArr)
        {
            string outStr = "";
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    outStr += Convert.ToString(inputArr[i, j]);
                    outStr += " ";
                }
                outStr += "\n";
            }
            return outStr;
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            matrix1 = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));
            matrix2 = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));

            matrix1 = ReadMatrix(matrix1.heigh, matrix1.weigth, matrixElementList1);
            matrix2 = ReadMatrix(matrix2.heigh, matrix2.weigth, matrixElementList2);
        }

        public rectMatrix ReadMatrix(int Height, int Weight, TextBox[,] matrixElementList)
        {
            rectMatrix outMatrix = new rectMatrix(Height, Weight);
            try
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Weight; j++)
                    {
                        outMatrix.matrixArr[i, j] = Convert.ToInt32(matrixElementList[i, j].Text);
                    }
                }
                //MessageBox.Show(ShowArr(Height, Weight, outMatrix.matrixArr));
                return outMatrix;
            }
            finally
            {
            }
        }

        public void CheckAllBoxes(TextBox[,] inputArr)
        {
            try
            {
                foreach (TextBox item in inputArr)
                    if (item.Text == "")
                        throw new Exception("Не все поля заполнены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RandFillTextBoxes(TextBox[,] inputArr)
        {
            Random rnd = new Random();
            if(heighMatrixFirst_textBox.Text != "" && weightMatrixFirst_textBox.Text != "")
            {
                foreach (TextBox item in inputArr)
                {
                    item.Text = Convert.ToString(rnd.Next()%100);
                }
            }
        }

        private void randomFillingSecond_button_Click(object sender, EventArgs e)
        {
            try
            {
                AutoFilling(heighMatrixSecond_textBox.Text, weightMatrixSecond_textBox.Text, matrix2, panelOfElements2, ref matrixElementList2);
                RandFillTextBoxes(matrixElementList2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Усе погано... Что-то пошло не так.\n¯\\_(ツ)_/¯\nСообщение: " + ex.Message);
            }
        }

        private void handFillingSecond_button_Click(object sender, EventArgs e)
        {
            try
            {
                AutoFilling(heighMatrixSecond_textBox.Text, weightMatrixSecond_textBox.Text, matrix2, panelOfElements2, ref matrixElementList2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Усе погано... Что-то пошло не так.\n¯\\_(ツ)_/¯\nСообщение: " + ex.Message);
            }
        }

        private void readSecondButton_Click(object sender, EventArgs e)
        {
            try
            {
                matrix1 = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));
                matrix2 = new rectMatrix(Convert.ToInt32(heighMatrixSecond_textBox.Text), Convert.ToInt32(weightMatrixSecond_textBox.Text));
                outMatrix = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));

                matrix1 = ReadMatrix(matrix1.heigh, matrix1.weigth, matrixElementList1);
                matrix2 = ReadMatrix(matrix2.heigh, matrix2.weigth, matrixElementList2);

                switch (operation_ComboBox.SelectedIndex)
                {
                    case -1:
                        MessageBox.Show("Необходимо выбрать операцию!");
                        break;

                    case 0:
                        outMatrix = rectMatrix.MatrixDiffOperation(matrix1, matrix2);
                        MessageBox.Show(ShowArr(outMatrix.heigh, outMatrix.weigth, outMatrix.matrixArr));
                        break;

                    case 1:
                        outMatrix = rectMatrix.MatrixAddOperation(matrix1, matrix2);
                        MessageBox.Show(ShowArr(outMatrix.heigh, outMatrix.weigth, outMatrix.matrixArr));
                        break;

                    case 3:
                        outMatrix = rectMatrix.MatrixTranspOperation(matrix1);
                        ShowMatrixOnForm(matrix1.matrixArr, matrix1.heigh, matrix1.weigth, matrixElementList1);
                        MessageBox.Show(ShowArr(outMatrix.heigh, outMatrix.weigth, outMatrix.matrixArr));
                        break;

                    case 2:
                        outMatrix = rectMatrix.MatrixMultOperation(matrix1, matrix2);
                        MessageBox.Show(ShowArr(outMatrix.heigh, outMatrix.weigth, outMatrix.matrixArr));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void operation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matrixElementList1 == null || matrixElementList2 == null)
            {
                operation_ComboBox.SelectedIndex = -1;
                MessageBox.Show("Кажется, матрицы пусты!");
                return;
            }
            if (matrixElementList1.Length == 0 || matrixElementList2.Length == 0)
            {
                operation_ComboBox.SelectedIndex = -1;
                MessageBox.Show("Кажется, матрицы пусты!");
            }
        }

     /*   public void ShowMatrixOnForm(rectMatrix inputMatrix, TextBox[,] textBoxList)
        {
            ClrTextBoxws(textBoxList);
            for (int i = 0;i < inputMatrix.heigh; i++)
            {
                for (int j = 0; j < inputMatrix.weigth; j++)
                {
                    textBoxList[i, j].Text = inputMatrix.matrixArr[i, j].ToString();
                }
            }
        }
     */
        public void ShowMatrixOnForm<T>(T[,] inputArr, int h, int w, TextBox[,] textBoxList)
        {
            string outStrTest = "";
          ClrTextBoxws(textBoxList);
          for (int i = 0;i < h; i++)
          {
              for (int j = 0; j < w; j++)
              {
                  textBoxList[i, j].Text = inputArr[i, j].ToString();
                    outStrTest += inputArr[i, j].ToString() + " ";
              }
                outStrTest += "\n";
          }
        }
        private void transpFirstButton_Click(object sender, EventArgs e)
        {
          try
          {
              matrix1 = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));
              outMatrix = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));

              matrix1 = ReadMatrix(matrix1.heigh, matrix1.weigth, matrixElementList1);

              outMatrix = rectMatrix.MatrixTranspOperation(matrix1);
              //MessageBox.Show(ShowArr(outMatrix.heigh, outMatrix.weigth, outMatrix.matrixArr));

              ShowMatrixOnForm(outMatrix.matrixArr, outMatrix.heigh, outMatrix.weigth, matrixElementList1);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
        }

        public void ClrTextBoxws(TextBox[,] textBoxList)
        {
          foreach (TextBox item in textBoxList)
          {
              item.Text = "";
          }
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            matrix1 = new rectMatrix(Convert.ToInt32(heighMatrixFirst_textBox.Text), Convert.ToInt32(weightMatrixFirst_textBox.Text));
            matrix1 = ReadMatrix(matrix1.heigh, matrix1.weigth, matrixElementList1);

            matrix2 = new rectMatrix(matrix1.heigh - 1, matrix1.weigth - 1);
            rectMatrix.getMatrixWithoutRowAndCol(matrix1.matrixArr, matrix1.heigh, 1, 1, ref matrix2);

          //AutoFilling(matrix2.heigh.ToString(), matrix2.weigth.ToString(), matrix2, panelOfElements2, ref matrixElementList2);
          //ShowMatrixOnForm(matrix2,matrixElementList2);
            int det = rectMatrix.matrixDet(matrix1.matrixArr, matrix1.heigh);

            rectMatrix reverseMatrix = rectMatrix.MatrixTranspOperation(matrix1);
            double[,] reverseArr = new double[reverseMatrix.heigh, reverseMatrix.weigth];

            rectMatrix.multScalar(rectMatrix.ToDoubleConverter(reverseMatrix.matrixArr, reverseMatrix.heigh, reverseMatrix.weigth), reverseMatrix.heigh, reverseMatrix.weigth, 1/det);
          
            AutoFilling(reverseMatrix.heigh.ToString(), reverseMatrix.weigth.ToString(), reverseMatrix, panelOfElements2, ref matrixElementList2);
            ShowMatrixOnForm(reverseArr, reverseMatrix.heigh, reverseMatrix.weigth, matrixElementList2);

            MessageBox.Show(reverseMatrix.ToString());

            detTextBox.Text = det.ToString();

            rectMatrix minorsMatr = rectMatrix.MatrixTranspOperation(rectMatrix.getMinorsMatrix(matrix1));

            reverseArr = rectMatrix.multScalar(rectMatrix.ToDoubleConverter(minorsMatr.matrixArr,minorsMatr.heigh, minorsMatr.weigth), minorsMatr.heigh, minorsMatr.weigth, 1/det);
            ShowMatrixOnForm(reverseArr, reverseMatrix.heigh, reverseMatrix.weigth, matrixElementList2);
            //MessageBox.Show();
        }
    }
}
