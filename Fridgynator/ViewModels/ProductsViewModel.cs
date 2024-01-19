using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridgynator.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {
        [ObservableProperty]
        string imageSource;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        string comment;    
    }
}
