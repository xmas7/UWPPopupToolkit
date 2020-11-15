﻿using System;
using System.Threading.Tasks;
using UWPPopupToolkit.Controls;
using UWPPopupToolkit.Controls.PopupControlControls;
using UWPPopupToolkit.Controls.PopupPresenterHostControls;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPPopupToolkit.Sample
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

        private void ShowSlideupPopupNormalSize(object sender, RoutedEventArgs e)
        {
            var g = PopupPresenterHost.ShowSlideupPopup(typeof(ListPage));
        }

        private void ShowSlideupPopupHeight200(object sender, RoutedEventArgs e)
        {
            var g = PopupPresenterHost.ShowSlideupPopup(typeof(ListPage), 300);
        }

        private async void ShowSlideupPopupNormalSizeAsync(object sender, RoutedEventArgs e)
        {
            var g = await PopupPresenterHost.ShowSlideupPopupAsync(typeof(ListPage));
            await new MessageDialog(g.ToString()).ShowAsync();
        }

        private async void ShowSlideupPopupHeight200Async(object sender, RoutedEventArgs e)
        {
            var g = await PopupPresenterHost.ShowSlideupPopupAsync(typeof(ListPage), 300);
            await new MessageDialog(g.ToString()).ShowAsync();
        }

        private async void ShowPopupControl(object sender, RoutedEventArgs e)
        {
            var g = PopupPresenterHost.ShowPopupControl(typeof(ListPage2));
            await Task.Delay(1000);
            PopupPresenterHost.HidePopupControl(g);
        }

        private async void ShowPopupControlAsync(object sender, RoutedEventArgs e)
        {
            var g = await PopupPresenterHost.ShowPopupControlAsync(typeof(ListPage2));
            PopupPresenterHost.HidePopupControl(g);
        }

        private void ShowPopupControlCustomClose(object sender, RoutedEventArgs e)
        {
            var g = PopupPresenterHost.ShowPopupControl(typeof(ListPage2));
        }

        private async void ShowPopupControlAnimation(object sender, RoutedEventArgs e)
        {
            var g = await PopupPresenterHost.ShowPopupControlAsync(typeof(ListPage2),
                ShowAnimationMode: PopupControlAnimationKind.SlideUp, HideAnimationMode: PopupControlAnimationKind.SlideUp);
            await PopupPresenterHost.HidePopupControlAsync(g);
        }

        private async void ShowShortTextMessageBox(object sender, RoutedEventArgs e)
        {
            await PopupPresenterHost.ShowMessageBoxAsync("This is a short message text sample.", Title: "Test Title");
        }

        private async void ShowLongTextMessageBox(object sender, RoutedEventArgs e)
        {
            var msg = await FileIO.ReadTextAsync(await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///DemoContent/LoremIpsum.txt", UriKind.RelativeOrAbsolute)));
            await PopupPresenterHost.ShowMessageBoxAsync(msg, Title: "Lorem Ipsum");
        }
    }
}
