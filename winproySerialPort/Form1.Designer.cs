﻿namespace winproySerialPort
{
    partial class Form1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rchConversacion = new System.Windows.Forms.RichTextBox();
            this.cbmPuerto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rchMensajes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParametros = new System.Windows.Forms.GroupBox();
            this.btnCerrarPuerto = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.flpDescargando = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEnviando = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).BeginInit();
            this.grpParametros.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(90, 274);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(158, 32);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "ENVIAR MENSAJE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // rchConversacion
            // 
            this.rchConversacion.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchConversacion.Location = new System.Drawing.Point(9, 19);
            this.rchConversacion.Name = "rchConversacion";
            this.rchConversacion.ReadOnly = true;
            this.rchConversacion.Size = new System.Drawing.Size(365, 191);
            this.rchConversacion.TabIndex = 2;
            this.rchConversacion.Text = "";
            this.rchConversacion.TextChanged += new System.EventHandler(this.RchConversacion_TextChanged);
            // 
            // cbmPuerto
            // 
            this.cbmPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmPuerto.FormattingEnabled = true;
            this.cbmPuerto.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.cbmPuerto.Location = new System.Drawing.Point(199, 82);
            this.cbmPuerto.Name = "cbmPuerto";
            this.cbmPuerto.Size = new System.Drawing.Size(133, 28);
            this.cbmPuerto.TabIndex = 5;
            this.cbmPuerto.SelectedIndexChanged += new System.EventHandler(this.CbmPuerto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Puerto Comunicaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rchMensajes);
            this.groupBox1.Controls.Add(this.rchConversacion);
            this.groupBox1.Location = new System.Drawing.Point(363, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 315);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // rchMensajes
            // 
            this.rchMensajes.Location = new System.Drawing.Point(9, 216);
            this.rchMensajes.Name = "rchMensajes";
            this.rchMensajes.Size = new System.Drawing.Size(365, 93);
            this.rchMensajes.TabIndex = 1;
            this.rchMensajes.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Baud rate";
            // 
            // nudBaudRate
            // 
            this.nudBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBaudRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBaudRate.Location = new System.Drawing.Point(199, 40);
            this.nudBaudRate.Maximum = new decimal(new int[] {
            115700,
            0,
            0,
            0});
            this.nudBaudRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBaudRate.Name = "nudBaudRate";
            this.nudBaudRate.Size = new System.Drawing.Size(133, 26);
            this.nudBaudRate.TabIndex = 11;
            this.nudBaudRate.Value = new decimal(new int[] {
            115700,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            // 
            // grpParametros
            // 
            this.grpParametros.Controls.Add(this.cbmPuerto);
            this.grpParametros.Controls.Add(this.nudBaudRate);
            this.grpParametros.Controls.Add(this.label2);
            this.grpParametros.Controls.Add(this.label4);
            this.grpParametros.Location = new System.Drawing.Point(8, 25);
            this.grpParametros.Name = "grpParametros";
            this.grpParametros.Size = new System.Drawing.Size(347, 129);
            this.grpParametros.TabIndex = 12;
            this.grpParametros.TabStop = false;
            this.grpParametros.Text = "Parametros";
            // 
            // btnCerrarPuerto
            // 
            this.btnCerrarPuerto.Enabled = false;
            this.btnCerrarPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPuerto.Location = new System.Drawing.Point(90, 237);
            this.btnCerrarPuerto.Name = "btnCerrarPuerto";
            this.btnCerrarPuerto.Size = new System.Drawing.Size(158, 31);
            this.btnCerrarPuerto.TabIndex = 12;
            this.btnCerrarPuerto.Text = "CERRAR PUERTO";
            this.btnCerrarPuerto.UseVisualStyleBackColor = true;
            this.btnCerrarPuerto.Click += new System.EventHandler(this.BtnCerrarPuerto_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Enabled = false;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(90, 200);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(158, 31);
            this.btnSelectFile.TabIndex = 15;
            this.btnSelectFile.Text = "Seleccionar Archivo";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 377);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectFile);
            this.tabPage1.Controls.Add(this.grpParametros);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.btnCerrarPuerto);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transferencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(745, 327);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.flpEnviando);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(737, 301);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Enviando";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "ENVIANDO";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.flpDescargando);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(737, 301);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Descargando";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "DESCARGANDO";
            // 
            // flpDescargando
            // 
            this.flpDescargando.AutoScroll = true;
            this.flpDescargando.Location = new System.Drawing.Point(20, 40);
            this.flpDescargando.Margin = new System.Windows.Forms.Padding(1);
            this.flpDescargando.Name = "flpDescargando";
            this.flpDescargando.Size = new System.Drawing.Size(700, 257);
            this.flpDescargando.TabIndex = 13;
            // 
            // flpEnviando
            // 
            this.flpEnviando.AutoScroll = true;
            this.flpEnviando.Location = new System.Drawing.Point(20, 40);
            this.flpEnviando.Margin = new System.Windows.Forms.Padding(1);
            this.flpEnviando.Name = "flpEnviando";
            this.flpEnviando.Size = new System.Drawing.Size(700, 257);
            this.flpEnviando.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Los archivos que envías apareceran aquí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Los archivos que recibas apareceran aquí";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 401);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Delgado Rodríguez Luis Guillermo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).EndInit();
            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rchConversacion;
        private System.Windows.Forms.ComboBox cbmPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.Button btnCerrarPuerto;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RichTextBox rchMensajes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FlowLayoutPanel flpEnviando;
        private System.Windows.Forms.FlowLayoutPanel flpDescargando;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

