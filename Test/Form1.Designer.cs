namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_LoadPicture = new System.Windows.Forms.Button();
            this.textBox_Decel = new System.Windows.Forms.TextBox();
            this.textBox_Accel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Velocity = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button_BrakeOff = new System.Windows.Forms.Button();
            this.button_BrakeOn = new System.Windows.Forms.Button();
            this.button_ServoOn = new System.Windows.Forms.Button();
            this.button_SStop = new System.Windows.Forms.Button();
            this.button_EStop = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.textBox_pulse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Unit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Rel = new System.Windows.Forms.CheckBox();
            this.checkBox_Abs = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_EdgeThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_EdgeThreshold = new System.Windows.Forms.TrackBar();
            this.textBox_BinaryThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_BinaryThreshold = new System.Windows.Forms.TrackBar();
            this.pictureBox_EdgePicture = new System.Windows.Forms.PictureBox();
            this.button_UPP = new System.Windows.Forms.Button();
            this.pictureBox_BinaryPicture = new System.Windows.Forms.PictureBox();
            this.button_ToGray = new System.Windows.Forms.Button();
            this.pictureBox_OriginalPicture = new System.Windows.Forms.PictureBox();
            this.Load_Picture = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_EdgeThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BinaryThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EdgePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BinaryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LoadPicture
            // 
            this.button_LoadPicture.Location = new System.Drawing.Point(52, 197);
            this.button_LoadPicture.Name = "button_LoadPicture";
            this.button_LoadPicture.Size = new System.Drawing.Size(99, 23);
            this.button_LoadPicture.TabIndex = 82;
            this.button_LoadPicture.Text = "Load";
            this.button_LoadPicture.UseVisualStyleBackColor = true;
            this.button_LoadPicture.Click += new System.EventHandler(this.button_LoadPicture_Click);
            // 
            // textBox_Decel
            // 
            this.textBox_Decel.Location = new System.Drawing.Point(102, 310);
            this.textBox_Decel.Name = "textBox_Decel";
            this.textBox_Decel.Size = new System.Drawing.Size(64, 21);
            this.textBox_Decel.TabIndex = 81;
            this.textBox_Decel.TextChanged += new System.EventHandler(this.textBox_Decel_TextChanged);
            // 
            // textBox_Accel
            // 
            this.textBox_Accel.Location = new System.Drawing.Point(102, 283);
            this.textBox_Accel.Name = "textBox_Accel";
            this.textBox_Accel.Size = new System.Drawing.Size(64, 21);
            this.textBox_Accel.TabIndex = 80;
            this.textBox_Accel.TextChanged += new System.EventHandler(this.textBox_Accel_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 12);
            this.label13.TabIndex = 79;
            this.label13.Text = "Decel";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 78;
            this.label12.Text = "Accel";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 12);
            this.label11.TabIndex = 77;
            this.label11.Text = "Velocity";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox_Velocity
            // 
            this.textBox_Velocity.Location = new System.Drawing.Point(102, 252);
            this.textBox_Velocity.Name = "textBox_Velocity";
            this.textBox_Velocity.Size = new System.Drawing.Size(64, 21);
            this.textBox_Velocity.TabIndex = 73;
            this.textBox_Velocity.TextChanged += new System.EventHandler(this.textBox_Velocity_TextChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(718, 154);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 23);
            this.button10.TabIndex = 71;
            this.button10.Text = "Draw";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button_BrakeOff
            // 
            this.button_BrakeOff.Location = new System.Drawing.Point(779, 125);
            this.button_BrakeOff.Name = "button_BrakeOff";
            this.button_BrakeOff.Size = new System.Drawing.Size(54, 23);
            this.button_BrakeOff.TabIndex = 70;
            this.button_BrakeOff.Text = "OFF(Z)";
            this.button_BrakeOff.UseVisualStyleBackColor = true;
            this.button_BrakeOff.Click += new System.EventHandler(this.button_BrakeOff_Click);
            // 
            // button_BrakeOn
            // 
            this.button_BrakeOn.Location = new System.Drawing.Point(718, 125);
            this.button_BrakeOn.Name = "button_BrakeOn";
            this.button_BrakeOn.Size = new System.Drawing.Size(55, 23);
            this.button_BrakeOn.TabIndex = 69;
            this.button_BrakeOn.Text = "ON(Z)";
            this.button_BrakeOn.UseVisualStyleBackColor = true;
            this.button_BrakeOn.Click += new System.EventHandler(this.button_BrakeOn_Click);
            // 
            // button_ServoOn
            // 
            this.button_ServoOn.Location = new System.Drawing.Point(718, 38);
            this.button_ServoOn.Name = "button_ServoOn";
            this.button_ServoOn.Size = new System.Drawing.Size(115, 23);
            this.button_ServoOn.TabIndex = 68;
            this.button_ServoOn.Text = "Servo On";
            this.button_ServoOn.UseVisualStyleBackColor = true;
            this.button_ServoOn.Click += new System.EventHandler(this.button_ServoOn_Click);
            // 
            // button_SStop
            // 
            this.button_SStop.Location = new System.Drawing.Point(814, 183);
            this.button_SStop.Name = "button_SStop";
            this.button_SStop.Size = new System.Drawing.Size(65, 23);
            this.button_SStop.TabIndex = 67;
            this.button_SStop.Text = "SStop";
            this.button_SStop.UseVisualStyleBackColor = true;
            this.button_SStop.Click += new System.EventHandler(this.button_SStop_Click);
            // 
            // button_EStop
            // 
            this.button_EStop.Location = new System.Drawing.Point(742, 183);
            this.button_EStop.Name = "button_EStop";
            this.button_EStop.Size = new System.Drawing.Size(65, 23);
            this.button_EStop.TabIndex = 66;
            this.button_EStop.Text = "EStop";
            this.button_EStop.UseVisualStyleBackColor = true;
            this.button_EStop.Click += new System.EventHandler(this.button_EStop_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(664, 183);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(65, 23);
            this.button_Stop.TabIndex = 65;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // textBox_pulse
            // 
            this.textBox_pulse.Location = new System.Drawing.Point(792, 309);
            this.textBox_pulse.Name = "textBox_pulse";
            this.textBox_pulse.Size = new System.Drawing.Size(56, 21);
            this.textBox_pulse.TabIndex = 64;
            this.textBox_pulse.TextChanged += new System.EventHandler(this.textBox_pulse_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 63;
            this.label6.Text = "Pulse";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_Unit
            // 
            this.textBox_Unit.Location = new System.Drawing.Point(696, 309);
            this.textBox_Unit.Name = "textBox_Unit";
            this.textBox_Unit.Size = new System.Drawing.Size(56, 21);
            this.textBox_Unit.TabIndex = 62;
            this.textBox_Unit.TextChanged += new System.EventHandler(this.textBox_Unit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 61;
            this.label5.Text = "Unit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBox_Rel
            // 
            this.checkBox_Rel.AutoSize = true;
            this.checkBox_Rel.Location = new System.Drawing.Point(792, 254);
            this.checkBox_Rel.Name = "checkBox_Rel";
            this.checkBox_Rel.Size = new System.Drawing.Size(42, 16);
            this.checkBox_Rel.TabIndex = 60;
            this.checkBox_Rel.Text = "Rel";
            this.checkBox_Rel.UseVisualStyleBackColor = true;
            this.checkBox_Rel.CheckedChanged += new System.EventHandler(this.checkBox_Rel_CheckedChanged);
            // 
            // checkBox_Abs
            // 
            this.checkBox_Abs.AutoSize = true;
            this.checkBox_Abs.Location = new System.Drawing.Point(719, 254);
            this.checkBox_Abs.Name = "checkBox_Abs";
            this.checkBox_Abs.Size = new System.Drawing.Size(46, 16);
            this.checkBox_Abs.TabIndex = 59;
            this.checkBox_Abs.Text = "Abs";
            this.checkBox_Abs.UseVisualStyleBackColor = true;
            this.checkBox_Abs.CheckedChanged += new System.EventHandler(this.checkBox_Abs_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = "Abs Rel Mode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_EdgeThreshold
            // 
            this.textBox_EdgeThreshold.Location = new System.Drawing.Point(427, 327);
            this.textBox_EdgeThreshold.Name = "textBox_EdgeThreshold";
            this.textBox_EdgeThreshold.Size = new System.Drawing.Size(100, 21);
            this.textBox_EdgeThreshold.TabIndex = 53;
            this.textBox_EdgeThreshold.TextChanged += new System.EventHandler(this.textBox_EdgeThreshold_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "Edge Threshold";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trackBar_EdgeThreshold
            // 
            this.trackBar_EdgeThreshold.Location = new System.Drawing.Point(282, 286);
            this.trackBar_EdgeThreshold.Maximum = 255;
            this.trackBar_EdgeThreshold.Name = "trackBar_EdgeThreshold";
            this.trackBar_EdgeThreshold.Size = new System.Drawing.Size(302, 45);
            this.trackBar_EdgeThreshold.TabIndex = 51;
            this.trackBar_EdgeThreshold.Scroll += new System.EventHandler(this.trackBar_EdgeThreshold_Scroll);
            // 
            // textBox_BinaryThreshold
            // 
            this.textBox_BinaryThreshold.Location = new System.Drawing.Point(427, 248);
            this.textBox_BinaryThreshold.Name = "textBox_BinaryThreshold";
            this.textBox_BinaryThreshold.Size = new System.Drawing.Size(100, 21);
            this.textBox_BinaryThreshold.TabIndex = 50;
            this.textBox_BinaryThreshold.TextChanged += new System.EventHandler(this.textBox_BinaryThreshold_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "Binary Threshold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar_BinaryThreshold
            // 
            this.trackBar_BinaryThreshold.Location = new System.Drawing.Point(282, 207);
            this.trackBar_BinaryThreshold.Maximum = 20;
            this.trackBar_BinaryThreshold.Name = "trackBar_BinaryThreshold";
            this.trackBar_BinaryThreshold.Size = new System.Drawing.Size(302, 45);
            this.trackBar_BinaryThreshold.TabIndex = 48;
            this.trackBar_BinaryThreshold.Scroll += new System.EventHandler(this.trackBar_BinaryThreshold_Scroll);
            // 
            // pictureBox_EdgePicture
            // 
            this.pictureBox_EdgePicture.Location = new System.Drawing.Point(452, 38);
            this.pictureBox_EdgePicture.Name = "pictureBox_EdgePicture";
            this.pictureBox_EdgePicture.Size = new System.Drawing.Size(132, 149);
            this.pictureBox_EdgePicture.TabIndex = 47;
            this.pictureBox_EdgePicture.TabStop = false;
            this.pictureBox_EdgePicture.Click += new System.EventHandler(this.pictureBox_EdgePicture_Click);
            // 
            // button_UPP
            // 
            this.button_UPP.Location = new System.Drawing.Point(754, 309);
            this.button_UPP.Name = "button_UPP";
            this.button_UPP.Size = new System.Drawing.Size(32, 23);
            this.button_UPP.TabIndex = 46;
            this.button_UPP.Text = "/";
            this.button_UPP.UseVisualStyleBackColor = true;
            this.button_UPP.Click += new System.EventHandler(this.button_UPP_Click);
            // 
            // pictureBox_BinaryPicture
            // 
            this.pictureBox_BinaryPicture.Location = new System.Drawing.Point(282, 38);
            this.pictureBox_BinaryPicture.Name = "pictureBox_BinaryPicture";
            this.pictureBox_BinaryPicture.Size = new System.Drawing.Size(126, 149);
            this.pictureBox_BinaryPicture.TabIndex = 45;
            this.pictureBox_BinaryPicture.TabStop = false;
            this.pictureBox_BinaryPicture.Click += new System.EventHandler(this.pictureBox_BinaryPicture_Click);
            // 
            // button_ToGray
            // 
            this.button_ToGray.Location = new System.Drawing.Point(184, 105);
            this.button_ToGray.Name = "button_ToGray";
            this.button_ToGray.Size = new System.Drawing.Size(75, 23);
            this.button_ToGray.TabIndex = 44;
            this.button_ToGray.Text = ">>";
            this.button_ToGray.UseVisualStyleBackColor = true;
            this.button_ToGray.Click += new System.EventHandler(this.button_ToGray_Click);
            // 
            // pictureBox_OriginalPicture
            // 
            this.pictureBox_OriginalPicture.Location = new System.Drawing.Point(43, 38);
            this.pictureBox_OriginalPicture.Name = "pictureBox_OriginalPicture";
            this.pictureBox_OriginalPicture.Size = new System.Drawing.Size(123, 149);
            this.pictureBox_OriginalPicture.TabIndex = 43;
            this.pictureBox_OriginalPicture.TabStop = false;
            this.pictureBox_OriginalPicture.Click += new System.EventHandler(this.pictureBox_OriginalPicture_Click);
            // 
            // Load_Picture
            // 
            this.Load_Picture.FileName = "Load_Picture";
            this.Load_Picture.Filter = "Jpg Files(*.jpg)|*.jpg|Png Files(*.png)|*.png|All Files(*.*)|*.*";
            this.Load_Picture.FilterIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(718, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 85;
            this.button3.Text = "InPosition";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(718, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 86;
            this.button4.Text = "Alarm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 376);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_LoadPicture);
            this.Controls.Add(this.textBox_Decel);
            this.Controls.Add(this.textBox_Accel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_Velocity);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button_BrakeOff);
            this.Controls.Add(this.button_BrakeOn);
            this.Controls.Add(this.button_ServoOn);
            this.Controls.Add(this.button_SStop);
            this.Controls.Add(this.button_EStop);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.textBox_pulse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Unit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_Rel);
            this.Controls.Add(this.checkBox_Abs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_EdgeThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_EdgeThreshold);
            this.Controls.Add(this.textBox_BinaryThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_BinaryThreshold);
            this.Controls.Add(this.pictureBox_EdgePicture);
            this.Controls.Add(this.button_UPP);
            this.Controls.Add(this.pictureBox_BinaryPicture);
            this.Controls.Add(this.button_ToGray);
            this.Controls.Add(this.pictureBox_OriginalPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_EdgeThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BinaryThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EdgePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BinaryPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OriginalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_LoadPicture;
        private System.Windows.Forms.TextBox textBox_Decel;
        private System.Windows.Forms.TextBox textBox_Accel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Velocity;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button_BrakeOff;
        private System.Windows.Forms.Button button_BrakeOn;
        private System.Windows.Forms.Button button_ServoOn;
        private System.Windows.Forms.Button button_SStop;
        private System.Windows.Forms.Button button_EStop;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TextBox textBox_pulse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Rel;
        private System.Windows.Forms.CheckBox checkBox_Abs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_EdgeThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_EdgeThreshold;
        private System.Windows.Forms.TextBox textBox_BinaryThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_BinaryThreshold;
        private System.Windows.Forms.PictureBox pictureBox_EdgePicture;
        private System.Windows.Forms.Button button_UPP;
        private System.Windows.Forms.PictureBox pictureBox_BinaryPicture;
        private System.Windows.Forms.Button button_ToGray;
        private System.Windows.Forms.PictureBox pictureBox_OriginalPicture;
        private System.Windows.Forms.OpenFileDialog Load_Picture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

