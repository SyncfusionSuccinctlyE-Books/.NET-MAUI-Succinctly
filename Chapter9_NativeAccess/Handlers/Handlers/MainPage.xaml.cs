using Microsoft.Maui.Platform;

namespace Handlers;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		ModifyEntry();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    void ModifyEntry()
    {
        Microsoft.Maui.Handlers.EntryHandler.
			Mapper.AppendToMapping("AutoSelectOnFocus", (handler, view) =>
		{
			if (view is AutoSelectEntry)
			{
#if ANDROID
            handler.PlatformView.SetSelectAllOnFocus(true);
#elif iOS
            handler.PlatformView.PerformSelector(new ObjCRuntime
                  .Selector("selectAll"), null, 0.0f);

#elif WINDOWS
            handler.PlatformView.SelectAll();
#endif
        }
    });


    }

    public class AutoSelectEntry: Entry
	{

	}

    private void Entry_HandlerChanging(object sender, HandlerChangingEventArgs e)
    {
        if (e.OldHandler != null)
        {
#if ANDROID
            (e.OldHandler.PlatformView as Android.Views.View).FocusChange -= OnFocusChange;
#endif
        }
    }

    private void Entry_HandlerChanged(object sender, EventArgs e)
    {
#if ANDROID
        ((sender as Entry).Handler.PlatformView as Android.Views.View).FocusChange += OnFocusChange;
#endif
    }


#if ANDROID
    void OnFocusChange(object sender, EventArgs e)
    {
        var nativeView = sender as AndroidX.AppCompat.Widget.AppCompatEditText;

        if (nativeView.IsFocused)
            nativeView.SetBackgroundColor(Colors.LightGray.ToPlatform());
        else
            nativeView.SetBackgroundColor(Colors.Transparent.ToPlatform());
    }
#endif  
}

