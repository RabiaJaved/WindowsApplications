using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Xml;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HadithApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        XmlReader reader = XmlReader.Create("Hadith.xml");
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "content")
                {
                    reader.Read();
                    mainTextBlock.Text = reader.Value;
                    break;
                }

            }
            
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            
           // reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "content")
                {
                    reader.Read();
                    mainTextBlock.Text = reader.Value;
                    break;
                }
            
            }
        }
    }
}
