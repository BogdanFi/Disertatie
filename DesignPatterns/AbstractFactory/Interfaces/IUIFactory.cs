﻿namespace AbstractFactory.Interfaces;

public interface IUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}