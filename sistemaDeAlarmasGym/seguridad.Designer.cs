namespace sistemaDeAlarmasGym
{
    partial class seguridad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seguridad));
            this.btnEncenderAlarma = new System.Windows.Forms.Button();
            this.btnApagarAlarma = new System.Windows.Forms.Button();
            this.COM3 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncenderAlarma
            // 
            this.btnEncenderAlarma.Image = ((System.Drawing.Image)(resources.GetObject("btnEncenderAlarma.Image")));
            this.btnEncenderAlarma.Location = new System.Drawing.Point(213, 180);
            this.btnEncenderAlarma.Name = "btnEncenderAlarma";
            this.btnEncenderAlarma.Size = new System.Drawing.Size(180, 143);
            this.btnEncenderAlarma.TabIndex = 0;
            this.btnEncenderAlarma.UseVisualStyleBackColor = true;
            this.btnEncenderAlarma.Click += new System.EventHandler(this.btnEncenderAlarma_Click);
            // 
            // btnApagarAlarma
            // 
            this.btnApagarAlarma.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarAlarma.Image")));
            this.btnApagarAlarma.Location = new System.Drawing.Point(421, 180);
            this.btnApagarAlarma.Name = "btnApagarAlarma";
            this.btnApagarAlarma.Size = new System.Drawing.Size(196, 143);
            this.btnApagarAlarma.TabIndex = 1;
            this.btnApagarAlarma.UseVisualStyleBackColor = true;
            this.btnApagarAlarma.Click += new System.EventHandler(this.btnApagarAlarma_Click);
            // 
            // COM3
            // 
            this.COM3.PortName = "COM3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vensim Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Activacion de Alarma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagarAlarma);
            this.Controls.Add(this.btnEncenderAlarma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seguridad";
            this.Text = "seguridad";
            this.Load += new System.EventHandler(this.seguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncenderAlarma;
        private System.Windows.Forms.Button btnApagarAlarma;
        private System.IO.Ports.SerialPort COM3;
        private System.Windows.Forms.Label label1;
    }
}