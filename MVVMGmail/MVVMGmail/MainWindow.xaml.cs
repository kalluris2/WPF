using EmailViewModel;
using LoginCrediantials;
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

namespace MVVMGmail
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

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            Inputs input = new Inputs();
            input.Sender = fromTextBox.Text;
            input.Receiver = toTextBox.Text;
            input.Password = passwordTextBox.Text;
            input.Message = messageTextBox.Text;
            input.CC = ccTextBox.Text;
            ViewModel model = new ViewModel();
            model.Email(input);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
