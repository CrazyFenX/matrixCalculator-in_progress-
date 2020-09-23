namespace Lab1_var5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOfElements1 = new System.Windows.Forms.Panel();
            this.heighMatrixFirst_textBox = new System.Windows.Forms.TextBox();
            this.weightMatrixFirst_textBox = new System.Windows.Forms.TextBox();
            this.X1_label = new System.Windows.Forms.Label();
            this.randomFillingFirst_button = new System.Windows.Forms.Button();
            this.handFillingFirst_button = new System.Windows.Forms.Button();
            this.readFirstButton = new System.Windows.Forms.Button();
            this.heighMatrixSecond_textBox = new System.Windows.Forms.TextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.handFillingSecond_button = new System.Windows.Forms.Button();
            this.randomFillingSecond_button = new System.Windows.Forms.Button();
            this.X2_label = new System.Windows.Forms.Label();
            this.weightMatrixSecond_textBox = new System.Windows.Forms.TextBox();
            this.panelOfElements2 = new System.Windows.Forms.Panel();
            this.operation_ComboBox = new System.Windows.Forms.ComboBox();
            this.transpFirstButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.detTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelOfElements1
            // 
            this.panelOfElements1.AutoScroll = true;
            this.panelOfElements1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOfElements1.Location = new System.Drawing.Point(32, 81);
            this.panelOfElements1.Name = "panelOfElements1";
            this.panelOfElements1.Size = new System.Drawing.Size(374, 277);
            this.panelOfElements1.TabIndex = 0;
            // 
            // heighMatrixFirst_textBox
            // 
            this.heighMatrixFirst_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heighMatrixFirst_textBox.Location = new System.Drawing.Point(31, 23);
            this.heighMatrixFirst_textBox.Name = "heighMatrixFirst_textBox";
            this.heighMatrixFirst_textBox.Size = new System.Drawing.Size(55, 34);
            this.heighMatrixFirst_textBox.TabIndex = 1;
            // 
            // weightMatrixFirst_textBox
            // 
            this.weightMatrixFirst_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightMatrixFirst_textBox.Location = new System.Drawing.Point(128, 23);
            this.weightMatrixFirst_textBox.Name = "weightMatrixFirst_textBox";
            this.weightMatrixFirst_textBox.Size = new System.Drawing.Size(55, 34);
            this.weightMatrixFirst_textBox.TabIndex = 2;
            // 
            // X1_label
            // 
            this.X1_label.AutoSize = true;
            this.X1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1_label.Location = new System.Drawing.Point(92, 29);
            this.X1_label.Name = "X1_label";
            this.X1_label.Size = new System.Drawing.Size(30, 29);
            this.X1_label.TabIndex = 3;
            this.X1_label.Text = "X";
            // 
            // randomFillingFirst_button
            // 
            this.randomFillingFirst_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomFillingFirst_button.Location = new System.Drawing.Point(200, 23);
            this.randomFillingFirst_button.Name = "randomFillingFirst_button";
            this.randomFillingFirst_button.Size = new System.Drawing.Size(106, 35);
            this.randomFillingFirst_button.TabIndex = 4;
            this.randomFillingFirst_button.Text = "Random";
            this.randomFillingFirst_button.UseVisualStyleBackColor = true;
            this.randomFillingFirst_button.Click += new System.EventHandler(this.randomFilling_button_Click);
            // 
            // handFillingFirst_button
            // 
            this.handFillingFirst_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.handFillingFirst_button.Location = new System.Drawing.Point(312, 22);
            this.handFillingFirst_button.Name = "handFillingFirst_button";
            this.handFillingFirst_button.Size = new System.Drawing.Size(94, 35);
            this.handFillingFirst_button.TabIndex = 5;
            this.handFillingFirst_button.Text = "Hand";
            this.handFillingFirst_button.UseVisualStyleBackColor = true;
            this.handFillingFirst_button.Click += new System.EventHandler(this.handFilling_button_Click);
            // 
            // readFirstButton
            // 
            this.readFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readFirstButton.Location = new System.Drawing.Point(32, 373);
            this.readFirstButton.Name = "readFirstButton";
            this.readFirstButton.Size = new System.Drawing.Size(97, 35);
            this.readFirstButton.TabIndex = 6;
            this.readFirstButton.Text = "Read";
            this.readFirstButton.UseVisualStyleBackColor = true;
            this.readFirstButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // heighMatrixSecond_textBox
            // 
            this.heighMatrixSecond_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heighMatrixSecond_textBox.Location = new System.Drawing.Point(465, 23);
            this.heighMatrixSecond_textBox.Name = "heighMatrixSecond_textBox";
            this.heighMatrixSecond_textBox.Size = new System.Drawing.Size(55, 34);
            this.heighMatrixSecond_textBox.TabIndex = 8;
            // 
            // CountButton
            // 
            this.CountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountButton.Location = new System.Drawing.Point(466, 373);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(97, 35);
            this.CountButton.TabIndex = 13;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.readSecondButton_Click);
            // 
            // handFillingSecond_button
            // 
            this.handFillingSecond_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.handFillingSecond_button.Location = new System.Drawing.Point(746, 22);
            this.handFillingSecond_button.Name = "handFillingSecond_button";
            this.handFillingSecond_button.Size = new System.Drawing.Size(94, 35);
            this.handFillingSecond_button.TabIndex = 12;
            this.handFillingSecond_button.Text = "Hand";
            this.handFillingSecond_button.UseVisualStyleBackColor = true;
            this.handFillingSecond_button.Click += new System.EventHandler(this.handFillingSecond_button_Click);
            // 
            // randomFillingSecond_button
            // 
            this.randomFillingSecond_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomFillingSecond_button.Location = new System.Drawing.Point(634, 23);
            this.randomFillingSecond_button.Name = "randomFillingSecond_button";
            this.randomFillingSecond_button.Size = new System.Drawing.Size(106, 35);
            this.randomFillingSecond_button.TabIndex = 11;
            this.randomFillingSecond_button.Text = "Random";
            this.randomFillingSecond_button.UseVisualStyleBackColor = true;
            this.randomFillingSecond_button.Click += new System.EventHandler(this.randomFillingSecond_button_Click);
            // 
            // X2_label
            // 
            this.X2_label.AutoSize = true;
            this.X2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X2_label.Location = new System.Drawing.Point(526, 29);
            this.X2_label.Name = "X2_label";
            this.X2_label.Size = new System.Drawing.Size(30, 29);
            this.X2_label.TabIndex = 10;
            this.X2_label.Text = "X";
            // 
            // weightMatrixSecond_textBox
            // 
            this.weightMatrixSecond_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightMatrixSecond_textBox.Location = new System.Drawing.Point(562, 23);
            this.weightMatrixSecond_textBox.Name = "weightMatrixSecond_textBox";
            this.weightMatrixSecond_textBox.Size = new System.Drawing.Size(55, 34);
            this.weightMatrixSecond_textBox.TabIndex = 9;
            // 
            // panelOfElements2
            // 
            this.panelOfElements2.AutoScroll = true;
            this.panelOfElements2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOfElements2.Location = new System.Drawing.Point(466, 81);
            this.panelOfElements2.Name = "panelOfElements2";
            this.panelOfElements2.Size = new System.Drawing.Size(374, 277);
            this.panelOfElements2.TabIndex = 7;
            // 
            // operation_ComboBox
            // 
            this.operation_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation_ComboBox.FormattingEnabled = true;
            this.operation_ComboBox.Items.AddRange(new object[] {
            "-",
            "+",
            "*"});
            this.operation_ComboBox.Location = new System.Drawing.Point(412, 208);
            this.operation_ComboBox.Name = "operation_ComboBox";
            this.operation_ComboBox.Size = new System.Drawing.Size(48, 37);
            this.operation_ComboBox.TabIndex = 14;
            this.operation_ComboBox.SelectedIndexChanged += new System.EventHandler(this.operation_ComboBox_SelectedIndexChanged);
            // 
            // transpFirstButton
            // 
            this.transpFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transpFirstButton.Location = new System.Drawing.Point(135, 373);
            this.transpFirstButton.Name = "transpFirstButton";
            this.transpFirstButton.Size = new System.Drawing.Size(48, 35);
            this.transpFirstButton.TabIndex = 15;
            this.transpFirstButton.Text = "T";
            this.transpFirstButton.UseVisualStyleBackColor = true;
            this.transpFirstButton.Click += new System.EventHandler(this.transpFirstButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverseButton.Location = new System.Drawing.Point(189, 373);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(48, 35);
            this.reverseButton.TabIndex = 16;
            this.reverseButton.Text = "-1";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // detTextBox
            // 
            this.detTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detTextBox.Location = new System.Drawing.Point(251, 374);
            this.detTextBox.Name = "detTextBox";
            this.detTextBox.Size = new System.Drawing.Size(55, 34);
            this.detTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 435);
            this.Controls.Add(this.detTextBox);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.transpFirstButton);
            this.Controls.Add(this.operation_ComboBox);
            this.Controls.Add(this.heighMatrixSecond_textBox);
            this.Controls.Add(this.heighMatrixFirst_textBox);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.readFirstButton);
            this.Controls.Add(this.handFillingSecond_button);
            this.Controls.Add(this.handFillingFirst_button);
            this.Controls.Add(this.randomFillingSecond_button);
            this.Controls.Add(this.randomFillingFirst_button);
            this.Controls.Add(this.X2_label);
            this.Controls.Add(this.X1_label);
            this.Controls.Add(this.weightMatrixSecond_textBox);
            this.Controls.Add(this.weightMatrixFirst_textBox);
            this.Controls.Add(this.panelOfElements2);
            this.Controls.Add(this.panelOfElements1);
            this.Name = "Form1";
            this.Text = "rectMatrix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOfElements1;
        private System.Windows.Forms.TextBox heighMatrixFirst_textBox;
        private System.Windows.Forms.TextBox weightMatrixFirst_textBox;
        private System.Windows.Forms.Label X1_label;
        private System.Windows.Forms.Button randomFillingFirst_button;
        private System.Windows.Forms.Button handFillingFirst_button;
        private System.Windows.Forms.Button readFirstButton;
        private System.Windows.Forms.TextBox heighMatrixSecond_textBox;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Button handFillingSecond_button;
        private System.Windows.Forms.Button randomFillingSecond_button;
        private System.Windows.Forms.Label X2_label;
        private System.Windows.Forms.TextBox weightMatrixSecond_textBox;
        private System.Windows.Forms.Panel panelOfElements2;
        private System.Windows.Forms.ComboBox operation_ComboBox;
        private System.Windows.Forms.Button transpFirstButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.TextBox detTextBox;
    }
}

