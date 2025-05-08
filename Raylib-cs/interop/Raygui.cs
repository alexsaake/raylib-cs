using System.Runtime.InteropServices;
using System.Security;

namespace Raylib_cs;

[SuppressUnmanagedCodeSecurity]
public static unsafe partial class Raygui
{
    /// <summary>
    /// Used by DllImport to load the native library
    /// </summary>
    public const string NativeLibName = "raylib";

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiPanel(Rectangle bounds, char* text);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiLabel(Rectangle bounds, char* text);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiButton(Rectangle bounds, char* text);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiToggleSlider(Rectangle bounds, char* text, int* active);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiValueBox(Rectangle bounds, char* text, int* value, int minValue, int maxValue, bool editMode);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiValueBoxFloat(Rectangle bounds, char* text, char* textValue, float* value, bool editMode);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiComboBox(Rectangle bounds, char* text, int* active);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiSlider(Rectangle bounds, char* textLeft, char* textRight, float* value, float minValue, float maxValue);
}
