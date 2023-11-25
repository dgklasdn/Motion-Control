using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;
using OpenCvSharp.UserInterface;



namespace Test
{
    public partial class Form1 : Form
    {
        int X = 0;
        int Y = 1;
        int Z = 2;

        int nServoOn = 0;
        int nAlarmOn = 0;
        int nInPosition = 0;

        public uint uXState = 1;
        public uint uYState = 1;
        public uint uZState = 1;
        public int nCnt = 0;

        uint unAbsRel_Mode = new uint();

        Mat mOri_Pic = new Mat();
        Mat Resized_OriPicture = new Mat();
        Mat mGray_Pic = new Mat();
        Mat mBlur_Pic = new Mat();
        Mat mBinary_Pic = new Mat();
        Mat mEdge_Pic = new Mat();

        private static DateTime Delay(int MS) // 시간 지연 함수
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;

        }

        public Form1()
        {
            InitializeComponent();
            if (CAXL.AxlOpen(7) == (uint)AXT_FUNC_RESULT.AXT_RT_SUCCESS)
            {
                MessageBox.Show("AXL라이브러리 초기화 성공");
            }
            else
            {
                MessageBox.Show("AXL라이브러리 초기화 실패");
            }
            button_BrakeOn.BackColor = Color.LightPink;

            CAXM.AxmMotSetPulseOutMethod(0, 6);  // 펄스출력방식 - TwoCwCcwHigh
            CAXM.AxmMotSetPulseOutMethod(1, 6);
            CAXM.AxmMotSetPulseOutMethod(2, 6);

            CAXM.AxmMotSetEncInputMethod(0, 3);  // 4체배
            CAXM.AxmMotSetEncInputMethod(1, 3);
            CAXM.AxmMotSetEncInputMethod(2, 3);

            CAXM.AxmSignalSetLimit(0, 0, 0, 0);  // LIMIT 알람 OFF
            CAXM.AxmSignalSetLimit(1, 0, 0, 0);
            CAXM.AxmSignalSetLimit(2, 0, 0, 0);

            CAXM.AxmSignalSetServoAlarm(0, 0);  // 알람 OFF
            CAXM.AxmSignalSetServoAlarm(1, 0);
            CAXM.AxmSignalSetServoAlarm(2, 0);
        }

        private void button_LoadPicture_Click(object sender, EventArgs e)  //이미지 로드 버튼
        {
            if (Load_Picture.ShowDialog() == DialogResult.OK)
            {
                pictureBox_OriginalPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_OriginalPicture.Image = Image.FromFile(Load_Picture.FileName);

            }
        }
            private void pictureBox_BinaryPicture_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Decel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Accel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Velocity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int nPic_Height = pictureBox_EdgePicture.Image.Height; // 이미지 높이
            int nPic_Width = pictureBox_EdgePicture.Image.Width;

            int[,] nPixel_Val = new int[nPic_Height, nPic_Width];

            double fXYVel = Convert.ToDouble(textBox_Velocity.Text);
            double fXYAccel = Convert.ToDouble(textBox_Accel.Text);
            double fXYDecel = Convert.ToDouble(textBox_Decel.Text);

            int[] nAxis = new int[3] { 0, 1, 2 };
            double[] fVel = new double[3] { fXYVel, fXYVel, fXYVel };
            double[] fAccel = new double[3] { fXYAccel, fXYAccel, fXYAccel };
            double[] fDecel = new double[3] { fXYDecel, fXYDecel, fXYDecel };

            for (int i = 0; i < nPic_Height; i++)
            {
                for (int j = 0; j < nPic_Width; j++)
                {
                    nPixel_Val[i, j] = Convert.ToInt32(mEdge_Pic.At<bool>(i, j));
                    System.Console.Write(Convert.ToString(Convert.ToInt16(nPixel_Val[i, j])));
                }
                System.Console.WriteLine();
            }

            int[] nCurrent_Pos = new int[2];
            double[] fCurrent_Pos = new double[3];

