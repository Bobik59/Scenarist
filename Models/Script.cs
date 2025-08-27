namespace ScriptApp.Models
{
    public class Script
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        // режим блочный
        public List<Block> Blocks { get; set; } = new();

        // режим текстовый
        public string? TextContent { get; set; }
    }

    public class Block
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Content { get; set; } = "";

        // Удобство для CSS
        public string Xpx => $"{X}px";
        public string Ypx => $"{Y}px";
        public string Widthpx => $"{Width}px";
        public string Heightpx => $"{Height}px";
    }
}
