using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.String_Disperser
{
	class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
	{
		private string[] strings;

		public StringDisperser(params string[] strings)
		{
			Strings = strings;
		}

		public string[] Strings
		{
			get { return strings; }
			set { this.strings = value; }
		}

		public override bool Equals(object obj)
		{
			var castedObj = obj as StringDisperser;
			if (castedObj == null)
			{
				return false;
			}
			return Strings.Equals(castedObj);
		}

		public static bool operator ==(StringDisperser sd1, StringDisperser sd2)
		{
			return Equals(sd1, sd2);
		}

		public static bool operator !=(StringDisperser sd1, StringDisperser sd2)
		{
			return !(sd1 == sd2);
		}

		public override int GetHashCode()
		{
			return Strings.GetHashCode();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		object ICloneable.Clone()
		{
			return Clone();
		}

		public StringDisperser Clone()
		{
			return new StringDisperser(Strings);
		}

		public int CompareTo(StringDisperser other)
		{
			var concat = string.Join(string.Empty, Strings);
			var otherConcat = string.Join(string.Empty, other.Strings);

			return string.CompareOrdinal(concat, otherConcat);
		}

		public IEnumerator<char> GetEnumerator()
		{
			foreach (var str in Strings)
			{
				foreach (var ch in str)
				{
					yield return ch;
				}
			}
		}

		public override string ToString()
		{
			return string.Join(string.Empty, strings);
		}
	}
}
