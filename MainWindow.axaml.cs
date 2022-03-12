using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.CodeAnalysis.Operations;

namespace avalonia_contextmenu_issue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                var contextMenu = new ContextMenu()
                {
                    Items = new[]
                    {
                        new MenuItem()
                        {
                            Header = "Foo"
                        },
                        new MenuItem()
                        {
                            Header = "Bar"
                        }
                    }
                };
                    
                contextMenu.Open(button);
            }
        }
    }
}