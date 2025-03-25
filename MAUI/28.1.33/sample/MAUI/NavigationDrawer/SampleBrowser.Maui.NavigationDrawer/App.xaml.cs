#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Reflection;

namespace SampleBrowser.Maui.NavigationDrawer;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Assembly assembly = typeof(App).GetTypeInfo().Assembly;
        SampleBrowser.Maui.Base.BaseConfig.IsIndividualSB = true;

    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        Assembly assembly = typeof(App).GetTypeInfo().Assembly;
        var mainPage = SampleBrowser.Maui.Base.BaseConfig.MainPageInit(assembly);
        return new Window(mainPage);
    }
}
