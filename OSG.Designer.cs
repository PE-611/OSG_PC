
namespace Test_COM
{
    partial class OSG
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
            this.DurTextBoxCh1 = new System.Windows.Forms.TextBox();
            this.SerialSendButton = new System.Windows.Forms.Button();
            this.ComComboBox = new System.Windows.Forms.ComboBox();
            this.OffComButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DurComboBoxCh1 = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ComboBoxTypeStartCh1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DelComboBoxCh1 = new System.Windows.Forms.ComboBox();
            this.DelTextBoxch1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CommentCh1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DurTextBoxCh1
            // 
            this.DurTextBoxCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurTextBoxCh1.Location = new System.Drawing.Point(16, 133);
            this.DurTextBoxCh1.MaxLength = 3;
            this.DurTextBoxCh1.Name = "DurTextBoxCh1";
            this.DurTextBoxCh1.Size = new System.Drawing.Size(94, 26);
            this.DurTextBoxCh1.TabIndex = 0;
            this.DurTextBoxCh1.TextChanged += new System.EventHandler(this.DurTextBoxCh1_TextChanged);
            // 
            // SerialSendButton
            // 
            this.SerialSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialSendButton.Location = new System.Drawing.Point(1449, 934);
            this.SerialSendButton.Name = "SerialSendButton";
            this.SerialSendButton.Size = new System.Drawing.Size(180, 34);
            this.SerialSendButton.TabIndex = 1;
            this.SerialSendButton.Text = "Сохранить";
            this.SerialSendButton.UseVisualStyleBackColor = true;
            this.SerialSendButton.Click += new System.EventHandler(this.SerialSendButton_Click);
            // 
            // ComComboBox
            // 
            this.ComComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ComComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComComboBox.FormattingEnabled = true;
            this.ComComboBox.Location = new System.Drawing.Point(12, 12);
            this.ComComboBox.Name = "ComComboBox";
            this.ComComboBox.Size = new System.Drawing.Size(85, 28);
            this.ComComboBox.TabIndex = 3;
            this.ComComboBox.SelectedIndexChanged += new System.EventHandler(this.ComComboBox_SelectedIndexChanged);
            // 
            // OffComButton
            // 
            this.OffComButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OffComButton.Location = new System.Drawing.Point(12, 46);
            this.OffComButton.Name = "OffComButton";
            this.OffComButton.Size = new System.Drawing.Size(329, 28);
            this.OffComButton.TabIndex = 4;
            this.OffComButton.Text = "Выберите порт";
            this.OffComButton.UseVisualStyleBackColor = true;
            this.OffComButton.Click += new System.EventHandler(this.OffComButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Нет подключенных портов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Канал 1";
            // 
            // DurComboBoxCh1
            // 
            this.DurComboBoxCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurComboBoxCh1.FormattingEnabled = true;
            this.DurComboBoxCh1.Items.AddRange(new object[] {
            "нс",
            "мкс",
            "мс",
            "с"});
            this.DurComboBoxCh1.Location = new System.Drawing.Point(64, 133);
            this.DurComboBoxCh1.Name = "DurComboBoxCh1";
            this.DurComboBoxCh1.Size = new System.Drawing.Size(46, 28);
            this.DurComboBoxCh1.TabIndex = 7;
            this.DurComboBoxCh1.SelectedIndexChanged += new System.EventHandler(this.DurComboBoxCh1_SelectedIndexChanged);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(1635, 934);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(180, 34);
            this.StartButton.TabIndex = 21;
            this.StartButton.Text = "Пуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ComboBoxTypeStartCh1
            // 
            this.ComboBoxTypeStartCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxTypeStartCh1.FormattingEnabled = true;
            this.ComboBoxTypeStartCh1.Items.AddRange(new object[] {
            "Общий",
            "От предыдущего"});
            this.ComboBoxTypeStartCh1.Location = new System.Drawing.Point(16, 199);
            this.ComboBoxTypeStartCh1.Name = "ComboBoxTypeStartCh1";
            this.ComboBoxTypeStartCh1.Size = new System.Drawing.Size(133, 28);
            this.ComboBoxTypeStartCh1.TabIndex = 22;
            this.ComboBoxTypeStartCh1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeStartCh1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(115, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Длительность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(155, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Тип пуска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(116, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Задержка";
            // 
            // DelComboBoxCh1
            // 
            this.DelComboBoxCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelComboBoxCh1.FormattingEnabled = true;
            this.DelComboBoxCh1.Items.AddRange(new object[] {
            "нс",
            "мкс",
            "мс",
            "с"});
            this.DelComboBoxCh1.Location = new System.Drawing.Point(64, 167);
            this.DelComboBoxCh1.Name = "DelComboBoxCh1";
            this.DelComboBoxCh1.Size = new System.Drawing.Size(46, 28);
            this.DelComboBoxCh1.TabIndex = 29;
            this.DelComboBoxCh1.SelectedIndexChanged += new System.EventHandler(this.DelComboBoxCh1_SelectedIndexChanged);
            // 
            // DelTextBoxch1
            // 
            this.DelTextBoxch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelTextBoxch1.Location = new System.Drawing.Point(16, 167);
            this.DelTextBoxch1.MaxLength = 3;
            this.DelTextBoxch1.Name = "DelTextBoxch1";
            this.DelTextBoxch1.Size = new System.Drawing.Size(94, 26);
            this.DelTextBoxch1.TabIndex = 28;
            this.DelTextBoxch1.TextChanged += new System.EventHandler(this.DelTextBoxch1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(103, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // CommentCh1
            // 
            this.CommentCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentCh1.Location = new System.Drawing.Point(16, 235);
            this.CommentCh1.Name = "CommentCh1";
            this.CommentCh1.Size = new System.Drawing.Size(220, 26);
            this.CommentCh1.TabIndex = 31;
            // 
            // OSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 992);
            this.Controls.Add(this.CommentCh1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DelComboBoxCh1);
            this.Controls.Add(this.DelTextBoxch1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxTypeStartCh1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DurComboBoxCh1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OffComButton);
            this.Controls.Add(this.ComComboBox);
            this.Controls.Add(this.SerialSendButton);
            this.Controls.Add(this.DurTextBoxCh1);
            this.Name = "OSG";
            this.Text = "OSG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DurTextBoxCh1;
        private System.Windows.Forms.Button SerialSendButton;
        private System.Windows.Forms.ComboBox ComComboBox;
        private System.Windows.Forms.Button OffComButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DurComboBoxCh1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ComboBox ComboBoxTypeStartCh1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DelComboBoxCh1;
        private System.Windows.Forms.TextBox DelTextBoxch1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CommentCh1;
    }
}

