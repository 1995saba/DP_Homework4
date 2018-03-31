namespace ScrollsAndMultiLinesApp
{
    partial class Form
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
            this.multilineCheckBox = new System.Windows.Forms.CheckBox();
            this.vsCheckBox = new System.Windows.Forms.CheckBox();
            this.hsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // multilineCheckBox
            // 
            this.multilineCheckBox.AutoSize = true;
            this.multilineCheckBox.Location = new System.Drawing.Point(355, 41);
            this.multilineCheckBox.Name = "multilineCheckBox";
            this.multilineCheckBox.Size = new System.Drawing.Size(64, 17);
            this.multilineCheckBox.TabIndex = 0;
            this.multilineCheckBox.Text = "Multiline";
            this.multilineCheckBox.UseVisualStyleBackColor = true;
            this.multilineCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // vsCheckBox
            // 
            this.vsCheckBox.AutoSize = true;
            this.vsCheckBox.Location = new System.Drawing.Point(355, 64);
            this.vsCheckBox.Name = "vsCheckBox";
            this.vsCheckBox.Size = new System.Drawing.Size(90, 17);
            this.vsCheckBox.TabIndex = 1;
            this.vsCheckBox.Text = "Vertical Scroll";
            this.vsCheckBox.UseVisualStyleBackColor = true;
            this.vsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // hsCheckBox
            // 
            this.hsCheckBox.AutoSize = true;
            this.hsCheckBox.Location = new System.Drawing.Point(355, 87);
            this.hsCheckBox.Name = "hsCheckBox";
            this.hsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.hsCheckBox.TabIndex = 2;
            this.hsCheckBox.Text = "Horizontal Scroll";
            this.hsCheckBox.UseVisualStyleBackColor = true;
            this.hsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 291);
            this.Controls.Add(this.hsCheckBox);
            this.Controls.Add(this.vsCheckBox);
            this.Controls.Add(this.multilineCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox multilineCheckBox;
        private System.Windows.Forms.CheckBox vsCheckBox;
        private System.Windows.Forms.CheckBox hsCheckBox;
    }
}

