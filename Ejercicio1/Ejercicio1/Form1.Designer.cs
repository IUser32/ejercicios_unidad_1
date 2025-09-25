namespace Ejercicio1
{
    partial class frmInicio
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnMostrar = new Button();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            btnSumar = new Button();
            lblValor = new Label();
            lblValor2 = new Label();
            txtResultado = new TextBox();
            lblResultado = new Label();
            label1 = new Label();
            txtResultadoRestar = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRestar = new Button();
            txtValor2Restar = new TextBox();
            txtValor1Restar = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(515, 47);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 41);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(577, 62);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(205, 58);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(54, 267);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(250, 47);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(54, 389);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(250, 47);
            txtValor2.TabIndex = 4;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(341, 267);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(209, 169);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(54, 207);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(109, 41);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor 1";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new Point(54, 345);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(109, 41);
            lblValor2.TabIndex = 7;
            lblValor2.Text = "Valor 2";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(593, 328);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(250, 47);
            txtResultado.TabIndex = 8;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(593, 267);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(149, 41);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 538);
            label1.Name = "label1";
            label1.Size = new Size(149, 41);
            label1.TabIndex = 16;
            label1.Text = "Resultado";
            // 
            // txtResultadoRestar
            // 
            txtResultadoRestar.Location = new Point(593, 599);
            txtResultadoRestar.Name = "txtResultadoRestar";
            txtResultadoRestar.ReadOnly = true;
            txtResultadoRestar.Size = new Size(250, 47);
            txtResultadoRestar.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 616);
            label2.Name = "label2";
            label2.Size = new Size(109, 41);
            label2.TabIndex = 14;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 478);
            label3.Name = "label3";
            label3.Size = new Size(109, 41);
            label3.TabIndex = 13;
            label3.Text = "Valor 1";
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(341, 538);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(209, 169);
            btnRestar.TabIndex = 12;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // txtValor2Restar
            // 
            txtValor2Restar.Location = new Point(54, 660);
            txtValor2Restar.Name = "txtValor2Restar";
            txtValor2Restar.Size = new Size(250, 47);
            txtValor2Restar.TabIndex = 11;
            // 
            // txtValor1Restar
            // 
            txtValor1Restar.Location = new Point(54, 538);
            txtValor1Restar.Name = "txtValor1Restar";
            txtValor1Restar.Size = new Size(250, 47);
            txtValor1Restar.TabIndex = 10;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 983);
            Controls.Add(label1);
            Controls.Add(txtResultadoRestar);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnRestar);
            Controls.Add(txtValor2Restar);
            Controls.Add(txtValor1Restar);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(lblValor2);
            Controls.Add(lblValor);
            Controls.Add(btnSumar);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnMostrar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "frmInicio";
            Text = "Formulario Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnMostrar;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnSumar;
        private Label lblValor;
        private Label lblValor2;
        private TextBox txtResultado;
        private Label lblResultado;
        private Label label1;
        private TextBox txtResultadoRestar;
        private Label label2;
        private Label label3;
        private Button btnRestar;
        private TextBox txtValor2Restar;
        private TextBox txtValor1Restar;
    }
}
