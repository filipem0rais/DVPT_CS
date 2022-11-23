using System;
using System.Collections;
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

namespace Exercice_CompteurInstance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<MaClasse> liste;

        public MainWindow()
        {
            InitializeComponent();
            liste = new List<MaClasse>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            liste.Add(new MaClasse());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            affichage.Content = MaClasse.instances;
        }
    }
}