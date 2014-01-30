using System;
using MonoDevelop.Ide.Gui.Dialogs;

namespace MonoDevelop.Refactoring.Unity
{
	[System.ComponentModel.ToolboxItem (true)]
	partial class FileOperationsOptionsWidget : Gtk.Bin
	{
		public FileOperationsOptionsWidget ()
		{
			this.Build ();
			checkTrackFiles.Active = FileOperationsOptions.TrackFiles;
			checkTrackDirectories.Active = FileOperationsOptions.TrackDirectories;

			checkTrackCopy.Active = FileOperationsOptions.TrackCopy;
			checkTrackMove.Active = FileOperationsOptions.TrackMove;
			checkTrackRename.Active = FileOperationsOptions.TrackRename;
			checkTrackDelete.Active = FileOperationsOptions.TrackDelete;
		}

		public void ApplyChanges ()
		{
			FileOperationsOptions.TrackFiles = checkTrackFiles.Active;
			FileOperationsOptions.TrackDirectories = checkTrackDirectories.Active;

			FileOperationsOptions.TrackCopy = checkTrackCopy.Active;
			FileOperationsOptions.TrackMove = checkTrackMove.Active;
			FileOperationsOptions.TrackRename = checkTrackRename.Active;
			FileOperationsOptions.TrackDelete = checkTrackDelete.Active;
		}
	}
}
