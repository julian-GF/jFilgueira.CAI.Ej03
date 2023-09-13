namespace jFilgueira.CAI.Ej03
{
    partial class Ejercicio3
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeptoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PisoTxt = new System.Windows.Forms.TextBox();
            this.NumeroTxt = new System.Windows.Forms.TextBox();
            this.CalleTxt = new System.Windows.Forms.TextBox();
            this.PaiseCmb = new System.Windows.Forms.ComboBox();
            this.provinciaCMB = new System.Windows.Forms.ComboBox();
            this.LocalidadCMB = new System.Windows.Forms.ComboBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "País ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeptoTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PisoTxt);
            this.groupBox1.Controls.Add(this.NumeroTxt);
            this.groupBox1.Controls.Add(this.CalleTxt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(50, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DeptoTxt
            // 
            this.DeptoTxt.Location = new System.Drawing.Point(96, 159);
            this.DeptoTxt.Name = "DeptoTxt";
            this.DeptoTxt.Size = new System.Drawing.Size(100, 27);
            this.DeptoTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Depto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Piso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calle";
            // 
            // PisoTxt
            // 
            this.PisoTxt.Location = new System.Drawing.Point(96, 115);
            this.PisoTxt.Name = "PisoTxt";
            this.PisoTxt.Size = new System.Drawing.Size(100, 27);
            this.PisoTxt.TabIndex = 6;
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.Location = new System.Drawing.Point(96, 66);
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Size = new System.Drawing.Size(100, 27);
            this.NumeroTxt.TabIndex = 5;
            // 
            // CalleTxt
            // 
            this.CalleTxt.Location = new System.Drawing.Point(93, 22);
            this.CalleTxt.Name = "CalleTxt";
            this.CalleTxt.Size = new System.Drawing.Size(327, 27);
            this.CalleTxt.TabIndex = 4;
            // 
            // PaiseCmb
            // 
            this.PaiseCmb.FormattingEnabled = true;
            this.PaiseCmb.Location = new System.Drawing.Point(46, 47);
            this.PaiseCmb.Name = "PaiseCmb";
            this.PaiseCmb.Size = new System.Drawing.Size(121, 23);
            this.PaiseCmb.TabIndex = 4;
            // 
            // provinciaCMB
            // 
            this.provinciaCMB.FormattingEnabled = true;
            this.provinciaCMB.Location = new System.Drawing.Point(50, 122);
            this.provinciaCMB.Name = "provinciaCMB";
            this.provinciaCMB.Size = new System.Drawing.Size(121, 23);
            this.provinciaCMB.TabIndex = 5;
            this.provinciaCMB.SelectedIndexChanged += new System.EventHandler(this.provinciaCMB_SelectedIndexChanged);
            // 
            // LocalidadCMB
            // 
            this.LocalidadCMB.FormattingEnabled = true;
            this.LocalidadCMB.Location = new System.Drawing.Point(50, 210);
            this.LocalidadCMB.Name = "LocalidadCMB";
            this.LocalidadCMB.Size = new System.Drawing.Size(121, 23);
            this.LocalidadCMB.TabIndex = 6;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(77, 508);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(111, 48);
            this.AceptarBtn.TabIndex = 7;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(291, 508);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(120, 48);
            this.Cancelar_btn.TabIndex = 8;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 581);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.LocalidadCMB);
            this.Controls.Add(this.provinciaCMB);
            this.Controls.Add(this.PaiseCmb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "EJERCICIO 3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox DeptoTxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox PisoTxt;
        private TextBox NumeroTxt;
        private TextBox CalleTxt;
        private ComboBox PaiseCmb;
        private ComboBox provinciaCMB;
        private ComboBox LocalidadCMB;
        private Button AceptarBtn;
        private Button Cancelar_btn;
    }
}