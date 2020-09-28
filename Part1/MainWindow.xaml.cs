/// Lab No. 4		Exercise Part 1
/// File Name: Speed check
/// @author: Evan Sinclair
/// Date:  Sept 26, 2020
///
/// Problem Statement:create a GUI that takes in a speed limit and your speed. Add a Canvas element that changes
/// color, green (legal speed), yellow (speeding no penalty), red (speeding with penalty). In addition, add a 
/// label that in addition to the color prints out the status.
/// 
/// Overall Plan:
/// 1)Create a canvas
/// 2)Create text boxes and labels for speed and speed limit
/// 3)Create a label for output
/// 4)Create Button for execution
/// 5)create if else statement to compare speed and speed limit
/// 6)Output message and change color of canvas
///
///
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

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int speedLimit, speed;

            speed = Convert.ToInt32(speedBox.Text);
            speedLimit = Convert.ToInt32(speedLimitBox.Text);

            if (speed <= speedLimit)
            {
                outputLabel.Content = "Traveling at a lawful speed";
                mainCanvas.Background = new SolidColorBrush(Colors.Green);
            }
     
            else if (speed <= (speedLimit + 5))
            {
                outputLabel.Content = "Speeding but no penalty";
                mainCanvas.Background = new SolidColorBrush(Colors.Yellow);
            }
            
            else
            {
                outputLabel.Content = "Speeding with penalty";
                mainCanvas.Background = new SolidColorBrush(Colors.Red);
            }

        }
    }
}
