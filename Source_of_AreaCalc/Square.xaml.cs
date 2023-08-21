using System.Windows.Controls;
using System.Windows;

namespace AeraCalc
{
    public partial class Square : Page
    {
        private const double cmtoinch = 0.393701;
        private bool is_cm = true, is_inch = false;
        public Square()
        {
            InitializeComponent();
        }

        private void Getanswer(object sender, RoutedEventArgs e)
        {
            double r = double.Parse(a.Text);
            double res = r * r;
            area.Text = res.ToString();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // 清空radius
            a.Text = "";
            area.Text = "";
        }
        private void Return_Click(object sender, RoutedEventArgs e)
        {
            // 返回主界面
            App.Current.MainWindow.Content = new MainPage();
            App.Current.MainWindow.Show();
        }
        private void ToCm_Click(object sender, RoutedEventArgs e)
        {
            if (is_inch && area.Text != "面积")
            {
                double r = double.Parse(a.Text) / cmtoinch;
                double res = r * r;
                a.Text = r.ToString();
                area.Text = res.ToString();
                label1.Content = "cm";
                label2.Content = "cm²";
                is_inch = false;
                is_cm = true;
            }
            else if (area.Text == "面积")
            {
                label1.Content = "cm";
                label2.Content = "cm²";
            }
        }
        private void ToInch_Click(object sender, RoutedEventArgs e)
        {
            if (is_cm && area.Text != "面积")
            {
                double r = double.Parse(a.Text) * cmtoinch;
                double res = r * r;
                a.Text = r.ToString();
                area.Text = res.ToString();
                label1.Content = "inch";
                label2.Content = "inch²";
                is_inch = true;
                is_cm = false;
            }
            else if (area.Text == "面积")
            {
                label1.Content = "inch";
                label2.Content = "inch²";
            }
        }
    }
}
