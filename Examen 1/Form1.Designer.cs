namespace Examen_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbConversiones = new System.Windows.Forms.GroupBox();
            this.txtJPY = new System.Windows.Forms.TextBox();
            this.txtEUR = new System.Windows.Forms.TextBox();
            this.txtCAD = new System.Windows.Forms.TextBox();
            this.txtMXM = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.labelJAP = new System.Windows.Forms.Label();
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelCAD = new System.Windows.Forms.Label();
            this.labelMXM = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.gbConversiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(191, 32);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(113, 27);
            this.txtMonto.TabIndex = 3;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(201, 65);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(94, 29);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "USD - Dólar Estadounidense",
            "MXM - Peso Mexicano",
            "CAD - Dólar Canadiense ",
            "EUR - Euro",
            "JPY - Yen Japonés"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // gbConversiones
            // 
            this.gbConversiones.Controls.Add(this.txtJPY);
            this.gbConversiones.Controls.Add(this.txtEUR);
            this.gbConversiones.Controls.Add(this.txtCAD);
            this.gbConversiones.Controls.Add(this.txtMXM);
            this.gbConversiones.Controls.Add(this.txtUSD);
            this.gbConversiones.Controls.Add(this.labelJAP);
            this.gbConversiones.Controls.Add(this.labelEUR);
            this.gbConversiones.Controls.Add(this.labelCAD);
            this.gbConversiones.Controls.Add(this.labelMXM);
            this.gbConversiones.Controls.Add(this.labelUSD);
            this.gbConversiones.Location = new System.Drawing.Point(12, 116);
            this.gbConversiones.Name = "gbConversiones";
            this.gbConversiones.Size = new System.Drawing.Size(317, 309);
            this.gbConversiones.TabIndex = 8;
            this.gbConversiones.TabStop = false;
            this.gbConversiones.Text = "Conversiones";
            // 
            // txtJPY
            // 
            this.txtJPY.Location = new System.Drawing.Point(179, 189);
            this.txtJPY.Name = "txtJPY";
            this.txtJPY.Size = new System.Drawing.Size(125, 27);
            this.txtJPY.TabIndex = 1;
            // 
            // txtEUR
            // 
            this.txtEUR.Location = new System.Drawing.Point(179, 147);
            this.txtEUR.Name = "txtEUR";
            this.txtEUR.Size = new System.Drawing.Size(125, 27);
            this.txtEUR.TabIndex = 1;
            // 
            // txtCAD
            // 
            this.txtCAD.Location = new System.Drawing.Point(179, 104);
            this.txtCAD.Name = "txtCAD";
            this.txtCAD.Size = new System.Drawing.Size(125, 27);
            this.txtCAD.TabIndex = 1;
            // 
            // txtMXM
            // 
            this.txtMXM.Location = new System.Drawing.Point(179, 71);
            this.txtMXM.Name = "txtMXM";
            this.txtMXM.Size = new System.Drawing.Size(125, 27);
            this.txtMXM.TabIndex = 1;
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(179, 32);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(125, 27);
            this.txtUSD.TabIndex = 1;
            // 
            // labelJAP
            // 
            this.labelJAP.AutoSize = true;
            this.labelJAP.Location = new System.Drawing.Point(6, 196);
            this.labelJAP.Name = "labelJAP";
            this.labelJAP.Size = new System.Drawing.Size(124, 20);
            this.labelJAP.TabIndex = 0;
            this.labelJAP.Text = "JPY - Yen Japonés";
            // 
            // labelEUR
            // 
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(6, 154);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(80, 20);
            this.labelEUR.TabIndex = 0;
            this.labelEUR.Text = "EUR - Euro";
            // 
            // labelCAD
            // 
            this.labelCAD.AutoSize = true;
            this.labelCAD.Location = new System.Drawing.Point(6, 111);
            this.labelCAD.Name = "labelCAD";
            this.labelCAD.Size = new System.Drawing.Size(170, 20);
            this.labelCAD.TabIndex = 0;
            this.labelCAD.Text = "CAD - Dólar Canadiense";
            // 
            // labelMXM
            // 
            this.labelMXM.AutoSize = true;
            this.labelMXM.Location = new System.Drawing.Point(6, 71);
            this.labelMXM.Name = "labelMXM";
            this.labelMXM.Size = new System.Drawing.Size(156, 20);
            this.labelMXM.TabIndex = 0;
            this.labelMXM.Text = "MXM - Peso Méxicano";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(6, 32);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(165, 20);
            this.labelUSD.TabIndex = 0;
            this.labelUSD.Text = "USD - Dólar Americano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.gbConversiones);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Convertidor de moneda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConversiones.ResumeLayout(false);
            this.gbConversiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMonto;
        private Button btCalcular;
        private ComboBox comboBox1;
        private GroupBox gbConversiones;
        private TextBox txtJPY;
        private TextBox txtEUR;
        private TextBox txtCAD;
        private TextBox txtMXM;
        private TextBox txtUSD;
        private Label labelJAP;
        private Label labelEUR;
        private Label labelCAD;
        private Label labelMXM;
        private Label labelUSD;
    }
}