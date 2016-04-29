namespace WindowsDemoQuiz
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQ1A1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ1A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ1A3 = new System.Windows.Forms.RadioButton();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelQ2 = new System.Windows.Forms.Label();
            this.radioButtonQ2A3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ2A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ2A1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.radioButtonQ3A3 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQ3A1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelA2 = new System.Windows.Forms.Label();
            this.labelA3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsDemoQuiz.Properties.Resources.images2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsDemoQuiz.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsDemoQuiz.Properties.Resources.image3;
            this.pictureBox3.Location = new System.Drawing.Point(12, 405);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.labelQ1);
            this.groupBox1.Controls.Add(this.radioButtonQ1A3);
            this.groupBox1.Controls.Add(this.radioButtonQ1A2);
            this.groupBox1.Controls.Add(this.radioButtonQ1A1);
            this.groupBox1.Location = new System.Drawing.Point(217, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonQ1A1
            // 
            this.radioButtonQ1A1.AutoSize = true;
            this.radioButtonQ1A1.CausesValidation = false;
            this.radioButtonQ1A1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonQ1A1.Location = new System.Drawing.Point(24, 46);
            this.radioButtonQ1A1.Name = "radioButtonQ1A1";
            this.radioButtonQ1A1.Size = new System.Drawing.Size(49, 17);
            this.radioButtonQ1A1.TabIndex = 0;
            this.radioButtonQ1A1.Text = "Tiger";
            this.radioButtonQ1A1.UseVisualStyleBackColor = true;
            this.radioButtonQ1A1.CheckedChanged += new System.EventHandler(this.radioButtonQ1A1_CheckedChanged);
            // 
            // radioButtonQ1A2
            // 
            this.radioButtonQ1A2.AutoSize = true;
            this.radioButtonQ1A2.CausesValidation = false;
            this.radioButtonQ1A2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonQ1A2.Location = new System.Drawing.Point(24, 90);
            this.radioButtonQ1A2.Name = "radioButtonQ1A2";
            this.radioButtonQ1A2.Size = new System.Drawing.Size(64, 17);
            this.radioButtonQ1A2.TabIndex = 1;
            this.radioButtonQ1A2.Text = "Leopard";
            this.radioButtonQ1A2.UseVisualStyleBackColor = true;
            this.radioButtonQ1A2.CheckedChanged += new System.EventHandler(this.radioButtonQ1A2_CheckedChanged);
            // 
            // radioButtonQ1A3
            // 
            this.radioButtonQ1A3.AutoSize = true;
            this.radioButtonQ1A3.CausesValidation = false;
            this.radioButtonQ1A3.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonQ1A3.Location = new System.Drawing.Point(24, 129);
            this.radioButtonQ1A3.Name = "radioButtonQ1A3";
            this.radioButtonQ1A3.Size = new System.Drawing.Size(69, 17);
            this.radioButtonQ1A3.TabIndex = 2;
            this.radioButtonQ1A3.Text = "Giant Cat";
            this.radioButtonQ1A3.UseVisualStyleBackColor = true;
            this.radioButtonQ1A3.CheckedChanged += new System.EventHandler(this.radioButtonQ1A3_CheckedChanged);
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.CausesValidation = false;
            this.labelQ1.Location = new System.Drawing.Point(24, 20);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(113, 13);
            this.labelQ1.TabIndex = 3;
            this.labelQ1.Text = "Which Animal is this..?";
            // 
            // groupBox2
            // 
            this.groupBox2.CausesValidation = false;
            this.groupBox2.Controls.Add(this.labelQ2);
            this.groupBox2.Controls.Add(this.radioButtonQ2A3);
            this.groupBox2.Controls.Add(this.radioButtonQ2A2);
            this.groupBox2.Controls.Add(this.radioButtonQ2A1);
            this.groupBox2.Location = new System.Drawing.Point(217, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 165);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // labelQ2
            // 
            this.labelQ2.AutoSize = true;
            this.labelQ2.CausesValidation = false;
            this.labelQ2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelQ2.Location = new System.Drawing.Point(24, 20);
            this.labelQ2.Name = "labelQ2";
            this.labelQ2.Size = new System.Drawing.Size(113, 13);
            this.labelQ2.TabIndex = 3;
            this.labelQ2.Text = "Which Animal is this..?";
            this.labelQ2.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonQ2A3
            // 
            this.radioButtonQ2A3.AutoSize = true;
            this.radioButtonQ2A3.CausesValidation = false;
            this.radioButtonQ2A3.Location = new System.Drawing.Point(24, 129);
            this.radioButtonQ2A3.Name = "radioButtonQ2A3";
            this.radioButtonQ2A3.Size = new System.Drawing.Size(42, 17);
            this.radioButtonQ2A3.TabIndex = 2;
            this.radioButtonQ2A3.Text = "Fox";
            this.radioButtonQ2A3.UseVisualStyleBackColor = true;
            this.radioButtonQ2A3.CheckedChanged += new System.EventHandler(this.radioButtonQ2A3_CheckedChanged);
            // 
            // radioButtonQ2A2
            // 
            this.radioButtonQ2A2.AutoSize = true;
            this.radioButtonQ2A2.CausesValidation = false;
            this.radioButtonQ2A2.Location = new System.Drawing.Point(24, 90);
            this.radioButtonQ2A2.Name = "radioButtonQ2A2";
            this.radioButtonQ2A2.Size = new System.Drawing.Size(45, 17);
            this.radioButtonQ2A2.TabIndex = 1;
            this.radioButtonQ2A2.Text = "Dog";
            this.radioButtonQ2A2.UseVisualStyleBackColor = true;
            this.radioButtonQ2A2.CheckedChanged += new System.EventHandler(this.radioButtonQ2A2_CheckedChanged);
            // 
            // radioButtonQ2A1
            // 
            this.radioButtonQ2A1.AutoSize = true;
            this.radioButtonQ2A1.CausesValidation = false;
            this.radioButtonQ2A1.Location = new System.Drawing.Point(24, 46);
            this.radioButtonQ2A1.Name = "radioButtonQ2A1";
            this.radioButtonQ2A1.Size = new System.Drawing.Size(47, 17);
            this.radioButtonQ2A1.TabIndex = 0;
            this.radioButtonQ2A1.Text = "Wolf";
            this.radioButtonQ2A1.UseVisualStyleBackColor = true;
            this.radioButtonQ2A1.CheckedChanged += new System.EventHandler(this.radioButtonQ2A1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.CausesValidation = false;
            this.groupBox3.Controls.Add(this.labelQ3);
            this.groupBox3.Controls.Add(this.radioButtonQ3A3);
            this.groupBox3.Controls.Add(this.radioButtonQ3A2);
            this.groupBox3.Controls.Add(this.radioButtonQ3A1);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Location = new System.Drawing.Point(217, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 142);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.CausesValidation = false;
            this.labelQ3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelQ3.Location = new System.Drawing.Point(24, 20);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(113, 13);
            this.labelQ3.TabIndex = 3;
            this.labelQ3.Text = "Which Animal is this..?";
            // 
            // radioButtonQ3A3
            // 
            this.radioButtonQ3A3.AutoSize = true;
            this.radioButtonQ3A3.CausesValidation = false;
            this.radioButtonQ3A3.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonQ3A3.Location = new System.Drawing.Point(24, 119);
            this.radioButtonQ3A3.Name = "radioButtonQ3A3";
            this.radioButtonQ3A3.Size = new System.Drawing.Size(64, 17);
            this.radioButtonQ3A3.TabIndex = 2;
            this.radioButtonQ3A3.TabStop = true;
            this.radioButtonQ3A3.Text = "Hamster";
            this.radioButtonQ3A3.UseVisualStyleBackColor = true;
            this.radioButtonQ3A3.CheckedChanged += new System.EventHandler(this.radioButtonQ3A3_CheckedChanged);
            // 
            // radioButtonQ3A2
            // 
            this.radioButtonQ3A2.AutoSize = true;
            this.radioButtonQ3A2.CausesValidation = false;
            this.radioButtonQ3A2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonQ3A2.Location = new System.Drawing.Point(24, 83);
            this.radioButtonQ3A2.Name = "radioButtonQ3A2";
            this.radioButtonQ3A2.Size = new System.Drawing.Size(42, 17);
            this.radioButtonQ3A2.TabIndex = 1;
            this.radioButtonQ3A2.TabStop = true;
            this.radioButtonQ3A2.Text = "Rat";
            this.radioButtonQ3A2.UseVisualStyleBackColor = true;
            this.radioButtonQ3A2.CheckedChanged += new System.EventHandler(this.radioButtonQ3A2_CheckedChanged);
            // 
            // radioButtonQ3A1
            // 
            this.radioButtonQ3A1.AutoCheck = false;
            this.radioButtonQ3A1.AutoSize = true;
            this.radioButtonQ3A1.CausesValidation = false;
            this.radioButtonQ3A1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButtonQ3A1.Location = new System.Drawing.Point(24, 46);
            this.radioButtonQ3A1.Name = "radioButtonQ3A1";
            this.radioButtonQ3A1.Size = new System.Drawing.Size(57, 17);
            this.radioButtonQ3A1.TabIndex = 0;
            this.radioButtonQ3A1.TabStop = true;
            this.radioButtonQ3A1.Text = "Mouse";
            this.radioButtonQ3A1.UseVisualStyleBackColor = true;
            this.radioButtonQ3A1.CheckedChanged += new System.EventHandler(this.radioButtonQ3A1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quiz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Remaining";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(217, 572);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 35);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(369, 572);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(125, 35);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA1.Location = new System.Drawing.Point(621, 115);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(0, 25);
            this.labelA1.TabIndex = 11;
            // 
            // labelA2
            // 
            this.labelA2.AutoSize = true;
            this.labelA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA2.Location = new System.Drawing.Point(621, 303);
            this.labelA2.Name = "labelA2";
            this.labelA2.Size = new System.Drawing.Size(0, 25);
            this.labelA2.TabIndex = 12;
            // 
            // labelA3
            // 
            this.labelA3.AutoSize = true;
            this.labelA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA3.Location = new System.Drawing.Point(621, 477);
            this.labelA3.Name = "labelA3";
            this.labelA3.Size = new System.Drawing.Size(0, 25);
            this.labelA3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(701, 625);
            this.Controls.Add(this.labelA3);
            this.Controls.Add(this.labelA2);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.RadioButton radioButtonQ1A3;
        private System.Windows.Forms.RadioButton radioButtonQ1A2;
        private System.Windows.Forms.RadioButton radioButtonQ1A1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelQ2;
        private System.Windows.Forms.RadioButton radioButtonQ2A3;
        private System.Windows.Forms.RadioButton radioButtonQ2A2;
        private System.Windows.Forms.RadioButton radioButtonQ2A1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelQ3;
        private System.Windows.Forms.RadioButton radioButtonQ3A3;
        private System.Windows.Forms.RadioButton radioButtonQ3A2;
        private System.Windows.Forms.RadioButton radioButtonQ3A1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelA2;
        private System.Windows.Forms.Label labelA3;
    }
}

