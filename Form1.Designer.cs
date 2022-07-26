
namespace skater
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
            this.boardSpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.madeByLabel = new System.Windows.Forms.Label();
            this.fovTB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.fovLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fovTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.rainbowHueTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.rainbowHueLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rainbowHueTB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lockInAirTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.disableRagdollTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.disableRogdollLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rainbowHueUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.statusLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fovUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.checkIfGameOpen = new System.Windows.Forms.Timer(this.components);
            this.statusInfoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.attachErrLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.opacityLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.opacityTB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.disableWipeoutsTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.disableWipeoutsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.speedHackTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.speedHackLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.wireframeTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.consoleTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.consoleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.drawPlayersTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sunRotationUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.sunRotationTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.sunRotationLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sunRotationTB = new Guna.UI2.WinForms.Guna2TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowHueUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationUD)).BeginInit();
            this.SuspendLayout();
            // 
            // boardSpeedTimer
            // 
            this.boardSpeedTimer.Interval = 25;
            this.boardSpeedTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeByLabel.Location = new System.Drawing.Point(9, 165);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(161, 16);
            this.madeByLabel.TabIndex = 17;
            this.madeByLabel.Text = "Made by kikkin_yo_azzez";
            // 
            // fovTB
            // 
            this.fovTB.Enabled = false;
            this.fovTB.Location = new System.Drawing.Point(255, 12);
            this.fovTB.Maximum = 180;
            this.fovTB.Minimum = -1;
            this.fovTB.Name = "fovTB";
            this.fovTB.Size = new System.Drawing.Size(273, 23);
            this.fovTB.TabIndex = 3;
            this.fovTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.fovTB.Value = -1;
            this.fovTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fovSlider_Scroll);
            // 
            // fovLabel
            // 
            this.fovLabel.BackColor = System.Drawing.Color.Transparent;
            this.fovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovLabel.ForeColor = System.Drawing.Color.White;
            this.fovLabel.Location = new System.Drawing.Point(55, 12);
            this.fovLabel.Name = "fovLabel";
            this.fovLabel.Size = new System.Drawing.Size(33, 20);
            this.fovLabel.TabIndex = 39;
            this.fovLabel.Text = "FOV";
            // 
            // fovTS
            // 
            this.fovTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fovTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.fovTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fovTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.fovTS.Location = new System.Drawing.Point(12, 12);
            this.fovTS.Name = "fovTS";
            this.fovTS.Size = new System.Drawing.Size(35, 20);
            this.fovTS.TabIndex = 0;
            this.fovTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fovTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fovTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.fovTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.fovTS.CheckedChanged += new System.EventHandler(this.fovTS_CheckedChanged);
            // 
            // rainbowHueTS
            // 
            this.rainbowHueTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rainbowHueTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rainbowHueTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rainbowHueTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rainbowHueTS.Location = new System.Drawing.Point(12, 38);
            this.rainbowHueTS.Name = "rainbowHueTS";
            this.rainbowHueTS.Size = new System.Drawing.Size(35, 20);
            this.rainbowHueTS.TabIndex = 4;
            this.rainbowHueTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rainbowHueTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rainbowHueTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.rainbowHueTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.rainbowHueTS.CheckedChanged += new System.EventHandler(this.rainbowHueTS_CheckedChanged);
            // 
            // rainbowHueLabel
            // 
            this.rainbowHueLabel.BackColor = System.Drawing.Color.Transparent;
            this.rainbowHueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainbowHueLabel.ForeColor = System.Drawing.Color.White;
            this.rainbowHueLabel.Location = new System.Drawing.Point(55, 38);
            this.rainbowHueLabel.Name = "rainbowHueLabel";
            this.rainbowHueLabel.Size = new System.Drawing.Size(92, 20);
            this.rainbowHueLabel.TabIndex = 49;
            this.rainbowHueLabel.Text = "Rainbow Hue";
            // 
            // rainbowHueTB
            // 
            this.rainbowHueTB.Enabled = false;
            this.rainbowHueTB.LargeChange = 1;
            this.rainbowHueTB.Location = new System.Drawing.Point(255, 38);
            this.rainbowHueTB.Maximum = 359;
            this.rainbowHueTB.Minimum = 1;
            this.rainbowHueTB.MouseWheelBarPartitions = 359;
            this.rainbowHueTB.Name = "rainbowHueTB";
            this.rainbowHueTB.Size = new System.Drawing.Size(273, 23);
            this.rainbowHueTB.TabIndex = 6;
            this.rainbowHueTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rainbowHueTB.Value = 1;
            this.rainbowHueTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rainbowHueSlider_Scroll);
            // 
            // lockInAirTS
            // 
            this.lockInAirTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lockInAirTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.lockInAirTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lockInAirTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.lockInAirTS.Location = new System.Drawing.Point(12, 142);
            this.lockInAirTS.Name = "lockInAirTS";
            this.lockInAirTS.Size = new System.Drawing.Size(35, 20);
            this.lockInAirTS.TabIndex = 12;
            this.lockInAirTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lockInAirTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lockInAirTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.lockInAirTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.lockInAirTS.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(55, 142);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 20);
            this.guna2HtmlLabel1.TabIndex = 52;
            this.guna2HtmlLabel1.Text = "Lock In Air";
            // 
            // disableRagdollTS
            // 
            this.disableRagdollTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.disableRagdollTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.disableRagdollTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.disableRagdollTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.disableRagdollTS.Location = new System.Drawing.Point(381, 93);
            this.disableRagdollTS.Name = "disableRagdollTS";
            this.disableRagdollTS.Size = new System.Drawing.Size(35, 20);
            this.disableRagdollTS.TabIndex = 15;
            this.disableRagdollTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.disableRagdollTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.disableRagdollTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.disableRagdollTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.disableRagdollTS.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // disableRogdollLabel
            // 
            this.disableRogdollLabel.BackColor = System.Drawing.Color.Transparent;
            this.disableRogdollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableRogdollLabel.ForeColor = System.Drawing.Color.White;
            this.disableRogdollLabel.Location = new System.Drawing.Point(424, 93);
            this.disableRogdollLabel.Name = "disableRogdollLabel";
            this.disableRogdollLabel.Size = new System.Drawing.Size(106, 20);
            this.disableRogdollLabel.TabIndex = 54;
            this.disableRogdollLabel.Text = "Disable Ragdoll";
            // 
            // rainbowHueUD
            // 
            this.rainbowHueUD.AutoRoundedCorners = true;
            this.rainbowHueUD.BackColor = System.Drawing.Color.Transparent;
            this.rainbowHueUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rainbowHueUD.BorderRadius = 10;
            this.rainbowHueUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rainbowHueUD.Enabled = false;
            this.rainbowHueUD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rainbowHueUD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rainbowHueUD.ForeColor = System.Drawing.Color.White;
            this.rainbowHueUD.Location = new System.Drawing.Point(188, 38);
            this.rainbowHueUD.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.rainbowHueUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rainbowHueUD.Name = "rainbowHueUD";
            this.rainbowHueUD.Size = new System.Drawing.Size(61, 23);
            this.rainbowHueUD.TabIndex = 5;
            this.rainbowHueUD.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rainbowHueUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rainbowHueUD.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(422, 150);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(36, 15);
            this.statusLabel.TabIndex = 58;
            this.statusLabel.Text = "Status: ";
            // 
            // fovUD
            // 
            this.fovUD.AutoRoundedCorners = true;
            this.fovUD.BackColor = System.Drawing.Color.Transparent;
            this.fovUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.fovUD.BorderRadius = 10;
            this.fovUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fovUD.Enabled = false;
            this.fovUD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fovUD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fovUD.ForeColor = System.Drawing.Color.White;
            this.fovUD.Location = new System.Drawing.Point(188, 12);
            this.fovUD.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.fovUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.fovUD.Name = "fovUD";
            this.fovUD.Size = new System.Drawing.Size(61, 23);
            this.fovUD.TabIndex = 2;
            this.fovUD.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.fovUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.fovUD.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged_1);
            // 
            // checkIfGameOpen
            // 
            this.checkIfGameOpen.Enabled = true;
            this.checkIfGameOpen.Interval = 1000;
            this.checkIfGameOpen.Tick += new System.EventHandler(this.checkIfGameOpen_Tick);
            // 
            // statusInfoLabel
            // 
            this.statusInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusInfoLabel.ForeColor = System.Drawing.Color.White;
            this.statusInfoLabel.Location = new System.Drawing.Point(459, 150);
            this.statusInfoLabel.Name = "statusInfoLabel";
            this.statusInfoLabel.Size = new System.Drawing.Size(66, 15);
            this.statusInfoLabel.TabIndex = 60;
            this.statusInfoLabel.Text = "Not Attached";
            // 
            // attachErrLabel
            // 
            this.attachErrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachErrLabel.BackColor = System.Drawing.Color.Transparent;
            this.attachErrLabel.ForeColor = System.Drawing.Color.White;
            this.attachErrLabel.Location = new System.Drawing.Point(419, 166);
            this.attachErrLabel.Name = "attachErrLabel";
            this.attachErrLabel.Size = new System.Drawing.Size(113, 15);
            this.attachErrLabel.TabIndex = 61;
            this.attachErrLabel.Text = "No Instances Detected";
            // 
            // opacityLabel
            // 
            this.opacityLabel.BackColor = System.Drawing.Color.Transparent;
            this.opacityLabel.ForeColor = System.Drawing.Color.White;
            this.opacityLabel.Location = new System.Drawing.Point(176, 166);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(39, 15);
            this.opacityLabel.TabIndex = 62;
            this.opacityLabel.Text = "Opacity";
            // 
            // opacityTB
            // 
            this.opacityTB.Location = new System.Drawing.Point(221, 168);
            this.opacityTB.Minimum = 1;
            this.opacityTB.Name = "opacityTB";
            this.opacityTB.Size = new System.Drawing.Size(151, 13);
            this.opacityTB.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.opacityTB.TabIndex = 17;
            this.opacityTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.opacityTB.Value = 85;
            this.opacityTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // disableWipeoutsTS
            // 
            this.disableWipeoutsTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.disableWipeoutsTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.disableWipeoutsTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.disableWipeoutsTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.disableWipeoutsTS.Location = new System.Drawing.Point(188, 116);
            this.disableWipeoutsTS.Name = "disableWipeoutsTS";
            this.disableWipeoutsTS.Size = new System.Drawing.Size(35, 20);
            this.disableWipeoutsTS.TabIndex = 16;
            this.disableWipeoutsTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.disableWipeoutsTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.disableWipeoutsTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.disableWipeoutsTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.disableWipeoutsTS.CheckedChanged += new System.EventHandler(this.disableWipeoutsTS_CheckedChanged);
            // 
            // disableWipeoutsLabel
            // 
            this.disableWipeoutsLabel.BackColor = System.Drawing.Color.Transparent;
            this.disableWipeoutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableWipeoutsLabel.ForeColor = System.Drawing.Color.White;
            this.disableWipeoutsLabel.Location = new System.Drawing.Point(231, 116);
            this.disableWipeoutsLabel.Name = "disableWipeoutsLabel";
            this.disableWipeoutsLabel.Size = new System.Drawing.Size(119, 20);
            this.disableWipeoutsLabel.TabIndex = 64;
            this.disableWipeoutsLabel.Text = "Disable Wipeouts";
            // 
            // speedHackTS
            // 
            this.speedHackTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.speedHackTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.speedHackTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.speedHackTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.speedHackTS.Location = new System.Drawing.Point(12, 90);
            this.speedHackTS.Name = "speedHackTS";
            this.speedHackTS.Size = new System.Drawing.Size(35, 20);
            this.speedHackTS.TabIndex = 10;
            this.speedHackTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.speedHackTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.speedHackTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.speedHackTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.speedHackTS.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged_1);
            // 
            // speedHackLabel
            // 
            this.speedHackLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedHackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedHackLabel.ForeColor = System.Drawing.Color.White;
            this.speedHackLabel.Location = new System.Drawing.Point(55, 90);
            this.speedHackLabel.Name = "speedHackLabel";
            this.speedHackLabel.Size = new System.Drawing.Size(84, 20);
            this.speedHackLabel.TabIndex = 66;
            this.speedHackLabel.Text = "Speed Hack";
            // 
            // wireframeTS
            // 
            this.wireframeTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wireframeTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.wireframeTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wireframeTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.wireframeTS.Location = new System.Drawing.Point(381, 116);
            this.wireframeTS.Name = "wireframeTS";
            this.wireframeTS.Size = new System.Drawing.Size(35, 20);
            this.wireframeTS.TabIndex = 13;
            this.wireframeTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wireframeTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wireframeTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.wireframeTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.wireframeTS.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_1);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(424, 116);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 20);
            this.guna2HtmlLabel3.TabIndex = 68;
            this.guna2HtmlLabel3.Text = "Wireframe Mode";
            // 
            // consoleTS
            // 
            this.consoleTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.consoleTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.consoleTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.consoleTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.consoleTS.Location = new System.Drawing.Point(12, 116);
            this.consoleTS.Name = "consoleTS";
            this.consoleTS.Size = new System.Drawing.Size(35, 20);
            this.consoleTS.TabIndex = 11;
            this.consoleTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.consoleTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.consoleTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.consoleTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.consoleTS.CheckedChanged += new System.EventHandler(this.consoleTS_CheckedChanged);
            // 
            // consoleLabel
            // 
            this.consoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLabel.ForeColor = System.Drawing.Color.White;
            this.consoleLabel.Location = new System.Drawing.Point(55, 116);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(59, 20);
            this.consoleLabel.TabIndex = 70;
            this.consoleLabel.Text = "Console";
            // 
            // drawPlayersTS
            // 
            this.drawPlayersTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.drawPlayersTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.drawPlayersTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.drawPlayersTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.drawPlayersTS.Location = new System.Drawing.Point(188, 93);
            this.drawPlayersTS.Name = "drawPlayersTS";
            this.drawPlayersTS.Size = new System.Drawing.Size(35, 20);
            this.drawPlayersTS.TabIndex = 14;
            this.drawPlayersTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.drawPlayersTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.drawPlayersTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.drawPlayersTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.drawPlayersTS.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged_2);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(231, 93);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(144, 20);
            this.guna2HtmlLabel2.TabIndex = 72;
            this.guna2HtmlLabel2.Text = "Disable Draw Players";
            // 
            // sunRotationUD
            // 
            this.sunRotationUD.AutoRoundedCorners = true;
            this.sunRotationUD.BackColor = System.Drawing.Color.Transparent;
            this.sunRotationUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sunRotationUD.BorderRadius = 10;
            this.sunRotationUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sunRotationUD.Enabled = false;
            this.sunRotationUD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.sunRotationUD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sunRotationUD.ForeColor = System.Drawing.Color.White;
            this.sunRotationUD.Location = new System.Drawing.Point(188, 64);
            this.sunRotationUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sunRotationUD.Name = "sunRotationUD";
            this.sunRotationUD.Size = new System.Drawing.Size(61, 23);
            this.sunRotationUD.TabIndex = 8;
            this.sunRotationUD.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sunRotationUD.ValueChanged += new System.EventHandler(this.sunRotationUD_ValueChanged);
            // 
            // sunRotationTS
            // 
            this.sunRotationTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.sunRotationTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sunRotationTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.sunRotationTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sunRotationTS.Location = new System.Drawing.Point(12, 64);
            this.sunRotationTS.Name = "sunRotationTS";
            this.sunRotationTS.Size = new System.Drawing.Size(35, 20);
            this.sunRotationTS.TabIndex = 7;
            this.sunRotationTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sunRotationTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sunRotationTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.sunRotationTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.sunRotationTS.CheckedChanged += new System.EventHandler(this.sunRotationTS_CheckedChanged);
            // 
            // sunRotationLabel
            // 
            this.sunRotationLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunRotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunRotationLabel.ForeColor = System.Drawing.Color.White;
            this.sunRotationLabel.Location = new System.Drawing.Point(55, 64);
            this.sunRotationLabel.Name = "sunRotationLabel";
            this.sunRotationLabel.Size = new System.Drawing.Size(89, 20);
            this.sunRotationLabel.TabIndex = 75;
            this.sunRotationLabel.Text = "Sun Rotation";
            // 
            // sunRotationTB
            // 
            this.sunRotationTB.Enabled = false;
            this.sunRotationTB.Location = new System.Drawing.Point(255, 64);
            this.sunRotationTB.Maximum = 10000;
            this.sunRotationTB.Name = "sunRotationTB";
            this.sunRotationTB.Size = new System.Drawing.Size(273, 23);
            this.sunRotationTB.TabIndex = 9;
            this.sunRotationTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sunRotationTB.Value = 0;
            this.sunRotationTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sunRotationTB_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.sunRotationUD);
            this.Controls.Add(this.sunRotationTS);
            this.Controls.Add(this.sunRotationLabel);
            this.Controls.Add(this.sunRotationTB);
            this.Controls.Add(this.drawPlayersTS);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.consoleTS);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.wireframeTS);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.speedHackTS);
            this.Controls.Add(this.speedHackLabel);
            this.Controls.Add(this.disableWipeoutsTS);
            this.Controls.Add(this.disableWipeoutsLabel);
            this.Controls.Add(this.opacityTB);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.attachErrLabel);
            this.Controls.Add(this.statusInfoLabel);
            this.Controls.Add(this.fovUD);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.rainbowHueUD);
            this.Controls.Add(this.disableRagdollTS);
            this.Controls.Add(this.disableRogdollLabel);
            this.Controls.Add(this.lockInAirTS);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.rainbowHueTS);
            this.Controls.Add(this.rainbowHueLabel);
            this.Controls.Add(this.rainbowHueTB);
            this.Controls.Add(this.fovTS);
            this.Controls.Add(this.fovLabel);
            this.Controls.Add(this.fovTB);
            this.Controls.Add(this.madeByLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.Text = "skater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rainbowHueUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer boardSpeedTimer;
        private System.Windows.Forms.Label madeByLabel;
        private Guna.UI2.WinForms.Guna2TrackBar fovTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel fovLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch fovTS;
        private Guna.UI2.WinForms.Guna2ToggleSwitch rainbowHueTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel rainbowHueLabel;
        private Guna.UI2.WinForms.Guna2TrackBar rainbowHueTB;
        private Guna.UI2.WinForms.Guna2ToggleSwitch lockInAirTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch disableRagdollTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel disableRogdollLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown rainbowHueUD;
        private Guna.UI2.WinForms.Guna2HtmlLabel statusLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown fovUD;
        private System.Windows.Forms.Timer checkIfGameOpen;
        private Guna.UI2.WinForms.Guna2HtmlLabel statusInfoLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel attachErrLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel opacityLabel;
        private Guna.UI2.WinForms.Guna2TrackBar opacityTB;
        private Guna.UI2.WinForms.Guna2ToggleSwitch disableWipeoutsTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel disableWipeoutsLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch speedHackTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel speedHackLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch wireframeTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch consoleTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel consoleLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch drawPlayersTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown sunRotationUD;
        private Guna.UI2.WinForms.Guna2ToggleSwitch sunRotationTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel sunRotationLabel;
        private Guna.UI2.WinForms.Guna2TrackBar sunRotationTB;
    }
}

