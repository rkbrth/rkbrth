namespace WindowsFormsApplication13
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
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textHotkey1 = new System.Windows.Forms.TextBox();
            this.textHotkey2 = new System.Windows.Forms.TextBox();
            this.textHotkey3 = new System.Windows.Forms.TextBox();
            this.textHotkey4 = new System.Windows.Forms.TextBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.numericInterval1 = new System.Windows.Forms.NumericUpDown();
            this.numericInterval2 = new System.Windows.Forms.NumericUpDown();
            this.numericInterval3 = new System.Windows.Forms.NumericUpDown();
            this.numericInterval4 = new System.Windows.Forms.NumericUpDown();
            this.labelProcessName = new System.Windows.Forms.Label();
            this.contextProcessSelector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval4)).BeginInit();
            this.SuspendLayout();
            // 
            // picture4
            // 
            this.picture4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picture4.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.CP1;
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
            this.picture3.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.CP;
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
            this.picture2.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.MP;
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
            this.picture1.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.HP;
            this.picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1.ErrorImage = null;
            this.picture1.Location = new System.Drawing.Point(21, 91);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(32, 32);
            this.picture1.TabIndex = 11;
            this.picture1.TabStop = false;
            this.picture1.Click += new System.EventHandler(this.picture1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(139, 67);
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
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hotkeys";
            // 
            // textHotkey1
            // 
            this.textHotkey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHotkey1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHotkey1.Location = new System.Drawing.Point(68, 95);
            this.textHotkey1.Name = "textHotkey1";
            this.textHotkey1.Size = new System.Drawing.Size(55, 25);
            this.textHotkey1.TabIndex = 23;
            this.textHotkey1.Text = "F9";
            this.textHotkey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHotkey2
            // 
            this.textHotkey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHotkey2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHotkey2.Location = new System.Drawing.Point(68, 133);
            this.textHotkey2.Name = "textHotkey2";
            this.textHotkey2.Size = new System.Drawing.Size(55, 25);
            this.textHotkey2.TabIndex = 24;
            this.textHotkey2.Text = "F10";
            this.textHotkey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHotkey3
            // 
            this.textHotkey3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHotkey3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHotkey3.Location = new System.Drawing.Point(68, 171);
            this.textHotkey3.Name = "textHotkey3";
            this.textHotkey3.Size = new System.Drawing.Size(55, 25);
            this.textHotkey3.TabIndex = 25;
            this.textHotkey3.Text = "F11";
            this.textHotkey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHotkey4
            // 
            this.textHotkey4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHotkey4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHotkey4.Location = new System.Drawing.Point(68, 209);
            this.textHotkey4.Name = "textHotkey4";
            this.textHotkey4.Size = new System.Drawing.Size(55, 25);
            this.textHotkey4.TabIndex = 26;
            this.textHotkey4.Text = "=";
            this.textHotkey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnToggle.BackgroundImage = global::WindowsFormsApplication13.Properties.Resources.play_circle_outline1;
            this.btnToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToggle.Location = new System.Drawing.Point(148, 16);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(36, 36);
            this.btnToggle.TabIndex = 27;
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
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
            this.numericInterval1.Location = new System.Drawing.Point(137, 95);
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
            this.numericInterval1.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
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
            this.numericInterval2.Location = new System.Drawing.Point(137, 133);
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
            this.numericInterval2.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
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
            this.numericInterval3.Location = new System.Drawing.Point(137, 171);
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
            this.numericInterval3.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
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
            this.numericInterval4.Location = new System.Drawing.Point(137, 209);
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
            this.numericInterval4.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
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
            // 
            // contextProcessSelector
            // 
            this.contextProcessSelector.Name = "contextProcessSelector";
            this.contextProcessSelector.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProcessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextProcessSelector;
            this.Controls.Add(this.labelProcessName);
            this.Controls.Add(this.numericInterval4);
            this.Controls.Add(this.numericInterval3);
            this.Controls.Add(this.numericInterval2);
            this.Controls.Add(this.numericInterval1);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.textHotkey4);
            this.Controls.Add(this.textHotkey3);
            this.Controls.Add(this.textHotkey2);
            this.Controls.Add(this.textHotkey1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture4);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Name = "ProcessControl";
            this.Size = new System.Drawing.Size(223, 251);
            this.Load += new System.EventHandler(this.ProcessControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval4)).EndInit();
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
        private System.Windows.Forms.TextBox textHotkey1;
        private System.Windows.Forms.TextBox textHotkey2;
        private System.Windows.Forms.TextBox textHotkey3;
        private System.Windows.Forms.TextBox textHotkey4;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.NumericUpDown numericInterval1;
        private System.Windows.Forms.NumericUpDown numericInterval2;
        private System.Windows.Forms.NumericUpDown numericInterval3;
        private System.Windows.Forms.NumericUpDown numericInterval4;
        private System.Windows.Forms.Label labelProcessName;
        private System.Windows.Forms.ContextMenuStrip contextProcessSelector;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
