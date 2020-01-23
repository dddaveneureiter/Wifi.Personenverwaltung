namespace Wifi.PersonenVerwaltung
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemDel = new System.Windows.Forms.ToolStripMenuItem();
			this.listViewPerson = new System.Windows.Forms.ListView();
			this.columnVorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnNachname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnGeschlecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnGebDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.editToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// programmToolStripMenuItem
			// 
			this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemSave,
            this.toolStripMenuItem1,
            this.menuItemExit});
			this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
			this.programmToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
			this.programmToolStripMenuItem.Text = "Programm";
			// 
			// menuItemOpen
			// 
			this.menuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuItemOpen.Image")));
			this.menuItemOpen.Name = "menuItemOpen";
			this.menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menuItemOpen.Size = new System.Drawing.Size(277, 34);
			this.menuItemOpen.Text = "Datei öffnen";
			this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
			// 
			// menuItemSave
			// 
			this.menuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSave.Image")));
			this.menuItemSave.Name = "menuItemSave";
			this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuItemSave.Size = new System.Drawing.Size(277, 34);
			this.menuItemSave.Text = "Speichern";
			this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(274, 6);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("menuItemExit.Image")));
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.menuItemExit.Size = new System.Drawing.Size(277, 34);
			this.menuItemExit.Text = "Beenden";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemDel});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// menuItemNew
			// 
			this.menuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("menuItemNew.Image")));
			this.menuItemNew.Name = "menuItemNew";
			this.menuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuItemNew.Size = new System.Drawing.Size(216, 34);
			this.menuItemNew.Text = "Neu";
			this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
			// 
			// menuItemDel
			// 
			this.menuItemDel.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDel.Image")));
			this.menuItemDel.Name = "menuItemDel";
			this.menuItemDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.menuItemDel.Size = new System.Drawing.Size(216, 34);
			this.menuItemDel.Text = "Löschen";
			this.menuItemDel.Click += new System.EventHandler(this.menuItemDel_Click);
			// 
			// listViewPerson
			// 
			this.listViewPerson.BackColor = System.Drawing.SystemColors.Window;
			this.listViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVorname,
            this.columnNachname,
            this.columnGeschlecht,
            this.columnGebDat});
			this.listViewPerson.FullRowSelect = true;
			this.listViewPerson.GridLines = true;
			this.listViewPerson.HideSelection = false;
			this.listViewPerson.Location = new System.Drawing.Point(18, 42);
			this.listViewPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewPerson.Name = "listViewPerson";
			this.listViewPerson.Size = new System.Drawing.Size(1162, 615);
			this.listViewPerson.TabIndex = 1;
			this.listViewPerson.UseCompatibleStateImageBehavior = false;
			this.listViewPerson.View = System.Windows.Forms.View.Details;
			this.listViewPerson.SelectedIndexChanged += new System.EventHandler(this.listViewPerson_SelectedIndexChanged);
			this.listViewPerson.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPerson_MouseDoubleClick);
			// 
			// columnVorname
			// 
			this.columnVorname.Text = "Vorname";
			this.columnVorname.Width = 150;
			// 
			// columnNachname
			// 
			this.columnNachname.Text = "Nachname";
			this.columnNachname.Width = 150;
			// 
			// columnGeschlecht
			// 
			this.columnGeschlecht.Text = "Geschlecht";
			this.columnGeschlecht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnGeschlecht.Width = 70;
			// 
			// columnGebDat
			// 
			this.columnGebDat.Text = "Geburtsdat.";
			this.columnGebDat.Width = 100;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.listViewPerson);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormMain";
			this.Text = "Personen Verwaltung 1.0 (c) 2019 by Wifi";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
		private System.Windows.Forms.ToolStripMenuItem menuItemSave;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuItemExit;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItemNew;
		private System.Windows.Forms.ToolStripMenuItem menuItemDel;
		private System.Windows.Forms.ListView listViewPerson;
		private System.Windows.Forms.ColumnHeader columnVorname;
		private System.Windows.Forms.ColumnHeader columnNachname;
		private System.Windows.Forms.ColumnHeader columnGeschlecht;
		private System.Windows.Forms.ColumnHeader columnGebDat;
	}
}

