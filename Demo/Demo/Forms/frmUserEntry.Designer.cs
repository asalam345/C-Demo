namespace Demo.Forms
{
	partial class frmUserEntry
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbCity = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.RichTextBox();
			this.rbGender = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.cbName = new System.Windows.Forms.ComboBox();
			this.dpDOB = new System.Windows.Forms.DateTimePicker();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dgUsers = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbCity);
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.rbGender);
			this.groupBox1.Controls.Add(this.rbMale);
			this.groupBox1.Controls.Add(this.cbName);
			this.groupBox1.Controls.Add(this.dpDOB);
			this.groupBox1.Controls.Add(this.txtSalary);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCode);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(14, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 212);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Entry User";
			// 
			// cbCity
			// 
			this.cbCity.FormattingEnabled = true;
			this.cbCity.Location = new System.Drawing.Point(427, 65);
			this.cbCity.Name = "cbCity";
			this.cbCity.Size = new System.Drawing.Size(133, 21);
			this.cbCity.TabIndex = 25;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(152, 65);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(213, 71);
			this.txtAddress.TabIndex = 24;
			this.txtAddress.Text = "";
			// 
			// rbGender
			// 
			this.rbGender.AutoSize = true;
			this.rbGender.Location = new System.Drawing.Point(518, 103);
			this.rbGender.Name = "rbGender";
			this.rbGender.Size = new System.Drawing.Size(59, 17);
			this.rbGender.TabIndex = 23;
			this.rbGender.Text = "Female";
			this.rbGender.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Checked = true;
			this.rbMale.Location = new System.Drawing.Point(427, 103);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(48, 17);
			this.rbMale.TabIndex = 23;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// cbName
			// 
			this.cbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbName.FormattingEnabled = true;
			this.cbName.Items.AddRange(new object[] {
            "Abdur Rahim",
            "Abdullah",
            "Mr. Sojib",
            "Mohammod Shawon",
            "Abdus Sattar",
            "Pavel",
            "A. K. Akiz",
            "Pavel Chowdury"});
			this.cbName.Location = new System.Drawing.Point(152, 39);
			this.cbName.Name = "cbName";
			this.cbName.Size = new System.Drawing.Size(213, 21);
			this.cbName.TabIndex = 22;
			// 
			// dpDOB
			// 
			this.dpDOB.Location = new System.Drawing.Point(426, 36);
			this.dpDOB.Name = "dpDOB";
			this.dpDOB.Size = new System.Drawing.Size(200, 20);
			this.dpDOB.TabIndex = 21;
			// 
			// txtSalary
			// 
			this.txtSalary.Location = new System.Drawing.Point(152, 145);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(100, 20);
			this.txtSalary.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Salary";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(390, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "City";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(390, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "DOB";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Address";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(152, 14);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(100, 20);
			this.txtCode.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Code";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(372, 180);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(152, 180);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Save && Clear";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(272, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.dgUsers);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(12, 223);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(776, 283);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "User List";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(6, 22);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(237, 21);
			this.comboBox2.TabIndex = 23;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(513, 22);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 21;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(377, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 21;
			// 
			// dgUsers
			// 
			this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUsers.Location = new System.Drawing.Point(6, 48);
			this.dgUsers.MultiSelect = false;
			this.dgUsers.Name = "dgUsers";
			this.dgUsers.Size = new System.Drawing.Size(764, 227);
			this.dgUsers.TabIndex = 6;
			this.dgUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellContentClick);
			this.dgUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgUsers_RowHeaderMouseClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(480, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Max";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(267, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Salary Range    Min";
			// 
			// frmUserEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 509);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmUserEntry";
			this.Load += new System.EventHandler(this.frmUserEntry_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbCity;
		private System.Windows.Forms.RichTextBox txtAddress;
		private System.Windows.Forms.RadioButton rbGender;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.ComboBox cbName;
		private System.Windows.Forms.DateTimePicker dpDOB;
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dgUsers;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}

