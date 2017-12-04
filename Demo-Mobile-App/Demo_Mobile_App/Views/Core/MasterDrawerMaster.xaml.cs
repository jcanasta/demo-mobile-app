using Demo_Mobile_App.Models.Core;
using Demo_Mobile_App.ViewModels.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_Mobile_App.Views.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDrawerMaster : ContentPage
    {
        public ListView ListView;

        public MasterDrawerMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDrawerViewModel();
            ListView = MenuItemsListView;
        }
    }
}