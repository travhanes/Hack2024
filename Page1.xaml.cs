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

namespace Hack2024
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void GoToPage2_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Page 2
            NavigationService?.Navigate(new Page2());
        }

        private void GoToPage3_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Page 2
            NavigationService?.Navigate(new Page3());
        }
    }
}
