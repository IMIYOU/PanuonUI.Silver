﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Panuon.UI.Silver
{
    #region WindowAnimation
    public enum WindowAnimation
    {
        None,
        Fade,
        Gradual,
        Scale,
    }
    #endregion

    #region Button
    public enum ButtonStyle
    {
        Standard,
        Hollow,
        Outline,
        Link,
    }

    public enum ClickStyle
    {
        None,
        Sink,
    }
    #endregion

    #region RepeatButton
    public enum RepeatButtonStyle
    {
        Standard,
        Hollow,
        Outline,
        Link,
    }
    #endregion

    #region Loading
    public enum LoadingStyle
    {
        Classic,
        Ring,
        Wave,
    }
    #endregion

    #region TreeView
    public enum TreeViewStyle
    {
        Standard,
        Classic,
        Modern,
        Chain,
    }

    public enum SelectMode
    {
        Any,
        ChildOnly,
    }

    public enum ExpandMode
    {
        DoubleClick,
        SingleClick
    }

    public enum ExpandBehaviour
    {
        Any,
        OnlyOne,
    }
    #endregion

    #region Expander
    public enum ExpanderStyle
    {
        Standard,
        Classic,
    }
    #endregion

    #region CheckBox
    public enum CheckBoxStyle
    {
        Standard,
        Switch,
        Button
    }
    #endregion

    #region RadioButton
    public enum RadioButtonStyle
    {
        Standard,
        Switch,
        Button
    }
    #endregion

    #region Calendar
    public enum CalendarMode
    {
        Date,
        YearMonth,
        Year,
    }
    #endregion

    #region Clock
    public enum ClockStyle
    {
        Standard,
        Dial,
    }
    #endregion

    #region Slider
    public enum SliderStyle
    {
        Standard,
        Classic,
    }
    #endregion

    #region ProgressBarStyle
    public enum ProgressBarStyle
    {
        Standard,
        Ring
    }
    #endregion

    #region DateTimePickerMode
    public enum DateTimePickerMode
    {
        DateTime,
        TimeOnly,
        DateOnly,
        YearMonth,
        Year,
    }
    #endregion

    #region TabControlStyle
    public enum TabControlStyle
    {
        Standard,
        Classic,
    }
    #endregion

    #region ImageCuter
    public enum ImageType
    {
        Rectangle,
        Square,
    }
    #endregion
}
