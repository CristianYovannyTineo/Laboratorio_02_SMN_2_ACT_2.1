namespace Laboratorio_02_SMN_2_ACT_2._1
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
            label1 = new Label();
            label2 = new Label();
            calcularButton = new Button();
            label3 = new Label();
            Montotxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Dsct = new Label();
            imp = new Label();
            Subt = new Label();
            ImpApagar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 155);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Descuento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 196);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Impuesto";
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(363, 375);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(94, 29);
            calcularButton.TabIndex = 2;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 234);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Subtotal";
            // 
            // Montotxt
            // 
            Montotxt.Location = new Point(453, 87);
            Montotxt.Name = "Montotxt";
            Montotxt.Size = new Size(125, 27);
            Montotxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 275);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 5;
            label4.Text = "Importe A pagar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 94);
            label5.Name = "label5";
            label5.Size = new Size(228, 20);
            label5.TabIndex = 6;
            label5.Text = "Ingrese la Cantidad de consumos";
            // 
            // Dsct
            // 
            Dsct.AutoSize = true;
            Dsct.Location = new Point(477, 155);
            Dsct.Name = "Dsct";
            Dsct.Size = new Size(17, 20);
            Dsct.TabIndex = 7;
            Dsct.Text = "0";
            // 
            // imp
            // 
            imp.AutoSize = true;
            imp.Location = new Point(477, 196);
            imp.Name = "imp";
            imp.Size = new Size(17, 20);
            imp.TabIndex = 8;
            imp.Text = "0";
            // 
            // Subt
            // 
            Subt.AutoSize = true;
            Subt.Location = new Point(477, 234);
            Subt.Name = "Subt";
            Subt.Size = new Size(17, 20);
            Subt.TabIndex = 9;
            Subt.Text = "0";
            // 
            // ImpApagar
            // 
            ImpApagar.AutoSize = true;
            ImpApagar.Location = new Point(477, 275);
            ImpApagar.Name = "ImpApagar";
            ImpApagar.Size = new Size(17, 20);
            ImpApagar.TabIndex = 10;
            ImpApagar.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImpApagar);
            Controls.Add(Subt);
            Controls.Add(imp);
            Controls.Add(Dsct);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Montotxt);
            Controls.Add(label3);
            Controls.Add(calcularButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button calcularButton;
        private Label label3;
        private TextBox Montotxt;
        private Label label4;
        private Label label5;
        private Label Dsct;
        private Label imp;
        private Label Subt;
        private Label ImpApagar;
    }
}