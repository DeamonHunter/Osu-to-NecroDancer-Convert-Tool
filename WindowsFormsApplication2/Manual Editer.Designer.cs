namespace WindowsFormsApplication2
{
    partial class Manual_Editer
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
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bpmUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.millisecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openManualButton = new System.Windows.Forms.Button();
            this.saveManualButton = new System.Windows.Forms.Button();
            this.manualConvertButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bpmChangeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.newBpmUpDown = new System.Windows.Forms.NumericUpDown();
            this.newOffsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bpmUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpmChangeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBpmUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOffsetUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Manual Editor: Choose what you want.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(53, 87);
            this.linkLabel1.Location = new System.Drawing.Point(5, 311);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(416, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "If you want a better manual editor, visit this site: http://necrodancer.eviltroop" +
    "a.com/";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bpmUpDown
            // 
            this.bpmUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bpmUpDown.Location = new System.Drawing.Point(290, 26);
            this.bpmUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bpmUpDown.Name = "bpmUpDown";
            this.bpmUpDown.Size = new System.Drawing.Size(120, 20);
            this.bpmUpDown.TabIndex = 21;
            this.bpmUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.bpmUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Beats per minute:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Offset (Milliseconds):";
            // 
            // offsetUpDown
            // 
            this.offsetUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.offsetUpDown.Location = new System.Drawing.Point(290, 52);
            this.offsetUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.offsetUpDown.Name = "offsetUpDown";
            this.offsetUpDown.Size = new System.Drawing.Size(120, 20);
            this.offsetUpDown.TabIndex = 24;
            this.offsetUpDown.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Song Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Minutes";
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Location = new System.Drawing.Point(200, 78);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(120, 20);
            this.minutesUpDown.TabIndex = 30;
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.secondsUpDown.Location = new System.Drawing.Point(200, 103);
            this.secondsUpDown.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(120, 20);
            this.secondsUpDown.TabIndex = 31;
            this.secondsUpDown.ThousandsSeparator = true;
            // 
            // millisecondsUpDown
            // 
            this.millisecondsUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.millisecondsUpDown.Location = new System.Drawing.Point(200, 127);
            this.millisecondsUpDown.Maximum = new decimal(new int[] {
            7200000,
            0,
            0,
            0});
            this.millisecondsUpDown.Name = "millisecondsUpDown";
            this.millisecondsUpDown.Size = new System.Drawing.Size(120, 20);
            this.millisecondsUpDown.TabIndex = 32;
            this.millisecondsUpDown.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Milliseconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.MaximumSize = new System.Drawing.Size(180, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 39);
            this.label7.TabIndex = 35;
            this.label7.Text = "You can specify the length in minutes, seconds or milleseconds or any combination" +
    " of the above.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Music File:";
            // 
            // openManualButton
            // 
            this.openManualButton.Location = new System.Drawing.Point(329, 153);
            this.openManualButton.Name = "openManualButton";
            this.openManualButton.Size = new System.Drawing.Size(75, 23);
            this.openManualButton.TabIndex = 37;
            this.openManualButton.Text = "Open";
            this.openManualButton.UseVisualStyleBackColor = true;
            // 
            // saveManualButton
            // 
            this.saveManualButton.Location = new System.Drawing.Point(329, 182);
            this.saveManualButton.Name = "saveManualButton";
            this.saveManualButton.Size = new System.Drawing.Size(75, 23);
            this.saveManualButton.TabIndex = 38;
            this.saveManualButton.Text = "Save";
            this.saveManualButton.UseVisualStyleBackColor = true;
            // 
            // manualConvertButton
            // 
            this.manualConvertButton.Enabled = false;
            this.manualConvertButton.Location = new System.Drawing.Point(335, 288);
            this.manualConvertButton.Name = "manualConvertButton";
            this.manualConvertButton.Size = new System.Drawing.Size(75, 23);
            this.manualConvertButton.TabIndex = 39;
            this.manualConvertButton.Text = "Convert";
            this.manualConvertButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Output:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "You can leave this empty.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Options:";
            // 
            // bpmChangeUpDown
            // 
            this.bpmChangeUpDown.Location = new System.Drawing.Point(290, 210);
            this.bpmChangeUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bpmChangeUpDown.Name = "bpmChangeUpDown";
            this.bpmChangeUpDown.Size = new System.Drawing.Size(120, 20);
            this.bpmChangeUpDown.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(89, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Bpm Change per bar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "New Bpm:";
            // 
            // newBpmUpDown
            // 
            this.newBpmUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.newBpmUpDown.Location = new System.Drawing.Point(290, 236);
            this.newBpmUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.newBpmUpDown.Name = "newBpmUpDown";
            this.newBpmUpDown.Size = new System.Drawing.Size(120, 20);
            this.newBpmUpDown.TabIndex = 49;
            // 
            // newOffsetUpDown
            // 
            this.newOffsetUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.newOffsetUpDown.Location = new System.Drawing.Point(290, 262);
            this.newOffsetUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.newOffsetUpDown.Name = "newOffsetUpDown";
            this.newOffsetUpDown.Size = new System.Drawing.Size(120, 20);
            this.newOffsetUpDown.TabIndex = 50;
            this.newOffsetUpDown.ThousandsSeparator = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(89, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Offset for new Bpm:";
            // 
            // Manual_Editer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 327);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.newOffsetUpDown);
            this.Controls.Add(this.newBpmUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bpmChangeUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.manualConvertButton);
            this.Controls.Add(this.saveManualButton);
            this.Controls.Add(this.openManualButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.millisecondsUpDown);
            this.Controls.Add(this.secondsUpDown);
            this.Controls.Add(this.minutesUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.offsetUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bpmUpDown);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Name = "Manual_Editer";
            this.Text = "Manual_Editer";
            ((System.ComponentModel.ISupportInitialize)(this.bpmUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpmChangeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBpmUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOffsetUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown bpmUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown offsetUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.NumericUpDown millisecondsUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openManualButton;
        private System.Windows.Forms.Button saveManualButton;
        private System.Windows.Forms.Button manualConvertButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown bpmChangeUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown newBpmUpDown;
        private System.Windows.Forms.NumericUpDown newOffsetUpDown;
        private System.Windows.Forms.Label label14;
    }
}