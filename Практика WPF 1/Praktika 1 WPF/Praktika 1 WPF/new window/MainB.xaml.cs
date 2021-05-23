using Praktika_1_WPF.Class;
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

namespace Praktika_1_WPF.new_window
{
    /// <summary>
    /// Логика взаимодействия для MainB.xaml
    /// </summary>
    public partial class MainB : Page
    {
        public MainB()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Framemm.mak.Navigate(new Login());
        }

        private void Btn_create_Click(object sender, RoutedEventArgs e)
        {
            Framemm.mak.Navigate(new Registr());
        }
    }
}
