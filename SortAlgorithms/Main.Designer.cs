namespace SortAlgorithms
{
    partial class Main
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
            this.buttonGenerateArray = new System.Windows.Forms.Button();
            this.buttonSortArray = new System.Windows.Forms.Button();
            this.trackBarArrayLenght = new System.Windows.Forms.TrackBar();
            this.labelArrayLenght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarArrayLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateArray
            // 
            this.buttonGenerateArray.Location = new System.Drawing.Point(12, 498);
            this.buttonGenerateArray.Name = "buttonGenerateArray";
            this.buttonGenerateArray.Size = new System.Drawing.Size(180, 43);
            this.buttonGenerateArray.TabIndex = 0;
            this.buttonGenerateArray.Text = "Сгенерировать массив";
            this.buttonGenerateArray.UseVisualStyleBackColor = true;
            this.buttonGenerateArray.Click += new System.EventHandler(this.buttonGenerateArray_Click);
            // 
            // buttonSortArray
            // 
            this.buttonSortArray.Location = new System.Drawing.Point(610, 498);
            this.buttonSortArray.Name = "buttonSortArray";
            this.buttonSortArray.Size = new System.Drawing.Size(180, 43);
            this.buttonSortArray.TabIndex = 1;
            this.buttonSortArray.Text = "Сортировать массив";
            this.buttonSortArray.UseVisualStyleBackColor = true;
            this.buttonSortArray.Click += new System.EventHandler(this.buttonSortArray_Click);
            // 
            // trackBarArrayLenght
            // 
            this.trackBarArrayLenght.Location = new System.Drawing.Point(233, 498);
            this.trackBarArrayLenght.Maximum = 100000;
            this.trackBarArrayLenght.Minimum = 10;
            this.trackBarArrayLenght.Name = "trackBarArrayLenght";
            this.trackBarArrayLenght.Size = new System.Drawing.Size(333, 56);
            this.trackBarArrayLenght.TabIndex = 2;
            this.trackBarArrayLenght.Value = 10000;
            this.trackBarArrayLenght.ValueChanged += new System.EventHandler(this.trackBarArrayLenght_ValueChanged);
            // 
            // labelArrayLenght
            // 
            this.labelArrayLenght.AutoSize = true;
            this.labelArrayLenght.Location = new System.Drawing.Point(328, 469);
            this.labelArrayLenght.Name = "labelArrayLenght";
            this.labelArrayLenght.Size = new System.Drawing.Size(147, 16);
            this.labelArrayLenght.TabIndex = 3;
            this.labelArrayLenght.Text = "Длина массива: 10000";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 553);
            this.Controls.Add(this.labelArrayLenght);
            this.Controls.Add(this.trackBarArrayLenght);
            this.Controls.Add(this.buttonSortArray);
            this.Controls.Add(this.buttonGenerateArray);
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "Main";
            this.Text = "Sort Algorithms";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarArrayLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateArray;
        private System.Windows.Forms.Button buttonSortArray;
        private System.Windows.Forms.TrackBar trackBarArrayLenght;
        private System.Windows.Forms.Label labelArrayLenght;
    }
}

