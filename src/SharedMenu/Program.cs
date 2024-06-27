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
		new ItemMenu { Name = "Hello 1", Url = "https://resultforyou.ru" }, 
		new ItemMenu { Name = "Hello 2", Url = "https://resultforyou.ru" },
        new ItemMenu { Name = "Hello 3", Url = "https://resultforyou.ru" },
    ] };
}