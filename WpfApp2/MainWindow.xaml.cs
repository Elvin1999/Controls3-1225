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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer=new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            //timer.Start();
            // prgbar.IsIndeterminate=true;

            //listbox.ItemsSource=GetCars();

            //myDataGrid.ItemsSource = GetCars();
        }

        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Model="E-200",
                    Vendor="Mercedes",
                    Year=2022
                },
                new Car
                {
                    Model="Malibu",
                    Vendor="Chevrolet",
                    Year=2017
                },
                new Car
                {
                    Model="Grandeour",
                    Vendor="Hyundai",
                    Year=2021
                },
                new Car
                {
                    Model="Supra",
                    Vendor="Toyota",
                    Year=2010
                },
                new Car
                {
                    Model="A8",
                    Vendor="Audi",
                    Year=2022
                }
            };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    prgbar.Value += 5;
            //}
            //else
            //{
            //    timer.Stop();
            //    MessageBox.Show("Downloading Ended");
            //}
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    prgbar.Value += 5;
            //}
        }

        private void down_Click(object sender, RoutedEventArgs e)
        {
            //if(prgbar.Value > prgbar.Minimum)
            //{
            //    prgbar.Value -= 5;
            //}
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //up.Content = mySlider.Value;
            //int data = (int)double.Parse(mySlider.Value.ToString());
            //byte r = byte.Parse(data.ToString());
            //byte g = 100;
            //byte b = 100;
            //this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var item=listbox.SelectedItem as Car;
            //MessageBox.Show(item.ToString());
        }

        private void cmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var stckPanel = btn.Parent as StackPanel;
            var text = stckPanel.Children[1] as TextBlock;
            MessageBox.Show(text.Text);
        }
    }
}
