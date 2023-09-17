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
            radioBinarioChecked = new RadioButton();
            rdbDecimalChecked = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOperar
            // 
            buttonOperar.Location = new Point(33, 381);
            buttonOperar.Name = "buttonOperar";
            buttonOperar.Size = new Size(212, 36);
            buttonOperar.TabIndex = 0;
            buttonOperar.Text = "Operar";
            buttonOperar.UseVisualStyleBackColor = true;
            buttonOperar.Click += buttonOperar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(273, 381);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(236, 36);
            buttonLimpiar.TabIndex = 1;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(564, 381);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(212, 36);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            Resultado.Location = new Point(33, 59);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(195, 51);
            Resultado.TabIndex = 3;
            Resultado.Text = "Resultado:";
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperator.FormattingEnabled = true;
            comboBoxOperator.ImeMode = ImeMode.On;
            comboBoxOperator.Location = new Point(314, 317);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(157, 23);
            comboBoxOperator.TabIndex = 4;
            // 
            // textPrimerOperador
            // 
            textPrimerOperador.Location = new Point(33, 317);
            textPrimerOperador.Name = "textPrimerOperador";
            textPrimerOperador.Size = new Size(212, 23);
            textPrimerOperador.TabIndex = 5;
            // 
            // textSegundoOperador
            // 
            textSegundoOperador.Location = new Point(564, 317);
            textSegundoOperador.Name = "textSegundoOperador";
            textSegundoOperador.Size = new Size(212, 23);
            textSegundoOperador.TabIndex = 6;
            // 
            // labelPrimerOperador
            // 
            labelPrimerOperador.AutoSize = true;
            labelPrimerOperador.Location = new Point(33, 284);
            labelPrimerOperador.Name = "labelPrimerOperador";
            labelPrimerOperador.Size = new Size(96, 15);
            labelPrimerOperador.TabIndex = 7;
            labelPrimerOperador.Text = "Primer operador:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(314, 284);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(57, 15);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "Operador";
            // 
            // labelOperando2
            // 
            labelOperando2.AutoSize = true;
            labelOperando2.Location = new Point(564, 284);
            labelOperando2.Name = "labelOperando2";
            labelOperando2.Size = new Size(108, 15);
            labelOperando2.TabIndex = 9;
            labelOperando2.Text = "Segundo operador:";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(262, 84);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(209, 23);
            textBoxResultado.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDecimalChecked);
            groupBox1.Controls.Add(radioBinarioChecked);
            groupBox1.Location = new Point(262, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 110);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representar resultado en :";
            // 
            // radioBinarioChecked
            // 
            radioBinarioChecked.AutoSize = true;
            radioBinarioChecked.Location = new Point(117, 37);
            radioBinarioChecked.Name = "radioBinarioChecked";
            radioBinarioChecked.Size = new Size(62, 19);
            radioBinarioChecked.TabIndex = 13;
            radioBinarioChecked.TabStop = true;
            radioBinarioChecked.Text = "Binario";
            radioBinarioChecked.UseVisualStyleBackColor = true;
            radioBinarioChecked.CheckedChanged += radioBinarioChecked_CheckedChanged;
            // 
            // rdbDecimalChecked
            // 
            rdbDecimalChecked.AutoSize = true;
            rdbDecimalChecked.Location = new Point(6, 37);
            rdbDecimalChecked.Name = "rdbDecimalChecked";
            rdbDecimalChecked.Size = new Size(68, 19);
            rdbDecimalChecked.TabIndex = 12;
            rdbDecimalChecked.TabStop = true;
            rdbDecimalChecked.Text = "Decimal";
            rdbDecimalChecked.UseVisualStyleBackColor = true;
            rdbDecimalChecked.CheckedChanged += rdbDecimalChecked_CheckedChanged;
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