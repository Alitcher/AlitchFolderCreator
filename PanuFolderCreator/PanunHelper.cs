namespace PanuFolderCreator
{
    public class PanunHelper
    {
        public const int XOffset = 65;
        public const int YOffset = 20;

        private static float firstXPos = 112f;
        private static float firstYPos = 95f;

        public static Vector2D FirstCheckPos = new Vector2D { x = firstXPos, y = firstYPos };
        public static Vector2D StandardSize = new Vector2D { x = 61, y = 21 };

        public static readonly string[] ExtensionCollection = new string[]
        {
            ".MPG",
            ".MP2",
            ".MPEG",
            ".MPE",
            ".MPV",
            ".OGG",
            ".MP4",
            ".M4P" ,
            ".M4V" ,
            ".AVI",
            ".WMV",
            ".MOV",
            ".QT",
            ".FLV",
            ".SWF",
            "AVCHD",
        };
    }

    [System.Serializable]
    public struct Vector2D
    {
        public float x, y;
    }
}
