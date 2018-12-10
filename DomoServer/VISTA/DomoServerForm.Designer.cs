namespace DomoServer
{
    partial class DomoServerForm
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnAddCell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(246, 85);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(55, 13);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Domotica!";
            // 
            // btnAddCell
            // 
            this.btnAddCell.Location = new System.Drawing.Point(12, 12);
            this.btnAddCell.Name = "btnAddCell";
            this.btnAddCell.Size = new System.Drawing.Size(75, 23);
            this.btnAddCell.TabIndex = 1;
            this.btnAddCell.Text = "Añadir móvil";
            this.btnAddCell.UseVisualStyleBackColor = true;
            this.btnAddCell.Click += new System.EventHandler(this.btnAddCell_Click);
            // 
            // DomoServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCell);
            this.Controls.Add(this.lblTexto);
            this.Name = "DomoServerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnAddCell;
    }
}

