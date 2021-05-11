
namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dragPanel1 = new WinFormsApp3.dragPanel();
            this.Disjunction = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Conjunction = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addition_Modulo_Two = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Equivalence = new System.Windows.Forms.PictureBox();
            this.Implication = new System.Windows.Forms.PictureBox();
            this.Co_implication = new System.Windows.Forms.PictureBox();
            this.Webb_Element = new System.Windows.Forms.PictureBox();
            this.Schaeffer_Element = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disjunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conjunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addition_Modulo_Two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Equivalence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Implication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Co_implication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Webb_Element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schaeffer_Element)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Schaeffer_Element);
            this.panel1.Controls.Add(this.Webb_Element);
            this.panel1.Controls.Add(this.Co_implication);
            this.panel1.Controls.Add(this.Implication);
            this.panel1.Controls.Add(this.Equivalence);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Addition_Modulo_Two);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Conjunction);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Disjunction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dragPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(263, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 450);
            this.panel2.TabIndex = 1;
            // 
            // dragPanel1
            // 
            this.dragPanel1.BackColor = System.Drawing.Color.Black;
            this.dragPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragPanel1.Location = new System.Drawing.Point(0, 0);
            this.dragPanel1.Name = "dragPanel1";
            this.dragPanel1.Size = new System.Drawing.Size(537, 450);
            this.dragPanel1.TabIndex = 0;
            // 
            // Disjunction
            // 
            this.Disjunction.Image = ((System.Drawing.Image)(resources.GetObject("Disjunction.Image")));
            this.Disjunction.Location = new System.Drawing.Point(168, 33);
            this.Disjunction.Name = "Disjunction";
            this.Disjunction.Size = new System.Drawing.Size(88, 68);
            this.Disjunction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Disjunction.TabIndex = 0;
            this.Disjunction.TabStop = false;
            this.Disjunction.Click += new System.EventHandler(this.Disjunction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дизъюнкция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конъюнкция";
            // 
            // Conjunction
            // 
            this.Conjunction.Image = ((System.Drawing.Image)(resources.GetObject("Conjunction.Image")));
            this.Conjunction.Location = new System.Drawing.Point(12, 117);
            this.Conjunction.Name = "Conjunction";
            this.Conjunction.Size = new System.Drawing.Size(88, 64);
            this.Conjunction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Conjunction.TabIndex = 3;
            this.Conjunction.TabStop = false;
            this.Conjunction.Click += new System.EventHandler(this.Conjunction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сложение по модулю 2";
            // 
            // Addition_Modulo_Two
            // 
            this.Addition_Modulo_Two.Image = ((System.Drawing.Image)(resources.GetObject("Addition_Modulo_Two.Image")));
            this.Addition_Modulo_Two.Location = new System.Drawing.Point(12, 33);
            this.Addition_Modulo_Two.Name = "Addition_Modulo_Two";
            this.Addition_Modulo_Two.Size = new System.Drawing.Size(88, 63);
            this.Addition_Modulo_Two.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Addition_Modulo_Two.TabIndex = 5;
            this.Addition_Modulo_Two.TabStop = false;
            this.Addition_Modulo_Two.Click += new System.EventHandler(this.Addition_Modulo_Two_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Эквивалентность";
            // 
            // Equivalence
            // 
            this.Equivalence.Image = ((System.Drawing.Image)(resources.GetObject("Equivalence.Image")));
            this.Equivalence.Location = new System.Drawing.Point(12, 288);
            this.Equivalence.Name = "Equivalence";
            this.Equivalence.Size = new System.Drawing.Size(88, 56);
            this.Equivalence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Equivalence.TabIndex = 7;
            this.Equivalence.TabStop = false;
            this.Equivalence.Click += new System.EventHandler(this.Equivalence_Click);
            // 
            // Implication
            // 
            this.Implication.Image = ((System.Drawing.Image)(resources.GetObject("Implication.Image")));
            this.Implication.Location = new System.Drawing.Point(11, 198);
            this.Implication.Name = "Implication";
            this.Implication.Size = new System.Drawing.Size(89, 68);
            this.Implication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Implication.TabIndex = 8;
            this.Implication.TabStop = false;
            this.Implication.Click += new System.EventHandler(this.Implication_Click);
            // 
            // Co_implication
            // 
            this.Co_implication.Image = ((System.Drawing.Image)(resources.GetObject("Co_implication.Image")));
            this.Co_implication.Location = new System.Drawing.Point(167, 121);
            this.Co_implication.Name = "Co_implication";
            this.Co_implication.Size = new System.Drawing.Size(89, 60);
            this.Co_implication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Co_implication.TabIndex = 9;
            this.Co_implication.TabStop = false;
            this.Co_implication.Click += new System.EventHandler(this.Co_implication_Click);
            // 
            // Webb_Element
            // 
            this.Webb_Element.Image = ((System.Drawing.Image)(resources.GetObject("Webb_Element.Image")));
            this.Webb_Element.Location = new System.Drawing.Point(167, 204);
            this.Webb_Element.Name = "Webb_Element";
            this.Webb_Element.Size = new System.Drawing.Size(89, 63);
            this.Webb_Element.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Webb_Element.TabIndex = 10;
            this.Webb_Element.TabStop = false;
            this.Webb_Element.Click += new System.EventHandler(this.Webb_Element_Click);
            // 
            // Schaeffer_Element
            // 
            this.Schaeffer_Element.Image = ((System.Drawing.Image)(resources.GetObject("Schaeffer_Element.Image")));
            this.Schaeffer_Element.Location = new System.Drawing.Point(168, 288);
            this.Schaeffer_Element.Name = "Schaeffer_Element";
            this.Schaeffer_Element.Size = new System.Drawing.Size(89, 56);
            this.Schaeffer_Element.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Schaeffer_Element.TabIndex = 11;
            this.Schaeffer_Element.TabStop = false;
            this.Schaeffer_Element.Click += new System.EventHandler(this.Schaeffer_Element_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Импликация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(152, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Коимпликация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(152, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Элемент Вебба";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(132, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Элемент Шеффера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Disjunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conjunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addition_Modulo_Two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Equivalence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Implication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Co_implication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Webb_Element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schaeffer_Element)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private dragPanel dragPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Schaeffer_Element;
        private System.Windows.Forms.PictureBox Webb_Element;
        private System.Windows.Forms.PictureBox Co_implication;
        private System.Windows.Forms.PictureBox Implication;
        private System.Windows.Forms.PictureBox Equivalence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Addition_Modulo_Two;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Conjunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Disjunction;
    }
}

