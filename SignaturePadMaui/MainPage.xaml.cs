using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;

namespace SignaturePadMaui
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<IDrawingLine> Lines { get; set; } = new ObservableCollection<IDrawingLine>();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Lines.Clear();
        }
    }

}
