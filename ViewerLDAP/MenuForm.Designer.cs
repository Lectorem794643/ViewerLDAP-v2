namespace ViewerLDAP
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.CustomSearch = new System.Windows.Forms.Button();
            this.InformationS = new System.Windows.Forms.Button();
            this.InformationCS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите режим поиска:";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(45)))));
            this.Search.Location = new System.Drawing.Point(149, 31);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(188, 34);
            this.Search.TabIndex = 3;
            this.Search.Text = "Расширеный поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.AdvancedSearch_Click);
            // 
            // CustomSearch
            // 
            this.CustomSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(45)))));
            this.CustomSearch.Location = new System.Drawing.Point(149, 71);
            this.CustomSearch.Name = "CustomSearch";
            this.CustomSearch.Size = new System.Drawing.Size(188, 34);
            this.CustomSearch.TabIndex = 4;
            this.CustomSearch.Text = "Настраевыемый поиск";
            this.CustomSearch.UseVisualStyleBackColor = false;
            this.CustomSearch.Click += new System.EventHandler(this.CustomSearch_Click);
            // 
            // InformationS
            // 
            this.InformationS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.InformationS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationS.Location = new System.Drawing.Point(343, 31);
            this.InformationS.Name = "InformationS";
            this.InformationS.Size = new System.Drawing.Size(34, 34);
            this.InformationS.TabIndex = 5;
            this.InformationS.Text = "?";
            this.InformationS.UseVisualStyleBackColor = false;
            this.InformationS.Click += new System.EventHandler(this.InformationS_Click);
            // 
            // InformationCS
            // 
            this.InformationCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.InformationCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationCS.Location = new System.Drawing.Point(343, 71);
            this.InformationCS.Name = "InformationCS";
            this.InformationCS.Size = new System.Drawing.Size(34, 34);
            this.InformationCS.TabIndex = 7;
            this.InformationCS.Text = "?";
            this.InformationCS.UseVisualStyleBackColor = false;
            this.InformationCS.Click += new System.EventHandler(this.InformationCS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 157);
            this.Controls.Add(this.InformationCS);
            this.Controls.Add(this.InformationS);
            this.Controls.Add(this.CustomSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "ViewerLDAP";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button CustomSearch;
        private System.Windows.Forms.Button InformationS;
        private System.Windows.Forms.Button InformationCS;
    }
}