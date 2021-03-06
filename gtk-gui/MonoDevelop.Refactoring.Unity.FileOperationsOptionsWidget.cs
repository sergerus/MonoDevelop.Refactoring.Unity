
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Refactoring.Unity
{
	internal partial class FileOperationsOptionsWidget
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.CheckButton checkTrackFiles;
		private global::Gtk.CheckButton checkTrackDirectories;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.CheckButton checkTrackCopy;
		private global::Gtk.CheckButton checkTrackMove;
		private global::Gtk.CheckButton checkTrackRename;
		private global::Gtk.CheckButton checkTrackDelete;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Refactoring.Unity.FileOperationsOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Refactoring.Unity.FileOperationsOptionsWidget";
			// Container child MonoDevelop.Refactoring.Unity.FileOperationsOptionsWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.checkTrackFiles = new global::Gtk.CheckButton ();
			this.checkTrackFiles.CanFocus = true;
			this.checkTrackFiles.Name = "checkTrackFiles";
			this.checkTrackFiles.Label = global::Mono.Unix.Catalog.GetString ("Track files");
			this.checkTrackFiles.DrawIndicator = true;
			this.checkTrackFiles.UseUnderline = true;
			this.hbox1.Add (this.checkTrackFiles);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.checkTrackFiles]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.checkTrackDirectories = new global::Gtk.CheckButton ();
			this.checkTrackDirectories.CanFocus = true;
			this.checkTrackDirectories.Name = "checkTrackDirectories";
			this.checkTrackDirectories.Label = global::Mono.Unix.Catalog.GetString ("Track directories");
			this.checkTrackDirectories.DrawIndicator = true;
			this.checkTrackDirectories.UseUnderline = true;
			this.hbox1.Add (this.checkTrackDirectories);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.checkTrackDirectories]));
			w2.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkTrackCopy = new global::Gtk.CheckButton ();
			this.checkTrackCopy.CanFocus = true;
			this.checkTrackCopy.Name = "checkTrackCopy";
			this.checkTrackCopy.Label = global::Mono.Unix.Catalog.GetString ("Track copy");
			this.checkTrackCopy.DrawIndicator = true;
			this.checkTrackCopy.UseUnderline = true;
			this.vbox2.Add (this.checkTrackCopy);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkTrackCopy]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkTrackMove = new global::Gtk.CheckButton ();
			this.checkTrackMove.CanFocus = true;
			this.checkTrackMove.Name = "checkTrackMove";
			this.checkTrackMove.Label = global::Mono.Unix.Catalog.GetString ("Track move");
			this.checkTrackMove.DrawIndicator = true;
			this.checkTrackMove.UseUnderline = true;
			this.vbox2.Add (this.checkTrackMove);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkTrackMove]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkTrackRename = new global::Gtk.CheckButton ();
			this.checkTrackRename.CanFocus = true;
			this.checkTrackRename.Name = "checkTrackRename";
			this.checkTrackRename.Label = global::Mono.Unix.Catalog.GetString ("Track rename");
			this.checkTrackRename.DrawIndicator = true;
			this.checkTrackRename.UseUnderline = true;
			this.vbox2.Add (this.checkTrackRename);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkTrackRename]));
			w7.Position = 4;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkTrackDelete = new global::Gtk.CheckButton ();
			this.checkTrackDelete.CanFocus = true;
			this.checkTrackDelete.Name = "checkTrackDelete";
			this.checkTrackDelete.Label = global::Mono.Unix.Catalog.GetString ("Track delete");
			this.checkTrackDelete.DrawIndicator = true;
			this.checkTrackDelete.UseUnderline = true;
			this.vbox2.Add (this.checkTrackDelete);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkTrackDelete]));
			w8.Position = 5;
			w8.Expand = false;
			w8.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
