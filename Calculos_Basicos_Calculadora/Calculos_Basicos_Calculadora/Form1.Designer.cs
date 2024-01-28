
namespace Calculos_Basicos_Calculadora
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNum1 = new System.Windows.Forms.TextBox();
            txtNum2 = new System.Windows.Forms.TextBox();
            txtResultado = new System.Windows.Forms.TextBox();
            btnSomar = new System.Windows.Forms.Button();
            btnSubtrair = new System.Windows.Forms.Button();
            btnMultiplicar = new System.Windows.Forms.Button();
            btnDividir = new System.Windows.Forms.Button();
            bntLimpar = new System.Windows.Forms.Button();
            btnSair = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(132, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "CÁLCULOS BÁSICOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(35, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(192, 20);
            label2.TabIndex = 1;
            label2.Text = "DIGITE O 1º NÚMERO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(35, 144);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(192, 20);
            label3.TabIndex = 2;
            label3.Text = "DIGITE O 2º NÚMERO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(94, 297);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 20);
            label4.TabIndex = 3;
            label4.Text = "RESULTADO";
            // 
            // txtNum1
            // 
            txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtNum1.ForeColor = System.Drawing.Color.Red;
            txtNum1.Location = new System.Drawing.Point(261, 87);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new System.Drawing.Size(156, 26);
            txtNum1.TabIndex = 4;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtNum2.ForeColor = System.Drawing.Color.Red;
            txtNum2.Location = new System.Drawing.Point(261, 141);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new System.Drawing.Size(156, 26);
            txtNum2.TabIndex = 5;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // txtResultado
            // 
            txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtResultado.ForeColor = System.Drawing.Color.Red;
            txtResultado.Location = new System.Drawing.Point(217, 294);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new System.Drawing.Size(156, 26);
            txtResultado.TabIndex = 6;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnSomar
            // 
            btnSomar.BackColor = System.Drawing.Color.LightSteelBlue;
            btnSomar.FlatAppearance.BorderSize = 0;
            btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSomar.Location = new System.Drawing.Point(94, 203);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new System.Drawing.Size(69, 52);
            btnSomar.TabIndex = 7;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.BackColor = System.Drawing.Color.LightSteelBlue;
            btnSubtrair.FlatAppearance.BorderSize = 0;
            btnSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubtrair.Location = new System.Drawing.Point(184, 203);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new System.Drawing.Size(70, 54);
            btnSubtrair.TabIndex = 8;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = false;
            btnSubtrair.Click += button2_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = System.Drawing.Color.LightSteelBlue;
            btnMultiplicar.FlatAppearance.BorderSize = 0;
            btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMultiplicar.Location = new System.Drawing.Point(274, 203);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new System.Drawing.Size(77, 54);
            btnMultiplicar.TabIndex = 9;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += button3_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = System.Drawing.Color.LightSteelBlue;
            btnDividir.FlatAppearance.BorderSize = 0;
            btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDividir.Location = new System.Drawing.Point(374, 203);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new System.Drawing.Size(75, 54);
            btnDividir.TabIndex = 10;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // bntLimpar
            // 
            bntLimpar.BackColor = System.Drawing.Color.LightSteelBlue;
            bntLimpar.FlatAppearance.BorderSize = 0;
            bntLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            bntLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            bntLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntLimpar.Location = new System.Drawing.Point(83, 350);
            bntLimpar.Name = "bntLimpar";
            bntLimpar.Size = new System.Drawing.Size(107, 52);
            bntLimpar.TabIndex = 11;
            bntLimpar.Text = "Limpar";
            bntLimpar.UseVisualStyleBackColor = false;
            bntLimpar.Click += bntLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = System.Drawing.Color.LightSteelBlue;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.Location = new System.Drawing.Point(326, 350);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(110, 52);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(517, 442);
            Controls.Add(btnSair);
            Controls.Add(bntLimpar);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txtResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora Básica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

