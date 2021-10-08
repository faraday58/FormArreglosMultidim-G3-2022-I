
namespace FormArreglosMultidim_G3_2022_I
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbMatriz = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMatriz1 = new System.Windows.Forms.Label();
            this.lbMatriz2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.rdbRad = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtbMatriz
            // 
            this.txtbMatriz.Location = new System.Drawing.Point(87, 41);
            this.txtbMatriz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbMatriz.Name = "txtbMatriz";
            this.txtbMatriz.Size = new System.Drawing.Size(297, 20);
            this.txtbMatriz.TabIndex = 0;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(87, 171);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(74, 32);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(184, 171);
            this.btnResta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(74, 32);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(283, 171);
            this.btnMult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(74, 32);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // btnSen
            // 
            this.btnSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSen.Location = new System.Drawing.Point(87, 225);
            this.btnSen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(74, 32);
            this.btnSen.TabIndex = 1;
            this.btnSen.Text = "Sen";
            this.btnSen.UseVisualStyleBackColor = true;
            this.btnSen.Click += new System.EventHandler(this.btnSen_Click);
            // 
            // btnIntro
            // 
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(185, 209);
            this.btnIntro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(199, 59);
            this.btnIntro.TabIndex = 1;
            this.btnIntro.Text = "Intro";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lbMatriz1
            // 
            this.lbMatriz1.AutoSize = true;
            this.lbMatriz1.Location = new System.Drawing.Point(85, 104);
            this.lbMatriz1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMatriz1.Name = "lbMatriz1";
            this.lbMatriz1.Size = new System.Drawing.Size(35, 13);
            this.lbMatriz1.TabIndex = 2;
            this.lbMatriz1.Text = "label1";
            // 
            // lbMatriz2
            // 
            this.lbMatriz2.AutoSize = true;
            this.lbMatriz2.Location = new System.Drawing.Point(182, 104);
            this.lbMatriz2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMatriz2.Name = "lbMatriz2";
            this.lbMatriz2.Size = new System.Drawing.Size(35, 13);
            this.lbMatriz2.TabIndex = 2;
            this.lbMatriz2.Text = "label1";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(348, 104);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(35, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "label1";
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Checked = true;
            this.rdbDeg.Location = new System.Drawing.Point(93, 14);
            this.rdbDeg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(45, 17);
            this.rdbDeg.TabIndex = 3;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "Deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // rdbRad
            // 
            this.rdbRad.AutoSize = true;
            this.rdbRad.Location = new System.Drawing.Point(184, 14);
            this.rdbRad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRad.Name = "rdbRad";
            this.rdbRad.Size = new System.Drawing.Size(70, 17);
            this.rdbRad.TabIndex = 3;
            this.rdbRad.Text = "Radianes";
            this.rdbRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 340);
            this.Controls.Add(this.rdbRad);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMatriz2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMatriz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSen);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtbMatriz);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbMatriz;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMatriz1;
        private System.Windows.Forms.Label lbMatriz2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.RadioButton rdbRad;
    }
}

