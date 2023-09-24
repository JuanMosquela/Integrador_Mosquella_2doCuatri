namespace Integrador
{
    partial class FrmCalculadora
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
            buttonOperar = new Button();
            buttonLimpiar = new Button();
            buttonCerrar = new Button();
            Resultado = new Label();
            comboBoxOperator = new ComboBox();
            textPrimerOperador = new TextBox();
            textSegundoOperador = new TextBox();
            labelPrimerOperador = new Label();
            labelResultado = new Label();
            labelOperando2 = new Label();
            textBoxResultado = new TextBox();
            groupBox1 = new GroupBox();
            rdbDecimalChecked = new RadioButton();
            radioBinarioChecked = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOperar
            // 
            buttonOperar.Cursor = Cursors.Hand;
            buttonOperar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOperar.Location = new Point(33, 381);
            buttonOperar.Name = "buttonOperar";
            buttonOperar.Size = new Size(212, 44);
            buttonOperar.TabIndex = 0;
            buttonOperar.Text = "Operar";
            buttonOperar.UseVisualStyleBackColor = true;
            buttonOperar.Click += buttonOperar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Cursor = Cursors.Hand;
            buttonLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(284, 381);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(236, 44);
            buttonLimpiar.TabIndex = 1;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Cursor = Cursors.Hand;
            buttonCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCerrar.Location = new Point(564, 381);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(212, 44);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            Resultado.Location = new Point(33, 71);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(220, 59);
            Resultado.TabIndex = 3;
            Resultado.Text = "Resultado:";
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.ImeMode = ImeMode.On;
            comboBoxOperator.Location = new Point(326, 317);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(157, 40);
            comboBoxOperator.TabIndex = 4;
            // 
            // textPrimerOperador
            // 
            textPrimerOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textPrimerOperador.Location = new Point(33, 317);
            textPrimerOperador.Name = "textPrimerOperador";
            textPrimerOperador.Size = new Size(212, 39);
            textPrimerOperador.TabIndex = 5;
            // 
            // textSegundoOperador
            // 
            textSegundoOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textSegundoOperador.Location = new Point(564, 317);
            textSegundoOperador.Name = "textSegundoOperador";
            textSegundoOperador.Size = new Size(212, 39);
            textSegundoOperador.TabIndex = 6;
            // 
            // labelPrimerOperador
            // 
            labelPrimerOperador.AutoSize = true;
            labelPrimerOperador.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrimerOperador.Location = new Point(33, 284);
            labelPrimerOperador.Name = "labelPrimerOperador";
            labelPrimerOperador.Size = new Size(155, 25);
            labelPrimerOperador.TabIndex = 7;
            labelPrimerOperador.Text = "Primer operador:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultado.Location = new Point(326, 284);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(93, 25);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Operador";
            // 
            // labelOperando2
            // 
            labelOperando2.AutoSize = true;
            labelOperando2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperando2.Location = new Point(564, 284);
            labelOperando2.Name = "labelOperando2";
            labelOperando2.Size = new Size(174, 25);
            labelOperando2.TabIndex = 9;
            labelOperando2.Text = "Segundo operador:";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxResultado.Location = new Point(259, 95);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(209, 32);
            textBoxResultado.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDecimalChecked);
            groupBox1.Controls.Add(radioBinarioChecked);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(266, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 80);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representar resultado en :";
            // 
            // rdbDecimalChecked
            // 
            rdbDecimalChecked.AutoSize = true;
            rdbDecimalChecked.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimalChecked.Location = new Point(6, 37);
            rdbDecimalChecked.Name = "rdbDecimalChecked";
            rdbDecimalChecked.Size = new Size(75, 23);
            rdbDecimalChecked.TabIndex = 12;
            rdbDecimalChecked.TabStop = true;
            rdbDecimalChecked.Text = "Decimal";
            rdbDecimalChecked.UseVisualStyleBackColor = true;
            rdbDecimalChecked.CheckedChanged += rdbDecimalChecked_CheckedChanged;
            // 
            // radioBinarioChecked
            // 
            radioBinarioChecked.AutoSize = true;
            radioBinarioChecked.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioBinarioChecked.Location = new Point(117, 37);
            radioBinarioChecked.Name = "radioBinarioChecked";
            radioBinarioChecked.Size = new Size(69, 23);
            radioBinarioChecked.TabIndex = 13;
            radioBinarioChecked.TabStop = true;
            radioBinarioChecked.Text = "Binario";
            radioBinarioChecked.UseVisualStyleBackColor = true;
            radioBinarioChecked.CheckedChanged += radioBinarioChecked_CheckedChanged;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(textBoxResultado);
            Controls.Add(labelOperando2);
            Controls.Add(labelResultado);
            Controls.Add(labelPrimerOperador);
            Controls.Add(textSegundoOperador);
            Controls.Add(textPrimerOperador);
            Controls.Add(comboBoxOperator);
            Controls.Add(Resultado);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumnos Juan Manuel Mosquella";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FmrCalculadora_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOperar;
        private Button buttonLimpiar;
        private Button buttonCerrar;
        private Label Resultado;
        private ComboBox comboBoxOperator;
        private TextBox textPrimerOperador;
        private TextBox textSegundoOperador;
        private Label labelPrimerOperador;
        private Label labelResultado;
        private Label labelOperando2;
        private TextBox textBoxResultado;
        private GroupBox groupBox1;
        private RadioButton rdbDecimalChecked;
        private RadioButton radioBinarioChecked;
    }
}