namespace UnicodeAndPermutation
{
	partial class Form1
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
			this.ListboxWords = new System.Windows.Forms.ListBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lblSum = new System.Windows.Forms.Label();
			this.txtWord = new System.Windows.Forms.TextBox();
			this.buttonPorcess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ListboxWords
			// 
			this.ListboxWords.FormattingEnabled = true;
			this.ListboxWords.Location = new System.Drawing.Point(31, 67);
			this.ListboxWords.Name = "ListboxWords";
			this.ListboxWords.Size = new System.Drawing.Size(112, 316);
			this.ListboxWords.TabIndex = 9;
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(9, 67);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(13, 13);
			this.lbl2.TabIndex = 6;
			this.lbl2.Text = "2";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(9, 38);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(13, 13);
			this.lbl1.TabIndex = 7;
			this.lbl1.Text = "1";
			// 
			// lblSum
			// 
			this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSum.Location = new System.Drawing.Point(31, 38);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(112, 20);
			this.lblSum.TabIndex = 8;
			// 
			// txtWord
			// 
			this.txtWord.Location = new System.Drawing.Point(31, 12);
			this.txtWord.Name = "txtWord";
			this.txtWord.Size = new System.Drawing.Size(112, 20);
			this.txtWord.TabIndex = 5;
			this.txtWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyDown);
			// 
			// buttonPorcess
			// 
			this.buttonPorcess.Location = new System.Drawing.Point(149, 10);
			this.buttonPorcess.Name = "buttonPorcess";
			this.buttonPorcess.Size = new System.Drawing.Size(75, 23);
			this.buttonPorcess.TabIndex = 4;
			this.buttonPorcess.Text = "Permute";
			this.buttonPorcess.UseVisualStyleBackColor = true;
			this.buttonPorcess.Click += new System.EventHandler(this.buttonPorcess_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 398);
			this.Controls.Add(this.ListboxWords);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lblSum);
			this.Controls.Add(this.txtWord);
			this.Controls.Add(this.buttonPorcess);
			this.Name = "Form1";
			this.Text = "Unicode and Anigrams";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListboxWords;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lblSum;
		private System.Windows.Forms.TextBox txtWord;
		private System.Windows.Forms.Button buttonPorcess;
	}
}

