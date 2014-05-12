namespace WindowsFormsApplication2
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
            this.convertOkButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openOsuFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveLocationButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.showDebugCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // convertOkButton
            // 
            this.convertOkButton.BackColor = System.Drawing.Color.Silver;
            this.convertOkButton.Enabled = false;
            this.convertOkButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.convertOkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convertOkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.convertOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertOkButton.ForeColor = System.Drawing.Color.Black;
            this.convertOkButton.Location = new System.Drawing.Point(397, 226);
            this.convertOkButton.Name = "convertOkButton";
            this.convertOkButton.Size = new System.Drawing.Size(75, 23);
            this.convertOkButton.TabIndex = 0;
            this.convertOkButton.Text = "Convert";
            this.convertOkButton.UseVisualStyleBackColor = false;
            this.convertOkButton.Click += new System.EventHandler(this.convertOkButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // openOsuFileButton
            // 
            this.openOsuFileButton.BackColor = System.Drawing.Color.Silver;
            this.openOsuFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openOsuFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openOsuFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.openOsuFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openOsuFileButton.ForeColor = System.Drawing.Color.Black;
            this.openOsuFileButton.Location = new System.Drawing.Point(397, 72);
            this.openOsuFileButton.Name = "openOsuFileButton";
            this.openOsuFileButton.Size = new System.Drawing.Size(75, 23);
            this.openOsuFileButton.TabIndex = 2;
            this.openOsuFileButton.Text = "Open";
            this.openOsuFileButton.UseVisualStyleBackColor = false;
            this.openOsuFileButton.Click += new System.EventHandler(this.openOsuFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DeamonHunter\'s Osu to NecroDancer Conversion Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Step: 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Open a .osu file from your preferred song.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose the preferred folder and name to place the text file.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Step: 2";
            // 
            // saveLocationButton
            // 
            this.saveLocationButton.BackColor = System.Drawing.Color.Silver;
            this.saveLocationButton.Enabled = false;
            this.saveLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.saveLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLocationButton.ForeColor = System.Drawing.Color.Black;
            this.saveLocationButton.Location = new System.Drawing.Point(397, 132);
            this.saveLocationButton.Name = "saveLocationButton";
            this.saveLocationButton.Size = new System.Drawing.Size(75, 23);
            this.saveLocationButton.TabIndex = 9;
            this.saveLocationButton.Text = "Open";
            this.saveLocationButton.UseVisualStyleBackColor = false;
            this.saveLocationButton.Click += new System.EventHandler(this.saveLocationButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose your preferred options.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Step: 3";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Copy song";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Click Convert.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Step: 4";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(95, 195);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Add beats to leadup";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // showDebugCheckBox
            // 
            this.showDebugCheckBox.AutoSize = true;
            this.showDebugCheckBox.Location = new System.Drawing.Point(222, 195);
            this.showDebugCheckBox.Name = "showDebugCheckBox";
            this.showDebugCheckBox.Size = new System.Drawing.Size(141, 17);
            this.showDebugCheckBox.TabIndex = 16;
            this.showDebugCheckBox.Text = "Show the Debug Output";
            this.showDebugCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 254);
            this.Controls.Add(this.showDebugCheckBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveLocationButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openOsuFileButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertOkButton);
            this.Name = "Form1";
            this.Text = "DeamonHunter\'s Conversion Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertOkButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openOsuFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveLocationButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox showDebugCheckBox;
    }
}

