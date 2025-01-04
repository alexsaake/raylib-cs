namespace Raylib_cs;

public static unsafe partial class Raygui
{
    public static unsafe int GuiCheckBox(Rectangle bounds, string text, bool check)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiCheckBox(bounds, (char*)textAnsiBuffer.AsPointer(), &check);
    }

    public static unsafe int GuiLabel(Rectangle bounds, string text)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiLabel(bounds, (char*)textAnsiBuffer.AsPointer());
    }
}
