using SkiaSharp;

namespace Viewer_Maui;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();



//		skiaView = new SkiaSharp.Views.Maui.Controls.SKCanvasView();

	}



	private void Button_About_Clicked(object sender, EventArgs e)
	{
		
	}
    private void Button_Pages_Clicked(object sender, EventArgs e)
    {

    }

	private void skiaView_PaintSurface(object sender, SkiaSharp.Views.Maui.SKPaintSurfaceEventArgs e)
	{
        SKSurface surface = e.Surface;
        // then we get the canvas that we can draw on
        SKCanvas canvas = surface.Canvas;
        // clear the canvas / view
        canvas.Clear(SKColors.White);


        SKPaint paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            Color = SkiaSharp.SKColors.Aqua,
            StrokeWidth = 25
        };

        canvas.DrawCircle(100, 100, 20, paint); 


    }
}

