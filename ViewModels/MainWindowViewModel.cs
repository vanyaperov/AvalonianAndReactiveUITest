using System.Reactive;
using ReactiveUI;

namespace AvalonianAndReactiveUITest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ReactiveCommand<Unit, Unit> PrintCommand { get; }
    private string _textBox1 = "1";
    private string _textBox2 = "2";
    private string _textBox3 = "3";
    private string _textToShow = "Default text";
    
    public string TextBox1 
    {
        get => _textBox1;
        set => this.RaiseAndSetIfChanged(ref _textBox1, value);
    }
    public string TextBox2 
    {
        get => _textBox2;
        set => this.RaiseAndSetIfChanged(ref _textBox2, value);
    }
    public string TextBox3 
    {
        get => _textBox3;
        set => this.RaiseAndSetIfChanged(ref _textBox3, value);
    }
    public string TextToShow 
    {
        get => _textToShow;
        set => this.RaiseAndSetIfChanged(ref _textToShow, value);
    }
    public MainWindowViewModel()
    {
        PrintCommand = ReactiveCommand.Create( () => {
            string defaultText = string.Empty;
            Printer.Print(ref defaultText, TextBox1, TextBox2, TextBox3);
            TextToShow = defaultText;
        });
    }
}
