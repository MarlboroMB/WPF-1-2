using Praktika_1_WPF.Class;
using Praktika_1_WPF.new_window;
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

namespace Praktika_1_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Framemm.mak = MainWin;
            MainWin.Navigate(new MainB());
        }

        private void Btn_create_Click(object sender, RoutedEventArgs e)
        {
            MainWin.Navigate(new Registr());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWin.Navigate(new Login());
        }
    }
}
