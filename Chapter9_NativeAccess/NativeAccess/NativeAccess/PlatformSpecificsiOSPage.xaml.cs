using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace NativeAccess;

public partial class PlatformSpecificsiOSPage : ContentPage
{
	public PlatformSpecificsiOSPage()
	{
		InitializeComponent();

        //this.ListView1.On<iOS>().SetSeparatorStyle(SeparatorStyle.FullWidth);
    }
}