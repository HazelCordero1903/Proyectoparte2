namespace Proyectoparte2
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
            lerrores = new Label();
            panel1 = new Panel();
            btnFinalizar = new Button();
            label9 = new Label();
            button1 = new Button();
            tresultado = new TextBox();
            label2 = new Label();
            label4 = new Label();
            op = new Label();
            n2 = new Label();
            n1 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            laciertos = new Label();
            Aciertos = new Label();
            label5 = new Label();
            lpuntaje = new Label();
            cbJugadores = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lerrores
            // 
            lerrores.Location = new Point(604, 315);
            lerrores.Name = "lerrores";
            lerrores.Size = new Size(65, 20);
            lerrores.TabIndex = 8;
            lerrores.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnFinalizar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tresultado);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(op);
            panel1.Controls.Add(n2);
            panel1.Controls.Add(n1);
            panel1.ForeColor = SystemColors.InfoText;
            panel1.Location = new Point(176, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 342);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(304, 294);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar partida.";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 219);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(82, 254);
            button1.Name = "button1";
            button1.Size = new Size(125, 59);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tresultado
            // 
            tresultado.Location = new Point(15, 179);
            tresultado.Name = "tresultado";
            tresultado.Size = new Size(125, 27);
            tresultado.TabIndex = 5;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(22, 20);
            label2.Name = "label2";
            label2.Size = new Size(290, 48);
            label2.TabIndex = 4;
            label2.Text = "Digite el resultado";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(275, 92);
            label4.Name = "label4";
            label4.Size = new Size(55, 48);
            label4.TabIndex = 3;
            label4.Text = "=?";
            // 
            // op
            // 
            op.BorderStyle = BorderStyle.FixedSingle;
            op.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op.ForeColor = Color.Purple;
            op.Location = new Point(110, 92);
            op.Name = "op";
            op.Size = new Size(50, 48);
            op.TabIndex = 2;
            // 
            // n2
            // 
            n2.BorderStyle = BorderStyle.FixedSingle;
            n2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n2.ForeColor = Color.Purple;
            n2.Location = new Point(193, 92);
            n2.Name = "n2";
            n2.Size = new Size(47, 48);
            n2.TabIndex = 1;
            // 
            // n1
            // 
            n1.BorderStyle = BorderStyle.FixedSingle;
            n1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n1.ForeColor = Color.Purple;
            n1.Location = new Point(35, 92);
            n1.Name = "n1";
            n1.Size = new Size(45, 48);
            n1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(176, 10);
            label1.Name = "label1";
            label1.Size = new Size(314, 46);
            label1.TabIndex = 1;
            label1.Text = "Juego de Numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(599, 59);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Jugadores";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(599, 276);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(70, 25);
            label6.TabIndex = 6;
            label6.Text = "Errores";
            // 
            // laciertos
            // 
            laciertos.AutoSize = true;
            laciertos.Location = new Point(613, 228);
            laciertos.Name = "laciertos";
            laciertos.Size = new Size(17, 20);
            laciertos.TabIndex = 7;
            laciertos.Text = "0";
            // 
            // Aciertos
            // 
            Aciertos.AutoSize = true;
            Aciertos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Aciertos.ForeColor = Color.Yellow;
            Aciertos.Location = new Point(599, 203);
            Aciertos.Name = "Aciertos";
            Aciertos.RightToLeft = RightToLeft.Yes;
            Aciertos.Size = new Size(80, 25);
            Aciertos.TabIndex = 10;
            Aciertos.Text = "Aciertos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(43, 59);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 11;
            label5.Text = "Puntaje";
            // 
            // lpuntaje
            // 
            lpuntaje.Location = new Point(43, 81);
            lpuntaje.Name = "lpuntaje";
            lpuntaje.Size = new Size(65, 20);
            lpuntaje.TabIndex = 12;
            lpuntaje.Text = "0";
            // 
            // cbJugadores
            // 
            cbJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJugadores.FormattingEnabled = true;
            cbJugadores.Location = new Point(599, 111);
            cbJugadores.Name = "cbJugadores";
            cbJugadores.Size = new Size(151, 28);
            cbJugadores.TabIndex = 14;
            cbJugadores.SelectedIndexChanged += cbJugadores_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cbJugadores);
            Controls.Add(lpuntaje);
            Controls.Add(label5);
            Controls.Add(Aciertos);
            Controls.Add(lerrores);
            Controls.Add(laciertos);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Juego de Numeros";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label n1;
        private Label label2;
        private Label label4;
        private Label op;
        private Label n2;
        private Label label3;
        private Label label6;
        private Button button1;
        private TextBox tresultado;
        private Label label9;
        private Label laciertos;
        private Label lerrores;
        private Label Aciertos;
        private Label label5;
        private Label lpuntaje;
        private ComboBox cbJugadores;
        private Button btnFinalizar;
    }
}
