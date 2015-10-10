using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Learning
{
    public class Photo
    {
        public Photo(string title, string description, string imagePath, string category)
        {
            this.Title = title;
            this.Description = description;
            this._imagePath = imagePath;
            this.Category = category;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        private ImageSource _image = null;
        private String _imagePath = null;

        public ImageSource Image
        {
            get
            {
                if (this._image == null && this._imagePath != null)
                {
                    this._image = new BitmapImage(new Uri(this._imagePath));
                }
                return this._image;
            }
        }
    }
}
