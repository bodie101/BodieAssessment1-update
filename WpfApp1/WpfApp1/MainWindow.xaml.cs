﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        static Models.Validation val = new Models.Validation();

    
        public MainWindow()  
        {
            InitializeComponent();

        }





        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            errormessage.Content = val.ValidatePass(passwordBox1.Password, passwordBoxConfirm.Password, textBoxEmail.Text);

        }
    }
}
