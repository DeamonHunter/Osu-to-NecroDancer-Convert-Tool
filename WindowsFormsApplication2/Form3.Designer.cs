namespace WindowsFormsApplication2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.osuFinder = new System.Windows.Forms.Button();
            this.cotnFinder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.completeButton = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "As this is your first time using this program. Please enter the following;";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "The osu song folder location.";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(15, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(364, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "The Crypt of the Necrodancer custom music folder location.";
            // 
            // osuFinder
            // 
            this.osuFinder.Location = new System.Drawing.Point(385, 55);
            this.osuFinder.Name = "osuFinder";
            this.osuFinder.Size = new System.Drawing.Size(75, 23);
            this.osuFinder.TabIndex = 12;
            this.osuFinder.Text = "Browse";
            this.osuFinder.UseVisualStyleBackColor = true;
            this.osuFinder.Click += new System.EventHandler(this.osuFinder_Click);
            // 
            // cotnFinder
            // 
            this.cotnFinder.Location = new System.Drawing.Point(385, 107);
            this.cotnFinder.Name = "cotnFinder";
            this.cotnFinder.Size = new System.Drawing.Size(75, 23);
            this.cotnFinder.TabIndex = 13;
            this.cotnFinder.Text = "Browse";
            this.cotnFinder.UseVisualStyleBackColor = true;
            this.cotnFinder.Click += new System.EventHandler(this.cotnFinder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Osu Song folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Crypt of the NecroDancer custom music folder:";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(147, 138);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(161, 23);
            this.completeButton.TabIndex = 16;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.complete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 173);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cotnFinder);
            this.Controls.Add(this.osuFinder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button osuFinder;
        private System.Windows.Forms.Button cotnFinder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}