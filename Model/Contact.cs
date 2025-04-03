using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGyakorlas.Model
{
    public partial class Contact : ObservableObject
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private string _phone;


    }
    
}
