#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Maui.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SampleBrowser.Maui.Base.Converters;
using System.Reflection;

namespace SampleBrowser.Maui.Buttons.CheckBox;

public class ViewModel : INotifyPropertyChanged
{

    #region Fields

    /// <summary>
    /// Represents the text color
    /// </summary>
    private Color textColor = Color.FromRgba("#808080");

    /// <summary>
    /// The corner radius of button.
    /// </summary>
    private CornerRadius cornerRadius = 50;

    /// <summary>
    /// Represents the border width
    /// </summary>
    private int radius = 1;

    /// <summary>
    /// Represents the radiobutton size
    /// </summary>
    private int controlsize = 18;

    /// <summary>
    /// The text of button.
    /// </summary>
    private string text = "CheckBox";

    /// <summary>
    /// The can show background image
    /// </summary>
    private bool ischecked = false;

    /// <summary>
    /// Represents the enable or disable the shadow
    /// </summary>
    private bool isThreestate;
    #endregion

    #region Property

    /// <summary>
    /// Gets or Sets the text color
    /// </summary>
    public Color TextColor
    {
        get
        {
            return textColor;
        }

        set
        {
            textColor = value;
            OnPropertyChanged("TextColor");
        }
    }

    /// <summary>
    /// Gets or sets the border width.
    /// </summary>
    public int Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
            CornerRadius = new CornerRadius(value, value, value, value);
            OnPropertyChanged("Radius");
        }
    }


    /// <summary>
    /// Gets or sets the RadioButton Size.
    /// </summary>
    public int ControlSize {
        get {
            return controlsize;
        }
        set {
            controlsize = value;
            OnPropertyChanged("ControlSize");
        }
    }


    /// <summary>
    /// Gets or sets the corner radius.
    /// </summary>
    /// <value>The corner radius.</value>
    public CornerRadius CornerRadius
    {
        get
        {
            return cornerRadius;
        }
        set
        {

            cornerRadius = value;
            OnPropertyChanged("CornerRadius");
        }
    }


    /// <summary>
    /// Gets or sets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
            OnPropertyChanged("Text");
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:button.buttonViewModel"/> is enable stack.
    /// </summary>
    /// <value><c>true</c> if is enable stack; otherwise, <c>false</c>.</value>
    public bool IsChecked
    {
        get
        {
            return ischecked;
        }
        set
        {
            ischecked = value;
            OnPropertyChanged("IsChecked");
        }
    }

    /// <summary>
    /// Gets or sets whether shadow enable or disable
    /// </summary>
    public bool IsThreeState
    {
        get
        {
            return isThreestate;
        }
        set
        {
            isThreestate = value;
            OnPropertyChanged("IsThreeState");
        }
    }

    #endregion

    #region Property changed method

    /// <summary>
    /// Occurs when property changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;


    public void OnPropertyChanged([CallerMemberName] string? name = null) =>
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    #endregion
}
