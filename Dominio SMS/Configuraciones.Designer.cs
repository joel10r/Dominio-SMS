namespace Dominio_SMS
{
    partial class Configuraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuraciones));
            this.btnModificarDominio = new System.Windows.Forms.Button();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblDominioActual = new System.Windows.Forms.Label();
            this.txtDominioActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModificarDominio
            // 
            this.btnModificarDominio.Location = new System.Drawing.Point(173, 114);
            this.btnModificarDominio.Name = "btnModificarDominio";
            this.btnModificarDominio.Size = new System.Drawing.Size(102, 23);
            this.btnModificarDominio.TabIndex = 1;
            this.btnModificarDominio.Text = "Modificar Dominio";
            this.btnModificarDominio.UseVisualStyleBackColor = true;
            this.btnModificarDominio.Click += new System.EventHandler(this.btnModificarDominio_Click);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(173, 73);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 0;
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominio.Location = new System.Drawing.Point(49, 77);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(104, 16);
            this.lblDominio.TabIndex = 2;
            this.lblDominio.Text = "Nuevo Dominio:";
            // 
            // lblDominioActual
            // 
            this.lblDominioActual.AutoSize = true;
            this.lblDominioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominioActual.Location = new System.Drawing.Point(49, 36);
            this.lblDominioActual.Name = "lblDominioActual";
            this.lblDominioActual.Size = new System.Drawing.Size(101, 16);
            this.lblDominioActual.TabIndex = 2;
            this.lblDominioActual.Text = "Dominio Actual:";
            // 
            // txtDominioActual
            // 
            this.txtDominioActual.Location = new System.Drawing.Point(173, 35);
            this.txtDominioActual.Name = "txtDominioActual";
            this.txtDominioActual.ReadOnly = true;
            this.txtDominioActual.Size = new System.Drawing.Size(100, 20);
            this.txtDominioActual.TabIndex = 2;
            // 
            // Configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 169);
            this.Controls.Add(this.txtDominioActual);
            this.Controls.Add(this.lblDominioActual);
            this.Controls.Add(this.lblDominio);
            this.Controls.Add(this.txtDominio);
            this.Controls.Add(this.btnModificarDominio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.Configuraciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarDominio;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblDominioActual;
        private System.Windows.Forms.TextBox txtDominioActual;
    }
}