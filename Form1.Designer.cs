
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
            this.fixSkateboardCB = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.boardSpeedUD = new System.Windows.Forms.NumericUpDown();
            this.boardSpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.disableRogdollCB = new System.Windows.Forms.CheckBox();
            this.disableWipeoutsCB = new System.Windows.Forms.CheckBox();
            this.fovUD = new System.Windows.Forms.NumericUpDown();
            this.sunRotationXUD = new System.Windows.Forms.NumericUpDown();
            this.sunRotationYUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sunRotationLabel = new System.Windows.Forms.Label();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.wireframeCB = new System.Windows.Forms.CheckBox();
            this.wireframeUD = new System.Windows.Forms.NumericUpDown();
            this.fovCB = new System.Windows.Forms.CheckBox();
            this.drawSkinnedCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.satXUD = new System.Windows.Forms.NumericUpDown();
            this.satYUD = new System.Windows.Forms.NumericUpDown();
            this.satZUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.rainbowCB = new System.Windows.Forms.CheckBox();
            this.rainbowUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.consoleCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardSpeedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wireframeUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satZUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowUD)).BeginInit();
            this.SuspendLayout();
            // 
            // fixSkateboardCB
            // 
            this.fixSkateboardCB.AutoSize = true;
            this.fixSkateboardCB.BackColor = System.Drawing.Color.Black;
            this.fixSkateboardCB.ForeColor = System.Drawing.Color.White;
            this.fixSkateboardCB.Location = new System.Drawing.Point(12, 35);
            this.fixSkateboardCB.Name = "fixSkateboardCB";
            this.fixSkateboardCB.Size = new System.Drawing.Size(113, 17);
            this.fixSkateboardCB.TabIndex = 2;
            this.fixSkateboardCB.Text = "Enable Lock In Air";
            this.fixSkateboardCB.UseVisualStyleBackColor = false;
            this.fixSkateboardCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Black;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(15, 282);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Board Speed";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // boardSpeedUD
            // 
            this.boardSpeedUD.BackColor = System.Drawing.Color.Black;
            this.boardSpeedUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardSpeedUD.Enabled = false;
            this.boardSpeedUD.ForeColor = System.Drawing.Color.White;
            this.boardSpeedUD.Location = new System.Drawing.Point(134, 281);
            this.boardSpeedUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.boardSpeedUD.Name = "boardSpeedUD";
            this.boardSpeedUD.Size = new System.Drawing.Size(65, 20);
            this.boardSpeedUD.TabIndex = 7;
            // 
            // boardSpeedTimer
            // 
            this.boardSpeedTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disableRogdollCB
            // 
            this.disableRogdollCB.AutoSize = true;
            this.disableRogdollCB.BackColor = System.Drawing.Color.Black;
            this.disableRogdollCB.ForeColor = System.Drawing.Color.White;
            this.disableRogdollCB.Location = new System.Drawing.Point(12, 58);
            this.disableRogdollCB.Name = "disableRogdollCB";
            this.disableRogdollCB.Size = new System.Drawing.Size(100, 17);
            this.disableRogdollCB.TabIndex = 3;
            this.disableRogdollCB.Text = "Disable Ragdoll";
            this.disableRogdollCB.UseVisualStyleBackColor = false;
            this.disableRogdollCB.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // disableWipeoutsCB
            // 
            this.disableWipeoutsCB.AutoSize = true;
            this.disableWipeoutsCB.BackColor = System.Drawing.Color.Black;
            this.disableWipeoutsCB.ForeColor = System.Drawing.Color.White;
            this.disableWipeoutsCB.Location = new System.Drawing.Point(12, 81);
            this.disableWipeoutsCB.Name = "disableWipeoutsCB";
            this.disableWipeoutsCB.Size = new System.Drawing.Size(109, 17);
            this.disableWipeoutsCB.TabIndex = 4;
            this.disableWipeoutsCB.Text = "Disable Wipeouts";
            this.disableWipeoutsCB.UseVisualStyleBackColor = false;
            this.disableWipeoutsCB.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // fovUD
            // 
            this.fovUD.BackColor = System.Drawing.Color.Black;
            this.fovUD.Enabled = false;
            this.fovUD.ForeColor = System.Drawing.Color.White;
            this.fovUD.Location = new System.Drawing.Point(134, 235);
            this.fovUD.Maximum = new decimal(new int[] {
            179,
            0,
            0,
            0});
            this.fovUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.fovUD.Name = "fovUD";
            this.fovUD.Size = new System.Drawing.Size(65, 20);
            this.fovUD.TabIndex = 5;
            this.fovUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.fovUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // sunRotationXUD
            // 
            this.sunRotationXUD.BackColor = System.Drawing.Color.Black;
            this.sunRotationXUD.ForeColor = System.Drawing.Color.White;
            this.sunRotationXUD.Location = new System.Drawing.Point(134, 166);
            this.sunRotationXUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sunRotationXUD.Name = "sunRotationXUD";
            this.sunRotationXUD.Size = new System.Drawing.Size(65, 20);
            this.sunRotationXUD.TabIndex = 8;
            this.sunRotationXUD.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // sunRotationYUD
            // 
            this.sunRotationYUD.BackColor = System.Drawing.Color.Black;
            this.sunRotationYUD.ForeColor = System.Drawing.Color.White;
            this.sunRotationYUD.Location = new System.Drawing.Point(134, 188);
            this.sunRotationYUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sunRotationYUD.Name = "sunRotationYUD";
            this.sunRotationYUD.Size = new System.Drawing.Size(65, 20);
            this.sunRotationYUD.TabIndex = 9;
            this.sunRotationYUD.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y";
            // 
            // sunRotationLabel
            // 
            this.sunRotationLabel.AutoSize = true;
            this.sunRotationLabel.BackColor = System.Drawing.Color.Black;
            this.sunRotationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunRotationLabel.ForeColor = System.Drawing.Color.White;
            this.sunRotationLabel.Location = new System.Drawing.Point(115, 147);
            this.sunRotationLabel.Name = "sunRotationLabel";
            this.sunRotationLabel.Size = new System.Drawing.Size(84, 16);
            this.sunRotationLabel.TabIndex = 16;
            this.sunRotationLabel.Text = "Sun Rotation";
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madeByLabel.Location = new System.Drawing.Point(12, 302);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(161, 16);
            this.madeByLabel.TabIndex = 17;
            this.madeByLabel.Text = "Made by kikkin_yo_azzez";
            // 
            // wireframeCB
            // 
            this.wireframeCB.AutoSize = true;
            this.wireframeCB.Location = new System.Drawing.Point(15, 259);
            this.wireframeCB.Name = "wireframeCB";
            this.wireframeCB.Size = new System.Drawing.Size(110, 17);
            this.wireframeCB.TabIndex = 18;
            this.wireframeCB.Text = "Enable Wireframe";
            this.wireframeCB.UseVisualStyleBackColor = true;
            this.wireframeCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // wireframeUD
            // 
            this.wireframeUD.BackColor = System.Drawing.Color.Black;
            this.wireframeUD.Enabled = false;
            this.wireframeUD.ForeColor = System.Drawing.Color.White;
            this.wireframeUD.Location = new System.Drawing.Point(134, 258);
            this.wireframeUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.wireframeUD.Name = "wireframeUD";
            this.wireframeUD.Size = new System.Drawing.Size(65, 20);
            this.wireframeUD.TabIndex = 19;
            this.wireframeUD.ValueChanged += new System.EventHandler(this.wireframeUD_ValueChanged);
            // 
            // fovCB
            // 
            this.fovCB.AutoSize = true;
            this.fovCB.Location = new System.Drawing.Point(15, 236);
            this.fovCB.Name = "fovCB";
            this.fovCB.Size = new System.Drawing.Size(47, 17);
            this.fovCB.TabIndex = 20;
            this.fovCB.Text = "FOV";
            this.fovCB.UseVisualStyleBackColor = true;
            this.fovCB.CheckedChanged += new System.EventHandler(this.fovCB_CheckedChanged);
            // 
            // drawSkinnedCB
            // 
            this.drawSkinnedCB.AutoSize = true;
            this.drawSkinnedCB.Location = new System.Drawing.Point(12, 104);
            this.drawSkinnedCB.Name = "drawSkinnedCB";
            this.drawSkinnedCB.Size = new System.Drawing.Size(143, 17);
            this.drawSkinnedCB.TabIndex = 21;
            this.drawSkinnedCB.Text = "Disable Draw Characters";
            this.drawSkinnedCB.UseVisualStyleBackColor = true;
            this.drawSkinnedCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Saturation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Z";
            // 
            // satXUD
            // 
            this.satXUD.BackColor = System.Drawing.Color.Black;
            this.satXUD.ForeColor = System.Drawing.Color.White;
            this.satXUD.Location = new System.Drawing.Point(15, 166);
            this.satXUD.Name = "satXUD";
            this.satXUD.Size = new System.Drawing.Size(38, 20);
            this.satXUD.TabIndex = 26;
            this.satXUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.satXUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // satYUD
            // 
            this.satYUD.BackColor = System.Drawing.Color.Black;
            this.satYUD.ForeColor = System.Drawing.Color.White;
            this.satYUD.Location = new System.Drawing.Point(15, 188);
            this.satYUD.Name = "satYUD";
            this.satYUD.Size = new System.Drawing.Size(38, 20);
            this.satYUD.TabIndex = 27;
            this.satYUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.satYUD.ValueChanged += new System.EventHandler(this.satYUD_ValueChanged);
            // 
            // satZUD
            // 
            this.satZUD.BackColor = System.Drawing.Color.Black;
            this.satZUD.ForeColor = System.Drawing.Color.White;
            this.satZUD.Location = new System.Drawing.Point(15, 210);
            this.satZUD.Name = "satZUD";
            this.satZUD.Size = new System.Drawing.Size(38, 20);
            this.satZUD.TabIndex = 28;
            this.satZUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.satZUD.ValueChanged += new System.EventHandler(this.satZUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hue";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.Color.Black;
            this.numericUpDown4.ForeColor = System.Drawing.Color.White;
            this.numericUpDown4.Location = new System.Drawing.Point(154, 210);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown4.TabIndex = 30;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged_1);
            // 
            // rainbowCB
            // 
            this.rainbowCB.AutoSize = true;
            this.rainbowCB.Location = new System.Drawing.Point(12, 127);
            this.rainbowCB.Name = "rainbowCB";
            this.rainbowCB.Size = new System.Drawing.Size(91, 17);
            this.rainbowCB.TabIndex = 31;
            this.rainbowCB.Text = "Rainbow Hue";
            this.rainbowCB.UseVisualStyleBackColor = true;
            this.rainbowCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_3);
            // 
            // rainbowUD
            // 
            this.rainbowUD.BackColor = System.Drawing.Color.Black;
            this.rainbowUD.ForeColor = System.Drawing.Color.White;
            this.rainbowUD.Location = new System.Drawing.Point(151, 124);
            this.rainbowUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rainbowUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rainbowUD.Name = "rainbowUD";
            this.rainbowUD.Size = new System.Drawing.Size(45, 20);
            this.rainbowUD.TabIndex = 32;
            this.rainbowUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rainbowUD.ValueChanged += new System.EventHandler(this.rainbowUD_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Speed";
            // 
            // consoleCB
            // 
            this.consoleCB.AutoSize = true;
            this.consoleCB.BackColor = System.Drawing.Color.Black;
            this.consoleCB.ForeColor = System.Drawing.Color.White;
            this.consoleCB.Location = new System.Drawing.Point(12, 12);
            this.consoleCB.Name = "consoleCB";
            this.consoleCB.Size = new System.Drawing.Size(100, 17);
            this.consoleCB.TabIndex = 34;
            this.consoleCB.Text = "Enable Console";
            this.consoleCB.UseVisualStyleBackColor = false;
            this.consoleCB.CheckedChanged += new System.EventHandler(this.consoleCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(208, 325);
            this.Controls.Add(this.consoleCB);
            this.Controls.Add(this.rainbowUD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rainbowCB);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.satZUD);
            this.Controls.Add(this.satYUD);
            this.Controls.Add(this.satXUD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawSkinnedCB);
            this.Controls.Add(this.fovCB);
            this.Controls.Add(this.wireframeUD);
            this.Controls.Add(this.wireframeCB);
            this.Controls.Add(this.madeByLabel);
            this.Controls.Add(this.sunRotationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sunRotationYUD);
            this.Controls.Add(this.sunRotationXUD);
            this.Controls.Add(this.fovUD);
            this.Controls.Add(this.disableWipeoutsCB);
            this.Controls.Add(this.disableRogdollCB);
            this.Controls.Add(this.boardSpeedUD);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.fixSkateboardCB);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "skater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boardSpeedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fovUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunRotationYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wireframeUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satZUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainbowUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fixSkateboardCB;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown boardSpeedUD;
        private System.Windows.Forms.Timer boardSpeedTimer;
        private System.Windows.Forms.CheckBox disableRogdollCB;
        private System.Windows.Forms.CheckBox disableWipeoutsCB;
        private System.Windows.Forms.NumericUpDown fovUD;
        private System.Windows.Forms.NumericUpDown sunRotationXUD;
        private System.Windows.Forms.NumericUpDown sunRotationYUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sunRotationLabel;
        private System.Windows.Forms.Label madeByLabel;
        private System.Windows.Forms.CheckBox wireframeCB;
        private System.Windows.Forms.NumericUpDown wireframeUD;
        private System.Windows.Forms.CheckBox fovCB;
        private System.Windows.Forms.CheckBox drawSkinnedCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown satXUD;
        private System.Windows.Forms.NumericUpDown satYUD;
        private System.Windows.Forms.NumericUpDown satZUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox rainbowCB;
        private System.Windows.Forms.NumericUpDown rainbowUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox consoleCB;
    }
}

