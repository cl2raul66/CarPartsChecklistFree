using CarPartsChecklist.App.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsChecklist.App.ViewModels;

public partial class PgAllViewModel : ObservableRecipient
{
    [RelayCommand]
    async Task GoToNewlist()
    {
        await Shell.Current.GoToAsync(nameof(PgNewList));
    }
}
