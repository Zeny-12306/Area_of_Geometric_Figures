using System;
using System.Windows.Controls;
using System.Windows;

namespace AeraCalc
{
    public partial class Trig : Page
    {
        private const double cmtoinch = 0.393701;
        private bool is_cm = true, is_inch = false;
        public Trig()
        {
            InitializeComponent();
        }

        private void Getanswer(object sender, RoutedEventArgs e)
        {
            double a_val = double.Parse(a.Text);
            double b_val = double.Parse(b.Text);
            double res = 0.5 * a_val * b_val;
            area.Text = res.ToString();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // 清空radius
            a.Text = "";
            b.Text = ""; 
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
                double a_val = double.Parse(a.Text) / cmtoinch;
                double b_val = double.Parse(b.Text) / cmtoinch;
                double res = a_val * b_val * 0.5;
                area.Text = res.ToString();
                a.Text = a_val.ToString();
                b.Text = b_val.ToString();
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
                double a_val = double.Parse(a.Text) * cmtoinch;
                double b_val = double.Parse(b.Text) * cmtoinch;
                double res = a_val * b_val;
                area.Text = res.ToString();
                a.Text = a_val.ToString();
                b.Text = b_val.ToString();
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
