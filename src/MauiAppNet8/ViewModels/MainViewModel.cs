namespace MauiAppNet8.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _email = string.Empty;

    public MainViewModel()
    {
        string[] domains = { "gmail.com", "yahoo.com", "outlook.com", "protonmail.com", "aol.com" };
        Random rand = new();
        Email = Path.GetRandomFileName().Replace(".", "") + "@" + domains[rand.Next(domains.Length)];
    }
}
