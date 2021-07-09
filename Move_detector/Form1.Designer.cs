namespace Scan0_C_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hScrollBarRojo = new System.Windows.Forms.HScrollBar();
            this.hScrollBarVerde = new System.Windows.Forms.HScrollBar();
            this.hScrollBarAzul = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxNotification = new System.Windows.Forms.CheckBox();
            this.trackBarSensibility = new System.Windows.Forms.TrackBar();
            this.labelPorcent = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxNotification = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensibility)).BeginInit();
            this.groupBoxNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(544, 21);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(112, 40);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Iniciar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Image = global::Scan0_C_.Properties.Resources.Lena;
            this.PictureBox1.Location = new System.Drawing.Point(12, 21);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(500, 500);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Parar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Formato de video";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(708, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Origen de video";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo frame";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600"});
            this.comboBox2.Location = new System.Drawing.Point(634, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resolución";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(751, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 21);
            this.button5.TabIndex = 11;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(634, 159);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rojo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Verde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Azul";
            // 
            // hScrollBarRojo
            // 
            this.hScrollBarRojo.Location = new System.Drawing.Point(73, 43);
            this.hScrollBarRojo.Maximum = 255;
            this.hScrollBarRojo.Minimum = 1;
            this.hScrollBarRojo.Name = "hScrollBarRojo";
            this.hScrollBarRojo.Size = new System.Drawing.Size(166, 19);
            this.hScrollBarRojo.TabIndex = 18;
            this.hScrollBarRojo.Value = 35;
            this.hScrollBarRojo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBarVerde
            // 
            this.hScrollBarVerde.Location = new System.Drawing.Point(73, 77);
            this.hScrollBarVerde.Maximum = 255;
            this.hScrollBarVerde.Minimum = 1;
            this.hScrollBarVerde.Name = "hScrollBarVerde";
            this.hScrollBarVerde.Size = new System.Drawing.Size(166, 19);
            this.hScrollBarVerde.TabIndex = 19;
            this.hScrollBarVerde.Value = 35;
            this.hScrollBarVerde.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBarAzul
            // 
            this.hScrollBarAzul.Location = new System.Drawing.Point(73, 109);
            this.hScrollBarAzul.Maximum = 255;
            this.hScrollBarAzul.Minimum = 1;
            this.hScrollBarAzul.Name = "hScrollBarAzul";
            this.hScrollBarAzul.Size = new System.Drawing.Size(166, 19);
            this.hScrollBarAzul.TabIndex = 20;
            this.hScrollBarAzul.Value = 35;
            this.hScrollBarAzul.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hScrollBarAzul);
            this.groupBox1.Controls.Add(this.hScrollBarVerde);
            this.groupBox1.Controls.Add(this.hScrollBarRojo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(544, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 170);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Umbrales detección";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Imagen original";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxNotification
            // 
            this.checkBoxNotification.AutoSize = true;
            this.checkBoxNotification.Location = new System.Drawing.Point(546, 433);
            this.checkBoxNotification.Name = "checkBoxNotification";
            this.checkBoxNotification.Size = new System.Drawing.Size(163, 17);
            this.checkBoxNotification.TabIndex = 28;
            this.checkBoxNotification.Text = "Activar Notificacion Por SMS";
            this.checkBoxNotification.UseVisualStyleBackColor = true;
            this.checkBoxNotification.CheckedChanged += new System.EventHandler(this.checkBoxNotification_CheckedChanged);
            // 
            // trackBarSensibility
            // 
            this.trackBarSensibility.Location = new System.Drawing.Point(12, 556);
            this.trackBarSensibility.Name = "trackBarSensibility";
            this.trackBarSensibility.Size = new System.Drawing.Size(265, 45);
            this.trackBarSensibility.TabIndex = 29;
            this.trackBarSensibility.Value = 5;
            this.trackBarSensibility.Scroll += new System.EventHandler(this.trackBarSensibility_Scroll);
            // 
            // labelPorcent
            // 
            this.labelPorcent.AutoSize = true;
            this.labelPorcent.Location = new System.Drawing.Point(283, 560);
            this.labelPorcent.Name = "labelPorcent";
            this.labelPorcent.Size = new System.Drawing.Size(30, 13);
            this.labelPorcent.TabIndex = 30;
            this.labelPorcent.Text = "% 50";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ajustar Sensibilidad";
            // 
            // groupBoxNotification
            // 
            this.groupBoxNotification.Controls.Add(this.buttonAplicar);
            this.groupBoxNotification.Controls.Add(this.textBoxPhone);
            this.groupBoxNotification.Controls.Add(this.textBoxPort);
            this.groupBoxNotification.Controls.Add(this.label14);
            this.groupBoxNotification.Controls.Add(this.label13);
            this.groupBoxNotification.Location = new System.Drawing.Point(535, 456);
            this.groupBoxNotification.Name = "groupBoxNotification";
            this.groupBoxNotification.Size = new System.Drawing.Size(285, 84);
            this.groupBoxNotification.TabIndex = 32;
            this.groupBoxNotification.TabStop = false;
            this.groupBoxNotification.Text = "Configuracion De Notificacion";
            this.groupBoxNotification.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Puerto COM";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Telefono";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(77, 23);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 2;
            this.textBoxPort.Text = "COM4";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(77, 52);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.Text = "2223841973";
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(192, 23);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(84, 55);
            this.buttonAplicar.TabIndex = 4;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 604);
            this.Controls.Add(this.groupBoxNotification);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelPorcent);
            this.Controls.Add(this.trackBarSensibility);
            this.Controls.Add(this.checkBoxNotification);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Motion Detector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensibility)).EndInit();
            this.groupBoxNotification.ResumeLayout(false);
            this.groupBoxNotification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hScrollBarRojo;
        private System.Windows.Forms.HScrollBar hScrollBarVerde;
        private System.Windows.Forms.HScrollBar hScrollBarAzul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxNotification;
        private System.Windows.Forms.TrackBar trackBarSensibility;
        private System.Windows.Forms.Label labelPorcent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxNotification;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonAplicar;
    }
}

