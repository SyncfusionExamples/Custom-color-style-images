using Syncfusion.ListView.XForms;
using Syncfusion.SfImageEditor.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image_Filter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void listView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            var item = e.ItemData as TileInfo;
            if(item.ImageName == "Original")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
            }
            else if(item.ImageName == "Limestone")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
                image.ApplyImageEffect(ImageEffect.Hue, -147);
                image.ApplyImageEffect(ImageEffect.Saturation, 84);
                image.ApplyImageEffect(ImageEffect.Brightness, -16);
                image.ApplyImageEffect(ImageEffect.Contrast, 14);
            }
            else if (item.ImageName == "Old")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
                image.ApplyImageEffect(ImageEffect.Hue, -80);
                image.ApplyImageEffect(ImageEffect.Saturation, -30);
            }
            else if (item.ImageName == "Midnight")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
                image.ApplyImageEffect(ImageEffect.Hue, 23);
                image.ApplyImageEffect(ImageEffect.Saturation, 68);
                image.ApplyImageEffect(ImageEffect.Brightness, -25);
            }
            else if (item.ImageName == "Mint")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
                image.ApplyImageEffect(ImageEffect.Hue, -75);
                image.ApplyImageEffect(ImageEffect.Brightness, -10);
                image.ApplyImageEffect(ImageEffect.Contrast, 16);
            }
            else if (item.ImageName == "Gold")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
                image.ApplyImageEffect(ImageEffect.Hue, -179);
                image.ApplyImageEffect(ImageEffect.Saturation, 70);
                image.ApplyImageEffect(ImageEffect.Brightness, -12);
                image.ApplyImageEffect(ImageEffect.Contrast, 48);
            }
            else if (item.ImageName == "Majestic")
            {
                image.ApplyImageEffect(ImageEffect.None, 0);
                image.ApplyImageEffect(ImageEffect.Hue, 123);
                image.ApplyImageEffect(ImageEffect.Saturation, 50);
                image.ApplyImageEffect(ImageEffect.Brightness, -40);
                image.ApplyImageEffect(ImageEffect.Contrast, 20);
            }
        }
    }
    public class TileInfo : INotifyPropertyChanged
    {
        #region Fields

        private string imageName;
        private ImageSource image;

        #endregion

        #region Constructor

        public TileInfo()
        {

        }

        #endregion

        #region Properties

        public string ImageName
        {
            get { return imageName; }
            set
            {
                imageName = value;
                OnPropertyChanged("ImageName");
            }
        }

        public ImageSource Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }

    public class ViewModel
    {
        public ImageSource Image { get; set; }
        public ViewModel()
        {
            Image = ImageSource.FromResource("Image_Filter.adventure.jpg");
            TileInfos = new ObservableCollection<TileInfo>();
            TileInfos.Add(new TileInfo() { ImageName = "Original", Image = ImageSource.FromResource("Image_Filter.original1.png") } );
            TileInfos.Add(new TileInfo() { ImageName = "Limestone", Image = ImageSource.FromResource("Image_Filter.Lime.png") });
            TileInfos.Add(new TileInfo() { ImageName = "Old", Image = ImageSource.FromResource("Image_Filter.old.png") });
            TileInfos.Add(new TileInfo() { ImageName = "Midnight", Image = ImageSource.FromResource("Image_Filter.midnight.png") });
            TileInfos.Add(new TileInfo() { ImageName = "Mint", Image = ImageSource.FromResource("Image_Filter.mint.png") });
            TileInfos.Add(new TileInfo() { ImageName = "Gold", Image = ImageSource.FromResource("Image_Filter.gold.png") });
            TileInfos.Add(new TileInfo() { ImageName = "Majestic", Image = ImageSource.FromResource("Image_Filter.majestic.png") });
        }

        public ObservableCollection<TileInfo> TileInfos
        {
            get;set;
        }
    }

}
