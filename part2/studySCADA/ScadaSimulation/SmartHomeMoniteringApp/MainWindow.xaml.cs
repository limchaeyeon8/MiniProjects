﻿using MahApps.Metro.Controls;
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
using System.Diagnostics;

namespace SmartHomeMoniteringApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // <Frame> ==> Page.Xaml
            // <ContentControl> ==> UserControl.xaml
            ActiveItem.Content = new Views.DBControl();
        }

        // 끝내기 버튼 클릭 이벤트 핸들러
        private void MnuExitProgram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();  // 작업관리자에서 프로세스 종료!
            //Environment.Exit(0);        // 0: normal - 종료       // 둘 중 하나만 쓰면 됨
        }
    }
}
