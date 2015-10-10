using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Learning
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListViewPage : Page
    {
        //private List<Photo> photos = new List<Photo>();
        public ObservableCollection<Photo> photos = new ObservableCollection<Photo> { };
        

        public ListViewPage()
        {

            Photo photo1 = new Photo("The Cat's Eye Nebula", "Cat's Eye Nebula (NGC 6543) is revealed in this detailed view from NASA's Hubble Space Telescope.",
                "http://www.nasa.gov/images/content/64883main_image_feature_211_jw4.jpg", "Nebula");
            photos.Add(photo1);
            Photo photo2 = new Photo("Chaos at the Heart of Orion", "The chaos that baby stars are creating 1,500 light years away in a cosmic cloud called the Orion nebula.",
                "http://www.nasa.gov/images/content/162283main_image_feature_693_ys_4.jpg", "Nebula");
            photos.Add(photo2);
            Photo photo3 = new Photo("An Eyeful of Saturn", "Saturn and its rings completely  in this natural color image taken on March 27, 2004.",
                "http://www.nasa.gov/images/content/59802main_pia05389-516.jpg", "Planets");
            photos.Add(photo3);
            Photo photo4 = new Photo("Jupiter Gets a Close-up", "NASA's Cassini spacecraft took this true color mosaic of Jupiter.",
                "http://www.nasa.gov/images/content/53254main_MM_image_feature_97_jw4.jpg", "Planets");
            photos.Add(photo4);
            Photo photo5 = new Photo("A Long Way From Home", "This image of the Earth and moon in a single frame was recorded by Voyager 1 ",
                "http://www.nasa.gov/images/content/151232main_image_feature_601_ys_4.jpg", "Earth/Moon");
            photos.Add(photo5);
            Photo photo6 = new Photo("Milky Way Neighbor", "Our Sun and solar system are embedded in a broad pancake of stars deep within the Milky Way galaxy.",
                "http://www.nasa.gov/images/content/63375main_image_feature_202_jw4.jpg", "Galaxy");
            photos.Add(photo6);
            Photo photo7 = new Photo("Moon Aglow", "Framed by the Earth's horizon and airglow, the full moon floats in the blackness of space .",
                "http://www.nasa.gov/images/content/111199main_image_feature_290_ys4.jpg", "Earth/Moon");
            photos.Add(photo7);

            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            photoListView.ItemsSource = photos;
        }

        private void listview_item_click(object sender, ItemClickEventArgs e)
        {
            Photo p = e.ClickedItem as Photo;
            System.Diagnostics.Debug.Write(p.Description);
            Photo photo7 = new Photo("EleGiggle", "EleGiggle 4Head KappaPride",
                "http://img2.wikia.nocookie.net/__cb20140609044845/pyruslords/images/thumb/3/31/EleGiggle.png/130px-0,29,0,28-EleGiggle.png", "Earth/Moon");
            photos.Add(photo7);
        }
    }
}
