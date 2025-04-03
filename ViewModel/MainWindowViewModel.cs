using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfGyakorlas.Model;

namespace WpfGyakorlas.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Contact> _contacts = new()
        {
            new Contact { Name="APuci", Email="nagyFater@69.com", Phone="06301234567" },
            new Contact { Name="Dr.Imre Hokk",Email="imrehokk@szervkereskedelem.hu",Phone="01"}
        };


        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(OpenEditInformationWindowCommand),nameof(DeleteContactCommand))]
        private Contact _sellectedItem;


        [RelayCommand]
        private void OpenAddInformationWindow()
        {
            var addReservationView = new View.AddReservationView();
            if (addReservationView.ShowDialog()==true)
            {
                Contacts.Add(addReservationView.NewContact);
                
            }
        }

        [RelayCommand(CanExecute =nameof(isSellected))]
        private void OpenEditInformationWindow()
        {
            if (SellectedItem!=null)
            {
                var editReservationView = new View.EditReservationView(SellectedItem);
                if (editReservationView.ShowDialog()==true)
                {
                    OnPropertyChanged(nameof(Contacts));
                }

            }
        }
        [RelayCommand(CanExecute = nameof(isSellected))]
        private void DeleteContact()
        {
            if (SellectedItem != null)
            {
                if (MessageBox.Show($"Biztosan Törölni szeretnéd {SellectedItem.Name} információt?","kérdés",MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
                {
                    Contacts.Remove(SellectedItem);
                }
            }
        }



        private bool isSellected()
        {
            return SellectedItem != null;
        }
    }
}
