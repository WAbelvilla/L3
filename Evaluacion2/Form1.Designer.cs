namespace Evaluacion2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMult = new System.Windows.Forms.TextBox();
            this.txtRangoFinal = new System.Windows.Forms.TextBox();
            this.txtRangoInicio = new System.Windows.Forms.TextBox();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Multiplicando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multiplicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplicando:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rango de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rango de Final:";
            // 
            // txtMult
            // 
            this.txtMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMult.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMult.Location = new System.Drawing.Point(64, 93);
            this.txtMult.Multiline = true;
            this.txtMult.Name = "txtMult";
            this.txtMult.Size = new System.Drawing.Size(94, 36);
            this.txtMult.TabIndex = 3;
            this.txtMult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRangoFinal
            // 
            this.txtRangoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRangoFinal.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtRangoFinal.Location = new System.Drawing.Point(458, 93);
            this.txtRangoFinal.Multiline = true;
            this.txtRangoFinal.Name = "txtRangoFinal";
            this.txtRangoFinal.Size = new System.Drawing.Size(108, 36);
            this.txtRangoFinal.TabIndex = 4;
            this.txtRangoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRangoInicio
            // 
            this.txtRangoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRangoInicio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtRangoInicio.Location = new System.Drawing.Point(245, 93);
            this.txtRangoInicio.Multiline = true;
            this.txtRangoInicio.Name = "txtRangoInicio";
            this.txtRangoInicio.Size = new System.Drawing.Size(106, 36);
            this.txtRangoInicio.TabIndex = 5;
            this.txtRangoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostrar.Location = new System.Drawing.Point(629, 93);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(193, 52);
            this.cmdMostrar.TabIndex = 6;
            this.cmdMostrar.Text = "Mostrar Tabla";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Multiplicando,
            this.Multiplicador,
            this.Producto});
            this.dataGridView1.Location = new System.Drawing.Point(109, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 337);
            this.dataGridView1.TabIndex = 7;
            // 
            // Multiplicando
            // 
            this.Multiplicando.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Multiplicando.HeaderText = "Multiplicando";
            this.Multiplicando.Name = "Multiplicando";
            this.Multiplicando.ReadOnly = true;
            this.Multiplicando.Width = 119;
            // 
            // Multiplicador
            // 
            this.Multiplicador.HeaderText = "Multiplicador";
            this.Multiplicador.Name = "Multiplicador";
            this.Multiplicador.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.txtRangoInicio);
            this.Controls.Add(this.txtRangoFinal);
            this.Controls.Add(this.txtMult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMult;
        private System.Windows.Forms.TextBox txtRangoFinal;
        private System.Windows.Forms.TextBox txtRangoInicio;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multiplicando;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multiplicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
    }
}

