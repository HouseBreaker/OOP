using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HTML_Dispatcher__star_
{
	public class ElementBuilder
	{
		private string name;
		Dictionary<string, string> attributes = new Dictionary<string, string>();
		private List<string> content = new List<string>(); 

		public ElementBuilder(string name)
		{
			this.Name = name;
		}

		public string Name
		{
			get { return this.name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("name", "Name cannot be empty");
				}
				name = value;
			}
		}

		public void AddAttribute(string attribute, string value)
		{
			this.attributes.Add(attribute, value);
        }

		public void AddContent(string addedContent)
		{
			this.content.Add(addedContent);
		}

		public StringBuilder sb = new StringBuilder();
		public override string ToString()
		{
			
			sb.Append($"<{name}");

			if (attributes.Count != 0)
			{
				sb.Append(" ");
			}

			sb.Append(string.Join(" ", attributes.Select(x => $"{x.Key}=\"{x.Value}\"")));

			sb.Append(">");

			sb.Append(string.Join("", content));

			sb.Append($"</{Name}>");

			return sb.ToString();
		}

		public static string operator*(ElementBuilder one, int two)
		{
			StringBuilder multipliedString = new StringBuilder();
			string theString = one.ToString();

			for (int i = 0; i < two; i++)
			{
				multipliedString.Append(theString);
			}
			return multipliedString.ToString();
		}
	}
}
