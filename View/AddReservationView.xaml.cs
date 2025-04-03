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
using System.Windows.Shapes;
using WpfGyakorlas.Model;

namespace WpfGyakorlas.View
{
    /// <summary>
    /// Interaction logic for AddReservationView.xaml
    /// </summary>
    public partial class AddReservationView : Window
    {
        public Contact NewContact { get; private set; } 
        public AddReservationView()
        {
            InitializeComponent();
        }

        private void AddContactbttn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametxtb.Text)||string.IsNullOrWhiteSpace(emailtxtb.Text)||string.IsNullOrWhiteSpace(teltxtb.Text))
            {
                MessageBox.Show("Minden mezőt megfelelően kell kitőlteni!", "HIBA", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            NewContact = new Contact
            {
                Name = nametxtb.Text,
                Email = emailtxtb.Text,
                Phone = teltxtb.Text
            };

            DialogResult = true;
            Close();
        }
    }
}
