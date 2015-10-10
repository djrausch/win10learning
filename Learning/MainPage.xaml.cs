﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Learning
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void hello_click(object sender, RoutedEventArgs e)
        {
            greetingOutput.Text = "Hello, " + nameInput.Text + "!";


            //image.Source = new BitmapImage(new Uri("https://assets.onestore.ms/cdnfiles/onestorerolling-1510-07012/shell/v1_4/images/logo/microsoft.png", UriKind.Absolute));

            //this.Frame.Navigate(typeof(BlankPage1),nameInput.Text);
        }

        private void listview_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ListViewPage));
        }

        private void pivot_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PivotPage));
        }
    }
}
