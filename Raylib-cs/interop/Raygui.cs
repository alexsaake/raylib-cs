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
    public static extern void GuiEnable();

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern void GuiDisable();

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiCheckBox(Rectangle bounds, char* text, bool* check);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiLabel(Rectangle bounds, char* text);

    [DllImport(NativeLibName, CallingConvention = CallingConvention.Cdecl)]
    public static extern int GuiTextBox(Rectangle bounds, char* text, int textSize, bool editMode);
}
