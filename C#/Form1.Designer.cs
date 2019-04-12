namespace Multiplication_Table
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
			this.textBoxFirstValue = new System.Windows.Forms.TextBox();
			this.textBoxSecondValue = new System.Windows.Forms.TextBox();
			this.labelMulSym = new System.Windows.Forms.Label();
			this.labelEqSym = new System.Windows.Forms.Label();
			this.labelResultMul = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxFirstValue
			// 
			this.textBoxFirstValue.Location = new System.Drawing.Point(245, 12);
			this.textBoxFirstValue.Name = "textBoxFirstValue";
			this.textBoxFirstValue.Size = new System.Drawing.Size(100, 20);
			this.textBoxFirstValue.TabIndex = 0;
			this.textBoxFirstValue.TextChanged += new System.EventHandler(this.multiply);
			// 
			// textBoxSecondValue
			// 
			this.textBoxSecondValue.Location = new System.Drawing.Point(377, 12);
			this.textBoxSecondValue.Name = "textBoxSecondValue";
			this.textBoxSecondValue.Size = new System.Drawing.Size(100, 20);
			this.textBoxSecondValue.TabIndex = 1;
			this.textBoxSecondValue.TextChanged += new System.EventHandler(this.multiply);
			// 
			// labelMulSym
			// 
			this.labelMulSym.AutoSize = true;
			this.labelMulSym.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelMulSym.Location = new System.Drawing.Point(351, 15);
			this.labelMulSym.Name = "labelMulSym";
			this.labelMulSym.Size = new System.Drawing.Size(20, 25);
			this.labelMulSym.TabIndex = 2;
			this.labelMulSym.Text = "*";
			// 
			// labelEqSym
			// 
			this.labelEqSym.AutoSize = true;
			this.labelEqSym.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelEqSym.Location = new System.Drawing.Point(483, 8);
			this.labelEqSym.Name = "labelEqSym";
			this.labelEqSym.Size = new System.Drawing.Size(24, 25);
			this.labelEqSym.TabIndex = 2;
			this.labelEqSym.Text = "=";
			// 
			// labelResultMul
			// 
			this.labelResultMul.AutoSize = true;
			this.labelResultMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelResultMul.Location = new System.Drawing.Point(513, 8);
			this.labelResultMul.Name = "labelResultMul";
			this.labelResultMul.Size = new System.Drawing.Size(23, 25);
			this.labelResultMul.TabIndex = 2;
			this.labelResultMul.Text = "?";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(775, 398);
			this.dataGridView1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.labelResultMul);
			this.Controls.Add(this.labelEqSym);
			this.Controls.Add(this.labelMulSym);
			this.Controls.Add(this.textBoxSecondValue);
			this.Controls.Add(this.textBoxFirstValue);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Таблица умножения. Мусин А.М. 2019г.";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxFirstValue;
		private System.Windows.Forms.TextBox textBoxSecondValue;
		private System.Windows.Forms.Label labelMulSym;
		private System.Windows.Forms.Label labelEqSym;
		private System.Windows.Forms.Label labelResultMul;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

