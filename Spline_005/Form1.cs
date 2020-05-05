using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Spline_005 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

		// Списки координат для графиков
        public PointPairList FunctionList          = new PointPairList();
        public PointPairList SplineList            = new PointPairList();
        public PointPairList FirstDivFunctionList  = new PointPairList();
        public PointPairList SecondDivFunctionList = new PointPairList();
        public PointPairList SplineFirstDevList    = new PointPairList();
        public PointPairList SplineSecondDevList   = new PointPairList();
        public PointPairList FuncErrorList         = new PointPairList();
        public PointPairList FirstDevErrorList     = new PointPairList();
        public PointPairList SecondDevErrorList    = new PointPairList();

        public double[] A;
        public double[] B;
        public double[] C;
        public double[] D;
        public double[] X;

        public int FuncFlag = 1, GraphFlag = 1, n;
        public double a = -1, b = 1, h;

        public double f(double x) {  // Функции
            if (FuncFlag == 1) {
                if ((x >= -1.0) && (x <= 0.0)) {
                    return (Math.Pow(x, 3.0) + 3.0 * Math.Pow(x, 2.0));
                } else {
                    return (-Math.Pow(x, 3.0) + 3.0 * Math.Pow(x, 2.0));
                }
            }
            if (FuncFlag == 2) {
                return (Math.Sqrt(Math.Pow(x, 2) - 1)) / x;
            }
            if (FuncFlag == 3) {
                return ( Math.Sin(x + 1) / x + Math.Cos(10 * x) );
            }
            if (FuncFlag == 4) {
                return ( Math.Sin(x + 1) / x + Math.Cos(100 * x) );
            }
            return (0.0);
        }

        public double FirstDevf(double x) {  // Первые производные функций
            if (FuncFlag == 1) {
                if ((x >= -1.0) && (x <= 0.0)) {
                    return (3.0 * Math.Pow(x, 2.0) + 6.0 * x);
                } else {
                    return (-3.0 * Math.Pow(x, 2.0) + 6.0 * x);
                }
            }
            if (FuncFlag == 2) {
                return (1 / (Math.Pow(x, 2.0) * Math.Sqrt(Math.Pow(x, 2.0) - 1)));
            }
            if (FuncFlag == 3) {
                return (Math.Cos(x + 1) / x + Math.Sin(x + 1) / Math.Pow(x, 2.0) - 10 * Math.Sin(10 * x));
            }
            if (FuncFlag == 4) {
                return (Math.Cos(x + 1) / x + Math.Sin(x + 1) / Math.Pow(x, 2.0) - 100 * Math.Sin(100 * x));
            }
            return 0.0;
        }
		
		public double SecondDevf(double x) {    // Вторые производные функций
            if (FuncFlag == 1) {
                if ((x >= -1.0) && (x <= 0.0)) {
                    return (6.0 * x + 6.0);
                } else {
                    return (-6.0 * x + 6.0);
                }
            }
            if (FuncFlag == 2) {
                return ((2.0 - 3.0 * Math.Pow(x,2))/ (Math.Pow(x,3) * Math.Pow(Math.Pow(x,2)-1,1.5)));
            }
            if (FuncFlag == 3) {
                return ((-1.0) * Math.Sin(x + 1) / x - (2.0) * Math.Cos(x + 1) / Math.Pow(x, 2.0) + 2 * Math.Sin(x + 1) / Math.Pow(x, 3.0) - 100 * Math.Cos(10 * x));
            }
            if (FuncFlag == 4) {
                return ((-1.0) * Math.Sin(x + 1) / x - (2.0) * Math.Cos(x + 1) / Math.Pow(x, 2.0) + 2 * Math.Sin(x + 1) / Math.Pow(x, 3.0) - 10000 * Math.Cos(100 * x));
            }
            return 0.0;
        }


        //РАБОТА СО СПЛАЙНОМ
        public double Spline(double x)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((x >= X[i - 1]) && (x <= X[i]))
                {
                    return (A[i] + B[i] * (x - X[i]) + C[i] / 2 * Math.Pow((x - X[i]), 2) + D[i] / 6 * Math.Pow((x - X[i]), 3));
                }
            }
            return (0.0);
        }

        public double SplineFirstDev(double x)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((x >= X[i - 1]) && (x <= X[i]))
                {
                    return (B[i] + C[i] * (x - X[i]) + D[i] / 2 * Math.Pow((x - X[i]), 2));
                }
            }
            return (0.0);
        }

        public double SplineSecondDev(double x)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((x >= X[i - 1]) && (x <= X[i]))
                {
                    return (C[i] + D[i] * (x - X[i]));
                }
            }
            return (0.0);
        }


        //ЗАГРУЗКА ФОРМЫ
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            zedGraphControl1.Height = (int)(0.9 * this.Height);
            zedGraphControl1.Width = (int)(0.7 * this.Width);
            tabControl1.Height = (int)(0.77 * this.Height);
            Table1.Height = (int)(0.96 * tabControl1.Height);
            Table1.Width = (int)(0.98 * tabControl1.Width);
            Table2.Height = (int)(0.85 * tabControl1.Height);
            Table2.Width = (int)(0.98 * tabControl1.Width);
        }


        //ВЫЧИСЛЕНИЕ КОЭФФИЦИЕНТОВ СПЛАЙНА
        private void buttonGo_Click(object sender, EventArgs e)
        {
            n = System.Convert.ToInt32(textBoxN.Text);		//количество интервалов
            double myu1 = System.Convert.ToDouble(textBoxSa.Text), 	// S''(a) = myu1
                   myu2 = System.Convert.ToDouble(textBoxSb.Text);  // S''(a) = myu1
            h = (b - a) / n;
            A = new double[n + 1];
            B = new double[n + 1];
            C = new double[n + 1];
            D = new double[n + 1];
            X = new double[n + 1];
            double[] Alpha = new double[n + 1];
            double[] Beta = new double[n + 1];
            //из граничных условий S(x[i])=f[i] находим a[i] = f(x[i])
            for (int i = 0; i <= n; i++)
            {
                X[i] = a + i * h; 	//берём значения функции f в точках,
                A[i] = f(X[i]);		//начининая с "а" и сдвигаясь вправо на шаг "h"
            }

            Alpha[1] = 0;
            Beta[1] = myu1;
            //A[i] = h   		B[i] = h		C[i] = 4 * h
            //т.к. сетка равномерная, и h[i]=h[i+1], то нет смысла хранить 3 вектора - достаточно либо хранить 3 переменные,
            //либо, как сделано ниже - просто подставлять сразу значения
            for (int i = 1; i <= n - 1; i++)
            {
                // Alpha[i + 1] = - B[i] / ( alpha[i] * A[i] + C[i] )
                Alpha[i + 1] = (-1.0) * h / (Alpha[i] * h + 4 * h);
                // Beta[i + 1] = (  F[i] - beta[i]*A[i] ) / ( alpha[i] * A[i] + C[i] )
                // F[i] = 6 * (A[i + 1] - 2 * A[i] + A[i - 1]) / h; здесь A[i] - коээфициент сплайна: a[i] = f(x[i]
                Beta[i + 1] = ((-6.0 / h) * (A[i + 1] - 2 * A[i] + A[i - 1]) + Beta[i] * h) / (-4 * h - Alpha[i] * h);
            }

            C[n] = myu2;
            for (int i = n; i >= 1; i--)
            {
                C[i - 1] = Alpha[i] * C[i] + Beta[i];
            }

            for (int i = 1; i <= n; i++)
            {
                B[i] = (A[i] - A[i - 1]) / h + h * (2 * C[i] + C[i - 1]) / 6;
                D[i] = (C[i] - C[i - 1]) / h;
            }

            double MaxFuncErr = 0;
            double MaxDevErr = 0;
            double xMaxFuncErr = 0;
            double xMaxDevErr = 0;

            for (double x = a; x <= b; x += h / 4.0)
            {
                //вычисление оценки сходства: |F(x) - S(x)|
                double Tmp = Math.Abs(f(x) - Spline(x));
                if (Tmp > MaxFuncErr)
                {
                    MaxFuncErr = Tmp;
                    xMaxFuncErr = x;
                }
                //вычисление оценки cходства: |F'(x) - S'(x)|
                Tmp = Math.Abs(FirstDevf(x) - SplineFirstDev(x));
                if (Tmp > MaxDevErr)
                {
                    MaxDevErr = Tmp;
                    xMaxDevErr = x;
                }
            }

            //Ограничение на количество строк в таблице
            int N;
            if (n < 100)
            {
                N = n;
            }
            else
            {
                N = 100;
            }

            Table1.RowCount = N + 1;
            Table1.ColumnCount = 7;
            Table1[0, 0].Value = "№";
            Table1[1, 0].Value = "xi-1";
            Table1[2, 0].Value = "xi";
            Table1[3, 0].Value = "ai";
            Table1[4, 0].Value = "bi";
            Table1[5, 0].Value = "ci";
            Table1[6, 0].Value = "di";
            for (int i = 1; i <= N; i++)
            {
                Table1[0, i].Value = i;
                Table1[1, i].Value = X[i - 1];
                Table1[2, i].Value = X[i];
                Table1[3, i].Value = A[i];
                Table1[4, i].Value = B[i];
                Table1[5, i].Value = C[i];
                Table1[6, i].Value = D[i];

            }
            if (4 * N < 100)
            {
                N = 4 * N;
            }
            else
            {
                N = 100;
            }
            Table2.RowCount = N + 1;
            Table2.ColumnCount = 8;
            Table2[0, 0].Value = "№";
            Table2[1, 0].Value = "x";
            Table2[2, 0].Value = "f(x)";
            Table2[3, 0].Value = "S(x)";
            Table2[4, 0].Value = "|f(x)-S(x)|";
            Table2[5, 0].Value = "f'(x)";
            Table2[6, 0].Value = "S'(x)";
            Table2[7, 0].Value = "|f'(x)-S'(x)|";
            double y = a;
            for (int i = 1; i <= N; i++)
            {
                Table2[0, i].Value = i;
                Table2[1, i].Value = y;
                Table2[2, i].Value = f(y);
                Table2[3, i].Value = Spline(y);
                Table2[4, i].Value = Math.Abs(f(y) - Spline(y));
                Table2[5, i].Value = FirstDevf(y);
                Table2[6, i].Value = SplineFirstDev(y);
                Table2[7, i].Value = Math.Abs(FirstDevf(y) - SplineFirstDev(y));
                y += h / 4.0;
            }
            labelT2n.Text = "Сетка сплайна: n=" + System.Convert.ToString(n);
            labelT2Nd.Text = "Дополн. сетка: N=" + System.Convert.ToString(n * 4);
            labelMaxF.Text = "Max|f(x)-S(x)|=" + System.Convert.ToString(MaxFuncErr) + ", при x=" + System.Convert.ToString(xMaxFuncErr);
            labelMaxFD.Text = "Max|f'(x)-S'(x)|=" + System.Convert.ToString(MaxDevErr) + ", при x=" + System.Convert.ToString(xMaxDevErr);
            FillLists();
            Draw();
        }


        //ОТРИСОВКА
        public void Draw()
        {
            GraphPane Pane = zedGraphControl1.GraphPane;

            if (GraphFlag == 1)
            {
                if (FuncFlag == 1)
                {
                    Pane.Title = "f(x)={x^3+3x^2, -1<=x<=0;" + "\n" + "      {-x^3+3x^2, 0<=x<=1";
                }
                if (FuncFlag == 2)
                {
                    Pane.Title = "f(x)=√‎(x^2-1)/x, 2<=x<=4";
                }
                if (FuncFlag == 3)
                {
                    Pane.Title = "f(x)=cos(e^x)+cos(10x), 1<=x<=Pi";
                }
                if (FuncFlag == 4)
                {
                    Pane.Title = "f(x)=cos(e^x)+cos(100x), 1<=x<=Pi";
                }
                Pane.CurveList.Clear();
                Pane.XAxis.Min = a;
                Pane.XAxis.Max = b;
                LineItem Curve = Pane.AddCurve("f(x)", FunctionList, Color.Blue, SymbolType.None);
                LineItem SCurve = Pane.AddCurve("S(x)", SplineList, Color.Green, SymbolType.None);
                LineItem ECurve = Pane.AddCurve("f(x)-S(x)", FuncErrorList, Color.Red, SymbolType.None);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
            if (GraphFlag == 2)
            {
                if (FuncFlag == 1)
                {
                    Pane.Title = "f'(x)";
                }
                if (FuncFlag == 2)
                {
                    Pane.Title = "f'(x)";
                }
                if (FuncFlag == 3)
                {
                    Pane.Title = "f'(x)";
                }
                if (FuncFlag == 4)
                {
                    Pane.Title = "f'(x)";
                }
                Pane.CurveList.Clear();
                Pane.XAxis.Min = a;
                Pane.XAxis.Max = b;
                LineItem Curve = Pane.AddCurve("f'(x)", FirstDivFunctionList, Color.Blue, SymbolType.None);
                LineItem SCurve = Pane.AddCurve("S'(x)", SplineFirstDevList, Color.Green, SymbolType.None);
                LineItem ECurve = Pane.AddCurve("f'(x)-S'(x)", FirstDevErrorList, Color.Red, SymbolType.None);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
            if (GraphFlag == 3)
            {
                if (FuncFlag == 1)
                {
                    Pane.Title = "f''(x)";
                }
                if (FuncFlag == 2)
                {
                    Pane.Title = "f''(x)";
                }
                if (FuncFlag == 3)
                {
                    Pane.Title = "f''(x)";
                }
                if (FuncFlag == 4)
                {
                    Pane.Title = "f''(x)";
                }
                Pane.CurveList.Clear();
                Pane.XAxis.Min = a;
                Pane.XAxis.Max = b;
                LineItem Curve = Pane.AddCurve("f''(x)", SecondDivFunctionList, Color.Blue, SymbolType.None);
                LineItem SCurve = Pane.AddCurve("S''(x)", SplineSecondDevList, Color.Green, SymbolType.None);
                LineItem ECurve = Pane.AddCurve("f''(x)-S''(x)", SecondDevErrorList, Color.Red, SymbolType.None);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
        }


        //ИНТЕРФЕЙС
        private void func1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncFlag = 1;
            a = -1;
            b = 1;
        }

        private void func2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncFlag = 2;
            a = 2;
            b = 4;
        }

        private void func3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncFlag = 3;
            a = 2;
            b = 4;
        }

        private void func4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncFlag = 4;
            a = 1;
            b = Math.PI;
        }

        private void functionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GraphFlag = 1;
            Draw();
        }

        private void derivative1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphFlag = 2;
            Draw();
        }

        private void derivative2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphFlag = 3;
            Draw();
        }

        private void buttonGU_Click(object sender, EventArgs e)
        {
            textBoxSa.Text = System.Convert.ToString(SecondDevf(a));
            textBoxSb.Text = System.Convert.ToString(SecondDevf(b));
        }


        ////////////////////
        public void FillLists()
        {
            FunctionList.Clear();
            FirstDivFunctionList.Clear();
            SecondDivFunctionList.Clear();
            SplineList.Clear();
            SplineFirstDevList.Clear();
            SplineSecondDevList.Clear();
            FuncErrorList.Clear();
            FirstDevErrorList.Clear();
            SecondDevErrorList.Clear();
            for (double x = a; x < b; x += 0.01)
            {
                FunctionList.Add(x, f(x));
                FirstDivFunctionList.Add(x, FirstDevf(x));
                SecondDivFunctionList.Add(x, SecondDevf(x));
                SplineList.Add(x, Spline(x));
                SplineFirstDevList.Add(x, SplineFirstDev(x));
                SplineSecondDevList.Add(x, SplineSecondDev(x));
                FuncErrorList.Add(x, f(x) - Spline(x));
                FirstDevErrorList.Add(x, Math.Abs(FirstDevf(x) - SplineFirstDev(x)));
                SecondDevErrorList.Add(x, Math.Abs(SecondDevf(x) - SplineSecondDev(x)));
            }
            FunctionList.Add(b, f(b));
            FirstDivFunctionList.Add(b, FirstDevf(b));
            SecondDivFunctionList.Add(b, SecondDevf(b));
            SplineList.Add(b, Spline(b));
            SplineFirstDevList.Add(b, SplineFirstDev(b));
            SplineSecondDevList.Add(b, SplineSecondDev(b));
            FuncErrorList.Add(b, f(b) - Spline(b));
            FirstDevErrorList.Add(b,Math.Abs( FirstDevf(b) - SplineFirstDev(b)));
            SecondDevErrorList.Add(b, Math.Abs(SecondDevf(b) - SplineSecondDev(b)));
        }
    }

}