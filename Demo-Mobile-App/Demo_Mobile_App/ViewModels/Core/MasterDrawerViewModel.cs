using Demo_Mobile_App.Models.Core;
using Demo_Mobile_App.Views.Home;
using Demo_Mobile_App.Views.Order;
using Demo_Mobile_App.Views.Sales;
using Demo_Mobile_App.Views.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Mobile_App.ViewModels.Core
{
    public class MasterDrawerViewModel : ModelBase
    {
        public ObservableCollection<MasterDrawerMenuItem> MenuItems { get; set; }

        public MasterDrawerViewModel()
        {
            MenuItems = new ObservableCollection<MasterDrawerMenuItem>(new[]
            {
                    new MasterDrawerMenuItem { Id = 0, Title = "My Acount", Image="", TargetType=typeof(Index) },
                    new MasterDrawerMenuItem { Id = 1, Title = "My Orders", Image="", TargetType=typeof(MyOrders) },
                    new MasterDrawerMenuItem { Id = 2, Title = "Browse Product", Image="", TargetType=typeof(Products) },
                    new MasterDrawerMenuItem { Id = 3, Title = "Settings", Image="", TargetType=typeof(Settings) },
             });
        }
    }
}
