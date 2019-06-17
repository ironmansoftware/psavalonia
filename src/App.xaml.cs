using Avalonia;
using Avalonia.Markup.Xaml;

namespace PSAvalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}