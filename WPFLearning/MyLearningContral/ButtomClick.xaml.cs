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

namespace WPFLearning
{
    /// <summary>
    /// ButtomClick.xaml 的交互逻辑
    /// </summary>
    public partial class ButtomClick : UserControl
    {
        public ButtomClick()
        {
            InitializeComponent();
        }

        private void buttom1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I just a buttom");
        }
    }
}
