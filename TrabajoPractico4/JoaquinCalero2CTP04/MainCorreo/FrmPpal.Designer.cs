namespace MainCorreo
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.lstBxIngresado = new System.Windows.Forms.ListBox();
            this.lstBxEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.mostrarToolStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.grpBxEstados = new System.Windows.Forms.GroupBox();
            this.rchtxtBx = new System.Windows.Forms.RichTextBox();
            this.grpBxPaquete = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBxDireccion = new System.Windows.Forms.TextBox();
            this.mskdTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTrackingId = new System.Windows.Forms.Label();
            this.mostrarToolStripMenu.SuspendLayout();
            this.grpBxEstados.SuspendLayout();
            this.grpBxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxIngresado
            // 
            this.lstBxIngresado.FormattingEnabled = true;
            this.lstBxIngresado.Location = new System.Drawing.Point(13, 43);
            this.lstBxIngresado.Name = "lstBxIngresado";
            this.lstBxIngresado.Size = new System.Drawing.Size(206, 238);
            this.lstBxIngresado.TabIndex = 0;
            // 
            // lstBxEnViaje
            // 
            this.lstBxEnViaje.FormattingEnabled = true;
            this.lstBxEnViaje.Location = new System.Drawing.Point(274, 43);
            this.lstBxEnViaje.Name = "lstBxEnViaje";
            this.lstBxEnViaje.Size = new System.Drawing.Size(206, 238);
            this.lstBxEnViaje.TabIndex = 1;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.mostrarToolStripMenu;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(535, 43);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(206, 238);
            this.lstEstadoEntregado.TabIndex = 2;
            // 
            // mostrarToolStripMenu
            // 
            this.mostrarToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.mostrarToolStripMenu.Name = "cntxtMenuStripEntregados";
            this.mostrarToolStripMenu.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(10, 27);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblIngresado.TabIndex = 3;
            this.lblIngresado.Text = "Ingresado";
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(271, 27);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEnViaje.TabIndex = 4;
            this.lblEnViaje.Text = "En Viaje";
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(532, 27);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 5;
            this.lblEntregado.Text = "Entregado";
            // 
            // grpBxEstados
            // 
            this.grpBxEstados.Controls.Add(this.lblEntregado);
            this.grpBxEstados.Controls.Add(this.lblEnViaje);
            this.grpBxEstados.Controls.Add(this.lblIngresado);
            this.grpBxEstados.Controls.Add(this.lstEstadoEntregado);
            this.grpBxEstados.Controls.Add(this.lstBxEnViaje);
            this.grpBxEstados.Controls.Add(this.lstBxIngresado);
            this.grpBxEstados.Location = new System.Drawing.Point(12, 12);
            this.grpBxEstados.Name = "grpBxEstados";
            this.grpBxEstados.Size = new System.Drawing.Size(776, 302);
            this.grpBxEstados.TabIndex = 6;
            this.grpBxEstados.TabStop = false;
            this.grpBxEstados.Text = "Estados Paquetes";
            // 
            // rchtxtBx
            // 
            this.rchtxtBx.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rchtxtBx.Location = new System.Drawing.Point(12, 320);
            this.rchtxtBx.Name = "rchtxtBx";
            this.rchtxtBx.ReadOnly = true;
            this.rchtxtBx.Size = new System.Drawing.Size(437, 149);
            this.rchtxtBx.TabIndex = 6;
            this.rchtxtBx.Text = "";
            // 
            // grpBxPaquete
            // 
            this.grpBxPaquete.Controls.Add(this.btnMostrarTodos);
            this.grpBxPaquete.Controls.Add(this.btnAgregar);
            this.grpBxPaquete.Controls.Add(this.txtBxDireccion);
            this.grpBxPaquete.Controls.Add(this.mskdTxtBx);
            this.grpBxPaquete.Controls.Add(this.lblDireccion);
            this.grpBxPaquete.Controls.Add(this.lblTrackingId);
            this.grpBxPaquete.Location = new System.Drawing.Point(460, 320);
            this.grpBxPaquete.Name = "grpBxPaquete";
            this.grpBxPaquete.Size = new System.Drawing.Size(327, 149);
            this.grpBxPaquete.TabIndex = 7;
            this.grpBxPaquete.TabStop = false;
            this.grpBxPaquete.Text = "Paquete";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(218, 85);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(103, 36);
            this.btnMostrarTodos.TabIndex = 11;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(218, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 36);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBxDireccion
            // 
            this.txtBxDireccion.Location = new System.Drawing.Point(6, 101);
            this.txtBxDireccion.Name = "txtBxDireccion";
            this.txtBxDireccion.Size = new System.Drawing.Size(199, 20);
            this.txtBxDireccion.TabIndex = 9;
            // 
            // mskdTxtBx
            // 
            this.mskdTxtBx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskdTxtBx.Location = new System.Drawing.Point(6, 49);
            this.mskdTxtBx.Mask = "000-000-0000";
            this.mskdTxtBx.Name = "mskdTxtBx";
            this.mskdTxtBx.Size = new System.Drawing.Size(199, 20);
            this.mskdTxtBx.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 85);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTrackingId
            // 
            this.lblTrackingId.AutoSize = true;
            this.lblTrackingId.Location = new System.Drawing.Point(6, 33);
            this.lblTrackingId.Name = "lblTrackingId";
            this.lblTrackingId.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingId.TabIndex = 6;
            this.lblTrackingId.Text = "Tracking ID";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.grpBxPaquete);
            this.Controls.Add(this.rchtxtBx);
            this.Controls.Add(this.grpBxEstados);
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN por Joaquin.Calero.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.mostrarToolStripMenu.ResumeLayout(false);
            this.grpBxEstados.ResumeLayout(false);
            this.grpBxEstados.PerformLayout();
            this.grpBxPaquete.ResumeLayout(false);
            this.grpBxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxIngresado;
        private System.Windows.Forms.ListBox lstBxEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.GroupBox grpBxEstados;
        private System.Windows.Forms.RichTextBox rchtxtBx;
        private System.Windows.Forms.GroupBox grpBxPaquete;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBxDireccion;
        private System.Windows.Forms.MaskedTextBox mskdTxtBx;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTrackingId;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ContextMenuStrip mostrarToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

