namespace Examen_1
{
    partial class Opciones
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
            this.chMXM = new System.Windows.Forms.CheckBox();
            this.chCAD = new System.Windows.Forms.CheckBox();
            this.chEUR = new System.Windows.Forms.CheckBox();
            this.chJPY = new System.Windows.Forms.CheckBox();
            this.chUSD = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chMXM
            // 
            this.chMXM.AutoSize = true;
            this.chMXM.Location = new System.Drawing.Point(12, 12);
            this.chMXM.Name = "chMXM";
            this.chMXM.Size = new System.Drawing.Size(178, 24);
            this.chMXM.TabIndex = 0;
            this.chMXM.Text = "MXM - Peso Mexicano";
            this.chMXM.UseVisualStyleBackColor = true;
            // 
            // chCAD
            // 
            this.chCAD.AutoSize = true;
            this.chCAD.Location = new System.Drawing.Point(12, 42);
            this.chCAD.Name = "chCAD";
            this.chCAD.Size = new System.Drawing.Size(192, 24);
            this.chCAD.TabIndex = 0;
            this.chCAD.Text = "CAD - Dolar Canadiense";
            this.chCAD.UseVisualStyleBackColor = true;
            // 
            // chEUR
            // 
            this.chEUR.AutoSize = true;
            this.chEUR.Location = new System.Drawing.Point(12, 72);
            this.chEUR.Name = "chEUR";
            this.chEUR.Size = new System.Drawing.Size(102, 24);
            this.chEUR.TabIndex = 0;
            this.chEUR.Text = "EUR - Euro";
            this.chEUR.UseVisualStyleBackColor = true;
            // 
            // chJPY
            // 
            this.chJPY.AutoSize = true;
            this.chJPY.Location = new System.Drawing.Point(12, 102);
            this.chJPY.Name = "chJPY";
            this.chJPY.Size = new System.Drawing.Size(146, 24);
            this.chJPY.TabIndex = 0;
            this.chJPY.Text = "JPY - Yen Japonés";
            this.chJPY.UseVisualStyleBackColor = true;
            // 
            // chUSD
            // 
            this.chUSD.AutoSize = true;
            this.chUSD.Location = new System.Drawing.Point(12, 132);
            this.chUSD.Name = "chUSD";
            this.chUSD.Size = new System.Drawing.Size(219, 24);
            this.chUSD.TabIndex = 0;
            this.chUSD.Text = "USD - Dolar Estadounidense";
            this.chUSD.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(8, 162);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(94, 29);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(10, 202);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(94, 29);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 237);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.chEUR);
            this.Controls.Add(this.chCAD);
            this.Controls.Add(this.chUSD);
            this.Controls.Add(this.chJPY);
            this.Controls.Add(this.chMXM);
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chMXM;
        private CheckBox chCAD;
        private CheckBox chEUR;
        private CheckBox chJPY;
        private CheckBox chUSD;
        private Button btAceptar;
        private Button btCancelar;
    }
}