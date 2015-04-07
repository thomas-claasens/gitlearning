using System;
using Gtk;

namespace Learning_Project
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//This is a test for the changelog functions.
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
