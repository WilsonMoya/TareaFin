namespace tareaFin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Promediobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Nota1textBox = new System.Windows.Forms.TextBox();
            this.Nota2textBox = new System.Windows.Forms.TextBox();
            this.Nota3textBox = new System.Windows.Forms.TextBox();
            this.Nota4textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Promediobutton
            // 
            this.Promediobutton.Location = new System.Drawing.Point(144, 239);
            this.Promediobutton.Name = "Promediobutton";
            this.Promediobutton.Size = new System.Drawing.Size(141, 46);
            this.Promediobutton.TabIndex = 0;
            this.Promediobutton.Text = "Calcular  Promedio";
            this.Promediobutton.UseVisualStyleBackColor = true;
            this.Promediobutton.Click += new System.EventHandler(this.Promediobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la Nota 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el Nombre del Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese la Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese la Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese la Nota 4";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(200, 57);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(186, 23);
            this.NombretextBox.TabIndex = 6;
            // 
            // Nota1textBox
            // 
            this.Nota1textBox.Location = new System.Drawing.Point(200, 104);
            this.Nota1textBox.Name = "Nota1textBox";
            this.Nota1textBox.Size = new System.Drawing.Size(107, 23);
            this.Nota1textBox.TabIndex = 7;
            // 
            // Nota2textBox
            // 
            this.Nota2textBox.Location = new System.Drawing.Point(200, 133);
            this.Nota2textBox.Name = "Nota2textBox";
            this.Nota2textBox.Size = new System.Drawing.Size(107, 23);
            this.Nota2textBox.TabIndex = 8;
            // 
            // Nota3textBox
            // 
            this.Nota3textBox.Location = new System.Drawing.Point(200, 162);
            this.Nota3textBox.Name = "Nota3textBox";
            this.Nota3textBox.Size = new System.Drawing.Size(107, 23);
            this.Nota3textBox.TabIndex = 9;
            this.Nota3textBox.TextChanged += new System.EventHandler(this.Nota3textBox_TextChanged);
            // 
            // Nota4textBox
            // 
            this.Nota4textBox.Location = new System.Drawing.Point(200, 191);
            this.Nota4textBox.Name = "Nota4textBox";
            this.Nota4textBox.Size = new System.Drawing.Size(107, 23);
            this.Nota4textBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 339);
            this.Controls.Add(this.Nota4textBox);
            this.Controls.Add(this.Nota3textBox);
            this.Controls.Add(this.Nota2textBox);
            this.Controls.Add(this.Nota1textBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Promediobutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Promediobutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NombretextBox;
        private TextBox Nota1textBox;
        private TextBox Nota2textBox;
        private TextBox Nota3textBox;
        private TextBox Nota4textBox;
    }
}