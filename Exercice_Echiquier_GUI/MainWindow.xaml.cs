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

namespace Exercice_Echiquier_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Echiquier chessBoard = new Echiquier();

            Array chessBoardArray = chessBoard.GetEchiquierArray();

            displayChessboard(chessBoardArray);


        }

        private void displayChessboard(Array chessBoardArray)
        {
            // display the chessboard
            for (int i = 0; i < chessBoardArray.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoardArray.GetLength(1); j++)
                {
                    Button myButton = new Button();
                    myButton.Content = chessBoardArray.GetValue(i, j);
                    myButton.Name = "Button" + i + j;
                    if ((i + j) % 2 == 0)
                    {
                        myButton.Background = Brushes.White;
                        myButton.Foreground = Brushes.Black;
                        
                    }
                    else
                    {
                        myButton.Background = Brushes.Black;
                        myButton.Foreground = Brushes.White;
                    }

                   // BitmapImage btm = new BitmapImage(new Uri("/Exercice_Echiquier_GUI;component/Images/" + chessBoardArray.GetValue(i, j) + ".png", UriKind.Relative));
                   // Image img = new Image();
                   // img.Source = btm;
                   // myButton.Content = img;


                    Grid.SetRow(myButton, i);
                    Grid.SetColumn(myButton, j);
                    gridMain.Children.Add(myButton);                    
                }
            }
        }
    }
}
