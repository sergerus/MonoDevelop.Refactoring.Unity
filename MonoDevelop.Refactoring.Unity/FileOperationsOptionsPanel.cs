using System;
using MonoDevelop.Ide.Gui.Dialogs;
using Gtk;

namespace MonoDevelop.Refactoring.Unity
{
	public class FileOperationsOptionsPanel : OptionsPanel
	{
		FileOperationsOptionsWidget widget;

		public override Gtk.Widget CreatePanelWidget ()
		{
			return widget = new FileOperationsOptionsWidget ();
		}

		public override void ApplyChanges ()
		{
			widget.ApplyChanges ();
		}
	}
}
