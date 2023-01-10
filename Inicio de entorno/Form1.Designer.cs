
namespace Inicio_de_entorno
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
            this.Nombre = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(169, 52);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(445, 32);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre: Aimeé Ramírez Carmona";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(329, 121);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(135, 29);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID: 169680";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // materia
            // 
            this.materia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materia.AutoSize = true;
            this.materia.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia.Location = new System.Drawing.Point(169, 186);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(445, 32);
            this.materia.TabIndex = 2;
            this.materia.Text = "Materia: Graficación y videojuegos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 441);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label materia;
    }
}

