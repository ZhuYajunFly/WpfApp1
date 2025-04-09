using ScottPlot;
using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static double func1(double x) => (Math.Sin(x) * Math.Sin(x / 2));

        FunctionPlot functionPlot;
        private void BtnInit_Click(object sender, RoutedEventArgs e)
        {
            functionPlot =  WpfPlot1.Plot.Add.Function(func1);
            functionPlot.MinX = 10;
            functionPlot.MaxX = 20;
            WpfPlot1.Refresh();
        }

        private void BtnChangeXRange_Click(object sender, RoutedEventArgs e)
        {
            functionPlot.MinX = 0;
            functionPlot.MaxX = 30;
            WpfPlot1.Refresh();
        }
    }
}
