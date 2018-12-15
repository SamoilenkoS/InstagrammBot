namespace InstagramBot
{
    partial class MinMaxParameter
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.ElementEnable = new System.Windows.Forms.CheckBox();
            this.MinimalValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaximalValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(148, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // ElementEnable
            // 
            this.ElementEnable.AutoSize = true;
            this.ElementEnable.Checked = true;
            this.ElementEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ElementEnable.Location = new System.Drawing.Point(13, 25);
            this.ElementEnable.Name = "ElementEnable";
            this.ElementEnable.Size = new System.Drawing.Size(15, 14);
            this.ElementEnable.TabIndex = 1;
            this.ElementEnable.UseVisualStyleBackColor = true;
            this.ElementEnable.CheckedChanged += new System.EventHandler(this.ElementEnable_CheckedChanged);
            // 
            // MinimalValue
            // 
            this.MinimalValue.Location = new System.Drawing.Point(60, 22);
            this.MinimalValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MinimalValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimalValue.Name = "MinimalValue";
            this.MinimalValue.Size = new System.Drawing.Size(65, 20);
            this.MinimalValue.TabIndex = 2;
            this.MinimalValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimalValue.ValueChanged += new System.EventHandler(this.MinimalValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "До";
            // 
            // MaximalValue
            // 
            this.MaximalValue.Location = new System.Drawing.Point(252, 22);
            this.MaximalValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaximalValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaximalValue.Name = "MaximalValue";
            this.MaximalValue.Size = new System.Drawing.Size(65, 20);
            this.MaximalValue.TabIndex = 4;
            this.MaximalValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinMaxParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaximalValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimalValue);
            this.Controls.Add(this.ElementEnable);
            this.Controls.Add(this.Title);
            this.Name = "MinMaxParameter";
            this.Size = new System.Drawing.Size(320, 45);
            ((System.ComponentModel.ISupportInitialize)(this.MinimalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.CheckBox ElementEnable;
        private System.Windows.Forms.NumericUpDown MinimalValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaximalValue;
    }
}
