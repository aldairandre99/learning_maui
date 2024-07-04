using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainViewModal : ObservableObject
{

  public MainViewModal() { }



  [ObservableProperty]
  double numb1 = 0;

  [ObservableProperty]
  double numb2 = 0;


  [ObservableProperty]
  double result;



  [RelayCommand]
  void Some()
  {
    if (Numb1 > 0 && Numb2 > 0)
    {
      Result = Numb1 + Numb2;
      Numb1 = 0;
      Numb2 = 0;
    }
  }

  [RelayCommand]
  void Sub()
  {
    if (Numb1 > 0 && Numb2 > 0)
    {
      Result = Numb1 - Numb2;
      Numb1 = 0;
      Numb2 = 0;
    }
  }

  [RelayCommand]
  void Times()
  {
    if (Numb1 > 0 && Numb2 > 0)
    {
      Result = Numb1 * Numb2;
      Numb1 = 0;
      Numb2 = 0;
    }
  }

  [RelayCommand]
  void Div()
  {
    if (Numb1 > 0 && Numb2 > 0)
    {
      Result = Numb1 / Numb2;
      Numb1 = 0;
      Numb2 = 0;
    }
  }
}
