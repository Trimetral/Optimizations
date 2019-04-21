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
    public partial class ApproxForm : Form
    {
        double xmin = -50d;
        double xmax = 50d;
        double step = 2d;

        bool first = true;
        double min = 0;
        double max = 0;
        double minY = 0;
        double maxY = 0;

        public Random Random = new Random();

        public ApproxForm()
        {
            InitializeComponent();
        }

        void Draw()
        {
            if (minTB.Text != "")
            {
                try
                {
                    xmin = Convert.ToDouble(minTB.Text);
                }
                catch
                {
                    MessageBox.Show("Задан неверный формат числа для минимума!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minTB.Text = "";
                    return;
                }
            }

            if (maxTB.Text != "")
            {
                try
                {
                    xmax = Convert.ToDouble(maxTB.Text);
                }
                catch
                {
                    MessageBox.Show("Задан неверный формат числа для максимума!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maxTB.Text = "";
                    return;
                }
            }

            if (stepTB.Text != "")
            {
                try
                {
                    step = Convert.ToDouble(stepTB.Text);
                }
                catch
                {
                    MessageBox.Show("Задан неверный формат числа для шага!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stepTB.Text = "";
                    return;
                }
            }

            ZedGraph.GraphPane graphPane2 = zedGraphControl1.GraphPane;
            ZedGraph.PointPairList pointPairs2 = new ZedGraph.PointPairList();

            graphPane2.CurveList.Clear();
            graphPane2.Title.Text = "Случайные значениия";

            double xSum = 0d;
            double ySum = 0d;
            double xySum = 0d;
            double xSqSum = 0d;

            for (double x = xmin; x <= xmax; x += step)
            {
                double y = Random.NextDouble() + Random.Next(0, 10);
                pointPairs2.Add(x, y);
                xSum += x;
                ySum += y;
                xySum += x * y;
                xSqSum += x * x;
            }

            ZedGraph.LineItem lineItem2 = graphPane2.AddCurve("Случайные значения", pointPairs2, Color.Red, ZedGraph.SymbolType.None);

            double a = (pointPairs2.Count * xySum - xSum * ySum) / (pointPairs2.Count * xSqSum - xSum * xSum);
            double b = (ySum - a * xSum) / pointPairs2.Count;

            koefaTB.Text = a.ToString("0.000000");
            koefbTB.Text = b.ToString("0.00");

            ZedGraph.GraphPane graphPane3 = zedGraphControl1.GraphPane;
            ZedGraph.PointPairList pointPairs3 = new ZedGraph.PointPairList();

            for(double x = xmin; x <= xmax; x++)
            {
                pointPairs3.Add(x, a * x + b);
            }

            ZedGraph.LineItem lineItem3 = graphPane3.AddCurve("Линейная аппроксимация", pointPairs3, Color.Purple, ZedGraph.SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void ПосчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void ПосчитатьсвоиТочкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountPoints countPoints = new CountPoints();
            countPoints.ShowDialog();

            if (countPoints.Ready)
            {
                ZedGraph.GraphPane graphPaneStart = zedGraphControl1.GraphPane;
                ZedGraph.PointPairList pointPairsStart = new ZedGraph.PointPairList();
                graphPaneStart.CurveList.Clear();
                graphPaneStart.Title.Text = "Заданные значениия";

                double xSum = 0d;
                double ySum = 0d;
                double xySum = 0d;
                double xSqSum = 0d;

                


                for (int i = 0; i < countPoints.Count; i++)
                {
                    AddingPoint addingPoint = new AddingPoint();
                    addingPoint.ShowDialog();

                    if (addingPoint.Drop)
                    {
                        MessageBox.Show("Ввод данных прерван!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (addingPoint.Ready)
                    {
                        double x = addingPoint.X;
                        double y = addingPoint.Y;
                        pointPairsStart.Add(x, y);
                        xSum += x;
                        ySum += y;
                        xySum += x * y;
                        xSqSum += x * x;

                        if (first)
                        {
                            first = false;
                            min = max = x;
                            minY = maxY = y;
                        }
                        else
                        {
                            if (x < min) min = x;
                            if (x > max) max = x;

                            if (y < minY) minY = y;
                            if (y > maxY) maxY = y;
                        }
                    }
                }

                double a = (pointPairsStart.Count * xySum - xSum * ySum) / (pointPairsStart.Count * xSqSum - xSum * xSum);
                double b = (ySum - a * xSum) / pointPairsStart.Count;

                koefaTB.Text = a.ToString("0.0######");
                koefbTB.Text = b.ToString("0.0#");

                ZedGraph.GraphPane graphPaneResult = zedGraphControl1.GraphPane;
                ZedGraph.PointPairList pointPairsResult = new ZedGraph.PointPairList();

                graphPaneResult.XAxis.Scale.Min = min;
                graphPaneResult.XAxis.Scale.Max = max;
                if (min > 0)
                {
                    min = 0;
                    graphPaneResult.XAxis.Scale.Min = 0;
                }

                if (minY > 0)
                {
                    minY = 0;
                    graphPaneResult.YAxis.Scale.Min = 0;
                }

                for (double x = min; x <= max; x++)
                {
                    pointPairsResult.Add(x, a * x + b);
                }

                if (max > maxY)
                {
                    graphPaneResult.XAxis.Scale.Max = max;
                    graphPaneResult.YAxis.Scale.Max = max;
                }
                else
                {
                    graphPaneResult.XAxis.Scale.Max = maxY;
                    graphPaneResult.YAxis.Scale.Max = maxY;
                }

                if (min < minY)
                {
                    graphPaneResult.XAxis.Scale.Min = min;
                    graphPaneResult.YAxis.Scale.Min = min;
                }
                else
                {
                    graphPaneResult.XAxis.Scale.Min = minY;
                    graphPaneResult.YAxis.Scale.Min = minY;
                }

                this.Size = new Size(568, 702);

                ZedGraph.LineItem lineItemResult = graphPaneResult.AddCurve("Линейная аппроксимация", pointPairsResult, Color.Red, ZedGraph.SymbolType.None);

                ZedGraph.LineItem lineItemStart = graphPaneStart.AddCurve("Заданные значения", pointPairsStart, Color.Blue, ZedGraph.SymbolType.None);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
        }

    }
}