            for (int i = 0; i < nPic_Height - 1; i++)
            {
                for (int j = 0; j < nPic_Width - 1; j++)
                {
                    if (nPixel_Val[i, j] == 1)
                    {
                        CAXM.AxmMovePos(2, 200, fXYVel, fXYAccel, fXYDecel);

                        nCurrent_Pos[0] = i;
                        nCurrent_Pos[1] = j;
                        fCurrent_Pos[2] = 0;

                        fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                        fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                        System.Console.WriteLine("{0},{1}", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));

                        CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);
                        

                        Delay(10);

                        while (true)

                        {

                            if (nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1] + 1] == 1)

                            {

                                nCurrent_Pos[0] = nCurrent_Pos[0];
                                nCurrent_Pos[1] = nCurrent_Pos[1] + 1;

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine("{0},{1}", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));

                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }

                            else if (nPixel_Val[nCurrent_Pos[0] + 1, nCurrent_Pos[1] + 1] == 1)
                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0] + 1;
                                nCurrent_Pos[1] = nCurrent_Pos[1] + 1;

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine("{0}, {1}", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }

                            else if (nPixel_Val[nCurrent_Pos[0] + 1, nCurrent_Pos[1]] == 1)
                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0] + 1;
                                nCurrent_Pos[1] = nCurrent_Pos[1];

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);
                                System.Console.WriteLine("{0}. {1}", Convert.ToString(fCurrent_Pos[0] + 1), 1, Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }

                            else if (nPixel_Val[nCurrent_Pos[0] + 1, nCurrent_Pos[1] - 1] == 1)
                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0] + 1;
                                nCurrent_Pos[1] = nCurrent_Pos[1] - 1;

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine("{0}", "{1}", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }

                            else if (nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1] - 1] == 1)
                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0];
                                nCurrent_Pos[1] = nCurrent_Pos[1] - 1;

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine("{0}", "{1}", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }

                            else if (nPixel_Val[nCurrent_Pos[0] - 1, nCurrent_Pos[1] - 1] == 1)
                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0] - 1;
                                nCurrent_Pos[1] = nCurrent_Pos[1] - 1;

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine(" {0}, {1} ", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }

                            else if (nPixel_Val[nCurrent_Pos[0] - 1, nCurrent_Pos[1]] == 1)
                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0] - 1;
                                nCurrent_Pos[1] = nCurrent_Pos[1];

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine(" {0}, {1} ", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;
                            }


                            else if (nPixel_Val[nCurrent_Pos[0] - 1, nCurrent_Pos[1] + 1] == 1)

                            {
                                nCurrent_Pos[0] = nCurrent_Pos[0] - 1;
                                nCurrent_Pos[1] = nCurrent_Pos[1] + 1;

                                fCurrent_Pos[0] = Convert.ToDouble(nCurrent_Pos[0]);
                                fCurrent_Pos[1] = Convert.ToDouble(nCurrent_Pos[1]);

                                System.Console.WriteLine("{0},{1}", Convert.ToString(fCurrent_Pos[0] + 1), Convert.ToString(fCurrent_Pos[1] + 1));
                                CAXM.AxmMoveMultiPos(3, nAxis, fCurrent_Pos, fVel, fAccel, fDecel);

                                nPixel_Val[nCurrent_Pos[0], nCurrent_Pos[1]] = 0;

                            }

                            else
                                break;
                        }
                    }
                }
            }
        }
        private void button_BrakeOff_Click(object sender, EventArgs e)  // Brake OFF
        {
            CAXM.AxmSignalWriteOutputBit(Z, 2, 0);
            button_BrakeOn.BackColor = Color.LightGray;
            button_BrakeOff.BackColor = Color.LightPink;

        }

        private void button_BrakeOn_Click(object sender, EventArgs e)  // Brake ON
        {
            CAXM.AxmSignalWriteOutputBit(Z, 2, 1);
            button_BrakeOn.BackColor = Color.LightPink;
            button_BrakeOff.BackColor = Color.LightGray;

        }

        private void button_ServoOn_Click(object sender, EventArgs e)  // ServoOn 버튼
        {
            if (nServoOn == 0)
            {
                CAXM.AxmSignalServoOn(X, 1);
                CAXM.AxmSignalServoOn(Y, 1);
                CAXM.AxmSignalServoOn(Z, 1);
                button_ServoOn.BackColor = Color.LightPink;
            }
            else
            {
                CAXM.AxmSignalServoOn(X, 0);
                CAXM.AxmSignalServoOn(Y, 0);
                CAXM.AxmSignalServoOn(Z, 0);
                button_ServoOn.BackColor = Color.LightGray;
            }
            nServoOn = ~nServoOn;

        }

        private void button_SStop_Click(object sender, EventArgs e)
        {
            CAXM.AxmMoveEStop(0);
            CAXM.AxmMoveEStop(1);
            CAXM.AxmMoveEStop(2);
        }

        private void button_EStop_Click(object sender, EventArgs e)
        {
            CAXM.AxmMoveEStop(0);
            CAXM.AxmMoveEStop(1);
            CAXM.AxmMoveEStop(2);
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            CAXM.AxmMoveStop(0, 100);
            CAXM.AxmMoveStop(1, 100);
            CAXM.AxmMoveStop(2, 100);
        }

        private void textBox_pulse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Unit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Rel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Rel.CheckState == CheckState.Checked)
            {
                checkBox_Abs.CheckState = CheckState.Unchecked;
                unAbsRel_Mode = 1;

                CAXM.AxmMotSetAbsRelMode(X, unAbsRel_Mode);
                CAXM.AxmMotSetAbsRelMode(Y, unAbsRel_Mode);
                CAXM.AxmMotSetAbsRelMode(X, unAbsRel_Mode);
            }

        }

        private void checkBox_Abs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Abs.CheckState == CheckState.Checked)
            {
                checkBox_Rel.CheckState = CheckState.Unchecked;
                unAbsRel_Mode = 0;

                CAXM.AxmMotSetAbsRelMode(X, unAbsRel_Mode);
                CAXM.AxmMotSetAbsRelMode(Y, unAbsRel_Mode);
                CAXM.AxmMotSetAbsRelMode(X, unAbsRel_Mode);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_EdgeThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_EdgeThreshold_Scroll(object sender, EventArgs e)
        {
            int EdgeThreshold_Val = trackBar_EdgeThreshold.Value;

            textBox_EdgeThreshold.TextAlign = HorizontalAlignment.Center;
            textBox_EdgeThreshold.Text = (Convert.ToString(EdgeThreshold_Val));

            Cv2.Canny(mBinary_Pic, mEdge_Pic, 0, EdgeThreshold_Val);

            pictureBox_EdgePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_EdgePicture.Image = BitmapConverter.ToBitmap(mEdge_Pic);
        }

        private void textBox_BinaryThreshold_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_BinaryThreshold_Scroll(object sender, EventArgs e)
        {
            int BinaryThreshold_Val = trackBar_BinaryThreshold.Value;

            textBox_BinaryThreshold.TextAlign = HorizontalAlignment.Center;
            textBox_BinaryThreshold.Text = (Convert.ToString(BinaryThreshold_Val));

            Cv2.Threshold(mBlur_Pic, mBinary_Pic, BinaryThreshold_Val, 255, ThresholdType.ToZero);

            pictureBox_BinaryPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_BinaryPicture.Image = BitmapConverter.ToBitmap(mBlur_Pic);
        }

        private void pictureBox_EdgePicture_Click(object sender, EventArgs e)
        {
            Mat Resized_Picture = new Mat();

            Cv2.Resize(mEdge_Pic, Resized_Picture, new OpenCvSharp.CPlusPlus.Size(700, 700), 1, 1, Interpolation.Area);

            Cv2.ImShow("Edge Picture", Resized_Picture);
        }

        private void button_UPP_Click(object sender, EventArgs e)
        {
            double dUnit = Convert.ToDouble(textBox_Unit.Text);
            int nPulse = Convert.ToInt32(textBox_pulse.Text);

            CAXM.AxmMotSetMoveUnitPerPulse(0, dUnit, nPulse);
            CAXM.AxmMotSetMoveUnitPerPulse(1, dUnit, nPulse);
            CAXM.AxmMotSetMoveUnitPerPulse(2, dUnit, nPulse);
        }

      

        private void button_ToGray_Click(object sender, EventArgs e)  // 그레이 스케일 버튼
        {
            mOri_Pic = BitmapConverter.ToMat(new Bitmap(pictureBox_OriginalPicture.Image));

            Cv2.CvtColor(mOri_Pic, mGray_Pic, ColorConversion.BgrToGray);
            Cv2.GaussianBlur(mGray_Pic, mBlur_Pic, new OpenCvSharp.CPlusPlus.Size(3, 3), 5, 0, BorderType.Default);

            pictureBox_BinaryPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_BinaryPicture.Image = BitmapConverter.ToBitmap(mBlur_Pic);
        }

        private void pictureBox_OriginalPicture_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        public void checkInMotion()
        {
            uint uState;
            do
            {
                CAXM.AxmStatusReadInMotion(0, ref uXState);
                CAXM.AxmStatusReadInMotion(1, ref uYState);
                CAXM.AxmStatusReadInMotion(2, ref uZState);
                uState = uXState | uYState | uZState;
            } while (uState != 0);
            uXState = 1;
            uYState = 1;
            uZState = 1;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            CAXM.AxmStatusReadInMotion(0, ref uXState);
            CAXM.AxmStatusReadInMotion(1, ref uYState);
            CAXM.AxmStatusReadInMotion(2, ref uZState);
            if ((uXState | uYState | uZState) == 0)
            {
                nCnt++;
                uXState = 1;
                uYState = 1;
                uZState = 1;
            }

            if (nCnt == 1)
            {
                int[] lAxis = new int[2];
                double[] dPos = new double[2];
                int lCoordinate = 0;
                double dVelocity = 200, dAccel = 400;
                lAxis[0] = 0;
                lAxis[1] = 1;
                CAXM.AxmContiBeginNode(lCoordinate);
                dPos[0] = 800; dPos[1] = 800;
                CAXM.AxmLineMove(lCoordinate, dPos, dVelocity, dAccel, dAccel);
                dPos[0] = 900; dPos[1] = 900;
                CAXM.AxmLineMove(lCoordinate, dPos, dVelocity, dAccel, dAccel);
                CAXM.AxmContiEndNode(lCoordinate);
                CAXM.AxmContiSetAbsRelMode(lCoordinate, 0); 
                CAXM.AxmContiStart(lCoordinate, 0, 0);
            }
            else if (nCnt == 2)
            {
                int[] lAxis = new int[2];
                double[] dPos = new double[2];
                int lCoordinate = 0;
                double dVelocity = 200, dAccel = 400;
                lAxis[0] = 0;
                lAxis[1] = 1;
                CAXM.AxmContiBeginNode(lCoordinate);
                dPos[0] = 1000; dPos[1] = 1000;
                CAXM.AxmLineMove(lCoordinate, dPos, dVelocity, dAccel, dAccel);
                dPos[0] = 1100; dPos[1] = 1100;
                CAXM.AxmLineMove(lCoordinate, dPos, dVelocity, dAccel, dAccel);
                CAXM.AxmContiEndNode(lCoordinate);
                CAXM.AxmContiSetAbsRelMode(lCoordinate, 0);
                CAXM.AxmContiStart(lCoordinate, 0, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)  // Alarm 버튼
        {
            if (nAlarmOn == 0)
            {
                CAXM.AxmSignalSetServoAlarm(X, 0);
                CAXM.AxmSignalSetServoAlarm(Y, 0);
                CAXM.AxmSignalSetServoAlarm(Z, 0);
                button4.BackColor = Color.LightPink;
            }
            else
            {
                CAXM.AxmSignalSetServoAlarm(X, 1);
                CAXM.AxmSignalSetServoAlarm(Y, 1);
                CAXM.AxmSignalSetServoAlarm(Z, 1);
                button4.BackColor = Color.LightGray;
            }
            nAlarmOn = ~nAlarmOn;

        }

        private void button3_Click(object sender, EventArgs e)  // InPosition 버튼
        {
            if (nInPosition == 0)
            {
                CAXM.AxmSignalSetInpos(X, 0);
                CAXM.AxmSignalSetInpos(Y, 0);
                CAXM.AxmSignalSetInpos(Z, 0);
                button3.BackColor = Color.LightPink;
            }
            else 
            {
                CAXM.AxmSignalSetInpos(X, 1);
                CAXM.AxmSignalSetInpos(Y, 1);
                CAXM.AxmSignalSetInpos(Z, 1);
                button3.BackColor = Color.LightGray;
            }
            nInPosition = ~nInPosition;
        }

        
    }
}

