using colorin.Models;
using System.Threading.Tasks;

public class ColorService
{
    private static ColorData colorData = new ColorData();

    public Task<ColorData> GetColorsAsync()
    {
        // Simula una operación asincrónica, puedes reemplazarla con una operación real asincrónica si es necesario
        return Task.FromResult(colorData);
    }

    public Task SaveColorsAsync(ColorModel model)
    {
        ColorData data = new ColorData
        {
            RedCount = model.RedCount,
            GreenCount = model.GreenCount,
            BlueCount = model.BlueCount
        };

        colorData = data;

        // Simula una operación asincrónica, puedes reemplazarla con una operación real asincrónica si es necesario
        return Task.CompletedTask;
    }
}
