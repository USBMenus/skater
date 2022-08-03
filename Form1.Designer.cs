﻿
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
            this.drawPlayersTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sunRotationUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.sunRotationTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.sunRotationLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sunRotationTB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.infJumpTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.infJumpLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mainTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.playerTabPage = new System.Windows.Forms.TabPage();
            this.visualTabPage = new System.Windows.Forms.TabPage();
            this.miscTabPage = new System.Windows.Forms.TabPage();
            this.truckTightnessTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.truckTightnessTB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.wheelHardessTB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.wheelHardnessTS = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.wheelHardnessUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.truckTightnessUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowHueUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationUD)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playerTabPage.SuspendLayout();
            this.visualTabPage.SuspendLayout();
            this.miscTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wheelHardnessUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTightnessUD)).BeginInit();
            this.SuspendLayout();
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeByLabel.Location = new System.Drawing.Point(13, 202);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(161, 16);
            this.madeByLabel.TabIndex = 17;
            this.madeByLabel.Text = "Made by kikkin_yo_azzez";
            // 
            // fovTB
            // 
            this.fovTB.Enabled = false;
            this.fovTB.Location = new System.Drawing.Point(249, 6);
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
            this.fovLabel.Location = new System.Drawing.Point(49, 6);
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
            this.fovTS.Location = new System.Drawing.Point(6, 6);
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
            this.rainbowHueTS.Location = new System.Drawing.Point(6, 32);
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
            this.rainbowHueLabel.Location = new System.Drawing.Point(49, 32);
            this.rainbowHueLabel.Name = "rainbowHueLabel";
            this.rainbowHueLabel.Size = new System.Drawing.Size(92, 20);
            this.rainbowHueLabel.TabIndex = 49;
            this.rainbowHueLabel.Text = "Rainbow Hue";
            // 
            // rainbowHueTB
            // 
            this.rainbowHueTB.Enabled = false;
            this.rainbowHueTB.LargeChange = 1;
            this.rainbowHueTB.Location = new System.Drawing.Point(249, 32);
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
            this.lockInAirTS.Location = new System.Drawing.Point(6, 58);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(49, 58);
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
            this.disableRagdollTS.Location = new System.Drawing.Point(6, 110);
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
            this.disableRogdollLabel.Location = new System.Drawing.Point(49, 110);
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
            this.rainbowHueUD.Location = new System.Drawing.Point(182, 32);
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
            this.statusLabel.Location = new System.Drawing.Point(426, 187);
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
            this.fovUD.Location = new System.Drawing.Point(182, 6);
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
            this.statusInfoLabel.Location = new System.Drawing.Point(463, 187);
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
            this.attachErrLabel.Location = new System.Drawing.Point(423, 203);
            this.attachErrLabel.Name = "attachErrLabel";
            this.attachErrLabel.Size = new System.Drawing.Size(113, 15);
            this.attachErrLabel.TabIndex = 61;
            this.attachErrLabel.Text = "No Instances Detected";
            // 
            // opacityLabel
            // 
            this.opacityLabel.BackColor = System.Drawing.Color.Transparent;
            this.opacityLabel.ForeColor = System.Drawing.Color.White;
            this.opacityLabel.Location = new System.Drawing.Point(180, 203);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(39, 15);
            this.opacityLabel.TabIndex = 62;
            this.opacityLabel.Text = "Opacity";
            // 
            // opacityTB
            // 
            this.opacityTB.Location = new System.Drawing.Point(225, 205);
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
            this.disableWipeoutsTS.Location = new System.Drawing.Point(6, 84);
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
            this.disableWipeoutsLabel.Location = new System.Drawing.Point(49, 84);
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
            this.speedHackTS.Location = new System.Drawing.Point(6, 6);
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
            this.speedHackLabel.Location = new System.Drawing.Point(49, 6);
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
            this.wireframeTS.Location = new System.Drawing.Point(6, 84);
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
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(49, 84);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(114, 20);
            this.guna2HtmlLabel3.TabIndex = 68;
            this.guna2HtmlLabel3.Text = "Wireframe Mode";
            // 
            // drawPlayersTS
            // 
            this.drawPlayersTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.drawPlayersTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.drawPlayersTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.drawPlayersTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.drawPlayersTS.Location = new System.Drawing.Point(6, 110);
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
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(49, 110);
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
            this.sunRotationUD.Location = new System.Drawing.Point(182, 58);
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
            this.sunRotationTS.Location = new System.Drawing.Point(6, 58);
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
            this.sunRotationLabel.Location = new System.Drawing.Point(49, 58);
            this.sunRotationLabel.Name = "sunRotationLabel";
            this.sunRotationLabel.Size = new System.Drawing.Size(89, 20);
            this.sunRotationLabel.TabIndex = 75;
            this.sunRotationLabel.Text = "Sun Rotation";
            // 
            // sunRotationTB
            // 
            this.sunRotationTB.Enabled = false;
            this.sunRotationTB.Location = new System.Drawing.Point(249, 58);
            this.sunRotationTB.Maximum = 10000;
            this.sunRotationTB.Name = "sunRotationTB";
            this.sunRotationTB.Size = new System.Drawing.Size(273, 23);
            this.sunRotationTB.TabIndex = 9;
            this.sunRotationTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sunRotationTB.Value = 0;
            this.sunRotationTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sunRotationTB_Scroll);
            // 
            // infJumpTS
            // 
            this.infJumpTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.infJumpTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.infJumpTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.infJumpTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.infJumpTS.Location = new System.Drawing.Point(6, 32);
            this.infJumpTS.Name = "infJumpTS";
            this.infJumpTS.Size = new System.Drawing.Size(35, 20);
            this.infJumpTS.TabIndex = 76;
            this.infJumpTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.infJumpTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.infJumpTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.infJumpTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.infJumpTS.CheckedChanged += new System.EventHandler(this.infJumpTS_CheckedChanged);
            // 
            // infJumpLabel
            // 
            this.infJumpLabel.BackColor = System.Drawing.Color.Transparent;
            this.infJumpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infJumpLabel.ForeColor = System.Drawing.Color.White;
            this.infJumpLabel.Location = new System.Drawing.Point(49, 32);
            this.infJumpLabel.Name = "infJumpLabel";
            this.infJumpLabel.Size = new System.Drawing.Size(85, 20);
            this.infJumpLabel.TabIndex = 77;
            this.infJumpLabel.Text = "Infinite Jump";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playerTabPage);
            this.mainTabControl.Controls.Add(this.visualTabPage);
            this.mainTabControl.Controls.Add(this.miscTabPage);
            this.mainTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(548, 187);
            this.mainTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mainTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.mainTabControl.TabIndex = 78;
            this.mainTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mainTabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // playerTabPage
            // 
            this.playerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.playerTabPage.Controls.Add(this.speedHackTS);
            this.playerTabPage.Controls.Add(this.infJumpTS);
            this.playerTabPage.Controls.Add(this.guna2HtmlLabel1);
            this.playerTabPage.Controls.Add(this.infJumpLabel);
            this.playerTabPage.Controls.Add(this.lockInAirTS);
            this.playerTabPage.Controls.Add(this.disableRogdollLabel);
            this.playerTabPage.Controls.Add(this.disableRagdollTS);
            this.playerTabPage.Controls.Add(this.disableWipeoutsLabel);
            this.playerTabPage.Controls.Add(this.disableWipeoutsTS);
            this.playerTabPage.Controls.Add(this.speedHackLabel);
            this.playerTabPage.ForeColor = System.Drawing.Color.Transparent;
            this.playerTabPage.Location = new System.Drawing.Point(4, 44);
            this.playerTabPage.Name = "playerTabPage";
            this.playerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playerTabPage.Size = new System.Drawing.Size(540, 139);
            this.playerTabPage.TabIndex = 0;
            this.playerTabPage.Text = "Player";
            // 
            // visualTabPage
            // 
            this.visualTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.visualTabPage.Controls.Add(this.fovTS);
            this.visualTabPage.Controls.Add(this.sunRotationUD);
            this.visualTabPage.Controls.Add(this.fovTB);
            this.visualTabPage.Controls.Add(this.sunRotationTS);
            this.visualTabPage.Controls.Add(this.fovLabel);
            this.visualTabPage.Controls.Add(this.sunRotationLabel);
            this.visualTabPage.Controls.Add(this.rainbowHueTB);
            this.visualTabPage.Controls.Add(this.sunRotationTB);
            this.visualTabPage.Controls.Add(this.rainbowHueLabel);
            this.visualTabPage.Controls.Add(this.drawPlayersTS);
            this.visualTabPage.Controls.Add(this.rainbowHueTS);
            this.visualTabPage.Controls.Add(this.guna2HtmlLabel2);
            this.visualTabPage.Controls.Add(this.rainbowHueUD);
            this.visualTabPage.Controls.Add(this.wireframeTS);
            this.visualTabPage.Controls.Add(this.fovUD);
            this.visualTabPage.Controls.Add(this.guna2HtmlLabel3);
            this.visualTabPage.ForeColor = System.Drawing.Color.Transparent;
            this.visualTabPage.Location = new System.Drawing.Point(4, 44);
            this.visualTabPage.Name = "visualTabPage";
            this.visualTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visualTabPage.Size = new System.Drawing.Size(540, 139);
            this.visualTabPage.TabIndex = 1;
            this.visualTabPage.Text = "Visual";
            // 
            // miscTabPage
            // 
            this.miscTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.miscTabPage.Controls.Add(this.truckTightnessTS);
            this.miscTabPage.Controls.Add(this.truckTightnessTB);
            this.miscTabPage.Controls.Add(this.guna2HtmlLabel4);
            this.miscTabPage.Controls.Add(this.wheelHardessTB);
            this.miscTabPage.Controls.Add(this.guna2HtmlLabel5);
            this.miscTabPage.Controls.Add(this.wheelHardnessTS);
            this.miscTabPage.Controls.Add(this.wheelHardnessUD);
            this.miscTabPage.Controls.Add(this.truckTightnessUD);
            this.miscTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.miscTabPage.Location = new System.Drawing.Point(4, 44);
            this.miscTabPage.Name = "miscTabPage";
            this.miscTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.miscTabPage.Size = new System.Drawing.Size(540, 139);
            this.miscTabPage.TabIndex = 2;
            this.miscTabPage.Text = "Misc";
            // 
            // truckTightnessTS
            // 
            this.truckTightnessTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.truckTightnessTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.truckTightnessTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.truckTightnessTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.truckTightnessTS.Location = new System.Drawing.Point(6, 6);
            this.truckTightnessTS.Name = "truckTightnessTS";
            this.truckTightnessTS.Size = new System.Drawing.Size(35, 20);
            this.truckTightnessTS.TabIndex = 50;
            this.truckTightnessTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.truckTightnessTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.truckTightnessTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.truckTightnessTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.truckTightnessTS.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_2);
            // 
            // truckTightnessTB
            // 
            this.truckTightnessTB.Enabled = false;
            this.truckTightnessTB.Location = new System.Drawing.Point(249, 6);
            this.truckTightnessTB.Maximum = 4;
            this.truckTightnessTB.Minimum = -5;
            this.truckTightnessTB.MouseWheelBarPartitions = 1;
            this.truckTightnessTB.Name = "truckTightnessTB";
            this.truckTightnessTB.Size = new System.Drawing.Size(273, 23);
            this.truckTightnessTB.TabIndex = 52;
            this.truckTightnessTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.truckTightnessTB.Value = 0;
            this.truckTightnessTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.truckTightnessTB_Scroll);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(49, 6);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(109, 20);
            this.guna2HtmlLabel4.TabIndex = 56;
            this.guna2HtmlLabel4.Text = "Truck Tightness";
            // 
            // wheelHardessTB
            // 
            this.wheelHardessTB.Enabled = false;
            this.wheelHardessTB.LargeChange = 1;
            this.wheelHardessTB.Location = new System.Drawing.Point(249, 32);
            this.wheelHardessTB.Maximum = 4;
            this.wheelHardessTB.Minimum = -10;
            this.wheelHardessTB.MouseWheelBarPartitions = 1;
            this.wheelHardessTB.Name = "wheelHardessTB";
            this.wheelHardessTB.Size = new System.Drawing.Size(273, 23);
            this.wheelHardessTB.TabIndex = 55;
            this.wheelHardessTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.wheelHardessTB.Value = 1;
            this.wheelHardessTB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.wheelHardessTB_Scroll);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(49, 32);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(113, 20);
            this.guna2HtmlLabel5.TabIndex = 57;
            this.guna2HtmlLabel5.Text = "Wheel Hardness";
            // 
            // wheelHardnessTS
            // 
            this.wheelHardnessTS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wheelHardnessTS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.wheelHardnessTS.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wheelHardnessTS.CheckedState.InnerColor = System.Drawing.Color.White;
            this.wheelHardnessTS.Location = new System.Drawing.Point(6, 32);
            this.wheelHardnessTS.Name = "wheelHardnessTS";
            this.wheelHardnessTS.Size = new System.Drawing.Size(35, 20);
            this.wheelHardnessTS.TabIndex = 53;
            this.wheelHardnessTS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wheelHardnessTS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.wheelHardnessTS.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.wheelHardnessTS.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.wheelHardnessTS.CheckedChanged += new System.EventHandler(this.wheelHardnessTS_CheckedChanged);
            // 
            // wheelHardnessUD
            // 
            this.wheelHardnessUD.AutoRoundedCorners = true;
            this.wheelHardnessUD.BackColor = System.Drawing.Color.Transparent;
            this.wheelHardnessUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.wheelHardnessUD.BorderRadius = 10;
            this.wheelHardnessUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wheelHardnessUD.DecimalPlaces = 2;
            this.wheelHardnessUD.Enabled = false;
            this.wheelHardnessUD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wheelHardnessUD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wheelHardnessUD.ForeColor = System.Drawing.Color.White;
            this.wheelHardnessUD.Location = new System.Drawing.Point(182, 32);
            this.wheelHardnessUD.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.wheelHardnessUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.wheelHardnessUD.Name = "wheelHardnessUD";
            this.wheelHardnessUD.Size = new System.Drawing.Size(61, 23);
            this.wheelHardnessUD.TabIndex = 54;
            this.wheelHardnessUD.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.wheelHardnessUD.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.wheelHardnessUD.ValueChanged += new System.EventHandler(this.wheelHardnessUD_ValueChanged);
            // 
            // truckTightnessUD
            // 
            this.truckTightnessUD.AutoRoundedCorners = true;
            this.truckTightnessUD.BackColor = System.Drawing.Color.Transparent;
            this.truckTightnessUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.truckTightnessUD.BorderRadius = 10;
            this.truckTightnessUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.truckTightnessUD.DecimalPlaces = 2;
            this.truckTightnessUD.Enabled = false;
            this.truckTightnessUD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.truckTightnessUD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.truckTightnessUD.ForeColor = System.Drawing.Color.White;
            this.truckTightnessUD.Location = new System.Drawing.Point(182, 6);
            this.truckTightnessUD.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.truckTightnessUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.truckTightnessUD.Name = "truckTightnessUD";
            this.truckTightnessUD.Size = new System.Drawing.Size(61, 23);
            this.truckTightnessUD.TabIndex = 51;
            this.truckTightnessUD.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.truckTightnessUD.ValueChanged += new System.EventHandler(this.truckTightnessUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(573, 225);
            this.Controls.Add(this.opacityTB);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.attachErrLabel);
            this.Controls.Add(this.statusInfoLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.madeByLabel);
            this.Controls.Add(this.mainTabControl);
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
            this.mainTabControl.ResumeLayout(false);
            this.playerTabPage.ResumeLayout(false);
            this.playerTabPage.PerformLayout();
            this.visualTabPage.ResumeLayout(false);
            this.visualTabPage.PerformLayout();
            this.miscTabPage.ResumeLayout(false);
            this.miscTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wheelHardnessUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTightnessUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Guna.UI2.WinForms.Guna2ToggleSwitch drawPlayersTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown sunRotationUD;
        private Guna.UI2.WinForms.Guna2ToggleSwitch sunRotationTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel sunRotationLabel;
        private Guna.UI2.WinForms.Guna2TrackBar sunRotationTB;
        private Guna.UI2.WinForms.Guna2ToggleSwitch infJumpTS;
        private Guna.UI2.WinForms.Guna2HtmlLabel infJumpLabel;
        private Guna.UI2.WinForms.Guna2TabControl mainTabControl;
        private System.Windows.Forms.TabPage playerTabPage;
        private System.Windows.Forms.TabPage visualTabPage;
        private System.Windows.Forms.TabPage miscTabPage;
        private Guna.UI2.WinForms.Guna2ToggleSwitch truckTightnessTS;
        private Guna.UI2.WinForms.Guna2TrackBar truckTightnessTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TrackBar wheelHardessTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch wheelHardnessTS;
        private Guna.UI2.WinForms.Guna2NumericUpDown wheelHardnessUD;
        private Guna.UI2.WinForms.Guna2NumericUpDown truckTightnessUD;
    }
}

