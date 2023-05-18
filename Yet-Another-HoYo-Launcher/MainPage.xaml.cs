using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Yet_Another_HoYo_Launcher.Pages;
using Windows.Devices.Enumeration;
using Windows.UI.ApplicationSettings;
using Yet_Another_HoYo_Launcher.Pages.Games;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Yet_Another_HoYo_Launcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void MainNavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                switch (args.InvokedItemContainer.Tag.ToString())
                {
                    case "HomePage":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    case "GamePageGenshin":
                        ContentFrame.Navigate(typeof(GamePageGenshin));
                        break;
                    case "GamePageHonkai":
                        ContentFrame.Navigate(typeof(GamePageHonkai));
                        break;
                    case "GamePageStarRail":
                        ContentFrame.Navigate(typeof(GamePageStarRail));
                        break;
                }

            }
        }

        private void MainNavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationView navigationView = sender as NavigationView;
            foreach (NavigationViewItemBase item in navigationView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "HomePage")
                {
                    navigationView.SelectedItem = item;
                    ContentFrame.Navigate(typeof(HomePage));
                    break;
                }
            }
        }

    }
}
