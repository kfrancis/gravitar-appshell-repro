namespace MauiAppNet7;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));
	}
}
