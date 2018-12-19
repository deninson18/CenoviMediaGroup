namespace IntelligentPrestam.Registros
{
    partial class RegistroRutas
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
            this.nuevoRutabutton = new System.Windows.Forms.Button();
            this.guardarRutabutton = new System.Windows.Forms.Button();
            this.eliminarRutabutton = new System.Windows.Forms.Button();
            this.idRutatextBox = new System.Windows.Forms.TextBox();
            this.descripcionRutatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RutadataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RutadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoRutabutton
            // 
            this.nuevoRutabutton.Location = new System.Drawing.Point(8, 315);
            this.nuevoRutabutton.Name = "nuevoRutabutton";
            this.nuevoRutabutton.Size = new System.Drawing.Size(72, 50);
            this.nuevoRutabutton.TabIndex = 0;
            this.nuevoRutabutton.Text = "NUEVO";
            this.nuevoRutabutton.UseVisualStyleBackColor = true;
            this.nuevoRutabutton.Click += new System.EventHandler(this.nuevoRutabutton_Click);
            // 
            // guardarRutabutton
            // 
            this.guardarRutabutton.Location = new System.Drawing.Point(135, 315);
            this.guardarRutabutton.Name = "guardarRutabutton";
            this.guardarRutabutton.Size = new System.Drawing.Size(72, 50);
            this.guardarRutabutton.TabIndex = 1;
            this.guardarRutabutton.Text = "GUARDAR";
            this.guardarRutabutton.UseVisualStyleBackColor = true;
            this.guardarRutabutton.Click += new System.EventHandler(this.guardarRutabutton_Click);
            // 
            // eliminarRutabutton
            // 
            this.eliminarRutabutton.Location = new System.Drawing.Point(269, 315);
            this.eliminarRutabutton.Name = "eliminarRutabutton";
            this.eliminarRutabutton.Size = new System.Drawing.Size(72, 50);
            this.eliminarRutabutton.TabIndex = 2;
            this.eliminarRutabutton.Text = "ELIMINAR";
            this.eliminarRutabutton.UseVisualStyleBackColor = true;
            this.eliminarRutabutton.Click += new System.EventHandler(this.eliminarRutabutton_Click);
            // 
            // idRutatextBox
            // 
            this.idRutatextBox.Location = new System.Drawing.Point(12, 25);
            this.idRutatextBox.Name = "idRutatextBox";
            this.idRutatextBox.Size = new System.Drawing.Size(148, 20);
            this.idRutatextBox.TabIndex = 3;
            // 
            // descripcionRutatextBox
            // 
            this.descripcionRutatextBox.Location = new System.Drawing.Point(12, 76);
            this.descripcionRutatextBox.Multiline = true;
            this.descripcionRutatextBox.Name = "descripcionRutatextBox";
            this.descripcionRutatextBox.Size = new System.Drawing.Size(329, 40);
            this.descripcionRutatextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // RutadataGridView
            // 
            this.RutadataGridView.AllowUserToAddRows = false;
            this.RutadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RutadataGridView.Location = new System.Drawing.Point(12, 163);
            this.RutadataGridView.Name = "RutadataGridView";
            this.RutadataGridView.ReadOnly = true;
            this.RutadataGridView.Size = new System.Drawing.Size(333, 124);
            this.RutadataGridView.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "RUTAS";
            // 
            // RegistroRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RutadataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcionRutatextBox);
            this.Controls.Add(this.idRutatextBox);
            this.Controls.Add(this.eliminarRutabutton);
            this.Controls.Add(this.guardarRutabutton);
            this.Controls.Add(this.nuevoRutabutton);
            this.Name = "RegistroRutas";
            this.Text = "RegistroRutas";
            this.Load += new System.EventHandler(this.RegistroRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RutadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoRutabutton;
        private System.Windows.Forms.Button guardarRutabutton;
        private System.Windows.Forms.Button eliminarRutabutton;
        private System.Windows.Forms.TextBox idRutatextBox;
        private System.Windows.Forms.TextBox descripcionRutatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RutadataGridView;
        private System.Windows.Forms.Label label3;
    }
}