namespace Raylib_cs;

public static unsafe partial class Raygui
{
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

    public static unsafe int GuiComboBox(Rectangle bounds, string text, int* active)
    {
        var textAnsiBuffer = text.ToAnsiBuffer();
        return GuiComboBox(bounds, (char*)textAnsiBuffer.AsPointer(), active);
    }

    public static unsafe int GuiSlider(Rectangle bounds, string textLeft, string textRight, float* value, float minValue, float maxValue)
    {
        var textLeftAnsiBuffer = textLeft.ToAnsiBuffer();
        var textRightAnsiBuffer = textRight.ToAnsiBuffer();
        return GuiSlider(bounds, (char*)textLeftAnsiBuffer.AsPointer(), (char*)textRightAnsiBuffer.AsPointer(), value, minValue, maxValue);
    }
}
