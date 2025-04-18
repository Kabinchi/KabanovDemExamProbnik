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
using Kabanov_DemExam_18052025.Models;

namespace Kabanov_DemExam_18052025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            using (var context = new Kabanov_DemEx_18042025Context())
            {
                ClientsListView.ItemsSource = context.Clients
                    .ToList();
            }
        }
    }
}
