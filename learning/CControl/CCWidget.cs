using System;

namespace CControl
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class CCWidget : Gtk.Bin
	{
		public CCWidget ()
		{
			this.Build ();
		}

		protected void buttonClicked (object sender, EventArgs e)
		{
			Console.WriteLine ("Clicked button on custom control");
			label2.Text = "Clicked";
		}
	}
}

