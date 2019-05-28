using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimisations
{
    public partial class ActualTask : Form
    {
        public int AltsCount = 3;
        public int KritsCount = 3;

        List<double[,]> KritAlts;
        public double[,] KritCompares;
        public static List<double[]> KritNormals;
        public double[] KritWeigths;
        public double[] Functions;
        public int[] Prices;
        public double[] PricesNorm;
        public static List<Alternatives> Alters;
        public static List<Risks> risks;


        public ActualTask()
        {
            InitializeComponent();            
        }

        
        

        private void ExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawGraphs();

            Calculate("example");
        }


        private void случайноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawGraphs();

            Calculate("");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZedGraph.GraphPane graphPane1 = zedGraphControl1.GraphPane;
            ZedGraph.PointPairList pointPairs = new ZedGraph.PointPairList();

            pointPairs.Add(0.5, 0);
            pointPairs.Add(0.5, Function1(0.5));
            pointPairs.Add(0, Function1(0.5));

            ZedGraph.LineItem lineItemResult1 = graphPane1.AddCurve("Альтернатива 1", pointPairs, Color.Blue, ZedGraph.SymbolType.None);

            zedGraphControl1.Invalidate();
        }


        public void Calculate(string str)
        {
            Random random = new Random();

            //----------------------------------------ЗАПОЛНЕНИЕ МАТРИЦ
            #region ЗАПОЛНЕНИЕ МАТРИЦ

            KritAlts = new List<double[,]>();

            if (str == "example")
            {
                KritAlts.Add(new double[,] { { 1, 3, 2 }, { 0.33, 1, 0.33 }, { 0.5, 3, 1 } });
                KritAlts.Add(new double[,] { { 1, 0.25, 6 }, { 4, 1, 5 }, { 0.16, 0.2, 1 } });
                KritAlts.Add(new double[,] { { 1, 0.33, 2 }, { 3, 1, 5 }, { 0.5, 0.2, 1 } });
                KritCompares = new double[,] { { 1, 2, 3 }, { 0.5, 1, 4 }, { 0.33, 0.25, 1 } };
            }
            else
            {
                double[,] krits = new double[AltsCount, AltsCount];

                for (int count = 0; count < AltsCount; count++)
                {
                    krits = new double[AltsCount, AltsCount];

                    for (int i = 0; i < AltsCount; i++)
                    {
                        for (int j = 0; j < AltsCount; j++)
                        {
                            if (i == j) krits[i, j] = 1;
                            else if (i < j)
                            {
                                int ch = random.Next(2);
                                if (ch == 0) krits[i, j] = random.Next(1, 6);
                                else krits[i, j] = random.NextDouble();
                            }
                            else krits[i, j] = 1 / krits[j, i];
                        }
                    }

                    KritAlts.Add(krits);
                }


                KritCompares = new double[KritsCount, KritsCount];
                for (int i = 0; i < KritsCount; i++)
                {
                    for (int j = 0; j < KritsCount; j++)
                    {
                        if (i == j) KritCompares[i, j] = 1;
                        else if (i < j)
                        {
                            int ch = random.Next(2);
                            if (ch == 0) KritCompares[i, j] = random.Next(1, 6);
                            else KritCompares[i, j] = random.NextDouble();
                        }
                        else KritCompares[i, j] = 1 / KritCompares[j, i];
                    }
                }
            }

            #region Вывод матриц

            foreach (double[,] d in KritAlts)
            {
                string strn = "Сравнение алтернатив по критериям\r\n";
                for (int i = 0; i < d.GetLength(0); i++)
                {
                    for (int j = 0; j < d.GetLength(1); j++)
                    {
                        strn += $"{d[i, j]:0.00}\t";
                    }
                    strn += "\r\n";
                }
                MessageBox.Show(strn);
            }

            string strnK = "Сравнение критериев\r\n";
            for (int i = 0; i < KritCompares.GetLength(0); i++)
            {
                for (int j = 0; j < KritCompares.GetLength(1); j++)
                {
                    strnK += $"{KritCompares[i, j]:0.00}\t";
                }
                strnK += "\r\n";
            }
            MessageBox.Show(strnK);

            #endregion

            #endregion

            //---------------------------------РАСЧЁТ МАТРИЦ
            #region РАСЧЁТ МАТРИЦ

            KritNormals = new List<double[]>();

            foreach (double[,] d in KritAlts)
            {
                double Sum = 0;
                double[] sums = new double[d.GetLength(0)];
                for (int i = 0; i < d.GetLength(0); i++)
                {
                    double rowSum = 0;
                    for (int j = 0; j < d.GetLength(1); j++)
                    {
                        rowSum += d[i, j];
                    }
                    sums[i] = rowSum;
                    Sum += rowSum;
                }

                for (int i = 0; i < sums.Length; i++)
                {
                    sums[i] /= Sum;
                }

                KritNormals.Add(sums);

                #region Вывод нормированных критериев

                string ts1 = $"Общая сумма: {Sum:0.00}\r\n";
                foreach (double db in sums)
                {
                    ts1 += $"{db:0.00}\t";
                }

                MessageBox.Show(ts1);

                #endregion
            }

            double sumsWeights = 0;
            KritWeigths = new double[KritsCount];

            for (int i = 0; i < KritCompares.GetLength(0); i++)
            {
                double Sum = 0;
                for (int j = 0; j < KritCompares.GetLength(1); j++)
                {
                    Sum += KritCompares[i, j];
                }
                KritWeigths[i] = Sum;
                sumsWeights += Sum;
            }

            for (int i = 0; i < KritWeigths.Length; i++)
            {
                KritWeigths[i] /= sumsWeights;
            }

            #region Вывод весов

            string ts2 = $"Веса критериев, общая сумма: {sumsWeights:0.00}\r\n";
            foreach (double d in KritWeigths)
            {
                ts2 += $"{d:0.00}\t";
            }

            MessageBox.Show(ts2);

            #endregion

            #endregion

            //----------------------------------РАСЧЁТ ФУНКЦИЙ ПОЛЕЗНОСТИ И ЦЕН
            #region РАСЧЁТ ФУНКЦИЙ ПОЛЕЗНОСТИ И ЦЕН

            Functions = new double[AltsCount];
            MessageBox.Show("РАСЧЁТ ФУНКЦИЙ ПОЛЕЗНОСТИ");
            for (int i = 0; i < AltsCount; i++)
            {
                double sum = 0;
                for (int normals = 0; normals < KritNormals.Count; normals++)
                {
                    double res = KritNormals[normals][i] * KritWeigths[normals];
                    sum += res;
                    MessageBox.Show($"RES: {res:0.00}; FIRST: {KritNormals[normals][i]:0.00}; SECOND: {KritWeigths[normals]:0.00}");
                }
                Functions[i] = sum;
                MessageBox.Show($"Альтернатива {i + 1} : {sum:0.000}");
            }


            if (str == "example")
            {
                Prices = new int[] { 10000, 15000, 8000 };
            }
            else
            {
                Prices = new int[AltsCount];
                for (int i = 0; i < AltsCount; i++)
                {
                    Prices[i] = random.Next(5000, 20000);
                }
            }


            #region Вывод цен

            string ts3 = "Цены\r\n";
            foreach (int i in Prices)
            {
                ts3 += $"{i}\t";
            }
            ts3 += $"\r\nОбщая сумма: {Prices.Sum():0.00}";
            MessageBox.Show(ts3);

            #endregion

            #endregion

            PricesNorm = new double[AltsCount];
            for (int i = 0; i < AltsCount; i++)
            {
                double PricesSum = Prices.Sum();
                double pr = Prices[i];
                PricesNorm[i] = pr / PricesSum;
                MessageBox.Show($"Нормаль цены {i + 1} : {PricesNorm[i]:0.000}");
            }

            Alters = new List<Alternatives>();
            risks = new List<Risks>();

            for (int i = 0; i < AltsCount; i++)
            {
                double cmpr = Functions[i] / PricesNorm[i];
                Alters.Add(new Alternatives() { Compare = cmpr, Name = $"Альтернатива {i + 1}" });

                double rk = Function1(PricesNorm[i]) + Function2(PricesNorm[i]) + Function3(PricesNorm[i]);
                risks.Add(new Risks() { Compare = rk, Name = $"Альтернатива {i + 1}" });

                ZedGraph.GraphPane graphPane1 = zedGraphControl1.GraphPane;
                ZedGraph.PointPairList pointPairs = new ZedGraph.PointPairList();

                pointPairs.Add(PricesNorm[i], 0);
                pointPairs.Add(PricesNorm[i], Function1(PricesNorm[i]));
                pointPairs.Add(0, Function1(PricesNorm[i]));

                ZedGraph.LineItem lineItemResult1 = graphPane1.AddCurve($"Альтернатива {i + 1}", pointPairs, Color.Blue, ZedGraph.SymbolType.None);
                zedGraphControl1.Invalidate();


                ZedGraph.GraphPane graphPane2 = zedGraphControl2.GraphPane;
                ZedGraph.PointPairList pointPairs2 = new ZedGraph.PointPairList();

                pointPairs2.Add(PricesNorm[i], 0);
                pointPairs2.Add(PricesNorm[i], Function2(PricesNorm[i]));
                pointPairs2.Add(0, Function2(PricesNorm[i]));

                ZedGraph.LineItem lineItemResult2 = graphPane2.AddCurve($"Альтернатива {i + 1}", pointPairs2, Color.Green, ZedGraph.SymbolType.None);
                zedGraphControl2.Invalidate();


                ZedGraph.GraphPane graphPane3 = zedGraphControl3.GraphPane;
                ZedGraph.PointPairList pointPairs3 = new ZedGraph.PointPairList();

                pointPairs3.Add(PricesNorm[i], 0);
                pointPairs3.Add(PricesNorm[i], Function3(PricesNorm[i]));
                pointPairs3.Add(0, Function3(PricesNorm[i]));

                ZedGraph.LineItem lineItemResult3 = graphPane3.AddCurve($"Альтернатива {i + 1}", pointPairs3, Color.Purple, ZedGraph.SymbolType.None);
                zedGraphControl3.Invalidate();
            }


            Alters.Sort(delegate (Alternatives a1, Alternatives a2)
            {
                if (a1.Compare > a2.Compare) return -1;
                else if (a1.Compare < a2.Compare) return 1;
                else return 0;
            });

            risks.Sort(delegate (Risks a1, Risks a2)
            {
                if (a1.Compare > a2.Compare) return -1;
                else if (a1.Compare < a2.Compare) return 1;
                else return 0;
            });

            string answer = "Ответ:\r\n";
            foreach (Alternatives al in Alters)
            {
                answer += al.ToString() + "\r\n";
            }

            answer += "\r\n";
            foreach(Risks r in risks)
            {
                answer += r.ToString() + "\r\n";
            }
            MessageBox.Show(answer);





        }


        #region Graphs

        public void DrawGraphs()
        {
            ZedGraph.GraphPane graphPane1 = zedGraphControl1.GraphPane;
            ZedGraph.PointPairList pointPairs1 = new ZedGraph.PointPairList();

            graphPane1.CurveList.Clear();
            graphPane1.Title.Text = "График 1";

            for (double x = 0; x <= 1; x += 0.01)
            {
                pointPairs1.Add(x, Function1(x));
            }

            ZedGraph.LineItem lineItemResult1 = graphPane1.AddCurve("График 1", pointPairs1, Color.Red, ZedGraph.SymbolType.None);

            graphPane1.XAxis.Scale.Min = 0;
            graphPane1.XAxis.Scale.Max = 1;
            graphPane1.YAxis.Scale.Min = 0;
            graphPane1.YAxis.Scale.Max = 1;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();




            ZedGraph.GraphPane graphPane2 = zedGraphControl2.GraphPane;
            ZedGraph.PointPairList pointPairs2 = new ZedGraph.PointPairList();

            graphPane2.CurveList.Clear();
            graphPane2.Title.Text = "График 2";

            for (double x = 0; x <= 1; x += 0.01)
            {
                pointPairs2.Add(x, Function2(x));
            }

            ZedGraph.LineItem lineItemResult2 = graphPane2.AddCurve("График 2", pointPairs2, Color.Red, ZedGraph.SymbolType.None);

            graphPane2.XAxis.Scale.Min = 0;
            graphPane2.XAxis.Scale.Max = 1;
            graphPane2.YAxis.Scale.Min = 0;
            graphPane2.YAxis.Scale.Max = 1;

            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();



            ZedGraph.GraphPane graphPane3 = zedGraphControl3.GraphPane;
            ZedGraph.PointPairList pointPairs3 = new ZedGraph.PointPairList();

            graphPane3.CurveList.Clear();
            graphPane3.Title.Text = "График 3";

            for (double x = 0; x <= 1; x += 0.01)
            {
                pointPairs3.Add(x, Function3(x));
            }

            ZedGraph.LineItem lineItemResult3 = graphPane3.AddCurve("График 3", pointPairs3, Color.Red, ZedGraph.SymbolType.None);

            graphPane3.XAxis.Scale.Min = 0;
            graphPane3.XAxis.Scale.Max = 1;
            graphPane3.YAxis.Scale.Min = 0;
            graphPane3.YAxis.Scale.Max = 1;

            zedGraphControl3.AxisChange();
            zedGraphControl3.Invalidate();
        }
        
        public double Function1(double x)
        {
            if (x >= 0 && x < 0.32)
            {
                return 0.9;
            }
            else if (x >= 0.32 && x < 0.5)
            {
                return -10 * Math.Pow(x - 0.327, 2) + 0.9;
            }
            else if (x >= 0.5 && x <= 1)
            {
                return 2 * Math.Pow(x - 1, 2) + 0.1;
            }
            else MessageBox.Show($"Missing {x}");

            return 0;
        }

        public double Function2(double x)
        {
            if (x >= 0 && x < 0.08)
            {
                return 0.95;
            }
            else if (x >= 0.08 && x < 0.1)
            {
                return -30 * Math.Pow(x - 0.08, 2) + 0.95;
            }
            else if (x >= 0.1 && x <= 1)
            {
                return 1 / (x + 0.55) - 0.6;
            }
            else MessageBox.Show($"Missing {x}");

            return 0;
        }

        public double Function3(double x)
        {
            if (x >= 0 && x < 0.07)
            {
                return 0.95;
            }
            else if (x >= 0.07 && x < 0.13)
            {
                return -30 * Math.Pow(x - 0.068, 2) + 0.95;
            }
            else if (x >= 0.13 && x <= 1)
            {
                return 2 / (100 * x - 10) + 0.05;
            }
            else MessageBox.Show($"Missing {x}");

            return 0;
        }

        #endregion


        public class Alternatives
        {
            public double Compare { get; set; }
            public string Name { get; set; }

            public Alternatives()
            {
                Compare = 0;
                Name = "No name";
            }

            public override string ToString()
            {
                return $"Название: {Name}; Сравнительная полезность: {Compare:0.00}";
            }
        }

        public class Risks
        {
            public double Compare { get; set; }
            public string Name { get; set; }

            public Risks()
            {
                Compare = 0;
                Name = "No name";
            }

            public override string ToString()
            {
                return $"Название: {Name}; Риск: {Compare:0.00}";
            }
        }
    }
}
