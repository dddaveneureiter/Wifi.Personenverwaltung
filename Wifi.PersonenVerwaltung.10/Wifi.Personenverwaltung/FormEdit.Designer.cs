namespace Wifi.PersonenVerwaltung
{
	partial class FormEdit
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
			this.dateTimePickerGebDat = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxVorname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNachname = new System.Windows.Forms.TextBox();
			this.radioButtonGeschlechtW = new System.Windows.Forms.RadioButton();
			this.radioButtonGeschlechtM = new System.Windows.Forms.RadioButton();
			this.radioButtonGeschlechtD = new System.Windows.Forms.RadioButton();
			this.groupBoxGeschlecht = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.flowLayoutPanelKontakt = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonKontaktAdd = new System.Windows.Forms.Button();
			this.groupBoxGeschlecht.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePickerGebDat
			// 
			this.dateTimePickerGebDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerGebDat.Location = new System.Drawing.Point(474, 102);
			this.dateTimePickerGebDat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dateTimePickerGebDat.Name = "dateTimePickerGebDat";
			this.dateTimePickerGebDat.Size = new System.Drawing.Size(192, 26);
			this.dateTimePickerGebDat.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Vorname";
			// 
			// textBoxVorname
			// 
			this.textBoxVorname.Location = new System.Drawing.Point(22, 38);
			this.textBoxVorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxVorname.Name = "textBoxVorname";
			this.textBoxVorname.Size = new System.Drawing.Size(319, 26);
			this.textBoxVorname.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(363, 14);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nachname";
			// 
			// textBoxNachname
			// 
			this.textBoxNachname.Location = new System.Drawing.Point(368, 38);
			this.textBoxNachname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxNachname.Name = "textBoxNachname";
			this.textBoxNachname.Size = new System.Drawing.Size(442, 26);
			this.textBoxNachname.TabIndex = 4;
			// 
			// radioButtonGeschlechtW
			// 
			this.radioButtonGeschlechtW.AutoSize = true;
			this.radioButtonGeschlechtW.Location = new System.Drawing.Point(24, 29);
			this.radioButtonGeschlechtW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonGeschlechtW.Name = "radioButtonGeschlechtW";
			this.radioButtonGeschlechtW.Size = new System.Drawing.Size(93, 24);
			this.radioButtonGeschlechtW.TabIndex = 5;
			this.radioButtonGeschlechtW.TabStop = true;
			this.radioButtonGeschlechtW.Text = "Weiblich";
			this.radioButtonGeschlechtW.UseVisualStyleBackColor = true;
			// 
			// radioButtonGeschlechtM
			// 
			this.radioButtonGeschlechtM.AutoSize = true;
			this.radioButtonGeschlechtM.Location = new System.Drawing.Point(132, 29);
			this.radioButtonGeschlechtM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonGeschlechtM.Name = "radioButtonGeschlechtM";
			this.radioButtonGeschlechtM.Size = new System.Drawing.Size(97, 24);
			this.radioButtonGeschlechtM.TabIndex = 6;
			this.radioButtonGeschlechtM.TabStop = true;
			this.radioButtonGeschlechtM.Text = "Männlich";
			this.radioButtonGeschlechtM.UseVisualStyleBackColor = true;
			// 
			// radioButtonGeschlechtD
			// 
			this.radioButtonGeschlechtD.AutoSize = true;
			this.radioButtonGeschlechtD.Location = new System.Drawing.Point(243, 29);
			this.radioButtonGeschlechtD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButtonGeschlechtD.Name = "radioButtonGeschlechtD";
			this.radioButtonGeschlechtD.Size = new System.Drawing.Size(78, 24);
			this.radioButtonGeschlechtD.TabIndex = 7;
			this.radioButtonGeschlechtD.TabStop = true;
			this.radioButtonGeschlechtD.Text = "Divers";
			this.radioButtonGeschlechtD.UseVisualStyleBackColor = true;
			// 
			// groupBoxGeschlecht
			// 
			this.groupBoxGeschlecht.Controls.Add(this.radioButtonGeschlechtW);
			this.groupBoxGeschlecht.Controls.Add(this.radioButtonGeschlechtM);
			this.groupBoxGeschlecht.Controls.Add(this.radioButtonGeschlechtD);
			this.groupBoxGeschlecht.Location = new System.Drawing.Point(16, 80);
			this.groupBoxGeschlecht.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxGeschlecht.Name = "groupBoxGeschlecht";
			this.groupBoxGeschlecht.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBoxGeschlecht.Size = new System.Drawing.Size(400, 66);
			this.groupBoxGeschlecht.TabIndex = 10;
			this.groupBoxGeschlecht.TabStop = false;
			this.groupBoxGeschlecht.Text = "Geschlecht";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(470, 78);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Geburtsdatum";
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(578, 566);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(112, 35);
			this.buttonOk.TabIndex = 12;
			this.buttonOk.Text = "Ok";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(699, 566);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(112, 35);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Abbrechen";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// flowLayoutPanelKontakt
			// 
			this.flowLayoutPanelKontakt.AutoScroll = true;
			this.flowLayoutPanelKontakt.Location = new System.Drawing.Point(22, 200);
			this.flowLayoutPanelKontakt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.flowLayoutPanelKontakt.Name = "flowLayoutPanelKontakt";
			this.flowLayoutPanelKontakt.Size = new System.Drawing.Size(722, 326);
			this.flowLayoutPanelKontakt.TabIndex = 17;
			this.flowLayoutPanelKontakt.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelKontakt_Paint);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 175);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 20);
			this.label4.TabIndex = 18;
			this.label4.Text = "Bezeichnung";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(258, 175);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 20);
			this.label5.TabIndex = 19;
			this.label5.Text = "Wert";
			// 
			// buttonKontaktAdd
			// 
			this.buttonKontaktAdd.Location = new System.Drawing.Point(681, 162);
			this.buttonKontaktAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonKontaktAdd.Name = "buttonKontaktAdd";
			this.buttonKontaktAdd.Size = new System.Drawing.Size(63, 35);
			this.buttonKontaktAdd.TabIndex = 20;
			this.buttonKontaktAdd.Text = "+";
			this.buttonKontaktAdd.UseVisualStyleBackColor = true;
			this.buttonKontaktAdd.Click += new System.EventHandler(this.buttonKontaktAdd_Click);
			// 
			// FormEdit
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(832, 635);
			this.Controls.Add(this.buttonKontaktAdd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.flowLayoutPanelKontakt);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBoxGeschlecht);
			this.Controls.Add(this.textBoxNachname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxVorname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerGebDat);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormEdit";
			this.Text = "FormEdit";
			this.groupBoxGeschlecht.ResumeLayout(false);
			this.groupBoxGeschlecht.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerGebDat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxVorname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNachname;
		private System.Windows.Forms.RadioButton radioButtonGeschlechtW;
		private System.Windows.Forms.RadioButton radioButtonGeschlechtM;
		private System.Windows.Forms.RadioButton radioButtonGeschlechtD;
		private System.Windows.Forms.GroupBox groupBoxGeschlecht;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKontakt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonKontaktAdd;
	}
}