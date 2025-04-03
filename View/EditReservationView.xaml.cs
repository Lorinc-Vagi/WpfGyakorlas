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
    /// Interaction logic for EditReservationView.xaml
    /// </summary>
    public partial class EditReservationView : Window
    {
        public Contact EditedRContact { get; private set; }
        public EditReservationView(Contact contact)
        {
            InitializeComponent();
            EditedRContact = contact;

            DataContext = EditedRContact;

        }

        private void EdditContactbttn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(nametxtb.Text) || string.IsNullOrWhiteSpace(emailtxtb.Text) || string.IsNullOrWhiteSpace(teltxtb.Text))
                {
                    MessageBox.Show("Minden mezőt megfelelően kell kitőlteni!", "HIBA", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                EditedRContact.Name = nametxtb.Text;
                EditedRContact.Email = emailtxtb.Text;
                EditedRContact.Phone = teltxtb.Text;

                DialogResult = true;
                Close();
            }
        }
    }
}
