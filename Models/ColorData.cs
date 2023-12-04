// En el archivo ColorData.cs en la carpeta "Models" del proyecto Blazor WebAssembly
namespace colorin.Models
{
    public class ColorData
    {
        public int RedCount { get; set; }
        public int GreenCount { get; set; }
        public int BlueCount { get; set; }

            public int GetCount(string color)
    {
        switch (color.ToLower())
        {
            case "rojo":
                return RedCount;
            case "verde":
                return GreenCount;
            case "azul":
                return BlueCount;
            default:
                return 0; // O algún valor predeterminado según tus necesidades
        }
    }

    }
}
