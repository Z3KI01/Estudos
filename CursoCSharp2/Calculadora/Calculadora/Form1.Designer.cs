namespace Calculadora
{
    partial class form1
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
            txtResultado = new TextBox();
            lblOperacao = new Label();
            btnvirgula = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btnigual = new Button();
            btnsoma = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnsub = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnmulti = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btndiv = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 27);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(274, 32);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(21, 33);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 20);
            lblOperacao.TabIndex = 1;
            lblOperacao.Click += label1_Click;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(9, 361);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(66, 63);
            btnvirgula.TabIndex = 2;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += btnvirgula_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(9, 292);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 63);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(81, 361);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 63);
            btn0.TabIndex = 3;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnigual
            // 
            btnigual.Location = new Point(153, 361);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(66, 63);
            btnigual.TabIndex = 4;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // btnsoma
            // 
            btnsoma.Location = new Point(225, 361);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(66, 63);
            btnsoma.TabIndex = 5;
            btnsoma.Text = "+";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(81, 292);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 63);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(153, 292);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 63);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnsub
            // 
            btnsub.Location = new Point(225, 292);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(66, 63);
            btnsub.TabIndex = 8;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = true;
            btnsub.Click += btnsub_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(9, 223);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 63);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(81, 223);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 63);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(153, 223);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 63);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnmulti
            // 
            btnmulti.Location = new Point(225, 223);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(66, 63);
            btnmulti.TabIndex = 12;
            btnmulti.Text = "X";
            btnmulti.UseVisualStyleBackColor = true;
            btnmulti.Click += btnmulti_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(9, 154);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 63);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(81, 154);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 63);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(153, 154);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 63);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btndiv
            // 
            btndiv.Location = new Point(225, 154);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(66, 63);
            btndiv.TabIndex = 16;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(225, 116);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 32);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 434);
            Controls.Add(btnClear);
            Controls.Add(btndiv);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnmulti);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnsub);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnsoma);
            Controls.Add(btnigual);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btnvirgula);
            Controls.Add(lblOperacao);
            Controls.Add(txtResultado);
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Label lblOperacao;
        private Button btnvirgula;
        private Button btn1;
        private Button btn0;
        private Button btnigual;
        private Button btnsoma;
        private Button btn2;
        private Button btn3;
        private Button btnsub;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnmulti;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btndiv;
        private Button btnClear;
    }
}
