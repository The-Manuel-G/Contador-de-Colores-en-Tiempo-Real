// ColorService.cs en la carpeta "Server" del proyecto Blazor WebAssembly
using colorin.Models;
public class ColorService
{
    private static ColorData colorData = new ColorData();

    public ColorData GetColors()
    {
        return colorData;
    }

 public void SaveColors(ColorModel model)
    {
        ColorData data = new ColorData
        {
            RedCount = model.RedCount,
            GreenCount = model.GreenCount,
            BlueCount = model.BlueCount
        };

        colorData = data;
    }

}