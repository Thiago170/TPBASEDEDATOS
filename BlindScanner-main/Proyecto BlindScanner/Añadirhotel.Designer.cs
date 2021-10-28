
namespace Proyecto_BlindScanner
{
    partial class Añadirhotel
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombrehotel = new System.Windows.Forms.TextBox();
            this.btnvolver2 = new System.Windows.Forms.Button();
            this.comboboxpais = new System.Windows.Forms.ComboBox();
            this.comboboxprovincia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "En que pais se encuentra?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "En que provincia se encuentra?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOMBRE DEL HOTEL:";
            // 
            // txtnombrehotel
            // 
            this.txtnombrehotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrehotel.Location = new System.Drawing.Point(274, 59);
            this.txtnombrehotel.Name = "txtnombrehotel";
            this.txtnombrehotel.Size = new System.Drawing.Size(215, 26);
            this.txtnombrehotel.TabIndex = 7;
            this.txtnombrehotel.TextChanged += new System.EventHandler(this.txtnombrehotel_TextChanged);
            // 
            // btnvolver2
            // 
            this.btnvolver2.BackColor = System.Drawing.Color.Red;
            this.btnvolver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver2.Location = new System.Drawing.Point(13, 13);
            this.btnvolver2.Name = "btnvolver2";
            this.btnvolver2.Size = new System.Drawing.Size(75, 43);
            this.btnvolver2.TabIndex = 8;
            this.btnvolver2.Text = "Vover";
            this.btnvolver2.UseVisualStyleBackColor = false;
            this.btnvolver2.Click += new System.EventHandler(this.btnvolver2_Click);
            // 
            // comboboxpais
            // 
            this.comboboxpais.FormattingEnabled = true;
            this.comboboxpais.Items.AddRange(new object[] {
            "ARGENTINA"});
            this.comboboxpais.Location = new System.Drawing.Point(310, 118);
            this.comboboxpais.Name = "comboboxpais";
            this.comboboxpais.Size = new System.Drawing.Size(121, 21);
            this.comboboxpais.TabIndex = 9;
            // 
            // comboboxprovincia
            // 
            this.comboboxprovincia.FormattingEnabled = true;
            this.comboboxprovincia.Location = new System.Drawing.Point(310, 173);
            this.comboboxprovincia.Name = "comboboxprovincia";
            this.comboboxprovincia.Size = new System.Drawing.Size(121, 21);
            this.comboboxprovincia.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Añadirhotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboboxprovincia);
            this.Controls.Add(this.comboboxpais);
            this.Controls.Add(this.btnvolver2);
            this.Controls.Add(this.txtnombrehotel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Añadirhotel";
            this.Text = "Añadirhotel";
            this.Load += new System.EventHandler(this.Añadirhotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombrehotel;
        private System.Windows.Forms.Button btnvolver2;
        private System.Windows.Forms.ComboBox comboboxpais;
        private System.Windows.Forms.ComboBox comboboxprovincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}