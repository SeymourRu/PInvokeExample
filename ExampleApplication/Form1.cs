using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = DLLApi.ReadIntValuesFromDll();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart1.Titles.Add("Random int points");
            for (int i = 0; i < values.Count; i++)
            {
                var series = chart1.Series.Add("Point " + i + ": " + values[i]);
                series.Points.Add(values[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var values = DLLApi.ReadFloatValuesFromDll();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart1.Titles.Add("Random float points");
            for (int i = 0; i < values.Count; i++)
            {
                var series = chart1.Series.Add("Point " + i + ": " + values[i]);
                series.Points.Add(values[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var values = DLLApi.ReadDoubleValuesFromDll();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart1.Titles.Add("Random double points");
            for (int i = 0; i < values.Count; i++)
            {
                var series = chart1.Series.Add("Point " + i + ": " + values[i]);
                series.Points.Add(values[i]);
            }
        }
    }
}
