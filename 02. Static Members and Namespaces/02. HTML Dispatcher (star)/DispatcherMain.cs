using System;

namespace _02.HTML_Dispatcher__star_
{
	class DispatcherMain
	{
		static void Main()
		{
			ElementBuilder div = new ElementBuilder("div");
			div.AddAttribute("id", "page");
			div.AddAttribute("class", "big");
			div.AddContent("<p>Hello</p>");

			Console.WriteLine(HTMLDispatcher.CreateImage("google.com/jpg.jpg", "sample image", "Sample Image"));
			Console.WriteLine(HTMLDispatcher.CreateURL("google.com", "Google", "Go to Google"));
			Console.WriteLine(HTMLDispatcher.CreateInput("button", "do u want to continue", "yes"));
		}
	}
}
