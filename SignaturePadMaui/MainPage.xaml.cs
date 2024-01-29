using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
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

        private async void Button_Clicked(object sender, EventArgs e) // One option to get the button is saved
        {
            var stream = await DrawingView.GetImageStream(Lines,
                new Size(400, 200), Colors.Gray);
            drawingImage.Source = ImageSource.FromStream(() => stream);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Lines.Clear();
        }

        private async void DrawingView_DrawingLineCompleted(object sender, DrawingLineCompletedEventArgs e) // One option to get the image after every line
        {
            //var stream = await e.LastDrawingLine.GetImageStream(400, 200, Colors.Gray.AsPaint());
            //drawingImage.Source = ImageSource.FromStream(() => stream);
        }
    }

}
