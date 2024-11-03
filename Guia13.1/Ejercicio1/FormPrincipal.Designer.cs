namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.rbNuevoCliente = new System.Windows.Forms.RadioButton();
            this.rbDenuncia = new System.Windows.Forms.RadioButton();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.btnAtenderDenuncias = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lbxTurnos = new System.Windows.Forms.ListBox();
            this.btnAtenderClientes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExportarTickets = new System.Windows.Forms.Button();
            this.btnImportarVehiculos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.tbPatente);
            this.groupBox2.Controls.Add(this.rbNuevoCliente);
            this.groupBox2.Controls.Add(this.rbDenuncia);
            this.groupBox2.Controls.Add(this.cbTipoVehiculo);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 123);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(154, 44);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(171, 26);
            this.tbPatente.TabIndex = 8;
            this.tbPatente.Text = "patente";
            // 
            // rbNuevoCliente
            // 
            this.rbNuevoCliente.AutoSize = true;
            this.rbNuevoCliente.Location = new System.Drawing.Point(6, 89);
            this.rbNuevoCliente.Name = "rbNuevoCliente";
            this.rbNuevoCliente.Size = new System.Drawing.Size(125, 24);
            this.rbNuevoCliente.TabIndex = 6;
            this.rbNuevoCliente.TabStop = true;
            this.rbNuevoCliente.Text = "Nuevo Cliente";
            this.rbNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // rbDenuncia
            // 
            this.rbDenuncia.AutoSize = true;
            this.rbDenuncia.Location = new System.Drawing.Point(6, 46);
            this.rbDenuncia.Name = "rbDenuncia";
            this.rbDenuncia.Size = new System.Drawing.Size(95, 24);
            this.rbDenuncia.TabIndex = 5;
            this.rbDenuncia.TabStop = true;
            this.rbDenuncia.Text = "Denuncia";
            this.rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "1- Auto",
            "2- Moto",
            "3-Equipo de trabajo",
            "4- Bicicleta",
            ""});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(152, 85);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(106, 28);
            this.cbTipoVehiculo.TabIndex = 4;
            this.cbTipoVehiculo.Text = "TipoVehiculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(66, 8);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(165, 26);
            this.tbDNI.TabIndex = 0;
            // 
            // btnAtenderDenuncias
            // 
            this.btnAtenderDenuncias.Location = new System.Drawing.Point(12, 311);
            this.btnAtenderDenuncias.Name = "btnAtenderDenuncias";
            this.btnAtenderDenuncias.Size = new System.Drawing.Size(110, 55);
            this.btnAtenderDenuncias.TabIndex = 14;
            this.btnAtenderDenuncias.Text = "Atender Denuncias";
            this.btnAtenderDenuncias.UseVisualStyleBackColor = true;
            this.btnAtenderDenuncias.Click += new System.EventHandler(this.btnAtenderDenuncias_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(349, 50);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(98, 113);
            this.btnTicket.TabIndex = 16;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // lbxTurnos
            // 
            this.lbxTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTurnos.FormattingEnabled = true;
            this.lbxTurnos.ItemHeight = 16;
            this.lbxTurnos.Location = new System.Drawing.Point(12, 201);
            this.lbxTurnos.Name = "lbxTurnos";
            this.lbxTurnos.Size = new System.Drawing.Size(331, 100);
            this.lbxTurnos.TabIndex = 15;
            // 
            // btnAtenderClientes
            // 
            this.btnAtenderClientes.Location = new System.Drawing.Point(128, 311);
            this.btnAtenderClientes.Name = "btnAtenderClientes";
            this.btnAtenderClientes.Size = new System.Drawing.Size(117, 55);
            this.btnAtenderClientes.TabIndex = 17;
            this.btnAtenderClientes.Text = "Atender Nuevo Cliente";
            this.btnAtenderClientes.UseVisualStyleBackColor = true;
            this.btnAtenderClientes.Click += new System.EventHandler(this.btnAtenderClientes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Turnos";
            // 
            // btnExportarTickets
            // 
            this.btnExportarTickets.Location = new System.Drawing.Point(349, 201);
            this.btnExportarTickets.Name = "btnExportarTickets";
            this.btnExportarTickets.Size = new System.Drawing.Size(98, 55);
            this.btnExportarTickets.TabIndex = 18;
            this.btnExportarTickets.Text = "Exportar tickets";
            this.btnExportarTickets.UseVisualStyleBackColor = true;
            this.btnExportarTickets.Click += new System.EventHandler(this.btnExportarTickets_Click);
            // 
            // btnImportarVehiculos
            // 
            this.btnImportarVehiculos.Location = new System.Drawing.Point(349, 262);
            this.btnImportarVehiculos.Name = "btnImportarVehiculos";
            this.btnImportarVehiculos.Size = new System.Drawing.Size(98, 55);
            this.btnImportarVehiculos.TabIndex = 19;
            this.btnImportarVehiculos.Text = "Importar vehiculos";
            this.btnImportarVehiculos.UseVisualStyleBackColor = true;
            this.btnImportarVehiculos.Click += new System.EventHandler(this.btnImportarVehiculos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 370);
            this.Controls.Add(this.btnImportarVehiculos);
            this.Controls.Add(this.btnExportarTickets);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAtenderClientes);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxTurnos);
            this.Controls.Add(this.btnAtenderDenuncias);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAtenderDenuncias;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.RadioButton rbNuevoCliente;
        private System.Windows.Forms.RadioButton rbDenuncia;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.ListBox lbxTurnos;
        private System.Windows.Forms.Button btnAtenderClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportarTickets;
        private System.Windows.Forms.Button btnImportarVehiculos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

