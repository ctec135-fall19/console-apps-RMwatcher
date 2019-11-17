// minimun required namespaces.
using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
	// application object
	class Program
	{
		static void Main()
		{
			Application.Run(new MainWindow("My Window", 200, 300));
		}
	}
	
	// main window
	class MainWindow : Form
	{
		// members for a simple menu system.
		private MenuStrip mnuMainMenu = new MenuStrip();
		private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
		private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();
		
		public MainWindow(string title, int height, int width) 
		{
			Text = title;
			Width = width;
			Height = height;
			
			CenterToScreen();
			// method to create the menu system.
			BuildMenuSystem();
		}
		
		private void BuildMenuSystem()
		{
			// adding the file menu item to the main menu.
			mnuFile.Text = "&File";
			mnuMainMenu.Items.Add(mnuFile);
			
			// add the exit menu to the file menu.
			mnuFileExit.Text = "E&xit";
			mnuFile.DropDownItems.Add(mnuFileExit);
			mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			
			// Finally, setting the menu for this form.
			Controls.Add(this.mnuMainMenu);
		}
		
		// Handler for the File | Exit event.
		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}