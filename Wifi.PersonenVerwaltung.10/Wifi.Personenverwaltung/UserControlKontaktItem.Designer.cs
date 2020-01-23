namespace Wifi.PersonenVerwaltung
{
	partial class UserControlKontaktItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxBezeichnung = new System.Windows.Forms.ComboBox();
			this.textBoxWert = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBoxBezeichnung
			// 
			this.comboBoxBezeichnung.FormattingEnabled = true;
			this.comboBoxBezeichnung.Items.AddRange(new object[] {
            "Telefon (mobil)",
            "Telefon (arbeit)",
            "Telefon (privat)",
            "Mail (arbeit)",
            "Mail (privat)",
            "Skype",
            "WhatsApp"});
			this.comboBoxBezeichnung.Location = new System.Drawing.Point(0, 0);
			this.comboBoxBezeichnung.Name = "comboBoxBezeichnung";
			this.comboBoxBezeichnung.Size = new System.Drawing.Size(149, 21);
			this.comboBoxBezeichnung.TabIndex = 0;
			// 
			// textBoxWert
			// 
			this.textBoxWert.Location = new System.Drawing.Point(153, 0);
			this.textBoxWert.Name = "textBoxWert";
			this.textBoxWert.Size = new System.Drawing.Size(292, 20);
			this.textBoxWert.TabIndex = 1;
			// 
			// UserControlKontaktItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxWert);
			this.Controls.Add(this.comboBoxBezeichnung);
			this.Name = "UserControlKontaktItem";
			this.Size = new System.Drawing.Size(445, 22);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxBezeichnung;
		private System.Windows.Forms.TextBox textBoxWert;
	}
}
