﻿using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainViewModal : ObservableObject
{

  public MainViewModal()
  {
    Items = [];
  }

  [ObservableProperty]
  ObservableCollection<string> items;

  [ObservableProperty]
  string text;

  [RelayCommand]
  void Add()
  {
    if (string.IsNullOrWhiteSpace(Text))
      return;
    Items.Add(Text);
    // Addd our item
    Text = string.Empty;
  }

  [RelayCommand]
  void Delete(string s)
  {
    if (Items.Contains(s))
    {
      Items.Remove(s);
    }


  }
}
