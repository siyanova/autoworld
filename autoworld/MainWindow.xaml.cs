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

namespace autoworld
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Log.Text.Length > 0)
            {
                if (pass.Password.Length > 0)
                {
                    if (Log.Text == "admin" && pass.Password == "123")
                    {
                        admin admin = new admin();
                        this.Close();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("неверный пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
