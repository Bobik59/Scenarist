using System.Text.Json.Serialization;

public class BoundingClientRect
{
    [JsonPropertyName("left")]
    public double Left { get; set; }
    
    [JsonPropertyName("top")]
    public double Top { get; set; }
}