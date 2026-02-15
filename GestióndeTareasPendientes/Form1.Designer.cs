namespace GestióndeTareasPendientes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnEliminarTarea;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.SuspendLayout();

          
            this.txtTarea.Location = new System.Drawing.Point(12, 12);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(260, 20);
            this.txtTarea.TabIndex = 0;

            this.btnAgregarTarea.Location = new System.Drawing.Point(12, 38);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(260, 23);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);

            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.Location = new System.Drawing.Point(12, 67);
            this.lstTareas.Name = "listaTareas";
            this.lstTareas.Size = new System.Drawing.Size(260, 160);
            this.lstTareas.TabIndex = 2;

            this.btnEliminarTarea.Location = new System.Drawing.Point(12, 233);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(260, 23);
            this.btnEliminarTarea.TabIndex = 3;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);

            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.txtTarea);
            this.Name = "Form1";
            this.Text = "GestionTareasPendientes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
