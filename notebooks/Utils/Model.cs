using System.Text.Json.Serialization;

/// <summary>
/// Represent a colour in RGB colour space.
/// </summary>
public struct RgbColour
{
    /// <summary>
    /// Gets or sets the red value.
    /// </summary>
    [JsonPropertyName("r")]
    public double R { get; set;}

    /// <summary>
    /// Gets or sets the green value.
    /// </summary>
    [JsonPropertyName("g")]
    public double G { get; set;}

    /// <summary>
    /// Gets or sets the blue value.
    /// </summary>
    [JsonPropertyName("b")]
    public double B { get; set;}
}

/// <summary>
/// Represents a colour in XY colour space.
/// </summary>
public struct XyColour
{
    /// <summary>
    /// Gets or sets the X value.
    /// </summary>
    [JsonPropertyName("x")]
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y value.
    /// </summary>
    [JsonPropertyName("y")]
    public double Y { get; set; }
}

/// <summary>
/// Information about a colour.
/// </summary>
public class ColourInfo
{
    /// <summary>
    /// Gets or sets the colour in XY colour space.
    /// </summary>
    [JsonPropertyName("xy")]
    public XyColour Xy { get; set; }

    /// <summary>
    /// Gets or sets the colour in RGB colour space.
    /// </summary>
    [JsonPropertyName("rgb")]
    public RgbColour Rgb { get; set; }

    /// <summary>
    /// Gets of sets the brightness.
    /// </summary>
    /// <remarks>This is a percentage value between 0 and 100.</remarks>
    [JsonPropertyName("brightness")]
    public double Brightness { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

/// <summary>
/// Information about a scene.
/// </summary>
public class SceneInfo
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the colours.
    /// </summary>
    [JsonPropertyName("colours")]
    public ColourInfo[] Colours { get; set; } = [];
}