/*
    Copyright (c) 2026
    Apache License Version 2.0
*/

using System.Drawing;
using System.Windows.Forms;

namespace Klocman.Forms.Tools
{
    public static class SolarizedPalette
    {
        // Solarized 16-color palette
        public static Color Base03 { get; } = Color.FromArgb(0, 43, 54);     // #002b36 - Dark Background
        public static Color Base02 { get; } = Color.FromArgb(7, 54, 66);     // #073642 - Dark Background Highlight / Surface
        public static Color Base01 { get; } = Color.FromArgb(88, 110, 117);  // #586e75 - Muted Text / Content / Borders
        public static Color Base00 { get; } = Color.FromArgb(101, 123, 131); // #657b83 - Sub-highlight Text
        public static Color Base0 { get; }  = Color.FromArgb(131, 148, 150); // #839496 - Default Text / Foreground
        public static Color Base1 { get; }  = Color.FromArgb(147, 161, 161); // #93a1a1 - Emphasized Text
        public static Color Base2 { get; }  = Color.FromArgb(238, 232, 213); // #eee8d5 - Light Surface
        public static Color Base3 { get; }  = Color.FromArgb(253, 246, 227); // #fdf6e3 - Light Background

        public static Color Yellow { get; }  = Color.FromArgb(181, 137, 0);  // #b58900
        public static Color Orange { get; }  = Color.FromArgb(203, 75, 22);  // #cb4b16
        public static Color Red { get; }     = Color.FromArgb(220, 50, 47);  // #dc322f
        public static Color Magenta { get; } = Color.FromArgb(211, 54, 130); // #d33682
        public static Color Violet { get; }  = Color.FromArgb(108, 113, 196); // #6c71c4
        public static Color Blue { get; }    = Color.FromArgb(38, 139, 210); // #268bd2
        public static Color Cyan { get; }    = Color.FromArgb(42, 161, 152); // #2aa198
        public static Color Green { get; }   = Color.FromArgb(133, 153, 0);  // #859900

        // Dark theme list row highlights (optimized for dark background readability)
        public static Color VerifiedDark { get; }       = Color.FromArgb(14, 74, 66);   // Cyan/Green tint on Base03
        public static Color UnverifiedDark { get; }     = Color.FromArgb(13, 58, 88);   // Blue tint on Base03
        public static Color InvalidDark { get; }        = Color.FromArgb(70, 25, 25);   // Red tint on Base03
        public static Color UnregisteredDark { get; }   = Color.FromArgb(65, 50, 10);   // Yellow tint on Base03
        public static Color WindowsFeatureDark { get; } = Color.FromArgb(45, 35, 75);   // Violet tint on Base03
        public static Color WindowsStoreAppDark { get; }= Color.FromArgb(70, 20, 50);   // Magenta tint on Base03
    }

    public class SolarizedColorTable : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin => SolarizedPalette.Base02;
        public override Color ToolStripGradientMiddle => SolarizedPalette.Base02;
        public override Color ToolStripGradientEnd => SolarizedPalette.Base02;
        public override Color MenuStripGradientBegin => SolarizedPalette.Base03;
        public override Color MenuStripGradientEnd => SolarizedPalette.Base03;
        public override Color StatusStripGradientBegin => SolarizedPalette.Base02;
        public override Color StatusStripGradientEnd => SolarizedPalette.Base02;

        public override Color MenuItemSelected => SolarizedPalette.Base02;
        public override Color MenuItemSelectedGradientBegin => SolarizedPalette.Base02;
        public override Color MenuItemSelectedGradientEnd => SolarizedPalette.Base02;
        public override Color MenuItemBorder => SolarizedPalette.Cyan;
        public override Color MenuBorder => SolarizedPalette.Base01;

        public override Color ToolStripBorder => SolarizedPalette.Base01;
        public override Color ToolStripDropDownBackground => SolarizedPalette.Base03;
        public override Color ImageMarginGradientBegin => SolarizedPalette.Base03;
        public override Color ImageMarginGradientMiddle => SolarizedPalette.Base03;
        public override Color ImageMarginGradientEnd => SolarizedPalette.Base03;

        public override Color ButtonSelectedHighlight => SolarizedPalette.Base02;
        public override Color ButtonSelectedHighlightBorder => SolarizedPalette.Cyan;
        public override Color ButtonPressedHighlight => SolarizedPalette.Base01;
        public override Color ButtonPressedHighlightBorder => SolarizedPalette.Blue;
        public override Color ButtonSelectedGradientBegin => SolarizedPalette.Base02;
        public override Color ButtonSelectedGradientMiddle => SolarizedPalette.Base02;
        public override Color ButtonSelectedGradientEnd => SolarizedPalette.Base02;
    }
}
