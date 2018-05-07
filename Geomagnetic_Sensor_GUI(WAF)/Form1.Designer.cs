namespace Geomagnetic_Sensor_GUI_WAF_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel4 = new System.Windows.Forms.Panel();
            this.about_panel = new System.Windows.Forms.Panel();
            this.config_btn = new System.Windows.Forms.Button();
            this.real_deal_btn = new System.Windows.Forms.Button();
            this.about_btn = new System.Windows.Forms.Button();
            this.btns_panel = new System.Windows.Forms.Panel();
            this.real_deal_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationChar = new System.Windows.Forms.TextBox();
            this.Viaje = new System.Windows.Forms.Button();
            this.PathConsole = new System.Windows.Forms.TextBox();
            this.cols_label = new System.Windows.Forms.Label();
            this.rows_label = new System.Windows.Forms.Label();
            this.cols_txtbx = new System.Windows.Forms.TextBox();
            this.rows_txtbx = new System.Windows.Forms.TextBox();
            this.Inicializar_sesion_real_deal = new System.Windows.Forms.Button();
            this.real_dea_console_lbl = new System.Windows.Forms.Label();
            this.consoleTxt_box = new System.Windows.Forms.TextBox();
            this.config_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ArduinoCOMBOX = new System.Windows.Forms.ComboBox();
            this.Status_Port = new System.Windows.Forms.Label();
            this.OpenPort_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptCOM_Btn = new System.Windows.Forms.Button();
            this.GetPortBtn = new System.Windows.Forms.Button();
            this.EnterCOMTxtB = new System.Windows.Forms.TextBox();
            this.GetPortTxtB = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.panel4.SuspendLayout();
            this.btns_panel.SuspendLayout();
            this.real_deal_panel.SuspendLayout();
            this.config_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.about_panel);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 122);
            this.panel4.TabIndex = 3;
            // 
            // about_panel
            // 
            this.about_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.about_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.about_panel.Location = new System.Drawing.Point(201, 3);
            this.about_panel.Name = "about_panel";
            this.about_panel.Size = new System.Drawing.Size(789, 535);
            this.about_panel.TabIndex = 7;
            // 
            // config_btn
            // 
            this.config_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.config_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.config_btn.Location = new System.Drawing.Point(0, 268);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(200, 100);
            this.config_btn.TabIndex = 4;
            this.config_btn.Text = "Configuration";
            this.config_btn.UseVisualStyleBackColor = false;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // real_deal_btn
            // 
            this.real_deal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.real_deal_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.real_deal_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.real_deal_btn.Location = new System.Drawing.Point(0, 137);
            this.real_deal_btn.Name = "real_deal_btn";
            this.real_deal_btn.Size = new System.Drawing.Size(200, 100);
            this.real_deal_btn.TabIndex = 5;
            this.real_deal_btn.Text = "Main";
            this.real_deal_btn.UseVisualStyleBackColor = false;
            this.real_deal_btn.Click += new System.EventHandler(this.real_deal_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.about_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.about_btn.Location = new System.Drawing.Point(0, 404);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(200, 100);
            this.about_btn.TabIndex = 6;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Visible = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // btns_panel
            // 
            this.btns_panel.AllowDrop = true;
            this.btns_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btns_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btns_panel.Controls.Add(this.panel4);
            this.btns_panel.Controls.Add(this.about_btn);
            this.btns_panel.Controls.Add(this.config_btn);
            this.btns_panel.Controls.Add(this.real_deal_btn);
            this.btns_panel.Location = new System.Drawing.Point(0, 0);
            this.btns_panel.Name = "btns_panel";
            this.btns_panel.Size = new System.Drawing.Size(206, 551);
            this.btns_panel.TabIndex = 7;
            // 
            // real_deal_panel
            // 
            this.real_deal_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.real_deal_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.real_deal_panel.Controls.Add(this.label3);
            this.real_deal_panel.Controls.Add(this.destinationChar);
            this.real_deal_panel.Controls.Add(this.Viaje);
            this.real_deal_panel.Controls.Add(this.PathConsole);
            this.real_deal_panel.Controls.Add(this.cols_label);
            this.real_deal_panel.Controls.Add(this.rows_label);
            this.real_deal_panel.Controls.Add(this.cols_txtbx);
            this.real_deal_panel.Controls.Add(this.rows_txtbx);
            this.real_deal_panel.Controls.Add(this.Inicializar_sesion_real_deal);
            this.real_deal_panel.Controls.Add(this.real_dea_console_lbl);
            this.real_deal_panel.Controls.Add(this.consoleTxt_box);
            this.real_deal_panel.Location = new System.Drawing.Point(207, 0);
            this.real_deal_panel.Name = "real_deal_panel";
            this.real_deal_panel.Size = new System.Drawing.Size(795, 551);
            this.real_deal_panel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(249, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destination";
            // 
            // destinationChar
            // 
            this.destinationChar.Location = new System.Drawing.Point(278, 477);
            this.destinationChar.Name = "destinationChar";
            this.destinationChar.Size = new System.Drawing.Size(33, 20);
            this.destinationChar.TabIndex = 9;
            // 
            // Viaje
            // 
            this.Viaje.Location = new System.Drawing.Point(61, 475);
            this.Viaje.Name = "Viaje";
            this.Viaje.Size = new System.Drawing.Size(75, 23);
            this.Viaje.TabIndex = 8;
            this.Viaje.Text = "journey";
            this.Viaje.UseVisualStyleBackColor = true;
            this.Viaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathConsole
            // 
            this.PathConsole.Location = new System.Drawing.Point(34, 294);
            this.PathConsole.Multiline = true;
            this.PathConsole.Name = "PathConsole";
            this.PathConsole.Size = new System.Drawing.Size(530, 157);
            this.PathConsole.TabIndex = 7;
            // 
            // cols_label
            // 
            this.cols_label.AutoSize = true;
            this.cols_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cols_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cols_label.Location = new System.Drawing.Point(588, 107);
            this.cols_label.Name = "cols_label";
            this.cols_label.Size = new System.Drawing.Size(69, 17);
            this.cols_label.TabIndex = 6;
            this.cols_label.Text = "Columns";
            // 
            // rows_label
            // 
            this.rows_label.AutoSize = true;
            this.rows_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rows_label.Location = new System.Drawing.Point(588, 30);
            this.rows_label.Name = "rows_label";
            this.rows_label.Size = new System.Drawing.Size(46, 17);
            this.rows_label.TabIndex = 5;
            this.rows_label.Text = "Rows";
            // 
            // cols_txtbx
            // 
            this.cols_txtbx.Location = new System.Drawing.Point(588, 130);
            this.cols_txtbx.Name = "cols_txtbx";
            this.cols_txtbx.ReadOnly = true;
            this.cols_txtbx.Size = new System.Drawing.Size(100, 20);
            this.cols_txtbx.TabIndex = 4;
            this.cols_txtbx.Text = "3";
            this.cols_txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rows_txtbx
            // 
            this.rows_txtbx.Location = new System.Drawing.Point(588, 64);
            this.rows_txtbx.Name = "rows_txtbx";
            this.rows_txtbx.ReadOnly = true;
            this.rows_txtbx.Size = new System.Drawing.Size(100, 20);
            this.rows_txtbx.TabIndex = 3;
            this.rows_txtbx.Text = "3";
            this.rows_txtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inicializar_sesion_real_deal
            // 
            this.Inicializar_sesion_real_deal.Location = new System.Drawing.Point(34, 238);
            this.Inicializar_sesion_real_deal.Name = "Inicializar_sesion_real_deal";
            this.Inicializar_sesion_real_deal.Size = new System.Drawing.Size(95, 23);
            this.Inicializar_sesion_real_deal.TabIndex = 2;
            this.Inicializar_sesion_real_deal.Text = "Init Comm";
            this.Inicializar_sesion_real_deal.UseVisualStyleBackColor = true;
            this.Inicializar_sesion_real_deal.Click += new System.EventHandler(this.Inicializar_sesion_real_deal_Click);
            // 
            // real_dea_console_lbl
            // 
            this.real_dea_console_lbl.AutoSize = true;
            this.real_dea_console_lbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.real_dea_console_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.real_dea_console_lbl.Location = new System.Drawing.Point(34, 27);
            this.real_dea_console_lbl.Name = "real_dea_console_lbl";
            this.real_dea_console_lbl.Size = new System.Drawing.Size(121, 32);
            this.real_dea_console_lbl.TabIndex = 1;
            this.real_dea_console_lbl.Text = "Console";
            // 
            // consoleTxt_box
            // 
            this.consoleTxt_box.Location = new System.Drawing.Point(34, 61);
            this.consoleTxt_box.Multiline = true;
            this.consoleTxt_box.Name = "consoleTxt_box";
            this.consoleTxt_box.Size = new System.Drawing.Size(530, 157);
            this.consoleTxt_box.TabIndex = 0;
            this.consoleTxt_box.Text = " ";
            // 
            // config_panel
            // 
            this.config_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.config_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.config_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.config_panel.Controls.Add(this.label2);
            this.config_panel.Controls.Add(this.ArduinoCOMBOX);
            this.config_panel.Controls.Add(this.Status_Port);
            this.config_panel.Controls.Add(this.OpenPort_Status);
            this.config_panel.Controls.Add(this.label1);
            this.config_panel.Controls.Add(this.AcceptCOM_Btn);
            this.config_panel.Controls.Add(this.GetPortBtn);
            this.config_panel.Controls.Add(this.EnterCOMTxtB);
            this.config_panel.Controls.Add(this.GetPortTxtB);
            this.config_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.config_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.config_panel.Location = new System.Drawing.Point(207, 0);
            this.config_panel.Name = "config_panel";
            this.config_panel.Size = new System.Drawing.Size(795, 548);
            this.config_panel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(493, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ArduinoCOMport";
            // 
            // ArduinoCOMBOX
            // 
            this.ArduinoCOMBOX.FormattingEnabled = true;
            this.ArduinoCOMBOX.Location = new System.Drawing.Point(493, 80);
            this.ArduinoCOMBOX.Name = "ArduinoCOMBOX";
            this.ArduinoCOMBOX.Size = new System.Drawing.Size(121, 24);
            this.ArduinoCOMBOX.TabIndex = 7;
            // 
            // Status_Port
            // 
            this.Status_Port.AutoSize = true;
            this.Status_Port.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Status_Port.Location = new System.Drawing.Point(426, 195);
            this.Status_Port.Name = "Status_Port";
            this.Status_Port.Size = new System.Drawing.Size(42, 17);
            this.Status_Port.TabIndex = 6;
            this.Status_Port.Text = "None";
            // 
            // OpenPort_Status
            // 
            this.OpenPort_Status.AutoSize = true;
            this.OpenPort_Status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenPort_Status.Location = new System.Drawing.Point(368, 195);
            this.OpenPort_Status.Name = "OpenPort_Status";
            this.OpenPort_Status.Size = new System.Drawing.Size(52, 17);
            this.OpenPort_Status.TabIndex = 5;
            this.OpenPort_Status.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(302, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sensor COM Port";
            // 
            // AcceptCOM_Btn
            // 
            this.AcceptCOM_Btn.Location = new System.Drawing.Point(402, 152);
            this.AcceptCOM_Btn.Name = "AcceptCOM_Btn";
            this.AcceptCOM_Btn.Size = new System.Drawing.Size(75, 23);
            this.AcceptCOM_Btn.TabIndex = 3;
            this.AcceptCOM_Btn.Text = "Accept";
            this.AcceptCOM_Btn.UseVisualStyleBackColor = true;
            this.AcceptCOM_Btn.Click += new System.EventHandler(this.AcceptCOM_Btn_Click);
            // 
            // GetPortBtn
            // 
            this.GetPortBtn.Location = new System.Drawing.Point(24, 163);
            this.GetPortBtn.Name = "GetPortBtn";
            this.GetPortBtn.Size = new System.Drawing.Size(187, 23);
            this.GetPortBtn.TabIndex = 2;
            this.GetPortBtn.Text = "Get Port List";
            this.GetPortBtn.UseVisualStyleBackColor = true;
            this.GetPortBtn.Click += new System.EventHandler(this.GetPortBtn_Click);
            // 
            // EnterCOMTxtB
            // 
            this.EnterCOMTxtB.Location = new System.Drawing.Point(313, 79);
            this.EnterCOMTxtB.Name = "EnterCOMTxtB";
            this.EnterCOMTxtB.Size = new System.Drawing.Size(100, 23);
            this.EnterCOMTxtB.TabIndex = 1;
            // 
            // GetPortTxtB
            // 
            this.GetPortTxtB.Location = new System.Drawing.Point(24, 80);
            this.GetPortTxtB.Multiline = true;
            this.GetPortTxtB.Name = "GetPortTxtB";
            this.GetPortTxtB.ReadOnly = true;
            this.GetPortTxtB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GetPortTxtB.Size = new System.Drawing.Size(217, 73);
            this.GetPortTxtB.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Arduino
            // 
            this.Arduino.PortName = "COM6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1002, 551);
            this.Controls.Add(this.btns_panel);
            this.Controls.Add(this.real_deal_panel);
            this.Controls.Add(this.config_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel4.ResumeLayout(false);
            this.btns_panel.ResumeLayout(false);
            this.real_deal_panel.ResumeLayout(false);
            this.real_deal_panel.PerformLayout();
            this.config_panel.ResumeLayout(false);
            this.config_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button config_btn;
		private System.Windows.Forms.Button real_deal_btn;
		private System.Windows.Forms.Button about_btn;
		private System.Windows.Forms.Panel btns_panel;
		private System.Windows.Forms.Panel config_panel;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Diagnostics.EventLog eventLog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AcceptCOM_Btn;
		private System.Windows.Forms.Button GetPortBtn;
		private System.Windows.Forms.TextBox EnterCOMTxtB;
		private System.Windows.Forms.TextBox GetPortTxtB;
		private System.Windows.Forms.Label Status_Port;
		private System.Windows.Forms.Label OpenPort_Status;
		private System.Windows.Forms.Panel real_deal_panel;
		private System.Windows.Forms.Label cols_label;
		private System.Windows.Forms.Label rows_label;
		private System.Windows.Forms.TextBox cols_txtbx;
		private System.Windows.Forms.TextBox rows_txtbx;
		private System.Windows.Forms.Button Inicializar_sesion_real_deal;
		private System.Windows.Forms.Label real_dea_console_lbl;
		private System.Windows.Forms.TextBox consoleTxt_box;
		private System.Windows.Forms.Panel about_panel;
		private System.Windows.Forms.ComboBox ArduinoCOMBOX;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.TextBox PathConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Viaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinationChar;
    }
}

