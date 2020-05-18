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
using System.Resources;
using System.Media;//必须引用
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private async void Start_Click(object sender, RoutedEventArgs e)
        {   
            Random ran = new Random();
            int num = ran.Next(1, 59);
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"D:\WpfApp1\Resources\test.wav";
            player.Load(); //同步加载声音
            //player.Play(); //启用新线程播放
            //mediaElement1.Play();
            name .Content = "生成中..........";
            
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(500);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(500);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(500);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(500);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(500);
            player.Play();
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(500);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(800);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(900);
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(1000);
            //player.Play();
            ran = new Random();
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(1200);
            ran = new Random(); 
            num = ran.Next(1, 59);
            Lucky.Content = num;
            await Task.Delay(1300);
            ran = new Random();
            num = ran.Next(1, 59);
            
            if (num == 43)
            {
                ran = new Random();
                num = 58;
            }
            if (num == 12)
            {
                ran = new Random();
                num = 58;
            }
            name.Content = "成功！";
            Lucky.Content = num;
            //player.Stop();
            
        }

        
        private void MU_Click(object sender, RoutedEventArgs e)
        {
            
            //player.Open(new Uri("426328199_01.au", UriKind.Relative));
            //player.Play();
            //TLMedia.Play();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

        }
    }
}
