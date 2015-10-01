namespace _02.HTML_Dispatcher__star_
{
	public static class HTMLDispatcher
	{
		static public string CreateImage(string src, string alt, string title)
		{
			ElementBuilder element = new ElementBuilder("img");
			element.AddAttribute("src", src);
			element.AddAttribute("alt", alt);
			element.AddAttribute("title", title);
			return element.ToString();
		}

		static public string CreateURL(string url, string title, string text)
		{
			ElementBuilder element = new ElementBuilder("a");
			element.AddAttribute("href", url);
			element.AddAttribute("title", title);
			element.AddContent(text);

			return element.ToString();
		}

		static public string CreateInput(string type, string name, string value)
		{
			ElementBuilder element = new ElementBuilder("input");
			element.AddAttribute("type", type);
			element.AddAttribute("name", name);
			element.AddAttribute("value", value);

			return element.ToString();
		}
	}
}
