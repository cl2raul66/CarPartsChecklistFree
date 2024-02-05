using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsChecklist.App.ViewModels;

public partial class PgNewListViewModel : ObservableValidator
{
    [RelayCommand]
    async Task Cancel() => await Shell.Current.GoToAsync("..", true);
}
