namespace Dzień_na_wyścigach
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bettingHouseGroupBox = new System.Windows.Forms.GroupBox();
            this.betMoneyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.makeBettButton = new System.Windows.Forms.Button();
            this.pickedGuyNameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickHoundNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dog1pictureBox = new System.Windows.Forms.PictureBox();
            this.dog2pictureBox = new System.Windows.Forms.PictureBox();
            this.dog3pictureBox = new System.Windows.Forms.PictureBox();
            this.dog4pictureBox = new System.Windows.Forms.PictureBox();
            this.bettingHouseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betMoneyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickHoundNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bettingHouseGroupBox
            // 
            this.bettingHouseGroupBox.Controls.Add(this.pickHoundNumericUpDown);
            this.bettingHouseGroupBox.Controls.Add(this.label3);
            this.bettingHouseGroupBox.Controls.Add(this.betMoneyNumericUpDown);
            this.bettingHouseGroupBox.Controls.Add(this.makeBettButton);
            this.bettingHouseGroupBox.Controls.Add(this.pickedGuyNameLabel);
            this.bettingHouseGroupBox.Controls.Add(this.startButton);
            this.bettingHouseGroupBox.Controls.Add(this.alBetLabel);
            this.bettingHouseGroupBox.Controls.Add(this.joeBetLabel);
            this.bettingHouseGroupBox.Controls.Add(this.alRadioButton);
            this.bettingHouseGroupBox.Controls.Add(this.bobRadioButton);
            this.bettingHouseGroupBox.Controls.Add(this.joeRadioButton);
            this.bettingHouseGroupBox.Controls.Add(this.bobBetLabel);
            this.bettingHouseGroupBox.Controls.Add(this.label1);
            this.bettingHouseGroupBox.Controls.Add(this.minimumBetLabel);
            this.bettingHouseGroupBox.Location = new System.Drawing.Point(12, 207);
            this.bettingHouseGroupBox.Name = "bettingHouseGroupBox";
            this.bettingHouseGroupBox.Size = new System.Drawing.Size(750, 183);
            this.bettingHouseGroupBox.TabIndex = 0;
            this.bettingHouseGroupBox.TabStop = false;
            this.bettingHouseGroupBox.Text = "Dom bukmacherski";
            // 
            // betMoneyNumericUpDown
            // 
            this.betMoneyNumericUpDown.Location = new System.Drawing.Point(122, 148);
            this.betMoneyNumericUpDown.Name = "betMoneyNumericUpDown";
            this.betMoneyNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.betMoneyNumericUpDown.TabIndex = 11;
            // 
            // makeBettButton
            // 
            this.makeBettButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.makeBettButton.Location = new System.Drawing.Point(62, 148);
            this.makeBettButton.Name = "makeBettButton";
            this.makeBettButton.Size = new System.Drawing.Size(54, 20);
            this.makeBettButton.TabIndex = 10;
            this.makeBettButton.Text = "stawia";
            this.makeBettButton.UseVisualStyleBackColor = false;
            this.makeBettButton.Click += new System.EventHandler(this.makeBettButton_Click);
            // 
            // pickedGuyNameLabel
            // 
            this.pickedGuyNameLabel.AutoSize = true;
            this.pickedGuyNameLabel.Location = new System.Drawing.Point(18, 152);
            this.pickedGuyNameLabel.Name = "pickedGuyNameLabel";
            this.pickedGuyNameLabel.Size = new System.Drawing.Size(33, 13);
            this.pickedGuyNameLabel.TabIndex = 9;
            this.pickedGuyNameLabel.Text = "name";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(532, 45);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(178, 116);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(189, 111);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(273, 23);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(189, 46);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(273, 20);
            this.joeBetLabel.TabIndex = 6;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 110);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 76);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 45);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(189, 76);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(273, 23);
            this.bobBetLabel.TabIndex = 5;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zakłady";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(124, 15);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = global::Dzień_na_wyścigach.Properties.Resources.racetrack;
            this.raceTrackPictureBox.InitialImage = null;
            this.raceTrackPictureBox.Location = new System.Drawing.Point(6, 12);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(756, 189);
            this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPictureBox.TabIndex = 1;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "zł na charta numer";
            // 
            // pickHoundNumericUpDown
            // 
            this.pickHoundNumericUpDown.Location = new System.Drawing.Point(291, 148);
            this.pickHoundNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.pickHoundNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pickHoundNumericUpDown.Name = "pickHoundNumericUpDown";
            this.pickHoundNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.pickHoundNumericUpDown.TabIndex = 13;
            this.pickHoundNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dog1pictureBox
            // 
            this.dog1pictureBox.Image = global::Dzień_na_wyścigach.Properties.Resources.dog;
            this.dog1pictureBox.Location = new System.Drawing.Point(12, 19);
            this.dog1pictureBox.Name = "dog1pictureBox";
            this.dog1pictureBox.Size = new System.Drawing.Size(79, 24);
            this.dog1pictureBox.TabIndex = 2;
            this.dog1pictureBox.TabStop = false;
            this.dog1pictureBox.Click += new System.EventHandler(this.dog1pictureBox_Click);
            // 
            // dog2pictureBox
            // 
            this.dog2pictureBox.Image = global::Dzień_na_wyścigach.Properties.Resources.dog;
            this.dog2pictureBox.Location = new System.Drawing.Point(12, 66);
            this.dog2pictureBox.Name = "dog2pictureBox";
            this.dog2pictureBox.Size = new System.Drawing.Size(79, 23);
            this.dog2pictureBox.TabIndex = 3;
            this.dog2pictureBox.TabStop = false;
            this.dog2pictureBox.Click += new System.EventHandler(this.dog2pictureBox_Click);
            // 
            // dog3pictureBox
            // 
            this.dog3pictureBox.Image = global::Dzień_na_wyścigach.Properties.Resources.dog;
            this.dog3pictureBox.Location = new System.Drawing.Point(12, 114);
            this.dog3pictureBox.Name = "dog3pictureBox";
            this.dog3pictureBox.Size = new System.Drawing.Size(79, 23);
            this.dog3pictureBox.TabIndex = 4;
            this.dog3pictureBox.TabStop = false;
            this.dog3pictureBox.Click += new System.EventHandler(this.dog3pictureBox_Click);
            // 
            // dog4pictureBox
            // 
            this.dog4pictureBox.Image = global::Dzień_na_wyścigach.Properties.Resources.dog;
            this.dog4pictureBox.Location = new System.Drawing.Point(12, 165);
            this.dog4pictureBox.Name = "dog4pictureBox";
            this.dog4pictureBox.Size = new System.Drawing.Size(79, 23);
            this.dog4pictureBox.TabIndex = 5;
            this.dog4pictureBox.TabStop = false;
            this.dog4pictureBox.Click += new System.EventHandler(this.dog4pictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 402);
            this.Controls.Add(this.dog4pictureBox);
            this.Controls.Add(this.dog3pictureBox);
            this.Controls.Add(this.dog2pictureBox);
            this.Controls.Add(this.dog1pictureBox);
            this.Controls.Add(this.raceTrackPictureBox);
            this.Controls.Add(this.bettingHouseGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzień na wyścigach";
            this.bettingHouseGroupBox.ResumeLayout(false);
            this.bettingHouseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betMoneyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickHoundNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox bettingHouseGroupBox;
        private System.Windows.Forms.NumericUpDown betMoneyNumericUpDown;
        private System.Windows.Forms.Button makeBettButton;
        private System.Windows.Forms.Label pickedGuyNameLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.NumericUpDown pickHoundNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox dog1pictureBox;
        private System.Windows.Forms.PictureBox dog2pictureBox;
        private System.Windows.Forms.PictureBox dog3pictureBox;
        private System.Windows.Forms.PictureBox dog4pictureBox;
    }
}

