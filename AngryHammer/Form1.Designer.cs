
namespace AngryHammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.deployButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.AdvancedCheckBox = new System.Windows.Forms.CheckBox();
            this.AdvancedGroupBox = new System.Windows.Forms.GroupBox();
            this.numericFakeGenUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericArgUpDown = new System.Windows.Forms.NumericUpDown();
            this.AdvancedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFakeGenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericArgUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "When ready, Click \'Deploy\'.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deployButton
            // 
            this.deployButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deployButton.Location = new System.Drawing.Point(13, 56);
            this.deployButton.Name = "deployButton";
            this.deployButton.Size = new System.Drawing.Size(145, 23);
            this.deployButton.TabIndex = 1;
            this.deployButton.Text = "Deploy";
            this.deployButton.UseVisualStyleBackColor = true;
            this.deployButton.Click += new System.EventHandler(this.deployButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 85);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(145, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // AdvancedCheckBox
            // 
            this.AdvancedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedCheckBox.Location = new System.Drawing.Point(12, 114);
            this.AdvancedCheckBox.Name = "AdvancedCheckBox";
            this.AdvancedCheckBox.Size = new System.Drawing.Size(146, 24);
            this.AdvancedCheckBox.TabIndex = 3;
            this.AdvancedCheckBox.Text = "Advanced Mode";
            this.AdvancedCheckBox.UseVisualStyleBackColor = true;
            this.AdvancedCheckBox.CheckedChanged += new System.EventHandler(this.AdvancedCheckBox_CheckedChanged);
            // 
            // AdvancedGroupBox
            // 
            this.AdvancedGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedGroupBox.Controls.Add(this.numericFakeGenUpDown);
            this.AdvancedGroupBox.Controls.Add(this.label3);
            this.AdvancedGroupBox.Controls.Add(this.label2);
            this.AdvancedGroupBox.Controls.Add(this.numericArgUpDown);
            this.AdvancedGroupBox.Location = new System.Drawing.Point(12, 145);
            this.AdvancedGroupBox.Name = "AdvancedGroupBox";
            this.AdvancedGroupBox.Size = new System.Drawing.Size(146, 100);
            this.AdvancedGroupBox.TabIndex = 4;
            this.AdvancedGroupBox.TabStop = false;
            this.AdvancedGroupBox.Visible = false;
            // 
            // numericFakeGenUpDown
            // 
            this.numericFakeGenUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericFakeGenUpDown.Location = new System.Drawing.Point(6, 73);
            this.numericFakeGenUpDown.Name = "numericFakeGenUpDown";
            this.numericFakeGenUpDown.Size = new System.Drawing.Size(134, 20);
            this.numericFakeGenUpDown.TabIndex = 3;
            this.numericFakeGenUpDown.Value = new decimal(new int[] {
            29,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "fake-gen Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Arg";
            // 
            // numericArgUpDown
            // 
            this.numericArgUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericArgUpDown.Location = new System.Drawing.Point(6, 34);
            this.numericArgUpDown.Name = "numericArgUpDown";
            this.numericArgUpDown.Size = new System.Drawing.Size(134, 20);
            this.numericArgUpDown.TabIndex = 0;
            this.numericArgUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 257);
            this.Controls.Add(this.AdvancedGroupBox);
            this.Controls.Add(this.AdvancedCheckBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.deployButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AngryHammer";
            this.AdvancedGroupBox.ResumeLayout(false);
            this.AdvancedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFakeGenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericArgUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deployButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox AdvancedCheckBox;
        private System.Windows.Forms.GroupBox AdvancedGroupBox;
        private System.Windows.Forms.NumericUpDown numericFakeGenUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericArgUpDown;
    }
}

