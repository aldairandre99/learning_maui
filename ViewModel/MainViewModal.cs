using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainViewModal : ObservableObject
{

  public MainViewModal() { }

  [ObservableProperty]
  int n1 = 0;

  [ObservableProperty]
  int n2 = 0;


  [ObservableProperty]
  double res = 0;



  [RelayCommand]
  void WriteInScreen(int txt)
  {
    Res = txt;
  }


}
