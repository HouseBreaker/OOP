namespace _04.Student_Class
{
	public class PropertyChangeEventArgs
	{
		public PropertyChangeEventArgs(string propertyName, string oldValue , string newValue)
		{
			this.PropertyName = propertyName;
			this.OldValue = oldValue;
			this.NewValue = newValue;
		}

		public string PropertyName { get; set; }
		public string OldValue { get; set; }
		public string NewValue { get; set; }
	}
}