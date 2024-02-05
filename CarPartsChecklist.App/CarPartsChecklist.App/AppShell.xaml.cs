using CarPartsChecklist.App.Views;

namespace CarPartsChecklist.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(PgNewList), typeof(PgNewList));
    }
}
