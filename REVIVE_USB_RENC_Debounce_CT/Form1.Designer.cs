namespace HID_PnP_Demo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReadWriteThread = new System.ComponentModel.BackgroundWorker();
            this.FormUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.KeyboardValue_txtbx = new System.Windows.Forms.TextBox();
            this.ToggleLEDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PushbuttonStateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RotaryEncoderSetting_grpbox = new System.Windows.Forms.GroupBox();
            this.check_count_renc_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.RotaryEncoder4_cbox = new System.Windows.Forms.CheckBox();
            this.renc_check_count_lbl1 = new System.Windows.Forms.Label();
            this.RotaryEncoder5_cbox = new System.Windows.Forms.CheckBox();
            this.RotaryEncoder6_cbox = new System.Windows.Forms.CheckBox();
            this.RotaryEncoder3_cbox = new System.Windows.Forms.CheckBox();
            this.renc_check_count_lbl2 = new System.Windows.Forms.Label();
            this.RotaryEncoder2_cbox = new System.Windows.Forms.CheckBox();
            this.RotaryEncoder1_cbox = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.MouseMove_UD = new System.Windows.Forms.NumericUpDown();
            this.Button12_cbox = new System.Windows.Forms.CheckBox();
            this.Button11_cbox = new System.Windows.Forms.CheckBox();
            this.Button10_cbox = new System.Windows.Forms.CheckBox();
            this.Button9_cbox = new System.Windows.Forms.CheckBox();
            this.Button8_cbox = new System.Windows.Forms.CheckBox();
            this.Button7_cbox = new System.Windows.Forms.CheckBox();
            this.SetPin_combox = new System.Windows.Forms.ComboBox();
            this.Button6_cbox = new System.Windows.Forms.CheckBox();
            this.Button5_cbox = new System.Windows.Forms.CheckBox();
            this.Button4_cbox = new System.Windows.Forms.CheckBox();
            this.Button3_cbox = new System.Windows.Forms.CheckBox();
            this.Button2_cbox = new System.Windows.Forms.CheckBox();
            this.Button1_cbox = new System.Windows.Forms.CheckBox();
            this.LeverRight_cbox = new System.Windows.Forms.CheckBox();
            this.LeverLeft_cbox = new System.Windows.Forms.CheckBox();
            this.LeverDown_cbox = new System.Windows.Forms.CheckBox();
            this.LeverUp_cbox = new System.Windows.Forms.CheckBox();
            this.Win_cbox = new System.Windows.Forms.CheckBox();
            this.Shift_cbox = new System.Windows.Forms.CheckBox();
            this.Alt_cbox = new System.Windows.Forms.CheckBox();
            this.Ctrl_cbox = new System.Windows.Forms.CheckBox();
            this.mousevalue_combx = new System.Windows.Forms.ComboBox();
            this.devicetype_combox = new System.Windows.Forms.ComboBox();
            this.devicetype_lbl4 = new System.Windows.Forms.Label();
            this.devicetype_lbl1 = new System.Windows.Forms.Label();
            this.devicetype_lbl3 = new System.Windows.Forms.Label();
            this.devicetype_lbl2 = new System.Windows.Forms.Label();
            this.devicetype_lbl9 = new System.Windows.Forms.Label();
            this.devicetype_lbl8 = new System.Windows.Forms.Label();
            this.devicetype_lbl7 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl4 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl1 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl3 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl2 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl9 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl8 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl7 = new System.Windows.Forms.Label();
            this.StatusBox_lbl = new System.Windows.Forms.Label();
            this.StatusBox_lbl2 = new System.Windows.Forms.Label();
            this.devicetype_lbl5 = new System.Windows.Forms.Label();
            this.devicetype_lbl6 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl5 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl6 = new System.Windows.Forms.Label();
            this.devicetype_lbl10 = new System.Windows.Forms.Label();
            this.devicetype_lbl11 = new System.Windows.Forms.Label();
            this.devicetype_lbl12 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl10 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl11 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl12 = new System.Windows.Forms.Label();
            this.ButtonPressIcon12 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon11 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon10 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon9 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon8 = new System.Windows.Forms.PictureBox();
            this.Pin12A_pb = new System.Windows.Forms.PictureBox();
            this.Pin11A_pb = new System.Windows.Forms.PictureBox();
            this.Pin10A_pb = new System.Windows.Forms.PictureBox();
            this.Pin09A_pb = new System.Windows.Forms.PictureBox();
            this.Pin08A_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Mouse3_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Mouse1_pb = new System.Windows.Forms.PictureBox();
            this.Pin01A_pb = new System.Windows.Forms.PictureBox();
            this.Pin02A_pb = new System.Windows.Forms.PictureBox();
            this.Pin03A_pb = new System.Windows.Forms.PictureBox();
            this.Pin04A_pb = new System.Windows.Forms.PictureBox();
            this.Pin05A_pb = new System.Windows.Forms.PictureBox();
            this.Pin02B_pb = new System.Windows.Forms.PictureBox();
            this.Pin03B_pb = new System.Windows.Forms.PictureBox();
            this.Pin04B_pb = new System.Windows.Forms.PictureBox();
            this.Pin01B_pb = new System.Windows.Forms.PictureBox();
            this.Pin05B_pb = new System.Windows.Forms.PictureBox();
            this.Pin06B_pb = new System.Windows.Forms.PictureBox();
            this.Pin07A_pb = new System.Windows.Forms.PictureBox();
            this.Pin07B_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Com_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Keyboard_pb = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Status_C_pb = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon5 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon6 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon7 = new System.Windows.Forms.PictureBox();
            this.Changevalue_btn = new System.Windows.Forms.Button();
            this.ButtonPressIcon4 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon3 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon2 = new System.Windows.Forms.PictureBox();
            this.ButtonPressIcon1 = new System.Windows.Forms.PictureBox();
            this.Pin08B_pb = new System.Windows.Forms.PictureBox();
            this.Pin09B_pb = new System.Windows.Forms.PictureBox();
            this.Pin10B_pb = new System.Windows.Forms.PictureBox();
            this.Pin11B_pb = new System.Windows.Forms.PictureBox();
            this.Pin12B_pb = new System.Windows.Forms.PictureBox();
            this.Speed_Mouse4_pb = new System.Windows.Forms.PictureBox();
            this.Speed_Mouse5_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Mouse2_pb = new System.Windows.Forms.PictureBox();
            this.Status_NC_pb = new System.Windows.Forms.PictureBox();
            this.Pin06A_pb = new System.Windows.Forms.PictureBox();
            this.BackGround_pb = new System.Windows.Forms.PictureBox();
            this.smpl_interval_lbl1 = new System.Windows.Forms.Label();
            this.smpl_interval_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.smpl_interval_lbl2 = new System.Windows.Forms.Label();
            this.fw_version_lbl = new System.Windows.Forms.Label();
            this.AllButtonSetting_grpbox = new System.Windows.Forms.GroupBox();
            this.check_count_numUpDown = new System.Windows.Forms.NumericUpDown();
            this.check_count_lbl1 = new System.Windows.Forms.Label();
            this.check_count_lbl2 = new System.Windows.Forms.Label();
            this.RotaryEncoderSetting_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_count_renc_numUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouseMove_UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin12A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin11A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin10A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin09A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin08A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse3_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse1_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin01A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin02A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin03A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin04A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin05A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin02B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin03B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin04B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin01B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin05B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin06B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin07A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin07B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Com_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Keyboard_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin08B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin09B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin10B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin11B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin12B_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Mouse4_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Mouse5_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse2_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin06A_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smpl_interval_numUpDown)).BeginInit();
            this.AllButtonSetting_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_count_numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadWriteThread
            // 
            this.ReadWriteThread.WorkerReportsProgress = true;
            this.ReadWriteThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadWriteThread_DoWork);
            // 
            // FormUpdateTimer
            // 
            this.FormUpdateTimer.Enabled = true;
            this.FormUpdateTimer.Interval = 6;
            this.FormUpdateTimer.Tick += new System.EventHandler(this.FormUpdateTimer_Tick);
            // 
            // KeyboardValue_txtbx
            // 
            this.KeyboardValue_txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.KeyboardValue_txtbx.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyboardValue_txtbx.Location = new System.Drawing.Point(64, 333);
            this.KeyboardValue_txtbx.Name = "KeyboardValue_txtbx";
            this.KeyboardValue_txtbx.Size = new System.Drawing.Size(100, 19);
            this.KeyboardValue_txtbx.TabIndex = 31;
            this.KeyboardValue_txtbx.Text = "ここに入力";
            this.KeyboardValue_txtbx.Visible = false;
            this.KeyboardValue_txtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardValue_txtbx_KeyDown);
            this.KeyboardValue_txtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardValue_txtbx_KeyUp);
            this.KeyboardValue_txtbx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyboardValue_txtbx_PreviewKeyDown);
            // 
            // ToggleLEDToolTip
            // 
            this.ToggleLEDToolTip.AutomaticDelay = 2000;
            this.ToggleLEDToolTip.AutoPopDelay = 20000;
            this.ToggleLEDToolTip.InitialDelay = 15;
            this.ToggleLEDToolTip.ReshowDelay = 15;
            // 
            // PushbuttonStateTooltip
            // 
            this.PushbuttonStateTooltip.AutomaticDelay = 20;
            this.PushbuttonStateTooltip.AutoPopDelay = 20000;
            this.PushbuttonStateTooltip.InitialDelay = 15;
            this.PushbuttonStateTooltip.ReshowDelay = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 2000;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 15;
            this.toolTip1.ReshowDelay = 15;
            // 
            // RotaryEncoderSetting_grpbox
            // 
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.check_count_renc_numUpDown);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.RotaryEncoder4_cbox);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.renc_check_count_lbl1);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.RotaryEncoder5_cbox);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.RotaryEncoder6_cbox);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.RotaryEncoder3_cbox);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.renc_check_count_lbl2);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.RotaryEncoder2_cbox);
            this.RotaryEncoderSetting_grpbox.Controls.Add(this.RotaryEncoder1_cbox);
            this.RotaryEncoderSetting_grpbox.Enabled = false;
            this.RotaryEncoderSetting_grpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.RotaryEncoderSetting_grpbox.Location = new System.Drawing.Point(389, 375);
            this.RotaryEncoderSetting_grpbox.Name = "RotaryEncoderSetting_grpbox";
            this.RotaryEncoderSetting_grpbox.Size = new System.Drawing.Size(144, 96);
            this.RotaryEncoderSetting_grpbox.TabIndex = 173;
            this.RotaryEncoderSetting_grpbox.TabStop = false;
            this.RotaryEncoderSetting_grpbox.Text = "RotaryEncoderSetting";
            // 
            // check_count_renc_numUpDown
            // 
            this.check_count_renc_numUpDown.Location = new System.Drawing.Point(83, 70);
            this.check_count_renc_numUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.check_count_renc_numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.check_count_renc_numUpDown.Name = "check_count_renc_numUpDown";
            this.check_count_renc_numUpDown.Size = new System.Drawing.Size(38, 19);
            this.check_count_renc_numUpDown.TabIndex = 171;
            this.check_count_renc_numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RotaryEncoder4_cbox
            // 
            this.RotaryEncoder4_cbox.AutoSize = true;
            this.RotaryEncoder4_cbox.Location = new System.Drawing.Point(70, 50);
            this.RotaryEncoder4_cbox.Name = "RotaryEncoder4_cbox";
            this.RotaryEncoder4_cbox.Size = new System.Drawing.Size(56, 16);
            this.RotaryEncoder4_cbox.TabIndex = 176;
            this.RotaryEncoder4_cbox.Text = "7P/8P";
            this.RotaryEncoder4_cbox.UseVisualStyleBackColor = true;
            this.RotaryEncoder4_cbox.CheckedChanged += new System.EventHandler(this.RotaryEncoder4_cbox_CheckedChanged);
            // 
            // renc_check_count_lbl1
            // 
            this.renc_check_count_lbl1.AutoSize = true;
            this.renc_check_count_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.renc_check_count_lbl1.Location = new System.Drawing.Point(5, 72);
            this.renc_check_count_lbl1.Name = "renc_check_count_lbl1";
            this.renc_check_count_lbl1.Size = new System.Drawing.Size(77, 12);
            this.renc_check_count_lbl1.TabIndex = 170;
            this.renc_check_count_lbl1.Text = "一致検出回数";
            // 
            // RotaryEncoder5_cbox
            // 
            this.RotaryEncoder5_cbox.AutoSize = true;
            this.RotaryEncoder5_cbox.Location = new System.Drawing.Point(70, 34);
            this.RotaryEncoder5_cbox.Name = "RotaryEncoder5_cbox";
            this.RotaryEncoder5_cbox.Size = new System.Drawing.Size(62, 16);
            this.RotaryEncoder5_cbox.TabIndex = 179;
            this.RotaryEncoder5_cbox.Text = "9P/10P";
            this.RotaryEncoder5_cbox.UseVisualStyleBackColor = true;
            this.RotaryEncoder5_cbox.CheckedChanged += new System.EventHandler(this.RotaryEncoder6_cbox_CheckedChanged);
            // 
            // RotaryEncoder6_cbox
            // 
            this.RotaryEncoder6_cbox.AutoSize = true;
            this.RotaryEncoder6_cbox.Location = new System.Drawing.Point(70, 18);
            this.RotaryEncoder6_cbox.Name = "RotaryEncoder6_cbox";
            this.RotaryEncoder6_cbox.Size = new System.Drawing.Size(68, 16);
            this.RotaryEncoder6_cbox.TabIndex = 178;
            this.RotaryEncoder6_cbox.Text = "11P/12P";
            this.RotaryEncoder6_cbox.UseVisualStyleBackColor = true;
            this.RotaryEncoder6_cbox.CheckedChanged += new System.EventHandler(this.RotaryEncoder5_cbox_CheckedChanged);
            // 
            // RotaryEncoder3_cbox
            // 
            this.RotaryEncoder3_cbox.AutoSize = true;
            this.RotaryEncoder3_cbox.Location = new System.Drawing.Point(7, 50);
            this.RotaryEncoder3_cbox.Name = "RotaryEncoder3_cbox";
            this.RotaryEncoder3_cbox.Size = new System.Drawing.Size(56, 16);
            this.RotaryEncoder3_cbox.TabIndex = 177;
            this.RotaryEncoder3_cbox.Text = "5P/6P";
            this.RotaryEncoder3_cbox.UseVisualStyleBackColor = true;
            this.RotaryEncoder3_cbox.CheckedChanged += new System.EventHandler(this.RotaryEncoder3_cbox_CheckedChanged);
            // 
            // renc_check_count_lbl2
            // 
            this.renc_check_count_lbl2.AutoSize = true;
            this.renc_check_count_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.renc_check_count_lbl2.Location = new System.Drawing.Point(122, 72);
            this.renc_check_count_lbl2.Name = "renc_check_count_lbl2";
            this.renc_check_count_lbl2.Size = new System.Drawing.Size(17, 12);
            this.renc_check_count_lbl2.TabIndex = 172;
            this.renc_check_count_lbl2.Text = "回";
            // 
            // RotaryEncoder2_cbox
            // 
            this.RotaryEncoder2_cbox.AutoSize = true;
            this.RotaryEncoder2_cbox.Location = new System.Drawing.Point(7, 34);
            this.RotaryEncoder2_cbox.Name = "RotaryEncoder2_cbox";
            this.RotaryEncoder2_cbox.Size = new System.Drawing.Size(56, 16);
            this.RotaryEncoder2_cbox.TabIndex = 175;
            this.RotaryEncoder2_cbox.Text = "3P/4P";
            this.RotaryEncoder2_cbox.UseVisualStyleBackColor = true;
            this.RotaryEncoder2_cbox.CheckedChanged += new System.EventHandler(this.RotaryEncoder2_cbox_CheckedChanged);
            // 
            // RotaryEncoder1_cbox
            // 
            this.RotaryEncoder1_cbox.AutoSize = true;
            this.RotaryEncoder1_cbox.Location = new System.Drawing.Point(7, 18);
            this.RotaryEncoder1_cbox.Name = "RotaryEncoder1_cbox";
            this.RotaryEncoder1_cbox.Size = new System.Drawing.Size(56, 16);
            this.RotaryEncoder1_cbox.TabIndex = 174;
            this.RotaryEncoder1_cbox.Text = "1P/2P";
            this.RotaryEncoder1_cbox.UseVisualStyleBackColor = true;
            this.RotaryEncoder1_cbox.CheckedChanged += new System.EventHandler(this.RotaryEncoder1_cbox_CheckedChanged);
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 20;
            this.toolTip2.AutoPopDelay = 20000;
            this.toolTip2.InitialDelay = 15;
            this.toolTip2.ReshowDelay = 15;
            // 
            // MouseMove_UD
            // 
            this.MouseMove_UD.BackColor = System.Drawing.SystemColors.Window;
            this.MouseMove_UD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.MouseMove_UD.Location = new System.Drawing.Point(53, 255);
            this.MouseMove_UD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MouseMove_UD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MouseMove_UD.Name = "MouseMove_UD";
            this.MouseMove_UD.Size = new System.Drawing.Size(128, 19);
            this.MouseMove_UD.TabIndex = 86;
            this.MouseMove_UD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MouseMove_UD.Visible = false;
            this.MouseMove_UD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Button12_cbox
            // 
            this.Button12_cbox.AutoSize = true;
            this.Button12_cbox.BackColor = System.Drawing.Color.White;
            this.Button12_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button12_cbox.Location = new System.Drawing.Point(119, 349);
            this.Button12_cbox.Name = "Button12_cbox";
            this.Button12_cbox.Size = new System.Drawing.Size(67, 16);
            this.Button12_cbox.TabIndex = 82;
            this.Button12_cbox.Text = "ボタン１２";
            this.Button12_cbox.UseVisualStyleBackColor = false;
            this.Button12_cbox.Visible = false;
            this.Button12_cbox.CheckedChanged += new System.EventHandler(this.Button12_cbox_CheckedChanged);
            // 
            // Button11_cbox
            // 
            this.Button11_cbox.AutoSize = true;
            this.Button11_cbox.BackColor = System.Drawing.Color.White;
            this.Button11_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button11_cbox.Location = new System.Drawing.Point(119, 328);
            this.Button11_cbox.Name = "Button11_cbox";
            this.Button11_cbox.Size = new System.Drawing.Size(67, 16);
            this.Button11_cbox.TabIndex = 81;
            this.Button11_cbox.Text = "ボタン１１";
            this.Button11_cbox.UseVisualStyleBackColor = false;
            this.Button11_cbox.Visible = false;
            this.Button11_cbox.CheckedChanged += new System.EventHandler(this.Button11_cbox_CheckedChanged);
            // 
            // Button10_cbox
            // 
            this.Button10_cbox.AutoSize = true;
            this.Button10_cbox.BackColor = System.Drawing.Color.White;
            this.Button10_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button10_cbox.Location = new System.Drawing.Point(119, 307);
            this.Button10_cbox.Name = "Button10_cbox";
            this.Button10_cbox.Size = new System.Drawing.Size(67, 16);
            this.Button10_cbox.TabIndex = 80;
            this.Button10_cbox.Text = "ボタン１０";
            this.Button10_cbox.UseVisualStyleBackColor = false;
            this.Button10_cbox.Visible = false;
            this.Button10_cbox.CheckedChanged += new System.EventHandler(this.Button10_cbox_CheckedChanged);
            // 
            // Button9_cbox
            // 
            this.Button9_cbox.AutoSize = true;
            this.Button9_cbox.BackColor = System.Drawing.Color.White;
            this.Button9_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button9_cbox.Location = new System.Drawing.Point(119, 287);
            this.Button9_cbox.Name = "Button9_cbox";
            this.Button9_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button9_cbox.TabIndex = 79;
            this.Button9_cbox.Text = "ボタン９";
            this.Button9_cbox.UseVisualStyleBackColor = false;
            this.Button9_cbox.Visible = false;
            this.Button9_cbox.CheckedChanged += new System.EventHandler(this.Button9_cbox_CheckedChanged);
            // 
            // Button8_cbox
            // 
            this.Button8_cbox.AutoSize = true;
            this.Button8_cbox.BackColor = System.Drawing.Color.White;
            this.Button8_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button8_cbox.Location = new System.Drawing.Point(119, 265);
            this.Button8_cbox.Name = "Button8_cbox";
            this.Button8_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button8_cbox.TabIndex = 78;
            this.Button8_cbox.Text = "ボタン８";
            this.Button8_cbox.UseVisualStyleBackColor = false;
            this.Button8_cbox.Visible = false;
            this.Button8_cbox.CheckedChanged += new System.EventHandler(this.Button8_cbox_CheckedChanged);
            // 
            // Button7_cbox
            // 
            this.Button7_cbox.AutoSize = true;
            this.Button7_cbox.BackColor = System.Drawing.Color.White;
            this.Button7_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button7_cbox.Location = new System.Drawing.Point(119, 244);
            this.Button7_cbox.Name = "Button7_cbox";
            this.Button7_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button7_cbox.TabIndex = 77;
            this.Button7_cbox.Text = "ボタン７";
            this.Button7_cbox.UseVisualStyleBackColor = false;
            this.Button7_cbox.Visible = false;
            this.Button7_cbox.CheckedChanged += new System.EventHandler(this.Button7_cbox_CheckedChanged);
            // 
            // SetPin_combox
            // 
            this.SetPin_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetPin_combox.Enabled = false;
            this.SetPin_combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.SetPin_combox.FormattingEnabled = true;
            this.SetPin_combox.Items.AddRange(new object[] {
            "01ピン",
            "02ピン",
            "03ピン",
            "04ピン",
            "05ピン",
            "06ピン",
            "07ピン",
            "08ピン",
            "09ピン",
            "10ピン",
            "11ピン",
            "12ピン"});
            this.SetPin_combox.Location = new System.Drawing.Point(53, 82);
            this.SetPin_combox.MaxDropDownItems = 12;
            this.SetPin_combox.Name = "SetPin_combox";
            this.SetPin_combox.Size = new System.Drawing.Size(121, 20);
            this.SetPin_combox.TabIndex = 46;
            this.SetPin_combox.SelectedIndexChanged += new System.EventHandler(this.SetPin_combox_SelectedIndexChanged);
            // 
            // Button6_cbox
            // 
            this.Button6_cbox.AutoSize = true;
            this.Button6_cbox.BackColor = System.Drawing.Color.White;
            this.Button6_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button6_cbox.Location = new System.Drawing.Point(119, 223);
            this.Button6_cbox.Name = "Button6_cbox";
            this.Button6_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button6_cbox.TabIndex = 45;
            this.Button6_cbox.Text = "ボタン６";
            this.Button6_cbox.UseVisualStyleBackColor = false;
            this.Button6_cbox.Visible = false;
            this.Button6_cbox.CheckedChanged += new System.EventHandler(this.Button6_cbox_CheckedChanged);
            // 
            // Button5_cbox
            // 
            this.Button5_cbox.AutoSize = true;
            this.Button5_cbox.BackColor = System.Drawing.Color.White;
            this.Button5_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button5_cbox.Location = new System.Drawing.Point(119, 202);
            this.Button5_cbox.Name = "Button5_cbox";
            this.Button5_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button5_cbox.TabIndex = 44;
            this.Button5_cbox.Text = "ボタン５";
            this.Button5_cbox.UseVisualStyleBackColor = false;
            this.Button5_cbox.Visible = false;
            this.Button5_cbox.CheckedChanged += new System.EventHandler(this.Button5_cbox_CheckedChanged);
            // 
            // Button4_cbox
            // 
            this.Button4_cbox.AutoSize = true;
            this.Button4_cbox.BackColor = System.Drawing.Color.White;
            this.Button4_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button4_cbox.Location = new System.Drawing.Point(52, 349);
            this.Button4_cbox.Name = "Button4_cbox";
            this.Button4_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button4_cbox.TabIndex = 43;
            this.Button4_cbox.Text = "ボタン４";
            this.Button4_cbox.UseVisualStyleBackColor = false;
            this.Button4_cbox.Visible = false;
            this.Button4_cbox.CheckedChanged += new System.EventHandler(this.Button4_cbox_CheckedChanged);
            // 
            // Button3_cbox
            // 
            this.Button3_cbox.AutoSize = true;
            this.Button3_cbox.BackColor = System.Drawing.Color.White;
            this.Button3_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button3_cbox.Location = new System.Drawing.Point(52, 328);
            this.Button3_cbox.Name = "Button3_cbox";
            this.Button3_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button3_cbox.TabIndex = 42;
            this.Button3_cbox.Text = "ボタン３";
            this.Button3_cbox.UseVisualStyleBackColor = false;
            this.Button3_cbox.Visible = false;
            this.Button3_cbox.CheckedChanged += new System.EventHandler(this.Button3_cbox_CheckedChanged);
            // 
            // Button2_cbox
            // 
            this.Button2_cbox.AutoSize = true;
            this.Button2_cbox.BackColor = System.Drawing.Color.White;
            this.Button2_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button2_cbox.Location = new System.Drawing.Point(52, 307);
            this.Button2_cbox.Name = "Button2_cbox";
            this.Button2_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button2_cbox.TabIndex = 41;
            this.Button2_cbox.Text = "ボタン２";
            this.Button2_cbox.UseVisualStyleBackColor = false;
            this.Button2_cbox.Visible = false;
            this.Button2_cbox.CheckedChanged += new System.EventHandler(this.Button2_cbox_CheckedChanged);
            // 
            // Button1_cbox
            // 
            this.Button1_cbox.AutoSize = true;
            this.Button1_cbox.BackColor = System.Drawing.Color.White;
            this.Button1_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Button1_cbox.Location = new System.Drawing.Point(52, 286);
            this.Button1_cbox.Name = "Button1_cbox";
            this.Button1_cbox.Size = new System.Drawing.Size(59, 16);
            this.Button1_cbox.TabIndex = 40;
            this.Button1_cbox.Text = "ボタン１";
            this.Button1_cbox.UseVisualStyleBackColor = false;
            this.Button1_cbox.Visible = false;
            this.Button1_cbox.CheckedChanged += new System.EventHandler(this.Button1_cbox_CheckedChanged);
            // 
            // LeverRight_cbox
            // 
            this.LeverRight_cbox.AutoSize = true;
            this.LeverRight_cbox.BackColor = System.Drawing.Color.White;
            this.LeverRight_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.LeverRight_cbox.Location = new System.Drawing.Point(52, 265);
            this.LeverRight_cbox.Name = "LeverRight_cbox";
            this.LeverRight_cbox.Size = new System.Drawing.Size(65, 16);
            this.LeverRight_cbox.TabIndex = 39;
            this.LeverRight_cbox.Text = "レバー右";
            this.LeverRight_cbox.UseVisualStyleBackColor = false;
            this.LeverRight_cbox.Visible = false;
            this.LeverRight_cbox.CheckedChanged += new System.EventHandler(this.LeverRight_cbox_CheckedChanged);
            // 
            // LeverLeft_cbox
            // 
            this.LeverLeft_cbox.AutoSize = true;
            this.LeverLeft_cbox.BackColor = System.Drawing.Color.White;
            this.LeverLeft_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.LeverLeft_cbox.Location = new System.Drawing.Point(52, 244);
            this.LeverLeft_cbox.Name = "LeverLeft_cbox";
            this.LeverLeft_cbox.Size = new System.Drawing.Size(65, 16);
            this.LeverLeft_cbox.TabIndex = 38;
            this.LeverLeft_cbox.Text = "レバー左";
            this.LeverLeft_cbox.UseVisualStyleBackColor = false;
            this.LeverLeft_cbox.Visible = false;
            this.LeverLeft_cbox.CheckedChanged += new System.EventHandler(this.LeverLeft_cbox_CheckedChanged);
            // 
            // LeverDown_cbox
            // 
            this.LeverDown_cbox.AutoSize = true;
            this.LeverDown_cbox.BackColor = System.Drawing.Color.White;
            this.LeverDown_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.LeverDown_cbox.Location = new System.Drawing.Point(52, 223);
            this.LeverDown_cbox.Name = "LeverDown_cbox";
            this.LeverDown_cbox.Size = new System.Drawing.Size(65, 16);
            this.LeverDown_cbox.TabIndex = 37;
            this.LeverDown_cbox.Text = "レバー下";
            this.LeverDown_cbox.UseVisualStyleBackColor = false;
            this.LeverDown_cbox.Visible = false;
            this.LeverDown_cbox.CheckedChanged += new System.EventHandler(this.LeverDown_cbox_CheckedChanged);
            // 
            // LeverUp_cbox
            // 
            this.LeverUp_cbox.AutoSize = true;
            this.LeverUp_cbox.BackColor = System.Drawing.Color.White;
            this.LeverUp_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.LeverUp_cbox.Location = new System.Drawing.Point(52, 202);
            this.LeverUp_cbox.Name = "LeverUp_cbox";
            this.LeverUp_cbox.Size = new System.Drawing.Size(65, 16);
            this.LeverUp_cbox.TabIndex = 36;
            this.LeverUp_cbox.Text = "レバー上";
            this.LeverUp_cbox.UseVisualStyleBackColor = false;
            this.LeverUp_cbox.Visible = false;
            this.LeverUp_cbox.CheckedChanged += new System.EventHandler(this.LeverUp_cbox_CheckedChanged);
            // 
            // Win_cbox
            // 
            this.Win_cbox.AutoSize = true;
            this.Win_cbox.BackColor = System.Drawing.Color.White;
            this.Win_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Win_cbox.Location = new System.Drawing.Point(93, 270);
            this.Win_cbox.Name = "Win_cbox";
            this.Win_cbox.Size = new System.Drawing.Size(42, 16);
            this.Win_cbox.TabIndex = 35;
            this.Win_cbox.Text = "Win";
            this.Win_cbox.UseVisualStyleBackColor = false;
            this.Win_cbox.Visible = false;
            this.Win_cbox.CheckedChanged += new System.EventHandler(this.Win_cbox_CheckedChanged);
            // 
            // Shift_cbox
            // 
            this.Shift_cbox.AutoSize = true;
            this.Shift_cbox.BackColor = System.Drawing.Color.White;
            this.Shift_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Shift_cbox.Location = new System.Drawing.Point(93, 228);
            this.Shift_cbox.Name = "Shift_cbox";
            this.Shift_cbox.Size = new System.Drawing.Size(48, 16);
            this.Shift_cbox.TabIndex = 34;
            this.Shift_cbox.Text = "Shift";
            this.Shift_cbox.UseVisualStyleBackColor = false;
            this.Shift_cbox.Visible = false;
            this.Shift_cbox.CheckedChanged += new System.EventHandler(this.Shift_cbox_CheckedChanged);
            // 
            // Alt_cbox
            // 
            this.Alt_cbox.AutoSize = true;
            this.Alt_cbox.BackColor = System.Drawing.Color.White;
            this.Alt_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Alt_cbox.Location = new System.Drawing.Point(93, 249);
            this.Alt_cbox.Name = "Alt_cbox";
            this.Alt_cbox.Size = new System.Drawing.Size(39, 16);
            this.Alt_cbox.TabIndex = 33;
            this.Alt_cbox.Text = "Alt";
            this.Alt_cbox.UseVisualStyleBackColor = false;
            this.Alt_cbox.Visible = false;
            this.Alt_cbox.CheckedChanged += new System.EventHandler(this.Alt_cbox_CheckedChanged);
            // 
            // Ctrl_cbox
            // 
            this.Ctrl_cbox.AutoSize = true;
            this.Ctrl_cbox.BackColor = System.Drawing.Color.White;
            this.Ctrl_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Ctrl_cbox.Location = new System.Drawing.Point(93, 207);
            this.Ctrl_cbox.Name = "Ctrl_cbox";
            this.Ctrl_cbox.Size = new System.Drawing.Size(43, 16);
            this.Ctrl_cbox.TabIndex = 32;
            this.Ctrl_cbox.Text = "Ctrl";
            this.Ctrl_cbox.UseVisualStyleBackColor = false;
            this.Ctrl_cbox.Visible = false;
            this.Ctrl_cbox.CheckedChanged += new System.EventHandler(this.Ctrl_cbox_CheckedChanged);
            // 
            // mousevalue_combx
            // 
            this.mousevalue_combx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mousevalue_combx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.mousevalue_combx.FormattingEnabled = true;
            this.mousevalue_combx.Items.AddRange(new object[] {
            "左クリック",
            "右クリック",
            "ホイールクリック",
            "上移動",
            "下移動",
            "左移動",
            "右移動",
            "ホイール上",
            "ホイール下",
            "カーソル速度変更"});
            this.mousevalue_combx.Location = new System.Drawing.Point(53, 198);
            this.mousevalue_combx.Name = "mousevalue_combx";
            this.mousevalue_combx.Size = new System.Drawing.Size(121, 20);
            this.mousevalue_combx.TabIndex = 26;
            this.mousevalue_combx.Visible = false;
            this.mousevalue_combx.SelectedIndexChanged += new System.EventHandler(this.mousevalue_combx_SelectedIndexChanged);
            // 
            // devicetype_combox
            // 
            this.devicetype_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicetype_combox.Enabled = false;
            this.devicetype_combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_combox.FormattingEnabled = true;
            this.devicetype_combox.Items.AddRange(new object[] {
            "未設定",
            "マウス",
            "キーボード",
            "ジョイパッド"});
            this.devicetype_combox.Location = new System.Drawing.Point(53, 140);
            this.devicetype_combox.Name = "devicetype_combox";
            this.devicetype_combox.Size = new System.Drawing.Size(121, 20);
            this.devicetype_combox.TabIndex = 25;
            this.devicetype_combox.SelectedIndexChanged += new System.EventHandler(this.devicetype_combox_SelectedIndexChanged);
            // 
            // devicetype_lbl4
            // 
            this.devicetype_lbl4.AutoSize = true;
            this.devicetype_lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl4.Location = new System.Drawing.Point(272, 229);
            this.devicetype_lbl4.Name = "devicetype_lbl4";
            this.devicetype_lbl4.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl4.TabIndex = 99;
            this.devicetype_lbl4.Text = "04Pin";
            // 
            // devicetype_lbl1
            // 
            this.devicetype_lbl1.AutoSize = true;
            this.devicetype_lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl1.Location = new System.Drawing.Point(272, 72);
            this.devicetype_lbl1.Name = "devicetype_lbl1";
            this.devicetype_lbl1.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl1.TabIndex = 100;
            this.devicetype_lbl1.Text = "01Pin";
            // 
            // devicetype_lbl3
            // 
            this.devicetype_lbl3.AutoSize = true;
            this.devicetype_lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl3.Location = new System.Drawing.Point(271, 177);
            this.devicetype_lbl3.Name = "devicetype_lbl3";
            this.devicetype_lbl3.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl3.TabIndex = 101;
            this.devicetype_lbl3.Text = "03Pin";
            // 
            // devicetype_lbl2
            // 
            this.devicetype_lbl2.AutoSize = true;
            this.devicetype_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl2.Location = new System.Drawing.Point(272, 125);
            this.devicetype_lbl2.Name = "devicetype_lbl2";
            this.devicetype_lbl2.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl2.TabIndex = 102;
            this.devicetype_lbl2.Text = "02Pin";
            // 
            // devicetype_lbl9
            // 
            this.devicetype_lbl9.AutoSize = true;
            this.devicetype_lbl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl9.Location = new System.Drawing.Point(760, 229);
            this.devicetype_lbl9.Name = "devicetype_lbl9";
            this.devicetype_lbl9.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl9.TabIndex = 103;
            this.devicetype_lbl9.Text = "09Pin";
            // 
            // devicetype_lbl8
            // 
            this.devicetype_lbl8.AutoSize = true;
            this.devicetype_lbl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl8.Location = new System.Drawing.Point(760, 281);
            this.devicetype_lbl8.Name = "devicetype_lbl8";
            this.devicetype_lbl8.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl8.TabIndex = 104;
            this.devicetype_lbl8.Text = "08Pin";
            // 
            // devicetype_lbl7
            // 
            this.devicetype_lbl7.AutoSize = true;
            this.devicetype_lbl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl7.Location = new System.Drawing.Point(760, 333);
            this.devicetype_lbl7.Name = "devicetype_lbl7";
            this.devicetype_lbl7.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl7.TabIndex = 105;
            this.devicetype_lbl7.Text = "07Pin";
            // 
            // DeviceAssign_lbl4
            // 
            this.DeviceAssign_lbl4.AutoSize = true;
            this.DeviceAssign_lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl4.Location = new System.Drawing.Point(272, 241);
            this.DeviceAssign_lbl4.Name = "DeviceAssign_lbl4";
            this.DeviceAssign_lbl4.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl4.TabIndex = 106;
            this.DeviceAssign_lbl4.Text = "未割当て";
            // 
            // DeviceAssign_lbl1
            // 
            this.DeviceAssign_lbl1.AutoSize = true;
            this.DeviceAssign_lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl1.Location = new System.Drawing.Point(272, 84);
            this.DeviceAssign_lbl1.Name = "DeviceAssign_lbl1";
            this.DeviceAssign_lbl1.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl1.TabIndex = 107;
            this.DeviceAssign_lbl1.Text = "未割当て";
            // 
            // DeviceAssign_lbl3
            // 
            this.DeviceAssign_lbl3.AutoSize = true;
            this.DeviceAssign_lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl3.Location = new System.Drawing.Point(271, 189);
            this.DeviceAssign_lbl3.Name = "DeviceAssign_lbl3";
            this.DeviceAssign_lbl3.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl3.TabIndex = 108;
            this.DeviceAssign_lbl3.Text = "未割当て";
            // 
            // DeviceAssign_lbl2
            // 
            this.DeviceAssign_lbl2.AutoSize = true;
            this.DeviceAssign_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl2.Location = new System.Drawing.Point(271, 137);
            this.DeviceAssign_lbl2.Name = "DeviceAssign_lbl2";
            this.DeviceAssign_lbl2.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl2.TabIndex = 109;
            this.DeviceAssign_lbl2.Text = "未割当て";
            // 
            // DeviceAssign_lbl9
            // 
            this.DeviceAssign_lbl9.AutoSize = true;
            this.DeviceAssign_lbl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl9.Location = new System.Drawing.Point(760, 241);
            this.DeviceAssign_lbl9.Name = "DeviceAssign_lbl9";
            this.DeviceAssign_lbl9.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl9.TabIndex = 110;
            this.DeviceAssign_lbl9.Text = "未割当て";
            // 
            // DeviceAssign_lbl8
            // 
            this.DeviceAssign_lbl8.AutoSize = true;
            this.DeviceAssign_lbl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl8.Location = new System.Drawing.Point(760, 293);
            this.DeviceAssign_lbl8.Name = "DeviceAssign_lbl8";
            this.DeviceAssign_lbl8.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl8.TabIndex = 111;
            this.DeviceAssign_lbl8.Text = "未割当て";
            // 
            // DeviceAssign_lbl7
            // 
            this.DeviceAssign_lbl7.AutoSize = true;
            this.DeviceAssign_lbl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl7.Location = new System.Drawing.Point(760, 345);
            this.DeviceAssign_lbl7.Name = "DeviceAssign_lbl7";
            this.DeviceAssign_lbl7.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl7.TabIndex = 112;
            this.DeviceAssign_lbl7.Text = "未割当て";
            // 
            // StatusBox_lbl
            // 
            this.StatusBox_lbl.AutoSize = true;
            this.StatusBox_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.StatusBox_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.StatusBox_lbl.Location = new System.Drawing.Point(756, 487);
            this.StatusBox_lbl.Name = "StatusBox_lbl";
            this.StatusBox_lbl.Size = new System.Drawing.Size(79, 12);
            this.StatusBox_lbl.TabIndex = 117;
            this.StatusBox_lbl.Text = "デバイス未接続";
            // 
            // StatusBox_lbl2
            // 
            this.StatusBox_lbl2.AutoSize = true;
            this.StatusBox_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.StatusBox_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.StatusBox_lbl2.Location = new System.Drawing.Point(18, 487);
            this.StatusBox_lbl2.Name = "StatusBox_lbl2";
            this.StatusBox_lbl2.Size = new System.Drawing.Size(322, 12);
            this.StatusBox_lbl2.TabIndex = 118;
            this.StatusBox_lbl2.Text = "REVIVE USB RENC Debounce, Configuration Tool起動しました";
            // 
            // devicetype_lbl5
            // 
            this.devicetype_lbl5.AutoSize = true;
            this.devicetype_lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl5.Location = new System.Drawing.Point(272, 281);
            this.devicetype_lbl5.Name = "devicetype_lbl5";
            this.devicetype_lbl5.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl5.TabIndex = 153;
            this.devicetype_lbl5.Text = "05Pin";
            // 
            // devicetype_lbl6
            // 
            this.devicetype_lbl6.AutoSize = true;
            this.devicetype_lbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl6.Location = new System.Drawing.Point(272, 333);
            this.devicetype_lbl6.Name = "devicetype_lbl6";
            this.devicetype_lbl6.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl6.TabIndex = 154;
            this.devicetype_lbl6.Text = "06Pin";
            // 
            // DeviceAssign_lbl5
            // 
            this.DeviceAssign_lbl5.AutoSize = true;
            this.DeviceAssign_lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl5.Location = new System.Drawing.Point(272, 293);
            this.DeviceAssign_lbl5.Name = "DeviceAssign_lbl5";
            this.DeviceAssign_lbl5.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl5.TabIndex = 155;
            this.DeviceAssign_lbl5.Text = "未割当て";
            // 
            // DeviceAssign_lbl6
            // 
            this.DeviceAssign_lbl6.AutoSize = true;
            this.DeviceAssign_lbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl6.Location = new System.Drawing.Point(272, 345);
            this.DeviceAssign_lbl6.Name = "DeviceAssign_lbl6";
            this.DeviceAssign_lbl6.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl6.TabIndex = 156;
            this.DeviceAssign_lbl6.Text = "未割当て";
            // 
            // devicetype_lbl10
            // 
            this.devicetype_lbl10.AutoSize = true;
            this.devicetype_lbl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl10.Location = new System.Drawing.Point(760, 177);
            this.devicetype_lbl10.Name = "devicetype_lbl10";
            this.devicetype_lbl10.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl10.TabIndex = 157;
            this.devicetype_lbl10.Text = "10Pin";
            // 
            // devicetype_lbl11
            // 
            this.devicetype_lbl11.AutoSize = true;
            this.devicetype_lbl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl11.Location = new System.Drawing.Point(760, 125);
            this.devicetype_lbl11.Name = "devicetype_lbl11";
            this.devicetype_lbl11.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl11.TabIndex = 158;
            this.devicetype_lbl11.Text = "11Pin";
            // 
            // devicetype_lbl12
            // 
            this.devicetype_lbl12.AutoSize = true;
            this.devicetype_lbl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.devicetype_lbl12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_lbl12.Location = new System.Drawing.Point(760, 72);
            this.devicetype_lbl12.Name = "devicetype_lbl12";
            this.devicetype_lbl12.Size = new System.Drawing.Size(33, 12);
            this.devicetype_lbl12.TabIndex = 159;
            this.devicetype_lbl12.Text = "12Pin";
            // 
            // DeviceAssign_lbl10
            // 
            this.DeviceAssign_lbl10.AutoSize = true;
            this.DeviceAssign_lbl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl10.Location = new System.Drawing.Point(760, 189);
            this.DeviceAssign_lbl10.Name = "DeviceAssign_lbl10";
            this.DeviceAssign_lbl10.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl10.TabIndex = 160;
            this.DeviceAssign_lbl10.Text = "未割当て";
            // 
            // DeviceAssign_lbl11
            // 
            this.DeviceAssign_lbl11.AutoSize = true;
            this.DeviceAssign_lbl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl11.Location = new System.Drawing.Point(760, 137);
            this.DeviceAssign_lbl11.Name = "DeviceAssign_lbl11";
            this.DeviceAssign_lbl11.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl11.TabIndex = 161;
            this.DeviceAssign_lbl11.Text = "未割当て";
            // 
            // DeviceAssign_lbl12
            // 
            this.DeviceAssign_lbl12.AutoSize = true;
            this.DeviceAssign_lbl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.DeviceAssign_lbl12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DeviceAssign_lbl12.Location = new System.Drawing.Point(760, 84);
            this.DeviceAssign_lbl12.Name = "DeviceAssign_lbl12";
            this.DeviceAssign_lbl12.Size = new System.Drawing.Size(50, 12);
            this.DeviceAssign_lbl12.TabIndex = 162;
            this.DeviceAssign_lbl12.Text = "未割当て";
            // 
            // ButtonPressIcon12
            // 
            this.ButtonPressIcon12.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon12.Image = global::Revive_USB_CT.Properties.Resources.FLAG12;
            this.ButtonPressIcon12.Location = new System.Drawing.Point(698, 47);
            this.ButtonPressIcon12.Name = "ButtonPressIcon12";
            this.ButtonPressIcon12.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon12.TabIndex = 152;
            this.ButtonPressIcon12.TabStop = false;
            this.ButtonPressIcon12.Visible = false;
            // 
            // ButtonPressIcon11
            // 
            this.ButtonPressIcon11.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon11.Image = global::Revive_USB_CT.Properties.Resources.FLAG11;
            this.ButtonPressIcon11.Location = new System.Drawing.Point(698, 100);
            this.ButtonPressIcon11.Name = "ButtonPressIcon11";
            this.ButtonPressIcon11.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon11.TabIndex = 151;
            this.ButtonPressIcon11.TabStop = false;
            this.ButtonPressIcon11.Visible = false;
            // 
            // ButtonPressIcon10
            // 
            this.ButtonPressIcon10.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon10.Image = global::Revive_USB_CT.Properties.Resources.FLAG10;
            this.ButtonPressIcon10.Location = new System.Drawing.Point(698, 152);
            this.ButtonPressIcon10.Name = "ButtonPressIcon10";
            this.ButtonPressIcon10.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon10.TabIndex = 150;
            this.ButtonPressIcon10.TabStop = false;
            this.ButtonPressIcon10.Visible = false;
            // 
            // ButtonPressIcon9
            // 
            this.ButtonPressIcon9.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon9.Image = global::Revive_USB_CT.Properties.Resources.FLAG09;
            this.ButtonPressIcon9.Location = new System.Drawing.Point(698, 204);
            this.ButtonPressIcon9.Name = "ButtonPressIcon9";
            this.ButtonPressIcon9.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon9.TabIndex = 149;
            this.ButtonPressIcon9.TabStop = false;
            this.ButtonPressIcon9.Visible = false;
            // 
            // ButtonPressIcon8
            // 
            this.ButtonPressIcon8.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon8.Image = global::Revive_USB_CT.Properties.Resources.FLAG08;
            this.ButtonPressIcon8.Location = new System.Drawing.Point(698, 256);
            this.ButtonPressIcon8.Name = "ButtonPressIcon8";
            this.ButtonPressIcon8.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon8.TabIndex = 148;
            this.ButtonPressIcon8.TabStop = false;
            this.ButtonPressIcon8.Visible = false;
            // 
            // Pin12A_pb
            // 
            this.Pin12A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin12A_pb.Image = global::Revive_USB_CT.Properties.Resources.B12Ap;
            this.Pin12A_pb.Location = new System.Drawing.Point(803, 50);
            this.Pin12A_pb.Name = "Pin12A_pb";
            this.Pin12A_pb.Size = new System.Drawing.Size(50, 19);
            this.Pin12A_pb.TabIndex = 142;
            this.Pin12A_pb.TabStop = false;
            this.Pin12A_pb.Visible = false;
            // 
            // Pin11A_pb
            // 
            this.Pin11A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin11A_pb.Image = global::Revive_USB_CT.Properties.Resources.B11Ap;
            this.Pin11A_pb.Location = new System.Drawing.Point(803, 103);
            this.Pin11A_pb.Name = "Pin11A_pb";
            this.Pin11A_pb.Size = new System.Drawing.Size(47, 19);
            this.Pin11A_pb.TabIndex = 141;
            this.Pin11A_pb.TabStop = false;
            this.Pin11A_pb.Visible = false;
            // 
            // Pin10A_pb
            // 
            this.Pin10A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin10A_pb.Image = global::Revive_USB_CT.Properties.Resources.B10Ap;
            this.Pin10A_pb.Location = new System.Drawing.Point(803, 155);
            this.Pin10A_pb.Name = "Pin10A_pb";
            this.Pin10A_pb.Size = new System.Drawing.Size(50, 19);
            this.Pin10A_pb.TabIndex = 140;
            this.Pin10A_pb.TabStop = false;
            this.Pin10A_pb.Visible = false;
            // 
            // Pin09A_pb
            // 
            this.Pin09A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin09A_pb.Image = global::Revive_USB_CT.Properties.Resources.B09Ap;
            this.Pin09A_pb.Location = new System.Drawing.Point(803, 207);
            this.Pin09A_pb.Name = "Pin09A_pb";
            this.Pin09A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin09A_pb.TabIndex = 139;
            this.Pin09A_pb.TabStop = false;
            this.Pin09A_pb.Visible = false;
            // 
            // Pin08A_pb
            // 
            this.Pin08A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin08A_pb.Image = global::Revive_USB_CT.Properties.Resources.B08Ap;
            this.Pin08A_pb.Location = new System.Drawing.Point(803, 259);
            this.Pin08A_pb.Name = "Pin08A_pb";
            this.Pin08A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin08A_pb.TabIndex = 138;
            this.Pin08A_pb.TabStop = false;
            this.Pin08A_pb.Visible = false;
            // 
            // Arrow_Mouse3_pb
            // 
            this.Arrow_Mouse3_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Mouse3_pb.Image = global::Revive_USB_CT.Properties.Resources.F_arrow;
            this.Arrow_Mouse3_pb.Location = new System.Drawing.Point(109, 224);
            this.Arrow_Mouse3_pb.Name = "Arrow_Mouse3_pb";
            this.Arrow_Mouse3_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Mouse3_pb.TabIndex = 137;
            this.Arrow_Mouse3_pb.TabStop = false;
            this.Arrow_Mouse3_pb.Visible = false;
            // 
            // Arrow_Mouse1_pb
            // 
            this.Arrow_Mouse1_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Mouse1_pb.Image = global::Revive_USB_CT.Properties.Resources.F_arrow;
            this.Arrow_Mouse1_pb.Location = new System.Drawing.Point(109, 342);
            this.Arrow_Mouse1_pb.Name = "Arrow_Mouse1_pb";
            this.Arrow_Mouse1_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Mouse1_pb.TabIndex = 133;
            this.Arrow_Mouse1_pb.TabStop = false;
            this.Arrow_Mouse1_pb.Visible = false;
            // 
            // Pin01A_pb
            // 
            this.Pin01A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin01A_pb.Image = ((System.Drawing.Image)(resources.GetObject("Pin01A_pb.Image")));
            this.Pin01A_pb.Location = new System.Drawing.Point(228, 50);
            this.Pin01A_pb.Name = "Pin01A_pb";
            this.Pin01A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin01A_pb.TabIndex = 132;
            this.Pin01A_pb.TabStop = false;
            this.Pin01A_pb.Visible = false;
            // 
            // Pin02A_pb
            // 
            this.Pin02A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin02A_pb.Image = global::Revive_USB_CT.Properties.Resources.B02Ap;
            this.Pin02A_pb.Location = new System.Drawing.Point(228, 103);
            this.Pin02A_pb.Name = "Pin02A_pb";
            this.Pin02A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin02A_pb.TabIndex = 131;
            this.Pin02A_pb.TabStop = false;
            this.Pin02A_pb.Visible = false;
            // 
            // Pin03A_pb
            // 
            this.Pin03A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin03A_pb.Image = global::Revive_USB_CT.Properties.Resources.B03Ap;
            this.Pin03A_pb.Location = new System.Drawing.Point(228, 155);
            this.Pin03A_pb.Name = "Pin03A_pb";
            this.Pin03A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin03A_pb.TabIndex = 130;
            this.Pin03A_pb.TabStop = false;
            this.Pin03A_pb.Visible = false;
            // 
            // Pin04A_pb
            // 
            this.Pin04A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin04A_pb.Image = global::Revive_USB_CT.Properties.Resources.B04Ap;
            this.Pin04A_pb.Location = new System.Drawing.Point(228, 207);
            this.Pin04A_pb.Name = "Pin04A_pb";
            this.Pin04A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin04A_pb.TabIndex = 129;
            this.Pin04A_pb.TabStop = false;
            this.Pin04A_pb.Visible = false;
            // 
            // Pin05A_pb
            // 
            this.Pin05A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin05A_pb.Image = global::Revive_USB_CT.Properties.Resources.B05Ap;
            this.Pin05A_pb.Location = new System.Drawing.Point(228, 259);
            this.Pin05A_pb.Name = "Pin05A_pb";
            this.Pin05A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin05A_pb.TabIndex = 128;
            this.Pin05A_pb.TabStop = false;
            this.Pin05A_pb.Visible = false;
            // 
            // Pin02B_pb
            // 
            this.Pin02B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin02B_pb.Image = global::Revive_USB_CT.Properties.Resources.B02Bp;
            this.Pin02B_pb.Location = new System.Drawing.Point(228, 103);
            this.Pin02B_pb.Name = "Pin02B_pb";
            this.Pin02B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin02B_pb.TabIndex = 126;
            this.Pin02B_pb.TabStop = false;
            this.Pin02B_pb.Click += new System.EventHandler(this.PIN2_lbl_Click);
            // 
            // Pin03B_pb
            // 
            this.Pin03B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin03B_pb.Image = global::Revive_USB_CT.Properties.Resources.B03Bp;
            this.Pin03B_pb.Location = new System.Drawing.Point(228, 155);
            this.Pin03B_pb.Name = "Pin03B_pb";
            this.Pin03B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin03B_pb.TabIndex = 125;
            this.Pin03B_pb.TabStop = false;
            this.Pin03B_pb.Click += new System.EventHandler(this.PIN3_lbl_Click);
            // 
            // Pin04B_pb
            // 
            this.Pin04B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin04B_pb.Image = global::Revive_USB_CT.Properties.Resources.B04Bp;
            this.Pin04B_pb.Location = new System.Drawing.Point(228, 207);
            this.Pin04B_pb.Name = "Pin04B_pb";
            this.Pin04B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin04B_pb.TabIndex = 124;
            this.Pin04B_pb.TabStop = false;
            this.Pin04B_pb.Click += new System.EventHandler(this.PIN4_lbl_Click);
            // 
            // Pin01B_pb
            // 
            this.Pin01B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin01B_pb.Image = global::Revive_USB_CT.Properties.Resources.B01Bp;
            this.Pin01B_pb.Location = new System.Drawing.Point(228, 50);
            this.Pin01B_pb.Name = "Pin01B_pb";
            this.Pin01B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin01B_pb.TabIndex = 123;
            this.Pin01B_pb.TabStop = false;
            this.Pin01B_pb.Click += new System.EventHandler(this.PIN1_lbl_Click);
            // 
            // Pin05B_pb
            // 
            this.Pin05B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin05B_pb.Image = global::Revive_USB_CT.Properties.Resources.B05Bp;
            this.Pin05B_pb.Location = new System.Drawing.Point(228, 259);
            this.Pin05B_pb.Name = "Pin05B_pb";
            this.Pin05B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin05B_pb.TabIndex = 122;
            this.Pin05B_pb.TabStop = false;
            this.Pin05B_pb.Click += new System.EventHandler(this.PIN5_lbl_Click);
            // 
            // Pin06B_pb
            // 
            this.Pin06B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin06B_pb.Image = global::Revive_USB_CT.Properties.Resources.B06B;
            this.Pin06B_pb.Location = new System.Drawing.Point(228, 311);
            this.Pin06B_pb.Name = "Pin06B_pb";
            this.Pin06B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin06B_pb.TabIndex = 121;
            this.Pin06B_pb.TabStop = false;
            this.Pin06B_pb.Click += new System.EventHandler(this.PIN6_lbl_Click);
            // 
            // Pin07A_pb
            // 
            this.Pin07A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin07A_pb.Image = global::Revive_USB_CT.Properties.Resources.B07Ap;
            this.Pin07A_pb.Location = new System.Drawing.Point(803, 311);
            this.Pin07A_pb.Name = "Pin07A_pb";
            this.Pin07A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin07A_pb.TabIndex = 120;
            this.Pin07A_pb.TabStop = false;
            this.Pin07A_pb.Visible = false;
            // 
            // Pin07B_pb
            // 
            this.Pin07B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin07B_pb.Image = global::Revive_USB_CT.Properties.Resources.B07Bp;
            this.Pin07B_pb.Location = new System.Drawing.Point(803, 311);
            this.Pin07B_pb.Name = "Pin07B_pb";
            this.Pin07B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin07B_pb.TabIndex = 119;
            this.Pin07B_pb.TabStop = false;
            this.Pin07B_pb.Click += new System.EventHandler(this.PIN7_lbl_Click);
            // 
            // Arrow_Com_pb
            // 
            this.Arrow_Com_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Com_pb.Image = global::Revive_USB_CT.Properties.Resources.F_arrow;
            this.Arrow_Com_pb.Location = new System.Drawing.Point(109, 375);
            this.Arrow_Com_pb.Name = "Arrow_Com_pb";
            this.Arrow_Com_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Com_pb.TabIndex = 115;
            this.Arrow_Com_pb.TabStop = false;
            this.Arrow_Com_pb.Visible = false;
            // 
            // Arrow_Keyboard_pb
            // 
            this.Arrow_Keyboard_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Keyboard_pb.Image = global::Revive_USB_CT.Properties.Resources.F_arrow;
            this.Arrow_Keyboard_pb.Location = new System.Drawing.Point(109, 294);
            this.Arrow_Keyboard_pb.Name = "Arrow_Keyboard_pb";
            this.Arrow_Keyboard_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Keyboard_pb.TabIndex = 114;
            this.Arrow_Keyboard_pb.TabStop = false;
            this.Arrow_Keyboard_pb.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Revive_USB_CT.Properties.Resources.F_wariate;
            this.pictureBox5.Location = new System.Drawing.Point(96, 182);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 13);
            this.pictureBox5.TabIndex = 113;
            this.pictureBox5.TabStop = false;
            // 
            // Status_C_pb
            // 
            this.Status_C_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_C_pb.Image = global::Revive_USB_CT.Properties.Resources.ON;
            this.Status_C_pb.Location = new System.Drawing.Point(843, 489);
            this.Status_C_pb.Name = "Status_C_pb";
            this.Status_C_pb.Size = new System.Drawing.Size(27, 8);
            this.Status_C_pb.TabIndex = 94;
            this.Status_C_pb.TabStop = false;
            this.Status_C_pb.Visible = false;
            // 
            // ButtonPressIcon5
            // 
            this.ButtonPressIcon5.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon5.Image = global::Revive_USB_CT.Properties.Resources.FLAG05;
            this.ButtonPressIcon5.Location = new System.Drawing.Point(342, 256);
            this.ButtonPressIcon5.Name = "ButtonPressIcon5";
            this.ButtonPressIcon5.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon5.TabIndex = 92;
            this.ButtonPressIcon5.TabStop = false;
            this.ButtonPressIcon5.Visible = false;
            // 
            // ButtonPressIcon6
            // 
            this.ButtonPressIcon6.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon6.Image = global::Revive_USB_CT.Properties.Resources.FLAG06;
            this.ButtonPressIcon6.Location = new System.Drawing.Point(342, 308);
            this.ButtonPressIcon6.Name = "ButtonPressIcon6";
            this.ButtonPressIcon6.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon6.TabIndex = 91;
            this.ButtonPressIcon6.TabStop = false;
            this.ButtonPressIcon6.Visible = false;
            // 
            // ButtonPressIcon7
            // 
            this.ButtonPressIcon7.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon7.Image = global::Revive_USB_CT.Properties.Resources.FLAG07;
            this.ButtonPressIcon7.Location = new System.Drawing.Point(698, 308);
            this.ButtonPressIcon7.Name = "ButtonPressIcon7";
            this.ButtonPressIcon7.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon7.TabIndex = 90;
            this.ButtonPressIcon7.TabStop = false;
            this.ButtonPressIcon7.Visible = false;
            // 
            // Changevalue_btn
            // 
            this.Changevalue_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Changevalue_btn.BackgroundImage")));
            this.Changevalue_btn.Enabled = false;
            this.Changevalue_btn.Location = new System.Drawing.Point(53, 420);
            this.Changevalue_btn.Name = "Changevalue_btn";
            this.Changevalue_btn.Size = new System.Drawing.Size(121, 29);
            this.Changevalue_btn.TabIndex = 24;
            this.Changevalue_btn.UseVisualStyleBackColor = true;
            this.Changevalue_btn.Click += new System.EventHandler(this.Changevalue_btn_Click);
            // 
            // ButtonPressIcon4
            // 
            this.ButtonPressIcon4.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon4.Image = global::Revive_USB_CT.Properties.Resources.FLAG04;
            this.ButtonPressIcon4.Location = new System.Drawing.Point(342, 204);
            this.ButtonPressIcon4.Name = "ButtonPressIcon4";
            this.ButtonPressIcon4.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon4.TabIndex = 87;
            this.ButtonPressIcon4.TabStop = false;
            this.ButtonPressIcon4.Visible = false;
            // 
            // ButtonPressIcon3
            // 
            this.ButtonPressIcon3.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon3.Image = global::Revive_USB_CT.Properties.Resources.FLAG03;
            this.ButtonPressIcon3.Location = new System.Drawing.Point(342, 152);
            this.ButtonPressIcon3.Name = "ButtonPressIcon3";
            this.ButtonPressIcon3.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon3.TabIndex = 86;
            this.ButtonPressIcon3.TabStop = false;
            this.ButtonPressIcon3.Visible = false;
            // 
            // ButtonPressIcon2
            // 
            this.ButtonPressIcon2.BackColor = System.Drawing.Color.White;
            this.ButtonPressIcon2.Image = global::Revive_USB_CT.Properties.Resources.FLAG02;
            this.ButtonPressIcon2.InitialImage = null;
            this.ButtonPressIcon2.Location = new System.Drawing.Point(342, 100);
            this.ButtonPressIcon2.Name = "ButtonPressIcon2";
            this.ButtonPressIcon2.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon2.TabIndex = 85;
            this.ButtonPressIcon2.TabStop = false;
            this.ButtonPressIcon2.Visible = false;
            // 
            // ButtonPressIcon1
            // 
            this.ButtonPressIcon1.BackColor = System.Drawing.Color.Black;
            this.ButtonPressIcon1.Image = global::Revive_USB_CT.Properties.Resources.FLAG01;
            this.ButtonPressIcon1.Location = new System.Drawing.Point(342, 47);
            this.ButtonPressIcon1.Name = "ButtonPressIcon1";
            this.ButtonPressIcon1.Size = new System.Drawing.Size(32, 26);
            this.ButtonPressIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonPressIcon1.TabIndex = 84;
            this.ButtonPressIcon1.TabStop = false;
            this.ButtonPressIcon1.Visible = false;
            // 
            // Pin08B_pb
            // 
            this.Pin08B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin08B_pb.Image = global::Revive_USB_CT.Properties.Resources.B08Bp;
            this.Pin08B_pb.Location = new System.Drawing.Point(803, 259);
            this.Pin08B_pb.Name = "Pin08B_pb";
            this.Pin08B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin08B_pb.TabIndex = 143;
            this.Pin08B_pb.TabStop = false;
            this.Pin08B_pb.Click += new System.EventHandler(this.PIN8_lbl_Click);
            // 
            // Pin09B_pb
            // 
            this.Pin09B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin09B_pb.Image = global::Revive_USB_CT.Properties.Resources.B09Bp;
            this.Pin09B_pb.Location = new System.Drawing.Point(803, 207);
            this.Pin09B_pb.Name = "Pin09B_pb";
            this.Pin09B_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin09B_pb.TabIndex = 144;
            this.Pin09B_pb.TabStop = false;
            this.Pin09B_pb.Click += new System.EventHandler(this.PIN9_lbl_Click);
            // 
            // Pin10B_pb
            // 
            this.Pin10B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin10B_pb.Image = global::Revive_USB_CT.Properties.Resources.B10Bp;
            this.Pin10B_pb.Location = new System.Drawing.Point(803, 155);
            this.Pin10B_pb.Name = "Pin10B_pb";
            this.Pin10B_pb.Size = new System.Drawing.Size(50, 19);
            this.Pin10B_pb.TabIndex = 145;
            this.Pin10B_pb.TabStop = false;
            this.Pin10B_pb.Click += new System.EventHandler(this.PIN10_lbl_Click);
            // 
            // Pin11B_pb
            // 
            this.Pin11B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin11B_pb.Image = global::Revive_USB_CT.Properties.Resources.B11Bp;
            this.Pin11B_pb.Location = new System.Drawing.Point(803, 103);
            this.Pin11B_pb.Name = "Pin11B_pb";
            this.Pin11B_pb.Size = new System.Drawing.Size(47, 19);
            this.Pin11B_pb.TabIndex = 146;
            this.Pin11B_pb.TabStop = false;
            this.Pin11B_pb.Click += new System.EventHandler(this.PIN11_lbl_Click);
            // 
            // Pin12B_pb
            // 
            this.Pin12B_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin12B_pb.Image = global::Revive_USB_CT.Properties.Resources.B12Bp;
            this.Pin12B_pb.Location = new System.Drawing.Point(803, 50);
            this.Pin12B_pb.Name = "Pin12B_pb";
            this.Pin12B_pb.Size = new System.Drawing.Size(50, 19);
            this.Pin12B_pb.TabIndex = 147;
            this.Pin12B_pb.TabStop = false;
            this.Pin12B_pb.Click += new System.EventHandler(this.PIN12_lbl_Click);
            // 
            // Speed_Mouse4_pb
            // 
            this.Speed_Mouse4_pb.BackColor = System.Drawing.Color.Transparent;
            this.Speed_Mouse4_pb.Image = global::Revive_USB_CT.Properties.Resources.F_idou;
            this.Speed_Mouse4_pb.Location = new System.Drawing.Point(91, 239);
            this.Speed_Mouse4_pb.Name = "Speed_Mouse4_pb";
            this.Speed_Mouse4_pb.Size = new System.Drawing.Size(45, 13);
            this.Speed_Mouse4_pb.TabIndex = 134;
            this.Speed_Mouse4_pb.TabStop = false;
            this.Speed_Mouse4_pb.Visible = false;
            // 
            // Speed_Mouse5_pb
            // 
            this.Speed_Mouse5_pb.BackColor = System.Drawing.Color.Transparent;
            this.Speed_Mouse5_pb.Image = global::Revive_USB_CT.Properties.Resources.F_sokudo;
            this.Speed_Mouse5_pb.Location = new System.Drawing.Point(58, 277);
            this.Speed_Mouse5_pb.Name = "Speed_Mouse5_pb";
            this.Speed_Mouse5_pb.Size = new System.Drawing.Size(111, 24);
            this.Speed_Mouse5_pb.TabIndex = 136;
            this.Speed_Mouse5_pb.TabStop = false;
            this.Speed_Mouse5_pb.Visible = false;
            // 
            // Arrow_Mouse2_pb
            // 
            this.Arrow_Mouse2_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Mouse2_pb.Image = global::Revive_USB_CT.Properties.Resources.F_arrow;
            this.Arrow_Mouse2_pb.Location = new System.Drawing.Point(109, 306);
            this.Arrow_Mouse2_pb.Name = "Arrow_Mouse2_pb";
            this.Arrow_Mouse2_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Mouse2_pb.TabIndex = 135;
            this.Arrow_Mouse2_pb.TabStop = false;
            this.Arrow_Mouse2_pb.Visible = false;
            // 
            // Status_NC_pb
            // 
            this.Status_NC_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_NC_pb.Image = global::Revive_USB_CT.Properties.Resources.OFF;
            this.Status_NC_pb.Location = new System.Drawing.Point(843, 489);
            this.Status_NC_pb.Name = "Status_NC_pb";
            this.Status_NC_pb.Size = new System.Drawing.Size(27, 8);
            this.Status_NC_pb.TabIndex = 95;
            this.Status_NC_pb.TabStop = false;
            this.Status_NC_pb.Visible = false;
            this.Status_NC_pb.Click += new System.EventHandler(this.Status_NC_pb_Click);
            // 
            // Pin06A_pb
            // 
            this.Pin06A_pb.BackColor = System.Drawing.SystemColors.Control;
            this.Pin06A_pb.Image = global::Revive_USB_CT.Properties.Resources.B06Ap;
            this.Pin06A_pb.Location = new System.Drawing.Point(228, 311);
            this.Pin06A_pb.Name = "Pin06A_pb";
            this.Pin06A_pb.Size = new System.Drawing.Size(51, 19);
            this.Pin06A_pb.TabIndex = 127;
            this.Pin06A_pb.TabStop = false;
            this.Pin06A_pb.Visible = false;
            // 
            // BackGround_pb
            // 
            this.BackGround_pb.Image = global::Revive_USB_CT.Properties.Resources.BG_ON;
            this.BackGround_pb.Location = new System.Drawing.Point(0, 0);
            this.BackGround_pb.Name = "BackGround_pb";
            this.BackGround_pb.Size = new System.Drawing.Size(878, 500);
            this.BackGround_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackGround_pb.TabIndex = 163;
            this.BackGround_pb.TabStop = false;
            // 
            // smpl_interval_lbl1
            // 
            this.smpl_interval_lbl1.AutoSize = true;
            this.smpl_interval_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.smpl_interval_lbl1.Location = new System.Drawing.Point(6, 27);
            this.smpl_interval_lbl1.Name = "smpl_interval_lbl1";
            this.smpl_interval_lbl1.Size = new System.Drawing.Size(82, 12);
            this.smpl_interval_lbl1.TabIndex = 164;
            this.smpl_interval_lbl1.Text = "サンプリング周期";
            // 
            // smpl_interval_numUpDown
            // 
            this.smpl_interval_numUpDown.Location = new System.Drawing.Point(89, 25);
            this.smpl_interval_numUpDown.Maximum = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.smpl_interval_numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smpl_interval_numUpDown.Name = "smpl_interval_numUpDown";
            this.smpl_interval_numUpDown.Size = new System.Drawing.Size(38, 19);
            this.smpl_interval_numUpDown.TabIndex = 166;
            this.smpl_interval_numUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // smpl_interval_lbl2
            // 
            this.smpl_interval_lbl2.AutoSize = true;
            this.smpl_interval_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.smpl_interval_lbl2.Location = new System.Drawing.Point(128, 27);
            this.smpl_interval_lbl2.Name = "smpl_interval_lbl2";
            this.smpl_interval_lbl2.Size = new System.Drawing.Size(20, 12);
            this.smpl_interval_lbl2.TabIndex = 169;
            this.smpl_interval_lbl2.Text = "ms";
            // 
            // fw_version_lbl
            // 
            this.fw_version_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.fw_version_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.fw_version_lbl.Location = new System.Drawing.Point(573, 487);
            this.fw_version_lbl.Name = "fw_version_lbl";
            this.fw_version_lbl.Size = new System.Drawing.Size(171, 12);
            this.fw_version_lbl.TabIndex = 170;
            this.fw_version_lbl.Text = "FW Version";
            this.fw_version_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AllButtonSetting_grpbox
            // 
            this.AllButtonSetting_grpbox.Controls.Add(this.check_count_numUpDown);
            this.AllButtonSetting_grpbox.Controls.Add(this.smpl_interval_lbl1);
            this.AllButtonSetting_grpbox.Controls.Add(this.smpl_interval_lbl2);
            this.AllButtonSetting_grpbox.Controls.Add(this.check_count_lbl1);
            this.AllButtonSetting_grpbox.Controls.Add(this.check_count_lbl2);
            this.AllButtonSetting_grpbox.Controls.Add(this.smpl_interval_numUpDown);
            this.AllButtonSetting_grpbox.Enabled = false;
            this.AllButtonSetting_grpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.AllButtonSetting_grpbox.Location = new System.Drawing.Point(228, 375);
            this.AllButtonSetting_grpbox.Name = "AllButtonSetting_grpbox";
            this.AllButtonSetting_grpbox.Size = new System.Drawing.Size(155, 96);
            this.AllButtonSetting_grpbox.TabIndex = 171;
            this.AllButtonSetting_grpbox.TabStop = false;
            this.AllButtonSetting_grpbox.Text = "AllButtonSetting";
            // 
            // check_count_numUpDown
            // 
            this.check_count_numUpDown.Location = new System.Drawing.Point(89, 59);
            this.check_count_numUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.check_count_numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.check_count_numUpDown.Name = "check_count_numUpDown";
            this.check_count_numUpDown.Size = new System.Drawing.Size(38, 19);
            this.check_count_numUpDown.TabIndex = 167;
            this.check_count_numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // check_count_lbl1
            // 
            this.check_count_lbl1.AutoSize = true;
            this.check_count_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.check_count_lbl1.Location = new System.Drawing.Point(11, 61);
            this.check_count_lbl1.Name = "check_count_lbl1";
            this.check_count_lbl1.Size = new System.Drawing.Size(77, 12);
            this.check_count_lbl1.TabIndex = 165;
            this.check_count_lbl1.Text = "一致検出回数";
            // 
            // check_count_lbl2
            // 
            this.check_count_lbl2.AutoSize = true;
            this.check_count_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.check_count_lbl2.Location = new System.Drawing.Point(128, 61);
            this.check_count_lbl2.Name = "check_count_lbl2";
            this.check_count_lbl2.Size = new System.Drawing.Size(17, 12);
            this.check_count_lbl2.TabIndex = 168;
            this.check_count_lbl2.Text = "回";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 500);
            this.Controls.Add(this.StatusBox_lbl2);
            this.Controls.Add(this.RotaryEncoderSetting_grpbox);
            this.Controls.Add(this.AllButtonSetting_grpbox);
            this.Controls.Add(this.fw_version_lbl);
            this.Controls.Add(this.DeviceAssign_lbl12);
            this.Controls.Add(this.DeviceAssign_lbl11);
            this.Controls.Add(this.DeviceAssign_lbl10);
            this.Controls.Add(this.devicetype_lbl12);
            this.Controls.Add(this.devicetype_lbl11);
            this.Controls.Add(this.devicetype_lbl10);
            this.Controls.Add(this.DeviceAssign_lbl6);
            this.Controls.Add(this.DeviceAssign_lbl5);
            this.Controls.Add(this.devicetype_lbl6);
            this.Controls.Add(this.devicetype_lbl5);
            this.Controls.Add(this.ButtonPressIcon12);
            this.Controls.Add(this.ButtonPressIcon11);
            this.Controls.Add(this.ButtonPressIcon10);
            this.Controls.Add(this.ButtonPressIcon9);
            this.Controls.Add(this.ButtonPressIcon8);
            this.Controls.Add(this.Pin12A_pb);
            this.Controls.Add(this.Pin11A_pb);
            this.Controls.Add(this.Pin10A_pb);
            this.Controls.Add(this.Pin09A_pb);
            this.Controls.Add(this.Pin08A_pb);
            this.Controls.Add(this.Arrow_Mouse3_pb);
            this.Controls.Add(this.Arrow_Mouse1_pb);
            this.Controls.Add(this.Pin01A_pb);
            this.Controls.Add(this.Pin02A_pb);
            this.Controls.Add(this.Pin03A_pb);
            this.Controls.Add(this.Pin04A_pb);
            this.Controls.Add(this.Pin05A_pb);
            this.Controls.Add(this.Pin02B_pb);
            this.Controls.Add(this.Pin03B_pb);
            this.Controls.Add(this.Pin04B_pb);
            this.Controls.Add(this.Pin01B_pb);
            this.Controls.Add(this.Pin05B_pb);
            this.Controls.Add(this.Pin06B_pb);
            this.Controls.Add(this.Pin07A_pb);
            this.Controls.Add(this.Pin07B_pb);
            this.Controls.Add(this.StatusBox_lbl);
            this.Controls.Add(this.Arrow_Com_pb);
            this.Controls.Add(this.Arrow_Keyboard_pb);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.DeviceAssign_lbl7);
            this.Controls.Add(this.DeviceAssign_lbl8);
            this.Controls.Add(this.DeviceAssign_lbl9);
            this.Controls.Add(this.DeviceAssign_lbl2);
            this.Controls.Add(this.DeviceAssign_lbl3);
            this.Controls.Add(this.DeviceAssign_lbl1);
            this.Controls.Add(this.DeviceAssign_lbl4);
            this.Controls.Add(this.devicetype_lbl7);
            this.Controls.Add(this.devicetype_lbl8);
            this.Controls.Add(this.devicetype_lbl9);
            this.Controls.Add(this.devicetype_lbl2);
            this.Controls.Add(this.devicetype_lbl3);
            this.Controls.Add(this.devicetype_lbl1);
            this.Controls.Add(this.devicetype_lbl4);
            this.Controls.Add(this.Status_C_pb);
            this.Controls.Add(this.Button12_cbox);
            this.Controls.Add(this.Button11_cbox);
            this.Controls.Add(this.Button10_cbox);
            this.Controls.Add(this.Button9_cbox);
            this.Controls.Add(this.Button8_cbox);
            this.Controls.Add(this.Button7_cbox);
            this.Controls.Add(this.SetPin_combox);
            this.Controls.Add(this.Button6_cbox);
            this.Controls.Add(this.Button5_cbox);
            this.Controls.Add(this.Button4_cbox);
            this.Controls.Add(this.ButtonPressIcon5);
            this.Controls.Add(this.Button3_cbox);
            this.Controls.Add(this.Button2_cbox);
            this.Controls.Add(this.Button1_cbox);
            this.Controls.Add(this.LeverRight_cbox);
            this.Controls.Add(this.ButtonPressIcon6);
            this.Controls.Add(this.LeverLeft_cbox);
            this.Controls.Add(this.LeverDown_cbox);
            this.Controls.Add(this.LeverUp_cbox);
            this.Controls.Add(this.Win_cbox);
            this.Controls.Add(this.ButtonPressIcon7);
            this.Controls.Add(this.Shift_cbox);
            this.Controls.Add(this.Alt_cbox);
            this.Controls.Add(this.Ctrl_cbox);
            this.Controls.Add(this.KeyboardValue_txtbx);
            this.Controls.Add(this.mousevalue_combx);
            this.Controls.Add(this.devicetype_combox);
            this.Controls.Add(this.Changevalue_btn);
            this.Controls.Add(this.ButtonPressIcon4);
            this.Controls.Add(this.ButtonPressIcon3);
            this.Controls.Add(this.ButtonPressIcon2);
            this.Controls.Add(this.ButtonPressIcon1);
            this.Controls.Add(this.Pin08B_pb);
            this.Controls.Add(this.Pin09B_pb);
            this.Controls.Add(this.Pin10B_pb);
            this.Controls.Add(this.Pin11B_pb);
            this.Controls.Add(this.Pin12B_pb);
            this.Controls.Add(this.Speed_Mouse4_pb);
            this.Controls.Add(this.MouseMove_UD);
            this.Controls.Add(this.Speed_Mouse5_pb);
            this.Controls.Add(this.Arrow_Mouse2_pb);
            this.Controls.Add(this.Status_NC_pb);
            this.Controls.Add(this.Pin06A_pb);
            this.Controls.Add(this.BackGround_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(894, 538);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "REVIVE USB RENC Debounce, Configuration Tool ver 1.1.0";
            this.RotaryEncoderSetting_grpbox.ResumeLayout(false);
            this.RotaryEncoderSetting_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_count_renc_numUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouseMove_UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin12A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin11A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin10A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin09A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin08A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse3_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse1_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin01A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin02A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin03A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin04A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin05A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin02B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin03B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin04B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin01B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin05B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin06B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin07A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin07B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Com_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Keyboard_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPressIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin08B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin09B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin10B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin11B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin12B_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Mouse4_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Mouse5_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pin06A_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smpl_interval_numUpDown)).EndInit();
            this.AllButtonSetting_grpbox.ResumeLayout(false);
            this.AllButtonSetting_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_count_numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changevalue_btn;
        private System.ComponentModel.BackgroundWorker ReadWriteThread;
        private System.Windows.Forms.Timer FormUpdateTimer;
        private System.Windows.Forms.ToolTip ToggleLEDToolTip;
        private System.Windows.Forms.ToolTip PushbuttonStateTooltip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox devicetype_combox;
        private System.Windows.Forms.ComboBox mousevalue_combx;
        private System.Windows.Forms.TextBox KeyboardValue_txtbx;
        private System.Windows.Forms.CheckBox Ctrl_cbox;
        private System.Windows.Forms.CheckBox Win_cbox;
        private System.Windows.Forms.CheckBox Shift_cbox;
        private System.Windows.Forms.CheckBox Alt_cbox;
        private System.Windows.Forms.CheckBox LeverDown_cbox;
        private System.Windows.Forms.CheckBox LeverUp_cbox;
        private System.Windows.Forms.CheckBox LeverRight_cbox;
        private System.Windows.Forms.CheckBox LeverLeft_cbox;
        private System.Windows.Forms.CheckBox Button6_cbox;
        private System.Windows.Forms.CheckBox Button5_cbox;
        private System.Windows.Forms.CheckBox Button4_cbox;
        private System.Windows.Forms.CheckBox Button3_cbox;
        private System.Windows.Forms.CheckBox Button2_cbox;
        private System.Windows.Forms.CheckBox Button1_cbox;
        private System.Windows.Forms.ComboBox SetPin_combox;
        private System.Windows.Forms.CheckBox Button12_cbox;
        private System.Windows.Forms.CheckBox Button11_cbox;
        private System.Windows.Forms.CheckBox Button10_cbox;
        private System.Windows.Forms.CheckBox Button9_cbox;
        private System.Windows.Forms.CheckBox Button8_cbox;
        private System.Windows.Forms.CheckBox Button7_cbox;
        private System.Windows.Forms.NumericUpDown MouseMove_UD;
        private System.Windows.Forms.PictureBox ButtonPressIcon1;
        private System.Windows.Forms.PictureBox ButtonPressIcon2;
        private System.Windows.Forms.PictureBox ButtonPressIcon3;
        private System.Windows.Forms.PictureBox ButtonPressIcon4;
        private System.Windows.Forms.PictureBox ButtonPressIcon7;
        private System.Windows.Forms.PictureBox ButtonPressIcon6;
        private System.Windows.Forms.PictureBox ButtonPressIcon5;
        private System.Windows.Forms.PictureBox Status_C_pb;
        private System.Windows.Forms.PictureBox Status_NC_pb;
        private System.Windows.Forms.Label devicetype_lbl4;
        private System.Windows.Forms.Label devicetype_lbl1;
        private System.Windows.Forms.Label devicetype_lbl3;
        private System.Windows.Forms.Label devicetype_lbl2;
        private System.Windows.Forms.Label devicetype_lbl9;
        private System.Windows.Forms.Label devicetype_lbl8;
        private System.Windows.Forms.Label devicetype_lbl7;
        private System.Windows.Forms.Label DeviceAssign_lbl4;
        private System.Windows.Forms.Label DeviceAssign_lbl1;
        private System.Windows.Forms.Label DeviceAssign_lbl3;
        private System.Windows.Forms.Label DeviceAssign_lbl2;
        private System.Windows.Forms.Label DeviceAssign_lbl9;
        private System.Windows.Forms.Label DeviceAssign_lbl8;
        private System.Windows.Forms.Label DeviceAssign_lbl7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Arrow_Keyboard_pb;
        private System.Windows.Forms.PictureBox Arrow_Com_pb;
        private System.Windows.Forms.Label StatusBox_lbl;
        private System.Windows.Forms.Label StatusBox_lbl2;
        private System.Windows.Forms.PictureBox Pin07B_pb;
        private System.Windows.Forms.PictureBox Pin07A_pb;
        private System.Windows.Forms.PictureBox Pin06B_pb;
        private System.Windows.Forms.PictureBox Pin05B_pb;
        private System.Windows.Forms.PictureBox Pin01B_pb;
        private System.Windows.Forms.PictureBox Pin04B_pb;
        private System.Windows.Forms.PictureBox Pin03B_pb;
        private System.Windows.Forms.PictureBox Pin02B_pb;
        private System.Windows.Forms.PictureBox Pin06A_pb;
        private System.Windows.Forms.PictureBox Pin05A_pb;
        private System.Windows.Forms.PictureBox Pin04A_pb;
        private System.Windows.Forms.PictureBox Pin03A_pb;
        private System.Windows.Forms.PictureBox Pin02A_pb;
        private System.Windows.Forms.PictureBox Pin01A_pb;
        private System.Windows.Forms.PictureBox Arrow_Mouse1_pb;
        private System.Windows.Forms.PictureBox Speed_Mouse4_pb;
        private System.Windows.Forms.PictureBox Arrow_Mouse2_pb;
        private System.Windows.Forms.PictureBox Speed_Mouse5_pb;
        private System.Windows.Forms.PictureBox Arrow_Mouse3_pb;
        private System.Windows.Forms.PictureBox Pin08A_pb;
        private System.Windows.Forms.PictureBox Pin09A_pb;
        private System.Windows.Forms.PictureBox Pin10A_pb;
        private System.Windows.Forms.PictureBox Pin11A_pb;
        private System.Windows.Forms.PictureBox Pin12A_pb;
        private System.Windows.Forms.PictureBox Pin08B_pb;
        private System.Windows.Forms.PictureBox Pin09B_pb;
        private System.Windows.Forms.PictureBox Pin10B_pb;
        private System.Windows.Forms.PictureBox Pin11B_pb;
        private System.Windows.Forms.PictureBox Pin12B_pb;
        private System.Windows.Forms.PictureBox ButtonPressIcon8;
        private System.Windows.Forms.PictureBox ButtonPressIcon9;
        private System.Windows.Forms.PictureBox ButtonPressIcon10;
        private System.Windows.Forms.PictureBox ButtonPressIcon11;
        private System.Windows.Forms.PictureBox ButtonPressIcon12;
        private System.Windows.Forms.Label devicetype_lbl5;
        private System.Windows.Forms.Label devicetype_lbl6;
        private System.Windows.Forms.Label DeviceAssign_lbl5;
        private System.Windows.Forms.Label DeviceAssign_lbl6;
        private System.Windows.Forms.Label devicetype_lbl10;
        private System.Windows.Forms.Label devicetype_lbl11;
        private System.Windows.Forms.Label devicetype_lbl12;
        private System.Windows.Forms.Label DeviceAssign_lbl10;
        private System.Windows.Forms.Label DeviceAssign_lbl11;
        private System.Windows.Forms.Label DeviceAssign_lbl12;
        private System.Windows.Forms.PictureBox BackGround_pb;
        private System.Windows.Forms.Label smpl_interval_lbl1;
        private System.Windows.Forms.NumericUpDown smpl_interval_numUpDown;
        private System.Windows.Forms.Label smpl_interval_lbl2;
        private System.Windows.Forms.Label fw_version_lbl;
        private System.Windows.Forms.GroupBox AllButtonSetting_grpbox;
        private System.Windows.Forms.GroupBox RotaryEncoderSetting_grpbox;
        private System.Windows.Forms.CheckBox RotaryEncoder5_cbox;
        private System.Windows.Forms.CheckBox RotaryEncoder3_cbox;
        private System.Windows.Forms.CheckBox RotaryEncoder4_cbox;
        private System.Windows.Forms.CheckBox RotaryEncoder6_cbox;
        private System.Windows.Forms.CheckBox RotaryEncoder2_cbox;
        private System.Windows.Forms.CheckBox RotaryEncoder1_cbox;
        private System.Windows.Forms.NumericUpDown check_count_numUpDown;
        private System.Windows.Forms.Label check_count_lbl1;
        private System.Windows.Forms.Label check_count_lbl2;
        private System.Windows.Forms.NumericUpDown check_count_renc_numUpDown;
        private System.Windows.Forms.Label renc_check_count_lbl1;
        private System.Windows.Forms.Label renc_check_count_lbl2;
    }
}

