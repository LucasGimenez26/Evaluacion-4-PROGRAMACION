namespace EvaluaciónProy
{
    partial class ResolveIt
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
            this.btSumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRestar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSumar
            // 
            this.btSumar.Location = new System.Drawing.Point(340, 195);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(118, 23);
            this.btSumar.TabIndex = 0;
            this.btSumar.Text = "Sumar";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a ResolveIt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuál operación deseas realizar?";
            // 
            // btRestar
            // 
            this.btRestar.Location = new System.Drawing.Point(340, 224);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(118, 23);
            this.btRestar.TabIndex = 3;
            this.btRestar.Text = "Restar";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.btRestar_Click);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(340, 253);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(118, 23);
            this.btDividir.TabIndex = 4;
            this.btDividir.Text = "Dividir";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(340, 282);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(118, 23);
            this.btMultiplicar.TabIndex = 5;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // ResolveIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSumar);
            this.Name = "ResolveIt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btMultiplicar;
    }
}

