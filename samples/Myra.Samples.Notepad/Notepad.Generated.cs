/* Generated by MyraPad at 9/8/2022 6:37:17 AM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Myra.Samples.Notepad
{
	partial class Notepad: VerticalStackPanel
	{
		private void BuildUI()
		{
			menuItemNew = new MenuItem();
			menuItemNew.Text = "&New";
			menuItemNew.ShortcutText = "Ctrl+N";
			menuItemNew.Id = "menuItemNew";

			menuItemOpen = new MenuItem();
			menuItemOpen.Text = "&Open...";
			menuItemOpen.ShortcutText = "Ctrl+O";
			menuItemOpen.Id = "menuItemOpen";

			menuItemSave = new MenuItem();
			menuItemSave.Text = "&Save";
			menuItemSave.ShortcutText = "Ctrl+S";
			menuItemSave.Id = "menuItemSave";

			menuItemSaveAs = new MenuItem();
			menuItemSaveAs.Text = "Save &As...";
			menuItemSaveAs.Id = "menuItemSaveAs";

			var menuSeparator1 = new MenuSeparator();

			menuItemDebugOptions = new MenuItem();
			menuItemDebugOptions.Text = "Debug Options";
			menuItemDebugOptions.Id = "menuItemDebugOptions";

			var menuSeparator2 = new MenuSeparator();

			menuItemQuit = new MenuItem();
			menuItemQuit.Text = "&Quit";
			menuItemQuit.ShortcutText = "Ctrl+Q";
			menuItemQuit.Id = "menuItemQuit";

			menuItemFile = new MenuItem();
			menuItemFile.Text = "&File";
			menuItemFile.Id = "menuItemFile";
			menuItemFile.Items.Add(menuItemNew);
			menuItemFile.Items.Add(menuItemOpen);
			menuItemFile.Items.Add(menuItemSave);
			menuItemFile.Items.Add(menuItemSaveAs);
			menuItemFile.Items.Add(menuSeparator1);
			menuItemFile.Items.Add(menuItemDebugOptions);
			menuItemFile.Items.Add(menuSeparator2);
			menuItemFile.Items.Add(menuItemQuit);

			menuItemAbout = new MenuItem();
			menuItemAbout.Text = "About";
			menuItemAbout.Id = "menuItemAbout";

			menuItemHelp = new MenuItem();
			menuItemHelp.Text = "&Help";
			menuItemHelp.Id = "menuItemHelp";
			menuItemHelp.Items.Add(menuItemAbout);

			_mainMenu = new HorizontalMenu();
			_mainMenu.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_mainMenu.Id = "_mainMenu";
			_mainMenu.Items.Add(menuItemFile);
			_mainMenu.Items.Add(menuItemHelp);

			var horizontalSeparator1 = new HorizontalSeparator();

			textArea = new TextBox();
			textArea.Multiline = true;
			textArea.Wrap = true;
			textArea.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			textArea.Id = "textArea";

			var scrollViewer1 = new ScrollViewer();
			scrollViewer1.Content = textArea;

			
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			Widgets.Add(_mainMenu);
			Widgets.Add(horizontalSeparator1);
			Widgets.Add(scrollViewer1);
		}

		
		public MenuItem menuItemNew;
		public MenuItem menuItemOpen;
		public MenuItem menuItemSave;
		public MenuItem menuItemSaveAs;
		public MenuItem menuItemDebugOptions;
		public MenuItem menuItemQuit;
		public MenuItem menuItemFile;
		public MenuItem menuItemAbout;
		public MenuItem menuItemHelp;
		public HorizontalMenu _mainMenu;
		public TextBox textArea;
	}
}
