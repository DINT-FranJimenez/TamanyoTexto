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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            pequeñoRadioButton.IsChecked = true;
            
        }

        private void PequeñoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
     

            if (pequeñoRadioButton.IsChecked == true)
                MuestraTextBlock.FontSize = Convert.ToInt16(pequeñoRadioButton.Tag);


        }

        private void MedianoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (medianoRadioButton.IsChecked == true)
                MuestraTextBlock.FontSize = Convert.ToInt16(medianoRadioButton.Tag);
        }

        private void GrandeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (grandeRadioButton.IsChecked == true)
                MuestraTextBlock.FontSize = Convert.ToInt16(grandeRadioButton.Tag);
        }
    }
}
