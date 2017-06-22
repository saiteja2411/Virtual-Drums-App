using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace virtualDrums
{
    public partial class Page1 : PhoneApplicationPage
    {
        bool a=false;
        public Page1()
        {
            InitializeComponent();

        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
        

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void ellipse4_Tap(object sender, GestureEventArgs e)
        {
               // p1.Stop();
                p1.Play();
      
        }

        private void bass_MediaOpened(object sender, RoutedEventArgs e)
        {

        }

        private void ellipse1_Tap(object sender, GestureEventArgs e)
        {
           // b5.Stop();
            b5.Play();
        }



        private void ellipse3_Tap_1(object sender, GestureEventArgs e)
        {
                //b3.Stop();
                b3.Play();
        }

        private void ellipse5_Tap_1(object sender, GestureEventArgs e)
        {
            p2.Stop();
            p2.Play();
        }

        private void ellipse6_Tap_1(object sender, GestureEventArgs e)
        {
           // b1.Stop();
            b1.Play();
        }

        private void ellipse7_Tap_1(object sender, GestureEventArgs e)
        {
            //b4.Stop();
            b4.Play();
        }

        private void ellipse2_Tap(object sender, GestureEventArgs e)
        {
           // b2.Stop();
            b2.Play();
        }

        private void image2_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

       
    }
}