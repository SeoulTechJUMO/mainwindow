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
using System.Windows.Threading;
using System.Windows.Diagnostics;
using System.Timers;


namespace 메인창
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainMenu : Window
    {

        public MainMenu()
        {
            InitializeComponent();
         
        }

        private void PlayListOpen_Click(object sender, RoutedEventArgs e)
        {
            PlayList winFileOpen = new PlayList();
            winFileOpen.Owner = this;
            if(winFileOpen.ShowDialog() == true)
            {

            }
        }
        
        private void Mixser_Click(object sender, RoutedEventArgs e)
        {
            Mixser winFileOpen = new Mixser();
            winFileOpen.Owner = this;
            if (winFileOpen.ShowDialog() == true)
            {

            }
        }


        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            SettingWindow winFileOpen = new SettingWindow();
            winFileOpen.Owner = this;
            if (winFileOpen.ShowDialog() == true)
            {

            }
        }

        private void Menu1(object sender, RoutedEventArgs e)
        {
            Mixser winFileOpen = new Mixser();
            winFileOpen.Owner = this;
            if (winFileOpen.ShowDialog() == true)
            {

            }
        }
    }
}
