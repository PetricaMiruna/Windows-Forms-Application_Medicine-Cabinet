namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.tbIDmed = new System.Windows.Forms.TextBox();
            this.tbNumeMed = new System.Windows.Forms.TextBox();
            this.tbPrenMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVechime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSpecializare = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIDmed
            // 
            this.tbIDmed.Location = new System.Drawing.Point(66, 23);
            this.tbIDmed.Name = "tbIDmed";
            this.tbIDmed.Size = new System.Drawing.Size(100, 20);
            this.tbIDmed.TabIndex = 0;
            // 
            // tbNumeMed
            // 
            this.tbNumeMed.Location = new System.Drawing.Point(88, 64);
            this.tbNumeMed.Name = "tbNumeMed";
            this.tbNumeMed.Size = new System.Drawing.Size(100, 20);
            this.tbNumeMed.TabIndex = 1;
            // 
            // tbPrenMed
            // 
            this.tbPrenMed.Location = new System.Drawing.Point(100, 99);
            this.tbPrenMed.Name = "tbPrenMed";
            this.tbPrenMed.Size = new System.Drawing.Size(100, 20);
            this.tbPrenMed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Medic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume Medic ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenume medic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Specializare";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbVechime
            // 
            this.tbVechime.Location = new System.Drawing.Point(82, 187);
            this.tbVechime.Name = "tbVechime";
            this.tbVechime.Size = new System.Drawing.Size(100, 20);
            this.tbVechime.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vechime";
            // 
            // cbSpecializare
            // 
            this.cbSpecializare.FormattingEnabled = true;
            this.cbSpecializare.Items.AddRange(new object[] {
            "Cardiolog",
            "Chirurg",
            "Medic de familie",
            "Neurolog",
            "Oftalmolog",
            "Ortoped",
            "Pediatru",
            "Radiolog"});
            this.cbSpecializare.Location = new System.Drawing.Point(79, 142);
            this.cbSpecializare.Name = "cbSpecializare";
            this.cbSpecializare.Size = new System.Drawing.Size(121, 21);
            this.cbSpecializare.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(374, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eliberare Reteta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(607, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "Adaugare medic";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSpecializare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVechime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrenMed);
            this.Controls.Add(this.tbNumeMed);
            this.Controls.Add(this.tbIDmed);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIDmed;
        private System.Windows.Forms.TextBox tbNumeMed;
        private System.Windows.Forms.TextBox tbPrenMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVechime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSpecializare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}