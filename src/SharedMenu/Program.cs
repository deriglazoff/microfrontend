using static Menu;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var menu = new Menu { Items = [new() { Name = "Hello World", Url = "https://resultforyou.ru" }] };
app.MapGet("/", () => menu);

app.Run();



public class Menu
{
	public List<ItemMenu> Items { get; set; }
	public class ItemMenu
	{
		public string Name { get; set; }
		public string Url { get; set; }

	}
}

public static class MenuStatic
{
    public static Menu Menu = new() { Items = [
		new ItemMenu { Name = "Service 1", Url = "http://localhost:5149" }, 
		new ItemMenu { Name = "Service 2", Url = "http://localhost:5222" },
        new ItemMenu { Name = "Service 3", Url = "https://resultforyou.ru" },
        new ItemMenu { Name = "Service 4", Url = "https://resultforyou.ru" },
        new ItemMenu { Name = "logout", Url = "d" },
    ] };
}