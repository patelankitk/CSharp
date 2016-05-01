namespace AppointmentForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelAD = new System.Windows.Forms.Label();
            this.dateTimePickerAD = new System.Windows.Forms.DateTimePicker();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.textBoxDoctor = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(90, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(123, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Please Enter Your Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(311, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(90, 108);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(116, 13);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Please Enter your DOB";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(311, 101);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDOB.TabIndex = 3;
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.Location = new System.Drawing.Point(90, 137);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(147, 13);
            this.labelAD.TabIndex = 4;
            this.labelAD.Text = "Requested Appointment Date";
            this.labelAD.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerAD
            // 
            this.dateTimePickerAD.Location = new System.Drawing.Point(311, 129);
            this.dateTimePickerAD.Name = "dateTimePickerAD";
            this.dateTimePickerAD.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerAD.TabIndex = 5;
            this.dateTimePickerAD.ValueChanged += new System.EventHandler(this.dateTimePickerAD_ValueChanged);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(239, 219);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(117, 23);
            this.ButtonSubmit.TabIndex = 6;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(90, 168);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(125, 13);
            this.labelDoctor.TabIndex = 7;
            this.labelDoctor.Text = "Requested Doctor Name";
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Location = new System.Drawing.Point(311, 160);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.Size = new System.Drawing.Size(194, 20);
            this.textBoxDoctor.TabIndex = 8;
            this.textBoxDoctor.TextChanged += new System.EventHandler(this.textBoxDoctor_TextChanged);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(90, 281);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(155, 13);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "Your Message will appear here.";
            this.labelMessage.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 348);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxDoctor);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.dateTimePickerAD);
            this.Controls.Add(this.labelAD);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.DateTimePicker dateTimePickerAD;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.TextBox textBoxDoctor;
        private System.Windows.Forms.Label labelMessage;
    }
}

