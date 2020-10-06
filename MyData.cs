using System;
using System.ComponentModel;

/// <summary>
/// My awesome data model.
/// </summary>
public class MyData : INotifyPropertyChanged
{
    private string name;
    private bool isbuyable;

    public string Name
    {
        get { return name; }
        set { name = value; RaisePropertyChanged("Name"); }
    }

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