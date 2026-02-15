namespace SistemaDeControlDeBuses
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.botonViajesyboletos = new System.Windows.Forms.Button();
            this.botonRutas = new System.Windows.Forms.Button();
            this.botonConductores = new System.Windows.Forms.Button();
            this.botonBuses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonViajesyboletos
            // 
            this.botonViajesyboletos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonViajesyboletos.Image = global::SistemaDeControlDeBuses.Properties.Resources.My_tickets_25425;
            this.botonViajesyboletos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonViajesyboletos.Location = new System.Drawing.Point(470, 12);
            this.botonViajesyboletos.Name = "botonViajesyboletos";
            this.botonViajesyboletos.Size = new System.Drawing.Size(172, 73);
            this.botonViajesyboletos.TabIndex = 3;
            this.botonViajesyboletos.Text = "Viajes y Boletos.";
            this.botonViajesyboletos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonViajesyboletos.UseVisualStyleBackColor = false;
            this.botonViajesyboletos.Click += new System.EventHandler(this.botonViajesyboletos_Click);
            // 
            // botonRutas
            // 
            this.botonRutas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonRutas.Image = global::SistemaDeControlDeBuses.Properties.Resources.google_map_location_logo_icon_159350;
            this.botonRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRutas.Location = new System.Drawing.Point(343, 12);
            this.botonRutas.Name = "botonRutas";
            this.botonRutas.Size = new System.Drawing.Size(121, 73);
            this.botonRutas.TabIndex = 2;
            this.botonRutas.Text = "Rutas";
            this.botonRutas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonRutas.UseVisualStyleBackColor = false;
            this.botonRutas.Click += new System.EventHandler(this.botonRutas_Click);
            // 
            // botonConductores
            // 
            this.botonConductores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonConductores.Image = global::SistemaDeControlDeBuses.Properties.Resources.ididentitycarddriverlicense_109689;
            this.botonConductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonConductores.Location = new System.Drawing.Point(153, 12);
            this.botonConductores.Name = "botonConductores";
            this.botonConductores.Size = new System.Drawing.Size(184, 73);
            this.botonConductores.TabIndex = 1;
            this.botonConductores.Text = "Conductores";
            this.botonConductores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonConductores.UseVisualStyleBackColor = false;
            this.botonConductores.Click += new System.EventHandler(this.Conductores_Click);
            // 
            // botonBuses
            // 
            this.botonBuses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonBuses.Image = global::SistemaDeControlDeBuses.Properties.Resources.Citycons_bus_icon_icons_com_67914;
            this.botonBuses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBuses.Location = new System.Drawing.Point(12, 12);
            this.botonBuses.Name = "botonBuses";
            this.botonBuses.Size = new System.Drawing.Size(135, 73);
            this.botonBuses.TabIndex = 0;
            this.botonBuses.Text = "Buses";
            this.botonBuses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonBuses.UseVisualStyleBackColor = false;
            this.botonBuses.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 609);
            this.Controls.Add(this.botonViajesyboletos);
            this.Controls.Add(this.botonRutas);
            this.Controls.Add(this.botonConductores);
            this.Controls.Add(this.botonBuses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonBuses;
        private System.Windows.Forms.Button botonConductores;
        private System.Windows.Forms.Button botonRutas;
        private System.Windows.Forms.Button botonViajesyboletos;
    }
}

