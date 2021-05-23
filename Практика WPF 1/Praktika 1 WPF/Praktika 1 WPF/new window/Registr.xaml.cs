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
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Page
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Framemm.mak.Navigate(new MainB());
        }

        public bool proverkaStr { get; set; } //Булевая переменная для проверки все ли поля заполнены
        private void Btn_create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                char dog = '@'; //Переменная для проверки строки с Email
                Proverka(Tb_login); //Вызов методов для проверки полей
                if (proverkaStr == true)
                {
                    if (proverkaStr == true && Pb_password.Password == Pb_povtor.Password)//Условия проверки на совпадение паролей
                    {
                        if (proverkaStr == true)
                        {

                            if (Tb_email.Text.IndexOf(dog) >= 1 && proverkaStr == true)//Условия проверки на @ и на то что все поля заполнены верно
                            {
                                MessageBox.Show("Вы успешно зарегистрировались!");
                            }
                            else { MessageBox.Show("Email указан не верно!", "Ошибка заполнения"); }//Сообщение об ошибке
                        }
                    }
                    else { MessageBox.Show("Пароли не совпадают!", "Ошибка заполнения"); }//Сообщение об ошибке
                }
                else { MessageBox.Show("Поля заполнены неверно!", "Ошибка заполнения"); }//Сообщение об ошибке

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Proverka(TextBox textBox)//Метод который проверяет Текст на пробелы и пустоту
        {
            try
            {
                string tb = textBox.Text;
                char space = ' ';
                if (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text) || Convert.ToInt32(tb.IndexOf(space)) >= 0)//Условия проверки
                {
                    proverkaStr = false;
                }
                else proverkaStr = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
