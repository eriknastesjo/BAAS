using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAAS.Resources
{

    static class Font
    {
        public static readonly string FontFamilyStandard = "FamiljenGrotesk";
        public static readonly string FontFamilySemiBold = "FamiljenGroteskSemibold";
        public static readonly string FontFamilyBold = "FamiljenGroteskBold";
    }

    static class FontSizes
    {
        public static readonly double H1Size = 33;
        public static readonly double H2Size = 25;
        public static readonly double PLargeSize = 18;
        public static readonly double PMediumSize = 16;
        public static readonly double PSmallSize = 14;
    }    
    static class LineHeight
    {
        public static readonly double H1Height = 1;
        public static readonly double H2Height = 1;
        public static readonly double PLargeHeight = 1.5;
        public static readonly double PMediumHeight = 1.5;
        public static readonly double PSmallHeight = 1.5;
    }    
    
    static class CharacterSpacing
    {
        public static readonly double H1Spacing = 0;
        public static readonly double H2Spacing = 0.5;
        public static readonly double PLargeSpacing = 1.2;
        public static readonly double PMediumSpacing = 1.2;
        public static readonly double PSmallSpacing = 1.2;
    }

    static class Colors
    {
        public static readonly Color AccentLight = Color.FromArgb("FFB838");
        public static readonly Color AccentDark = Color.FromArgb("0052AC");
        public static readonly Color White = Color.FromArgb("FFFFFF");
        public static readonly Color BackgroundLight = Color.FromArgb("CDCDCD");
        public static readonly Color BackgroundDark = Color.FromArgb("34322E");
        public static readonly Color FontLight = Color.FromArgb("FEFEFE");
        public static readonly Color FontDark= Color.FromArgb("34322E");
    }

    public static class Spacing
    {
        public static readonly double S05x = 2;
        public static readonly double S1x = 4;
        public static readonly double S2x = 8;
        public static readonly double S3x = 12;
        public static readonly double S4x = 16;
        public static readonly double S5x = 20;
        public static readonly double S6x = 24;
        public static readonly double S7x = 28;
        public static readonly double S8x = 32;
        public static readonly double S9x = 36;
        public static readonly double S10x = 40;
    }

    public static class ButtonSize
    {
        public static readonly double PaddingHorizontal = 16;
        public static readonly double PaddingHorizontalThick = 24;
        public static readonly double PaddingVertical= 8;
    }
    
    public static class BorderSize
    {
        public static readonly double BorderStandard = 2;
        public static readonly double BorderThick = 4;
    }

    public static class Radius
    {
        public static readonly int RadiusStandard = 0;
    }
}
