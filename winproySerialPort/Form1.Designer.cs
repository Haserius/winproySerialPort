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
            this.rchMensajes = new System.Windows.Forms.RichTextBox();
            this.rchConversacion = new System.Windows.Forms.RichTextBox();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.cbmPuerto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prgEnvio = new System.Windows.Forms.ProgressBar();
            this.nudBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParametros = new System.Windows.Forms.GroupBox();
            this.btnCerrarPuerto = new System.Windows.Forms.Button();
            this.btnEnviarArchivo = new System.Windows.Forms.Button();
            this.btnBuildFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).BeginInit();
            this.grpParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(83, 257);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(158, 32);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "ENVIAR MENSAJE";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rchMensajes
            // 
            this.rchMensajes.Location = new System.Drawing.Point(9, 216);
            this.rchMensajes.Name = "rchMensajes";
            this.rchMensajes.Size = new System.Drawing.Size(365, 98);
            this.rchMensajes.TabIndex = 1;
            this.rchMensajes.Text = "";
            // 
            // rchConversacion
            // 
            this.rchConversacion.Location = new System.Drawing.Point(9, 19);
            this.rchConversacion.Name = "rchConversacion";
            this.rchConversacion.Size = new System.Drawing.Size(365, 191);
            this.rchConversacion.TabIndex = 2;
            this.rchConversacion.Text = "";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(422, 401);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(146, 23);
            this.btnRecibir.TabIndex = 3;
            this.btnRecibir.Text = "RECIBIR MENSAJE";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Visible = false;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
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
            this.cbmPuerto.Location = new System.Drawing.Point(189, 82);
            this.cbmPuerto.Name = "cbmPuerto";
            this.cbmPuerto.Size = new System.Drawing.Size(121, 28);
            this.cbmPuerto.TabIndex = 5;
            this.cbmPuerto.SelectedIndexChanged += new System.EventHandler(this.cbmPuerto_SelectedIndexChanged);
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
            this.groupBox1.Controls.Add(this.rchConversacion);
            this.groupBox1.Controls.Add(this.rchMensajes);
            this.groupBox1.Location = new System.Drawing.Point(373, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
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
            // prgEnvio
            // 
            this.prgEnvio.Location = new System.Drawing.Point(57, 401);
            this.prgEnvio.Maximum = 1024;
            this.prgEnvio.Name = "prgEnvio";
            this.prgEnvio.Size = new System.Drawing.Size(238, 23);
            this.prgEnvio.Step = 1;
            this.prgEnvio.TabIndex = 10;
            // 
            // nudBaudRate
            // 
            this.nudBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBaudRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBaudRate.Location = new System.Drawing.Point(189, 40);
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
            this.nudBaudRate.Size = new System.Drawing.Size(120, 26);
            this.nudBaudRate.TabIndex = 11;
            this.nudBaudRate.Value = new decimal(new int[] {
            57600,
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
            this.grpParametros.Location = new System.Drawing.Point(12, 12);
            this.grpParametros.Name = "grpParametros";
            this.grpParametros.Size = new System.Drawing.Size(354, 129);
            this.grpParametros.TabIndex = 12;
            this.grpParametros.TabStop = false;
            this.grpParametros.Text = "Parametros";
            // 
            // btnCerrarPuerto
            // 
            this.btnCerrarPuerto.Enabled = false;
            this.btnCerrarPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPuerto.Location = new System.Drawing.Point(83, 220);
            this.btnCerrarPuerto.Name = "btnCerrarPuerto";
            this.btnCerrarPuerto.Size = new System.Drawing.Size(158, 31);
            this.btnCerrarPuerto.TabIndex = 12;
            this.btnCerrarPuerto.Text = "CERRAR PUERTO";
            this.btnCerrarPuerto.UseVisualStyleBackColor = true;
            this.btnCerrarPuerto.Click += new System.EventHandler(this.btmCerrarPuerto_Click);
            // 
            // btnEnviarArchivo
            // 
            this.btnEnviarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarArchivo.Location = new System.Drawing.Point(83, 295);
            this.btnEnviarArchivo.Name = "btnEnviarArchivo";
            this.btnEnviarArchivo.Size = new System.Drawing.Size(158, 32);
            this.btnEnviarArchivo.TabIndex = 13;
            this.btnEnviarArchivo.Text = "ENVIAR ARCHIVO";
            this.btnEnviarArchivo.UseVisualStyleBackColor = true;
            this.btnEnviarArchivo.Click += new System.EventHandler(this.btnEnviarArchivo_Click);
            // 
            // btnBuildFile
            // 
            this.btnBuildFile.Location = new System.Drawing.Point(201, 165);
            this.btnBuildFile.Name = "btnBuildFile";
            this.btnBuildFile.Size = new System.Drawing.Size(130, 23);
            this.btnBuildFile.TabIndex = 14;
            this.btnBuildFile.Text = "Construir Archivo";
            this.btnBuildFile.UseVisualStyleBackColor = true;
            this.btnBuildFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 341);
            this.Controls.Add(this.btnBuildFile);
            this.Controls.Add(this.btnEnviarArchivo);
            this.Controls.Add(this.btnCerrarPuerto);
            this.Controls.Add(this.grpParametros);
            this.Controls.Add(this.prgEnvio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Delgado Rodríguez Luis Guillermo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).EndInit();
            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rchMensajes;
        private System.Windows.Forms.RichTextBox rchConversacion;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.ComboBox cbmPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prgEnvio;
        private System.Windows.Forms.NumericUpDown nudBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.Button btnCerrarPuerto;
        private System.Windows.Forms.Button btnEnviarArchivo;
        private System.Windows.Forms.Button btnBuildFile;
    }
}

