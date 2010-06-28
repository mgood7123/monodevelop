
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Database.Designer
{
	public partial class PreviewDialog
	{
		private global::Gtk.VBox vboxContent;

		private global::MonoDevelop.Database.Components.SqlEditorWidget sqlEditor;

		private global::Gtk.Button button21;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Database.Designer.PreviewDialog
			this.Name = "MonoDevelop.Database.Designer.PreviewDialog";
			this.Title = global::MonoDevelop.Database.AddinCatalog.GetString ("Preview");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.SkipTaskbarHint = true;
			// Internal child MonoDevelop.Database.Designer.PreviewDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vboxContent = new global::Gtk.VBox ();
			this.vboxContent.Name = "vboxContent";
			this.vboxContent.Spacing = 6;
			// Container child vboxContent.Gtk.Box+BoxChild
			this.sqlEditor = null;
			this.vboxContent.Add (this.sqlEditor);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxContent[this.sqlEditor]));
			w2.Position = 0;
			w1.Add (this.vboxContent);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1[this.vboxContent]));
			w3.Position = 0;
			// Internal child MonoDevelop.Database.Designer.PreviewDialog.ActionArea
			global::Gtk.HButtonBox w4 = this.ActionArea;
			w4.Name = "dialog1_ActionArea";
			w4.Spacing = 6;
			w4.BorderWidth = ((uint)(5));
			w4.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button21 = new global::Gtk.Button ();
			this.button21.CanFocus = true;
			this.button21.Name = "button21";
			this.button21.UseUnderline = true;
			// Container child button21.Gtk.Container+ContainerChild
			global::Gtk.Alignment w5 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w6 = new global::Gtk.HBox ();
			w6.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			w6.Add (w7);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w9 = new global::Gtk.Label ();
			w9.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("_Save Script");
			w9.UseUnderline = true;
			w6.Add (w9);
			w5.Add (w6);
			this.button21.Add (w5);
			this.AddActionWidget (this.button21, -10);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4[this.button21]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4[this.buttonCancel]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w4[this.buttonOk]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 617;
			this.DefaultHeight = 382;
			this.Show ();
			this.button21.Clicked += new global::System.EventHandler (this.OnButton21Clicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.CancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OkClicked);
		}
	}
}
