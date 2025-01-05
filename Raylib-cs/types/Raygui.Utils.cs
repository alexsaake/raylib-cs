namespace Raylib_cs;

public static unsafe partial class Raygui
{
    public static unsafe int GuiGroupBox(Rectangle bounds, string text)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiGroupBox(bounds, (char*)textAnsiBuffer.AsPointer());
    }

    public static unsafe int GuiLine(Rectangle bounds, string text)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiLine(bounds, (char*)textAnsiBuffer.AsPointer());
    }

    public static unsafe int GuiPanel(Rectangle bounds, string text)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiPanel(bounds, (char*)textAnsiBuffer.AsPointer());
    }

    public static unsafe int GuiLabel(Rectangle bounds, string text)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiLabel(bounds, (char*)textAnsiBuffer.AsPointer());
    }

    public static unsafe int GuiButton(Rectangle bounds, string text)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiButton(bounds, (char*)textAnsiBuffer.AsPointer());
    }

    public static unsafe int GuiToggleSlider(Rectangle bounds, string text, int* active)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiToggleSlider(bounds, (char*)textAnsiBuffer.AsPointer(), active);
    }
}
