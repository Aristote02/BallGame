namespace BallGameWFA
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PowernumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AnglenumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.WeightnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Firebutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Firebutton2 = new System.Windows.Forms.Button();
            this.Power2numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Angle2numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Weight2numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PowernumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglenumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power2numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle2numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight2numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // PowernumericUpDown
            // 
            this.PowernumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowernumericUpDown.Location = new System.Drawing.Point(59, 52);
            this.PowernumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PowernumericUpDown.Name = "PowernumericUpDown";
            this.PowernumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.PowernumericUpDown.TabIndex = 3;
            this.PowernumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // AnglenumericUpDown1
            // 
            this.AnglenumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnglenumericUpDown1.Location = new System.Drawing.Point(176, 52);
            this.AnglenumericUpDown1.Name = "AnglenumericUpDown1";
            this.AnglenumericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.AnglenumericUpDown1.TabIndex = 4;
            this.AnglenumericUpDown1.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // WeightnumericUpDown1
            // 
            this.WeightnumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightnumericUpDown1.Location = new System.Drawing.Point(297, 52);
            this.WeightnumericUpDown1.Name = "WeightnumericUpDown1";
            this.WeightnumericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.WeightnumericUpDown1.TabIndex = 5;
            this.WeightnumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Firebutton
            // 
            this.Firebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firebutton.Location = new System.Drawing.Point(420, 52);
            this.Firebutton.Name = "Firebutton";
            this.Firebutton.Size = new System.Drawing.Size(75, 23);
            this.Firebutton.TabIndex = 6;
            this.Firebutton.Text = "Fire";
            this.Firebutton.UseVisualStyleBackColor = true;
            this.Firebutton.Click += new System.EventHandler(this.Firebutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Power2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Angle2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Weight2";
            // 
            // Firebutton2
            // 
            this.Firebutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firebutton2.Location = new System.Drawing.Point(420, 132);
            this.Firebutton2.Name = "Firebutton2";
            this.Firebutton2.Size = new System.Drawing.Size(75, 23);
            this.Firebutton2.TabIndex = 10;
            this.Firebutton2.Text = "Fire2";
            this.Firebutton2.UseVisualStyleBackColor = true;
            this.Firebutton2.Click += new System.EventHandler(this.Firebutton2_Click);
            // 
            // Power2numericUpDown1
            // 
            this.Power2numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Power2numericUpDown1.Location = new System.Drawing.Point(59, 135);
            this.Power2numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Power2numericUpDown1.Name = "Power2numericUpDown1";
            this.Power2numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.Power2numericUpDown1.TabIndex = 11;
            this.Power2numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Angle2numericUpDown2
            // 
            this.Angle2numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angle2numericUpDown2.Location = new System.Drawing.Point(176, 135);
            this.Angle2numericUpDown2.Name = "Angle2numericUpDown2";
            this.Angle2numericUpDown2.Size = new System.Drawing.Size(46, 20);
            this.Angle2numericUpDown2.TabIndex = 12;
            this.Angle2numericUpDown2.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // Weight2numericUpDown3
            // 
            this.Weight2numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight2numericUpDown3.Location = new System.Drawing.Point(291, 135);
            this.Weight2numericUpDown3.Name = "Weight2numericUpDown3";
            this.Weight2numericUpDown3.Size = new System.Drawing.Size(55, 20);
            this.Weight2numericUpDown3.TabIndex = 13;
            this.Weight2numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Weight2numericUpDown3);
            this.Controls.Add(this.Angle2numericUpDown2);
            this.Controls.Add(this.Power2numericUpDown1);
            this.Controls.Add(this.Firebutton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Firebutton);
            this.Controls.Add(this.WeightnumericUpDown1);
            this.Controls.Add(this.AnglenumericUpDown1);
            this.Controls.Add(this.PowernumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BallGame";
            ((System.ComponentModel.ISupportInitialize)(this.PowernumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglenumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power2numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle2numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight2numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PowernumericUpDown;
        private System.Windows.Forms.NumericUpDown AnglenumericUpDown1;
        private System.Windows.Forms.NumericUpDown WeightnumericUpDown1;
        private System.Windows.Forms.Button Firebutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Firebutton2;
        private System.Windows.Forms.NumericUpDown Power2numericUpDown1;
        private System.Windows.Forms.NumericUpDown Angle2numericUpDown2;
        private System.Windows.Forms.NumericUpDown Weight2numericUpDown3;
        private System.Windows.Forms.Timer timer2;
    }
}

