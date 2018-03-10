using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Апроксимация
{
    public partial class Form1 : Form
    {
        static double[] x = new double[7]; //Массив значений икса (х)
        static double[] y = new double[7]; //Массив значений игрика (у)
        double[] root = new double[4]; //Массив корней функции при аппроксимации МНК
        int coordinate_y; //Значение игрик (у) для корректного перемещения кнопки по форме
        bool IsCliked; //Проверка нажата ли кнопка мышки

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++) //Задаём начальные значения иксов (х) и игриков (у) при загрузке формы и линию, на которой лежат начальные точки
            {
                x[i] = i;
                y[i] = 1;
                chart1.Series[0].Points.AddXY(x[i], y[i]);
            }
        }


        


        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double[] summ = new double[7];
            double[] total = new double[4];
            double[,] a = new double[5, 5];

            summ[0] = 5; //Сумма колличества иксов (х)
            a[0, 4] = totals(1, 5, 2); //Вызов метода totals с k=2

            for (int i = 0; i < 6; i++)
            {
                summ[i + 1] = totals(i, 5, 0); //Вызов метода totals с k=0

                if (i < 3)
                    a[i + 1, 4] = totals(i, 5, 1); //Вызов метода totals с k=1
            }

            for (int q = 0; q < 4; q++)
            {
                for (int w = 0; w < 4; w++)
                {
                    a[q, w] = summ[w + q]; //Создание системы уравнений для полинома третьей степени
                } 
            }

            for (int i_ = 0; i_ < 4; i_++) //Упрощение матрицы методом Гаусса
                for (int i = i_ + 1; i < 4; i++)
                {
                    double k = -a[i, i_] / a[i_, i_]; //Коефициент для упрощения первых элементов системы каждой строчки (кроме строчки с индексом i_)
                    for (int q = i_ + 1; q < 5; q++)
                    {
                        a[i, q] = a[i, q] + a[i_, q] * k; //Умножение каждого элемента каждой строчки (кроме строчки с индексом i_) на найденный коефициент (k)
                    }
                }

            for (int i = 3; i > -1; i--)
            {
                double summ_ = a[i, 4]; //Записываем в переменную summ_ правую часть уравнения (одно число)
                int k_ = 3; //Переменная индексов элементов левой части уравнения
                for (int i_ = 3 - i; i_ > 0; i_--)
                {
                    summ_ -= a[i, k_] * root[k_]; //Отнимаем от правой части элементы, которые в левой части
                    k_--;
                }
                root[i] = summ_ / a[i, i]; //Находим корень i-той строчки
            }


            for (int i = 0; i < 7; i++) //Рисуем график (аппроксимированный МНК)
            {
                chart1.Series[0].Points.AddXY(x[i], MNK(x[i]));
            }

            for (int i = 0; i < 7; i++) //Рисуем график (интерполяция за Лагранжем)
            {
                chart1.Series[1].Points.AddXY(x[i], Lagrange(x[i]));
            }
        }


        double totals(int power, int i, int k) //Рекурсия. power -- нужная степень, i -- колличество повторений, k -- номер нужного действия (в switch..case)
        {
            double result = 0;
            if (i != 0)
            {
                switch (k)
                {
                    case 0:
                        { result = Math.Pow(x[i], power + 1) + totals(power, i - 1, k); break; } //Сумма иксов (x) в степени power+1
                    case 1:
                        { result = Math.Pow(x[i], power + 1) * y[i] + totals(power, i - 1, k); break; } //Сумма умножений игрика (у) на икса (х) в степени power+1
                    case 2:
                        { result = y[i] + totals(power, i - 1, k); break; } //Сумма игриков (у) в первой степени (вызывается лишь строчкой "a[0, 4] = totals(1, 4, 2);")
                }
            }
            return result;
        }



        double MNK(double f_x) //Метод функции игрик (у) от икса (х)
        {
            f_x = root[3] * Math.Pow(f_x, 3) + root[2] * Math.Pow(f_x, 2) + root[1] * f_x + root[0];
            return f_x;
        }

        double Lagrange(double f_x) //Метод возвращает значение функции от икса (х) (интерполяция за Лагранжем)
        {
            double Answer = 0;
            for (int i = 0; i < 7; i++)
            {
                double L = y[i];
                for (int i_ = 0; i_ < 7; i_++)
                {
                    if (i != i_)
                        L *= (f_x - x[i_]) / (x[i] - x[i_]);
                }
                Answer += L;
            }
            return Answer;
        }



        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                double yValue = chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
                double xValue = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                if (xValue > 0 && xValue < 6 && yValue > 0 && yValue < 10) //Границы диаграммы
                {
                    chart1.Cursor = System.Windows.Forms.Cursors.Cross;
                    label1.Visible = true;
                    label1.Text = string.Concat(String.Concat(Math.Round(xValue, 1).ToString(), " , "), Math.Round(yValue, 1).ToString()); //Показывает координаты икса (х) и игрика (у)
                    label1.Location = new Point(e.X + 5, e.Y); //Расположение формы со значениями координат
                }
                else //Курсор не в границах диаграммы
                {
                    label1.Visible = false;
                    chart1.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }
            catch { }
            finally { }
           
        }

        bool borders(int coordinate) //Возвращает выходит ли точка за границы диаграммы
        {
            if (coordinate > 30 && coordinate < 530) //Границы диаграммы для точек
                return true;
            else 
                return false;
        }


        ////////////////////////////////////////////////////////////////
        //Нажатие кнопкой мышки по точке
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            IsCliked = true; //Кнопка мышки нажата
            coordinate_y = Dot1.Location.Y - Cursor.Position.Y; //Переменная используемая для корректного рассположение точки после нажатия на неё
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            IsCliked = true;
            coordinate_y = Dot2.Location.Y - Cursor.Position.Y;
        }
        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            IsCliked = true;
            coordinate_y = Dot3.Location.Y - Cursor.Position.Y;
        }
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            IsCliked = true;
            coordinate_y = Dot4.Location.Y - Cursor.Position.Y;
        }
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            IsCliked = true;
            coordinate_y = Dot5.Location.Y - Cursor.Position.Y;
        }
        ////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////
        //Отпускание кнопки мыши
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            IsCliked = false; //Кнопки мыши отжата
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            IsCliked = false;
        }
        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            IsCliked = false;
        }
        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            IsCliked = false;
        }
        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            IsCliked = false;
        }
        ////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////
        //Движение точки по диаграмме
        private void Dot1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsCliked) //Если кнопка мыши нажата
            {
                if (borders(coordinate_y + Cursor.Position.Y)) //Проверка не выходит ли точка за границы
                {
                    Dot1.Top = coordinate_y + Cursor.Position.Y; //Перемещение точки по диаграмме
                    Label_coordinate(Dot1.Left, Dot1.Top, 1); //Вызов метода для вывода формы с координатами точки, принимает координаты точки
                }
            }
        }
        private void Dot2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsCliked)
            {
                if (borders(coordinate_y + Cursor.Position.Y))
                {
                    Dot2.Top = coordinate_y + Cursor.Position.Y;
                    Label_coordinate(Dot2.Left, Dot2.Top, 2);
                }
            }
        }
        private void Dot3_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsCliked)
            {
                if (borders(coordinate_y + Cursor.Position.Y))
                {
                    Dot3.Top = coordinate_y + Cursor.Position.Y;
                    Label_coordinate(Dot3.Left, Dot3.Top, 3);
                }
            }
        }
        private void Dot4_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsCliked)
            {
                if (borders(coordinate_y + Cursor.Position.Y))
                {
                    Dot4.Top = coordinate_y + Cursor.Position.Y;
                    Label_coordinate(Dot4.Left, Dot4.Top, 4);
                }
            }
        }
        private void Dot5_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsCliked)
            {
                if (borders(coordinate_y + Cursor.Position.Y))
                {
                    Dot5.Top = coordinate_y + Cursor.Position.Y;
                    Label_coordinate(Dot5.Left, Dot5.Top, 5);
                }
            }
        }
        ////////////////////////////////////////////////////////////////


        void Label_coordinate(int but_left, int butt_top, int i) //Меняет расположение формы с координатами точки
        {
            label1.Location = new Point(but_left + 12, butt_top); //Меняет расположение формы относительно расположение точки
            //value_y(butt_top - 5, i); //
            y[i] = (530 - Convert.ToDouble(butt_top)) / 50; //Вычисление значение точки по игрику (у)
            //530 -- длина диаграммы, coordinate_butt -- расположение точки на диаграмме (по длине), 50 -- расстояние между у(n) и у(n+1)
            label1.Text = string.Concat(x[i] + ", ", Math.Round(y[i] - 0.1, 1)); //Вывод на форму значения координат точки
        }

        void value_y(double coordinate_butt, int i) //Метод вычисление значения точки по игрику (у)
        {
            y[i] = (530 - coordinate_butt) / 50;
            //530 -- длина диаграммы, coordinate_butt -- расположение точки на диаграмме (по длине), 50 -- расстояние между у(n) и у(n+1)
        }
    }
}
