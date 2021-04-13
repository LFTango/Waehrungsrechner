namespace Währungsrechner
{
	partial class Forms1
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
			this.BerechnungsButton = new System.Windows.Forms.Button();
			this.SummeLB = new System.Windows.Forms.Label();
			this.vonWährung = new System.Windows.Forms.Label();
			this.nachWährung = new System.Windows.Forms.Label();
			this.summeTBox = new System.Windows.Forms.TextBox();
			this.comboVon = new System.Windows.Forms.ComboBox();
			this.comboNach = new System.Windows.Forms.ComboBox();
			this.ErgLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BerechnungsButton
			// 
			this.BerechnungsButton.Location = new System.Drawing.Point(87, 140);
			this.BerechnungsButton.Name = "BerechnungsButton";
			this.BerechnungsButton.Size = new System.Drawing.Size(100, 23);
			this.BerechnungsButton.TabIndex = 0;
			this.BerechnungsButton.Text = "Berechnen";
			this.BerechnungsButton.UseVisualStyleBackColor = true;
			this.BerechnungsButton.Click += new System.EventHandler(this.BerechnungButton);
			// 
			// SummeLB
			// 
			this.SummeLB.AutoSize = true;
			this.SummeLB.Location = new System.Drawing.Point(12, 10);
			this.SummeLB.Name = "SummeLB";
			this.SummeLB.Size = new System.Drawing.Size(42, 13);
			this.SummeLB.TabIndex = 1;
			this.SummeLB.Text = "Summe";
			this.SummeLB.Click += new System.EventHandler(this.label1_Click);
			// 
			// vonWährung
			// 
			this.vonWährung.AutoSize = true;
			this.vonWährung.Location = new System.Drawing.Point(12, 55);
			this.vonWährung.Name = "vonWährung";
			this.vonWährung.Size = new System.Drawing.Size(79, 13);
			this.vonWährung.TabIndex = 2;
			this.vonWährung.Text = "Von (Währung)";
			// 
			// nachWährung
			// 
			this.nachWährung.AutoSize = true;
			this.nachWährung.Location = new System.Drawing.Point(12, 100);
			this.nachWährung.Name = "nachWährung";
			this.nachWährung.Size = new System.Drawing.Size(86, 13);
			this.nachWährung.TabIndex = 3;
			this.nachWährung.Text = "Nach (Währung)";
			// 
			// summeTBox
			// 
			this.summeTBox.Location = new System.Drawing.Point(118, 10);
			this.summeTBox.Name = "summeTBox";
			this.summeTBox.Size = new System.Drawing.Size(100, 20);
			this.summeTBox.TabIndex = 4;
			// 
			// comboVon
			// 
			this.comboVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVon.FormattingEnabled = true;
			this.comboVon.Items.AddRange(new object[] {
            "Yen",
            "Rupie",
            "Rubel",
            "Pfund",
            "Euro",
            "Dollar"});
			this.comboVon.Location = new System.Drawing.Point(118, 47);
			this.comboVon.Name = "comboVon";
			this.comboVon.Size = new System.Drawing.Size(100, 21);
			this.comboVon.TabIndex = 5;
			// 
			// comboNach
			// 
			this.comboNach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboNach.FormattingEnabled = true;
			this.comboNach.Items.AddRange(new object[] {
            "Yen",
            "Rupie",
            "Rubel",
            "Pfund",
            "Euro",
            "Dollar"});
			this.comboNach.Location = new System.Drawing.Point(118, 92);
			this.comboNach.Name = "comboNach";
			this.comboNach.Size = new System.Drawing.Size(100, 21);
			this.comboNach.TabIndex = 6;
			// 
			// ErgLabel
			// 
			this.ErgLabel.AutoSize = true;
			this.ErgLabel.Location = new System.Drawing.Point(67, 182);
			this.ErgLabel.Name = "ErgLabel";
			this.ErgLabel.Size = new System.Drawing.Size(10, 13);
			this.ErgLabel.TabIndex = 7;
			this.ErgLabel.Text = ":";
			// 
			// Forms1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 226);
			this.Controls.Add(this.ErgLabel);
			this.Controls.Add(this.comboNach);
			this.Controls.Add(this.comboVon);
			this.Controls.Add(this.summeTBox);
			this.Controls.Add(this.nachWährung);
			this.Controls.Add(this.vonWährung);
			this.Controls.Add(this.SummeLB);
			this.Controls.Add(this.BerechnungsButton);
			this.Name = "Forms1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Währungsberechner";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BerechnungsButton;
		private System.Windows.Forms.Label SummeLB;
		private System.Windows.Forms.Label vonWährung;
		private System.Windows.Forms.Label nachWährung;
		private System.Windows.Forms.TextBox summeTBox;
		private System.Windows.Forms.ComboBox comboVon;
		private System.Windows.Forms.ComboBox comboNach;
		private System.Windows.Forms.Label ErgLabel;
	}
}

