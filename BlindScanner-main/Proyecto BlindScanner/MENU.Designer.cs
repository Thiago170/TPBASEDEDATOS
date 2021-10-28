
namespace Proyecto_BlindScanner
{
    partial class MENU
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
            this.btnbuscador = new System.Windows.Forms.Button();
            this.btnañadirhotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscador
            // 
            this.btnbuscador.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnbuscador.Font = new System.Drawing.Font("Niagara Solid", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnbuscador.Location = new System.Drawing.Point(67, 48);
            this.btnbuscador.Name = "btnbuscador";
            this.btnbuscador.Size = new System.Drawing.Size(165, 147);
            this.btnbuscador.TabIndex = 0;
            this.btnbuscador.Text = "Buscador";
            this.btnbuscador.UseVisualStyleBackColor = false;
            this.btnbuscador.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnañadirhotel
            // 
            this.btnañadirhotel.BackColor = System.Drawing.Color.DarkBlue;
            this.btnañadirhotel.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnañadirhotel.Location = new System.Drawing.Point(67, 243);
            this.btnañadirhotel.Name = "btnañadirhotel";
            this.btnañadirhotel.Size = new System.Drawing.Size(165, 154);
            this.btnañadirhotel.TabIndex = 1;
            this.btnañadirhotel.Text = "Añada un hotel";
            this.btnañadirhotel.UseVisualStyleBackColor = false;
            this.btnañadirhotel.Click += new System.EventHandler(this.button2_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnañadirhotel);
            this.Controls.Add(this.btnbuscador);
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbuscador;
        private System.Windows.Forms.Button btnañadirhotel;
    }
}