namespace Proyecto_BlindScanner
{
    partial class CreadorDeListas
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
            this.numUDCant = new System.Windows.Forms.NumericUpDown();
            this.txtAñadirProducto = new System.Windows.Forms.TextBox();
            this.txtNomLista = new System.Windows.Forms.TextBox();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.listBxProductos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCant)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDCant
            // 
            this.numUDCant.Location = new System.Drawing.Point(103, 217);
            this.numUDCant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCant.Name = "numUDCant";
            this.numUDCant.Size = new System.Drawing.Size(120, 20);
            this.numUDCant.TabIndex = 0;
            this.numUDCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAñadirProducto
            // 
            this.txtAñadirProducto.Location = new System.Drawing.Point(103, 98);
            this.txtAñadirProducto.Name = "txtAñadirProducto";
            this.txtAñadirProducto.Size = new System.Drawing.Size(100, 20);
            this.txtAñadirProducto.TabIndex = 1;
            // 
            // txtNomLista
            // 
            this.txtNomLista.Location = new System.Drawing.Point(310, 95);
            this.txtNomLista.Name = "txtNomLista";
            this.txtNomLista.Size = new System.Drawing.Size(100, 20);
            this.txtNomLista.TabIndex = 2;
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.Location = new System.Drawing.Point(103, 351);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(120, 62);
            this.btnAñadirProducto.TabIndex = 3;
            this.btnAñadirProducto.Text = "Añadir producto";
            this.btnAñadirProducto.UseVisualStyleBackColor = true;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(598, 95);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(75, 23);
            this.btnCrearLista.TabIndex = 4;
            this.btnCrearLista.Text = "Crear lista";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(598, 287);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(75, 54);
            this.btnQuitarProducto.TabIndex = 5;
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // listBxProductos
            // 
            this.listBxProductos.FormattingEnabled = true;
            this.listBxProductos.Location = new System.Drawing.Point(310, 208);
            this.listBxProductos.Name = "listBxProductos";
            this.listBxProductos.Size = new System.Drawing.Size(120, 95);
            this.listBxProductos.TabIndex = 6;
            // 
            // CreadorDeListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 515);
            this.Controls.Add(this.listBxProductos);
            this.Controls.Add(this.btnQuitarProducto);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.btnAñadirProducto);
            this.Controls.Add(this.txtNomLista);
            this.Controls.Add(this.txtAñadirProducto);
            this.Controls.Add(this.numUDCant);
            this.Name = "CreadorDeListas";
            this.Text = "CreadorDeListas";
            this.Load += new System.EventHandler(this.CreadorDeListas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDCant;
        private System.Windows.Forms.TextBox txtAñadirProducto;
        private System.Windows.Forms.TextBox txtNomLista;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.ListBox listBxProductos;
    }
}