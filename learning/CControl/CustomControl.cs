using System;
using Gtk;


namespace CControl
{
	public class CustomControl : Widget
	{
		public string myName { get; set; }
		public CustomControl ()
		{

		}

		protected override bool OnSelectionNotifyEvent (Gdk.EventSelection evnt)
		{
			return base.OnSelectionNotifyEvent (evnt);
		}

		public void Redraw()
		{

			this.QueueDraw();
		}
	}
}

