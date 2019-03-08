/*
 * Jesse Stanley
 * 3/8/2019
 * needs a label called lblOutput
 */
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

namespace _184784WhileExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /* Make sure to add a text file to your project and set 
                * the property Build Action to Conten and the Copy to 
                * Output Directory property to Copy Always.
                */
            System.IO.StreamReader reader = new System.IO.StreamReader("184784File.txt");
            try
               
            {
                string output = "";
                while (!reader.EndOfStream)
                {
                    output = output + Environment.NewLine + reader.ReadLine();
                }
                output = output.Trim();
                lblOutput.Content = output;
            } catch (Exception ex) { }
        }
    }
}
