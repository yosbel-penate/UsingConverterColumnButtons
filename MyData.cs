using System;
using System.ComponentModel;

/// <summary>
/// My awesome data model.
/// </summary>
public class MyData : INotifyPropertyChanged
{
    private string name;
    private bool isbuyable;

    /// <summary>
    /// The item name.
    /// </summary>
    public string Name
    {
        get { return name; }
        set { name = value; RaisePropertyChanged("Name"); }
    }

    /// <summary>
    /// Whether the item can be purchased right now.
    /// </summary>
    public bool IsBuyable
    {
        get { return isbuyable; }
        set { isbuyable = value; RaisePropertyChanged("IsBuyable"); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void RaisePropertyChanged(String propertyName)
    {
        PropertyChangedEventHandler temp = PropertyChanged;
        if (temp != null)
        {
            temp(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}