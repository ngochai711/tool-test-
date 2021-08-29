using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Test_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            FirefoxDriver firefoxDrivertest = new FirefoxDriver();

            firefoxDrivertest.Url = "https://vi-vn.facebook.com/";
            firefoxDrivertest.Navigate();

            var email = firefoxDrivertest.FindElementById("email");
            email.SendKeys("Nhap tai khoan deeeee");

            var passWord = firefoxDrivertest.FindElementById("pass");
            passWord.SendKeys("Password do day nha :)))");

            var login = firefoxDrivertest.FindElementByName("login");
            login.Click();

            var searchBo = firefoxDrivertest.FindElementByCssSelector("div.lpgh02oy:nth-child(6) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > span:nth-child(2) > div:nth-child(1) > div:nth-child(1)");
            searchBo.Click();

            Thread.Sleep(TimeSpan.FromSeconds(10));

            var addsearchBo = firefoxDrivertest.FindElementByCssSelector("input.oajrlxb2:nth-child(1)");
            addsearchBo.SendKeys("Ten ng can tim");

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var clickBo = firefoxDrivertest.FindElementByXPath("/html/body/div[1]/div/div[1]/div/div[5]/div/div[1]/div[1]/div[1]/div/div/div/div/div/div[2]/div/div[2]/div/div[1]/div/ul/li[1]/div/a/div");
            clickBo.Click();
            
            Thread.Sleep(TimeSpan.FromSeconds(10));

            var chat_box = firefoxDrivertest.FindElementByCssSelector("._1mf");
            chat_box.Click();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            firefoxDrivertest.ExecuteScript("var x = document.getElementsByClassName('_1mf _1mj'); x[0].innerHTML = 'Test bot'; var e = new Event('keydown'); e.keyCode = 13; ");

           

            
        }


    }
}
