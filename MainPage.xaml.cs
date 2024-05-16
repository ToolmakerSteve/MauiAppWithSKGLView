using SkiaSharp.Views.Maui.Controls;

namespace MauiApp4_SKGLView
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await Task.Delay(2000);
                // UNCOMMENT these lines to test adding SKGLView in code.
                //var skv = new SKGLView() { WidthRequest = 300, HeightRequest = 300 };
                // Below line: Exception: "Handler not found for view SkiaSharp.Views.Maui.Controls.SKGLView."
                //layout.Children.Add(skv);
            });
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
