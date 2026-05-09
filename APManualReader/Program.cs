using APManualReader.Components;
using Microsoft.Extensions.DependencyInjection;
using Photino.Blazor;
using MudBlazor.Services;

namespace APManualReader
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);

      appBuilder.Services.AddLogging();
      appBuilder.Services.AddMudServices();

      appBuilder.RootComponents.Add<App>("app");

      var app = appBuilder.Build();

      app.MainWindow.SetTitle("Photino Blazor Sample");

      AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
      {
        app.MainWindow.ShowMessage("Fatal Exception", error.ExceptionObject.ToString());
      };

      app.Run();
    }
  }
}