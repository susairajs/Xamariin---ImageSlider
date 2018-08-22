using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamd.ImageCarousel.Forms.Plugin.Abstractions;
namespace XamarinImageSlider
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        public MainPage()
        {
            InitializeComponent();

            imageSources.Add("XamarinmonkeyLogo.png");
            imageSources.Add("github.png");
            imageSources.Add("microsoft.png");


            imgSlider.Images = imageSources;
        }
    }
}
