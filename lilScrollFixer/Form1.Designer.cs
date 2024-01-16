namespace lilScrollFixer
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
            this.Mode = new System.Windows.Forms.Button();
            this.SensitivityControl = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SensitivityControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mode
            // 
            this.Mode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mode.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mode.Location = new System.Drawing.Point(3, 3);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(178, 74);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Activate";
            this.Mode.UseVisualStyleBackColor = true;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // SensitivityControl
            // 
            this.SensitivityControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SensitivityControl.Location = new System.Drawing.Point(53, 110);
            this.SensitivityControl.Name = "SensitivityControl";
            this.SensitivityControl.Size = new System.Drawing.Size(78, 20);
            this.SensitivityControl.TabIndex = 1;
            this.SensitivityControl.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Mode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SensitivityControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 161);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SensitivityControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mode;
        private System.Windows.Forms.NumericUpDown SensitivityControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

