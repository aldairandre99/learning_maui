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
  string mathOperator = "";

  [ObservableProperty]
  string res = "0";



  [RelayCommand]
  void WriteInScreen(object p)
  {

    if (int.Parse(Res) == 0) Res = (string)p;
    else Res += (string)p;

    if (N1 < 0) N1 = int.Parse(Res);
    else N2 = int.Parse(Res);
  }
  [RelayCommand]
  void Operator(object op)
  {
    MathOperator = (string)op;
    N1 = int.Parse(Res);
    CleanScreen();
  }

  [RelayCommand]
  void CleanScreen()
  {
    Res = "0";
  }

  [RelayCommand]
  void ShowResult(object p)
  {
    double op;
    switch (MathOperator)
    {
      case "/":
        if (N1 > 0 && N2 > 0)
        {
          op = N1 / N2;
          N1 = 0;
          N2 = 0;
          Res = op.ToString();
        }
        break;
      case "*":
        if (N1 > 0 && N2 > 0)
        {
          op = N1 * N2;
          N1 = 0;
          N2 = 0;
          Res = op.ToString();
        }
        break;
      case "-":
        if (N1 > 0 && N2 > 0)
        {
          op = N1 - N2;
          N1 = 0;
          N2 = 0;
          Res = op.ToString();
        }
        break;
      case "+":
        if (N1 > 0 && N2 > 0)
        {
          op = N1 + N2;
          N1 = 0;
          N2 = 0;
          Res = op.ToString();
        }
        break;
      default:
        break;
    }

  }
}