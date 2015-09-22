namespace PrettyClick
{
    partial class ProcessControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessControl));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericInterval1 = new System.Windows.Forms.NumericUpDown();
            this.numericInterval2 = new System.Windows.Forms.NumericUpDown();
            this.numericInterval3 = new System.Windows.Forms.NumericUpDown();
            this.numericInterval4 = new System.Windows.Forms.NumericUpDown();
            this.labelProcessName = new System.Windows.Forms.Label();
            this.contextProcessSelector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelHotkey1 = new System.Windows.Forms.Label();
            this.labelHotkey2 = new System.Windows.Forms.Label();
            this.labelHotkey3 = new System.Windows.Forms.Label();
            this.labelHotkey4 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(167, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hotkeys";
            // 
            // numericInterval1
            // 
            this.numericInterval1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericInterval1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericInterval1.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericInterval1.Location = new System.Drawing.Point(154, 95);
            this.numericInterval1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericInterval1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericInterval1.Name = "numericInterval1";
            this.numericInterval1.Size = new System.Drawing.Size(63, 25);
            this.numericInterval1.TabIndex = 32;
            this.numericInterval1.Tag = "0";
            this.numericInterval1.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numericInterval1.ValueChanged += new System.EventHandler(this.numericInterval_ValueChanged);
            // 
            // numericInterval2
            // 
            this.numericInterval2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericInterval2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericInterval2.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericInterval2.Location = new System.Drawing.Point(154, 133);
            this.numericInterval2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericInterval2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericInterval2.Name = "numericInterval2";
            this.numericInterval2.Size = new System.Drawing.Size(63, 25);
            this.numericInterval2.TabIndex = 33;
            this.numericInterval2.Tag = "1";
            this.numericInterval2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericInterval2.ValueChanged += new System.EventHandler(this.numericInterval_ValueChanged);
            // 
            // numericInterval3
            // 
            this.numericInterval3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericInterval3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericInterval3.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericInterval3.Location = new System.Drawing.Point(154, 171);
            this.numericInterval3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericInterval3.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericInterval3.Name = "numericInterval3";
            this.numericInterval3.Size = new System.Drawing.Size(63, 25);
            this.numericInterval3.TabIndex = 34;
            this.numericInterval3.Tag = "2";
            this.numericInterval3.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericInterval3.ValueChanged += new System.EventHandler(this.numericInterval_ValueChanged);
            // 
            // numericInterval4
            // 
            this.numericInterval4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericInterval4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericInterval4.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericInterval4.Location = new System.Drawing.Point(154, 209);
            this.numericInterval4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericInterval4.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericInterval4.Name = "numericInterval4";
            this.numericInterval4.Size = new System.Drawing.Size(63, 25);
            this.numericInterval4.TabIndex = 35;
            this.numericInterval4.Tag = "3";
            this.numericInterval4.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericInterval4.ValueChanged += new System.EventHandler(this.numericInterval_ValueChanged);
            // 
            // labelProcessName
            // 
            this.labelProcessName.BackColor = System.Drawing.Color.Transparent;
            this.labelProcessName.ContextMenuStrip = this.contextProcessSelector;
            this.labelProcessName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcessName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProcessName.Location = new System.Drawing.Point(20, 11);
            this.labelProcessName.Name = "labelProcessName";
            this.labelProcessName.Size = new System.Drawing.Size(103, 50);
            this.labelProcessName.TabIndex = 36;
            this.labelProcessName.Text = "Выберите\r\nпроцесс";
            this.labelProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextProcessSelector
            // 
            this.contextProcessSelector.Name = "contextProcessSelector";
            this.contextProcessSelector.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelHotkey1
            // 
            this.labelHotkey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHotkey1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotkey1.Location = new System.Drawing.Point(68, 94);
            this.labelHotkey1.Name = "labelHotkey1";
            this.labelHotkey1.Size = new System.Drawing.Size(80, 25);
            this.labelHotkey1.TabIndex = 37;
            this.labelHotkey1.Tag = "0";
            this.labelHotkey1.Text = "F9";
            this.labelHotkey1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHotkey1.Click += new System.EventHandler(this.labelHotkey_Click);
            // 
            // labelHotkey2
            // 
            this.labelHotkey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHotkey2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotkey2.Location = new System.Drawing.Point(68, 133);
            this.labelHotkey2.Name = "labelHotkey2";
            this.labelHotkey2.Size = new System.Drawing.Size(80, 25);
            this.labelHotkey2.TabIndex = 38;
            this.labelHotkey2.Tag = "1";
            this.labelHotkey2.Text = "F10";
            this.labelHotkey2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHotkey2.Click += new System.EventHandler(this.labelHotkey_Click);
            // 
            // labelHotkey3
            // 
            this.labelHotkey3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHotkey3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotkey3.Location = new System.Drawing.Point(68, 171);
            this.labelHotkey3.Name = "labelHotkey3";
            this.labelHotkey3.Size = new System.Drawing.Size(80, 25);
            this.labelHotkey3.TabIndex = 39;
            this.labelHotkey3.Tag = "2";
            this.labelHotkey3.Text = "F11";
            this.labelHotkey3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHotkey3.Click += new System.EventHandler(this.labelHotkey_Click);
            // 
            // labelHotkey4
            // 
            this.labelHotkey4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHotkey4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotkey4.Location = new System.Drawing.Point(68, 208);
            this.labelHotkey4.Name = "labelHotkey4";
            this.labelHotkey4.Size = new System.Drawing.Size(80, 25);
            this.labelHotkey4.TabIndex = 40;
            this.labelHotkey4.Tag = "3";
            this.labelHotkey4.Text = "F12";
            this.labelHotkey4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHotkey4.Click += new System.EventHandler(this.labelHotkey_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnToggle.BackgroundImage = global::PrettyClick.Properties.Resources.play_circle_outline1;
            this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToggle.Location = new System.Drawing.Point(149, 18);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(36, 36);
            this.btnToggle.TabIndex = 27;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // picture4
            // 
            this.picture4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picture4.BackgroundImage = global::PrettyClick.Properties.Resources.CP1;
            this.picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture4.ErrorImage = null;
            this.picture4.Location = new System.Drawing.Point(21, 205);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(32, 32);
            this.picture4.TabIndex = 14;
            this.picture4.TabStop = false;
            this.picture4.Click += new System.EventHandler(this.picture4_Click);
            // 
            // picture3
            // 
            this.picture3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picture3.BackgroundImage = global::PrettyClick.Properties.Resources.CP;
            this.picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture3.Location = new System.Drawing.Point(21, 167);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(32, 32);
            this.picture3.TabIndex = 13;
            this.picture3.TabStop = false;
            this.picture3.Click += new System.EventHandler(this.picture3_Click);
            // 
            // picture2
            // 
            this.picture2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picture2.BackgroundImage = global::PrettyClick.Properties.Resources.MP;
            this.picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture2.Location = new System.Drawing.Point(21, 129);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(32, 32);
            this.picture2.TabIndex = 12;
            this.picture2.TabStop = false;
            this.picture2.Click += new System.EventHandler(this.picture2_Click);
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picture1.BackgroundImage = global::PrettyClick.Properties.Resources.HP;
            this.picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1.ErrorImage = null;
            this.picture1.Location = new System.Drawing.Point(21, 91);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(32, 32);
            this.picture1.TabIndex = 11;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(209, 24);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5);
            this.btnHelp.Size = new System.Drawing.Size(24, 24);
            this.btnHelp.TabIndex = 41;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextProcessSelector;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.labelHotkey4);
            this.Controls.Add(this.labelHotkey3);
            this.Controls.Add(this.labelHotkey2);
            this.Controls.Add(this.labelHotkey1);
            this.Controls.Add(this.labelProcessName);
            this.Controls.Add(this.numericInterval4);
            this.Controls.Add(this.numericInterval3);
            this.Controls.Add(this.numericInterval2);
            this.Controls.Add(this.numericInterval1);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Name = "ProcessControl";
            this.Size = new System.Drawing.Size(245, 251);
            this.Load += new System.EventHandler(this.ProcessControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture4;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.NumericUpDown numericInterval1;
        private System.Windows.Forms.NumericUpDown numericInterval2;
        private System.Windows.Forms.NumericUpDown numericInterval3;
        private System.Windows.Forms.NumericUpDown numericInterval4;
        private System.Windows.Forms.Label labelProcessName;
        private System.Windows.Forms.ContextMenuStrip contextProcessSelector;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelHotkey1;
        private System.Windows.Forms.Label labelHotkey2;
        private System.Windows.Forms.Label labelHotkey3;
        private System.Windows.Forms.Label labelHotkey4;
        private System.Windows.Forms.Button btnHelp;
    }
}
