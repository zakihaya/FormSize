using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormSize
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.textBox1.Text = this.Width.ToString();
            this.textBox2.Text = this.Height.ToString();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.textBox1.Text = this.Width.ToString();
            this.textBox2.Text = this.Height.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int w = 0;
            int h = 0;

            if (!int.TryParse(this.textBox1.Text, out w))
            {
                return;
            }
            if (!int.TryParse(this.textBox2.Text, out h))
            {
                return;
            }

            this.Width = w;
            this.Height = h;
        }
    }
}
