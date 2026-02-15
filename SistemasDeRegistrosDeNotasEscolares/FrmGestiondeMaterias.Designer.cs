using System;

namespace SistemasDeRegistrosDeNotasEscolares
{
    partial class FrmGestiondeMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestiondeMaterias));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1Agregar = new System.Windows.Forms.Button();
            this.button2Editar = new System.Windows.Forms.Button();
            this.button3Eliminar = new System.Windows.Forms.Button();
            this.button4Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(325, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1Agregar
            // 
            this.button1Agregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1Agregar.Location = new System.Drawing.Point(208, 149);
            this.button1Agregar.Name = "button1Agregar";
            this.button1Agregar.Size = new System.Drawing.Size(93, 36);
            this.button1Agregar.TabIndex = 2;
            this.button1Agregar.Text = "Agregar";
            this.button1Agregar.UseVisualStyleBackColor = false;
            this.button1Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Editar
            // 
            this.button2Editar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2Editar.Location = new System.Drawing.Point(208, 214);
            this.button2Editar.Name = "button2Editar";
            this.button2Editar.Size = new System.Drawing.Size(93, 36);
            this.button2Editar.TabIndex = 3;
            this.button2Editar.Text = "Editar";
            this.button2Editar.UseVisualStyleBackColor = false;
            this.button2Editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3Eliminar
            // 
            this.button3Eliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3Eliminar.Location = new System.Drawing.Point(208, 275);
            this.button3Eliminar.Name = "button3Eliminar";
            this.button3Eliminar.Size = new System.Drawing.Size(93, 36);
            this.button3Eliminar.TabIndex = 4;
            this.button3Eliminar.Text = "Eliminar";
            this.button3Eliminar.UseVisualStyleBackColor = false;
            this.button3Eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4Guardar
            // 
            this.button4Guardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4Guardar.Location = new System.Drawing.Point(208, 331);
            this.button4Guardar.Name = "button4Guardar";
            this.button4Guardar.Size = new System.Drawing.Size(93, 36);
            this.button4Guardar.TabIndex = 5;
            this.button4Guardar.Text = "Guardar";
            this.button4Guardar.UseVisualStyleBackColor = false;
            this.button4Guardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmGestiondeMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4Guardar);
            this.Controls.Add(this.button3Eliminar);
            this.Controls.Add(this.button2Editar);
            this.Controls.Add(this.button1Agregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestiondeMaterias";
            this.Text = "FrmGestiondeMaterias";
            this.Load += new System.EventHandler(this.FrmGestiondeMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1Agregar;
        private System.Windows.Forms.Button button2Editar;
        private System.Windows.Forms.Button button3Eliminar;
        private System.Windows.Forms.Button button4Guardar;
    }
}