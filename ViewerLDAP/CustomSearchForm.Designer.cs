using System.Windows.Forms;

namespace ViewerLDAP
{
    partial class CustomSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomSearchForm));
            this.comboBoxSearchField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.ButtonProcessRequest = new System.Windows.Forms.Button();
            this.ButtonCleanForm = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonNextPage = new System.Windows.Forms.Button();
            this.ButtonPreviousPage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberElements = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.checkBoxPost = new System.Windows.Forms.CheckBox();
            this.checkBoxWorkplace = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearchField
            // 
            this.comboBoxSearchField.BackColor = System.Drawing.Color.White;
            this.comboBoxSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchField.FormattingEnabled = true;
            this.comboBoxSearchField.Items.AddRange(new object[] {
            "ID",
            "Фамилия",
            "Почта ",
            "Должность ",
            "Рабочее место"});
            this.comboBoxSearchField.Location = new System.Drawing.Point(122, 13);
            this.comboBoxSearchField.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchField.Name = "comboBoxSearchField";
            this.comboBoxSearchField.Size = new System.Drawing.Size(253, 24);
            this.comboBoxSearchField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск по полю";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Запрос";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(121, 41);
            this.textBoxRequest.MaxLength = 25;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(254, 22);
            this.textBoxRequest.TabIndex = 3;
            // 
            // ButtonProcessRequest
            // 
            this.ButtonProcessRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.ButtonProcessRequest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonProcessRequest.Location = new System.Drawing.Point(382, 13);
            this.ButtonProcessRequest.Name = "ButtonProcessRequest";
            this.ButtonProcessRequest.Size = new System.Drawing.Size(111, 50);
            this.ButtonProcessRequest.TabIndex = 4;
            this.ButtonProcessRequest.Text = "Обработать запрос";
            this.ButtonProcessRequest.UseVisualStyleBackColor = false;
            this.ButtonProcessRequest.Click += new System.EventHandler(this.Button_ProcessRequest_Click);
            // 
            // ButtonCleanForm
            // 
            this.ButtonCleanForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(45)))));
            this.ButtonCleanForm.Location = new System.Drawing.Point(498, 13);
            this.ButtonCleanForm.Name = "ButtonCleanForm";
            this.ButtonCleanForm.Size = new System.Drawing.Size(87, 50);
            this.ButtonCleanForm.TabIndex = 5;
            this.ButtonCleanForm.Text = "Очистить форму";
            this.ButtonCleanForm.UseVisualStyleBackColor = false;
            this.ButtonCleanForm.Click += new System.EventHandler(this.Button_CleanForm_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 132);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.Size = new System.Drawing.Size(914, 366);
            this.dataGridViewTable.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Почта";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Должность";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Рабочее место";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ButtonNextPage
            // 
            this.ButtonNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(45)))));
            this.ButtonNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextPage.Location = new System.Drawing.Point(885, 504);
            this.ButtonNextPage.Name = "ButtonNextPage";
            this.ButtonNextPage.Size = new System.Drawing.Size(41, 27);
            this.ButtonNextPage.TabIndex = 7;
            this.ButtonNextPage.Text = ">>>";
            this.ButtonNextPage.UseVisualStyleBackColor = false;
            this.ButtonNextPage.Click += new System.EventHandler(this.Button_NextPage_Click);
            // 
            // ButtonPreviousPage
            // 
            this.ButtonPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(45)))));
            this.ButtonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPreviousPage.Location = new System.Drawing.Point(838, 504);
            this.ButtonPreviousPage.Name = "ButtonPreviousPage";
            this.ButtonPreviousPage.Size = new System.Drawing.Size(41, 27);
            this.ButtonPreviousPage.TabIndex = 8;
            this.ButtonPreviousPage.Text = "<<<";
            this.ButtonPreviousPage.UseVisualStyleBackColor = false;
            this.ButtonPreviousPage.Click += new System.EventHandler(this.Button_PreviousPage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Найдено записей:";
            // 
            // textBoxNumberElements
            // 
            this.textBoxNumberElements.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNumberElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberElements.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumberElements.Location = new System.Drawing.Point(144, 501);
            this.textBoxNumberElements.Name = "textBoxNumberElements";
            this.textBoxNumberElements.ReadOnly = true;
            this.textBoxNumberElements.Size = new System.Drawing.Size(86, 15);
            this.textBoxNumberElements.TabIndex = 10;
            // 
            // textBoxCurrentPage
            // 
            this.textBoxCurrentPage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCurrentPage.Location = new System.Drawing.Point(373, 501);
            this.textBoxCurrentPage.Name = "textBoxCurrentPage";
            this.textBoxCurrentPage.ReadOnly = true;
            this.textBoxCurrentPage.Size = new System.Drawing.Size(100, 15);
            this.textBoxCurrentPage.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Текущая страница:";
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Checked = true;
            this.checkBoxId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxId.Location = new System.Drawing.Point(15, 106);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(39, 20);
            this.checkBoxId.TabIndex = 13;
            this.checkBoxId.Text = "ID";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Checked = true;
            this.checkBoxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxName.Location = new System.Drawing.Point(60, 106);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(85, 20);
            this.checkBoxName.TabIndex = 14;
            this.checkBoxName.Text = "Фамилия";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Checked = true;
            this.checkBoxMail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMail.Location = new System.Drawing.Point(151, 106);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(67, 20);
            this.checkBoxMail.TabIndex = 15;
            this.checkBoxMail.Text = "Почта";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            // 
            // checkBoxPost
            // 
            this.checkBoxPost.AutoSize = true;
            this.checkBoxPost.Checked = true;
            this.checkBoxPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPost.Location = new System.Drawing.Point(224, 106);
            this.checkBoxPost.Name = "checkBoxPost";
            this.checkBoxPost.Size = new System.Drawing.Size(97, 20);
            this.checkBoxPost.TabIndex = 16;
            this.checkBoxPost.Text = "Должность";
            this.checkBoxPost.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkplace
            // 
            this.checkBoxWorkplace.AutoSize = true;
            this.checkBoxWorkplace.Checked = true;
            this.checkBoxWorkplace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWorkplace.Location = new System.Drawing.Point(327, 106);
            this.checkBoxWorkplace.Name = "checkBoxWorkplace";
            this.checkBoxWorkplace.Size = new System.Drawing.Size(125, 20);
            this.checkBoxWorkplace.TabIndex = 17;
            this.checkBoxWorkplace.Text = "Рабочее место";
            this.checkBoxWorkplace.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Выберете поля, обязательные к заполнению";
            // 
            // CustomSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxWorkplace);
            this.Controls.Add(this.checkBoxPost);
            this.Controls.Add(this.checkBoxMail);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCurrentPage);
            this.Controls.Add(this.textBoxNumberElements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonPreviousPage);
            this.Controls.Add(this.ButtonNextPage);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.ButtonCleanForm);
            this.Controls.Add(this.ButtonProcessRequest);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSearchField);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Настраеваемый поиск";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Button ButtonProcessRequest;
        private System.Windows.Forms.Button ButtonCleanForm;
        private DataGridView dataGridViewTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button ButtonNextPage;
        private Button ButtonPreviousPage;
        private Label label3;
        private TextBox textBoxNumberElements;
        private TextBox textBoxCurrentPage;
        private Label label4;
        private CheckBox checkBoxId;
        private CheckBox checkBoxName;
        private CheckBox checkBoxMail;
        private CheckBox checkBoxPost;
        private CheckBox checkBoxWorkplace;
        private Label label5;
    }
}