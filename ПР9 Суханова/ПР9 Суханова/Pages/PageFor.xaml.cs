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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПР9_Суханова.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для PageFor.xaml
    /// </summary>
    public partial class PageFor : Page
    {
        public PageFor()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            clsFrame.frmObject.Navigate(new PageDoWhile());
        }
    }
}
