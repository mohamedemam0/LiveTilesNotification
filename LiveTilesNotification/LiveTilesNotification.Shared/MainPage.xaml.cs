using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NotificationsExtensions.TileContent;
using Windows.UI.Notifications;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LiveTilesNotification
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            ITileWide310x150Text09 instance_any_name = TileContentFactory.CreateTileWide310x150Text09();

            instance_any_name.TextHeading.Text = "Hello WideTile";
            instance_any_name.TextBodyWrap.Text = "Contenttext";


            ITileSquare150x150Text04 instance_name = TileContentFactory.CreateTileSquare150x150Text04();
            instance_name.TextBodyWrap.Text = "Content inthe 150X150 tile";
            instance_any_name.Square150x150Content = instance_name;

            ScheduledTileNotification GiveitTime = new ScheduledTileNotification(instance_any_name.GetXml(), DateTime.Now.AddSeconds(15));
            TileUpdateManager.CreateTileUpdaterForApplication().AddToSchedule(GiveitTime);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.

            
        }
    }
}
