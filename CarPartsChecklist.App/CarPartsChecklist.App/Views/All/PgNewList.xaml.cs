using CommunityToolkit.Maui.Core.Platform;
using System.Runtime.Versioning;

namespace CarPartsChecklist.App.Views;

public partial class PgNewList : ContentPage
{
	public PgNewList()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        this.Dispatcher.StartTimer(TimeSpan.FromMilliseconds(100), () =>
        {
            EntryStartFocus.Focus();
            return false; // Retorna false para que el temporizador no se repita
        });
    }

    [UnsupportedOSPlatform("maccatalyst")]
    private async void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        if (sender is not null && sender is Entry)
        {
            Entry entry = (sender as Entry)!;
            await entry!.HideKeyboardAsync(CancellationToken.None);
        }
    }
}