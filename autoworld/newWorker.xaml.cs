﻿using System;
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
using System.Windows.Shapes;

namespace autoworld
{
    /// <summary>
    /// Логика взаимодействия для newWorker.xaml
    /// </summary>
    public partial class newWorker : Window
    {
        public newWorker()
        {
            InitializeComponent();
        }

      

        private void new_Click(object sender, RoutedEventArgs e)
        {
            spisokworkers spisok = new spisokworkers();
            spisok.Show();
            this.Close();
        }
    }
}
