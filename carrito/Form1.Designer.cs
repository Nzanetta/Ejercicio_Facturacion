
namespace carrito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCarritto = new System.Windows.Forms.ListBox();
            this.btnCalcuclar = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoDescuento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listCarritto
            // 
            this.listCarritto.FormattingEnabled = true;
            this.listCarritto.Location = new System.Drawing.Point(92, 86);
            this.listCarritto.Name = "listCarritto";
            this.listCarritto.Size = new System.Drawing.Size(120, 95);
            this.listCarritto.TabIndex = 0;
            // 
            // btnCalcuclar
            // 
            this.btnCalcuclar.Location = new System.Drawing.Point(237, 158);
            this.btnCalcuclar.Name = "btnCalcuclar";
            this.btnCalcuclar.Size = new System.Drawing.Size(75, 23);
            this.btnCalcuclar.TabIndex = 2;
            this.btnCalcuclar.Text = "Calcular";
            this.btnCalcuclar.UseVisualStyleBackColor = true;
            this.btnCalcuclar.Click += new System.EventHandler(this.btnCalcuclar_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(237, 86);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(170, 21);
            this.cboProductos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(237, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código de Descuento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // codigoDescuento
            // 
            this.codigoDescuento.Location = new System.Drawing.Point(356, 200);
            this.codigoDescuento.Name = "codigoDescuento";
            this.codigoDescuento.Size = new System.Drawing.Size(100, 20);
            this.codigoDescuento.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codigoDescuento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.btnCalcuclar);
            this.Controls.Add(this.listCarritto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCarritto;
        private System.Windows.Forms.Button btnCalcuclar;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoDescuento;
    }
}

