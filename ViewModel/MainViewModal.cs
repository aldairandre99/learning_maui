using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainViewModal : ObservableObject
{

  public MainViewModal() { }



  [ObservableProperty]
  string name;

  [ObservableProperty]
  string sirName;


  [ObservableProperty]
  string outPut;



  [RelayCommand]
  void ShowName()
  {
    if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(SirName))
    {
      OutPut = "";
    }
    else
      OutPut = $"Welcome {Name} {SirName}";

  }
}
