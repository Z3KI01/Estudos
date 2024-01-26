namespace Calculadora3
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            txtResultado = new TextBox();
            btnIgual = new Button();
            btnSoma = new Button();
            btnSub = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnClear = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            textBox1 = new TextBox();
            txtConta = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.InfoText;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.Transparent;
            txtResultado.Location = new Point(-1, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(420, 144);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.OrangeRed;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIgual.ForeColor = SystemColors.ButtonHighlight;
            btnIgual.Location = new Point(311, 422);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(108, 76);
            btnIgual.TabIndex = 2;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.White;
            btnSoma.FlatAppearance.BorderSize = 0;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSoma.Location = new Point(311, 350);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(108, 74);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.White;
            btnSub.FlatAppearance.BorderSize = 0;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSub.Location = new Point(311, 286);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(108, 73);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.White;
            btnMulti.FlatAppearance.BorderSize = 0;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMulti.Location = new Point(311, 212);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(108, 75);
            btnMulti.TabIndex = 5;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.White;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDiv.Location = new Point(311, 144);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(108, 70);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(-1, 144);
            btn7.Name = "btn7";
            btn7.Size = new Size(104, 89);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(-1, 233);
            btn4.Name = "btn4";
            btn4.Size = new Size(104, 89);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(-1, 322);
            btn1.Name = "btn1";
            btn1.Size = new Size(104, 89);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.OrangeRed;
            btnClear.Location = new Point(-1, 411);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 89);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseCompatibleTextRendering = true;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(103, 409);
            btn0.Name = "btn0";
            btn0.Size = new Size(104, 89);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(64, 64, 64);
            btnVirgula.FlatAppearance.BorderSize = 0;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVirgula.ForeColor = SystemColors.ButtonFace;
            btnVirgula.Location = new Point(207, 409);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(104, 89);
            btnVirgula.TabIndex = 15;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(207, 322);
            btn3.Name = "btn3";
            btn3.Size = new Size(104, 89);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(103, 322);
            btn2.Name = "btn2";
            btn2.Size = new Size(104, 89);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(207, 233);
            btn6.Name = "btn6";
            btn6.Size = new Size(104, 89);
            btn6.TabIndex = 19;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(103, 233);
            btn5.Name = "btn5";
            btn5.Size = new Size(105, 89);
            btn5.TabIndex = 18;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(207, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(104, 89);
            btn9.TabIndex = 21;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(103, 144);
            btn8.Name = "btn8";
            btn8.Size = new Size(104, 89);
            btn8.TabIndex = 20;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Transparent;
            textBox1.Location = new Point(-1, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 144);
            textBox1.TabIndex = 22;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtConta
            // 
            txtConta.BackColor = Color.Black;
            txtConta.BorderStyle = BorderStyle.None;
            txtConta.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConta.ForeColor = Color.FromArgb(64, 64, 64);
            txtConta.Location = new Point(263, 8);
            txtConta.Multiline = true;
            txtConta.Name = "txtConta";
            txtConta.ReadOnly = true;
            txtConta.Size = new Size(145, 39);
            txtConta.TabIndex = 23;
            txtConta.TextAlign = HorizontalAlignment.Right;
            txtConta.TextChanged += txtConta_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 498);
            Controls.Add(pictureBox1);
            Controls.Add(txtConta);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnVirgula);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(txtResultado);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.Manual;
            Text = "CALCULADORA";
            Load += Calculadora_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMulti;
        private Button btnDiv;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btnClear;
        private Button btn0;
        private Button btnVirgula;
        private Button btn3;
        private Button btn2;
        private Button btn6;
        private Button btn5;
        private Button btn9;
        private Button btn8;
        private TextBox textBox1;
        private TextBox txtConta;
        private PictureBox pictureBox1;
    }
}
