using System;

/// <summary>
/// My awesome data model.
/// </summary>
public class MyData
{
    /// <summary>
    /// The item name.
    /// </summary>
    public string Name
    {
        get;
        set;
    }

    /// <summary>
    /// Whether the item can be purchased right now.
    /// </summary>
    public bool IsBuyable
    {
        get;
        set;
    }
}