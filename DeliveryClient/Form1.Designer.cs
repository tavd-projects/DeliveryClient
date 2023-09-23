namespace DeliveryClient
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateCargoRadioButton = new System.Windows.Forms.RadioButton();
            this.registerCargoRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.registerCargoButton = new System.Windows.Forms.Button();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.сargoСollectionTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelReasonTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fullTextSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.searchIdRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.getNewTicketsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.courierMenuGuidTextBox = new System.Windows.Forms.TextBox();
            this.checkAsDoneRadioButton = new System.Windows.Forms.RadioButton();
            this.takeInWorkRadioButton = new System.Windows.Forms.RadioButton();
            this.getAllTicketsButton = new System.Windows.Forms.Button();
            this.siteUriTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateCargoRadioButton);
            this.groupBox1.Controls.Add(this.registerCargoRadioButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.registerCargoButton);
            this.groupBox1.Controls.Add(this.guidTextBox);
            this.groupBox1.Controls.Add(this.сargoСollectionTimeDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descriptionRichTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.weightTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // updateCargoRadioButton
            // 
            this.updateCargoRadioButton.AutoSize = true;
            this.updateCargoRadioButton.Location = new System.Drawing.Point(176, 208);
            this.updateCargoRadioButton.Name = "updateCargoRadioButton";
            this.updateCargoRadioButton.Size = new System.Drawing.Size(74, 17);
            this.updateCargoRadioButton.TabIndex = 12;
            this.updateCargoRadioButton.Text = "Обновить";
            this.updateCargoRadioButton.UseVisualStyleBackColor = true;
            // 
            // registerCargoRadioButton
            // 
            this.registerCargoRadioButton.AutoSize = true;
            this.registerCargoRadioButton.Checked = true;
            this.registerCargoRadioButton.Location = new System.Drawing.Point(9, 208);
            this.registerCargoRadioButton.Name = "registerCargoRadioButton";
            this.registerCargoRadioButton.Size = new System.Drawing.Size(43, 17);
            this.registerCargoRadioButton.TabIndex = 11;
            this.registerCargoRadioButton.TabStop = true;
            this.registerCargoRadioButton.Text = "Рег";
            this.registerCargoRadioButton.UseVisualStyleBackColor = true;
            this.registerCargoRadioButton.CheckedChanged += new System.EventHandler(this.registerCargoRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Id:";
            // 
            // registerCargoButton
            // 
            this.registerCargoButton.Location = new System.Drawing.Point(52, 205);
            this.registerCargoButton.Name = "registerCargoButton";
            this.registerCargoButton.Size = new System.Drawing.Size(118, 23);
            this.registerCargoButton.TabIndex = 9;
            this.registerCargoButton.Text = "Рег/обновить";
            this.registerCargoButton.UseVisualStyleBackColor = true;
            this.registerCargoButton.Click += new System.EventHandler(this.registerCargoButton_Click);
            // 
            // guidTextBox
            // 
            this.guidTextBox.Location = new System.Drawing.Point(35, 175);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.ReadOnly = true;
            this.guidTextBox.Size = new System.Drawing.Size(225, 20);
            this.guidTextBox.TabIndex = 8;
            // 
            // сargoСollectionTimeDateTimePicker
            // 
            this.сargoСollectionTimeDateTimePicker.Location = new System.Drawing.Point(129, 148);
            this.сargoСollectionTimeDateTimePicker.Name = "сargoСollectionTimeDateTimePicker";
            this.сargoСollectionTimeDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.сargoСollectionTimeDateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата сбора курьером:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(9, 84);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(251, 53);
            this.descriptionRichTextBox.TabIndex = 5;
            this.descriptionRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(41, 45);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(219, 20);
            this.weightTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя заказчика:";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(100, 19);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(160, 20);
            this.customerName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelReasonTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cancelIdTextBox);
            this.groupBox2.Location = new System.Drawing.Point(285, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отмена заявки";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cancelReasonTextBox
            // 
            this.cancelReasonTextBox.Location = new System.Drawing.Point(60, 51);
            this.cancelReasonTextBox.Name = "cancelReasonTextBox";
            this.cancelReasonTextBox.Size = new System.Drawing.Size(134, 20);
            this.cancelReasonTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Причина:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(60, 88);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id:";
            // 
            // cancelIdTextBox
            // 
            this.cancelIdTextBox.Location = new System.Drawing.Point(31, 23);
            this.cancelIdTextBox.Name = "cancelIdTextBox";
            this.cancelIdTextBox.Size = new System.Drawing.Size(163, 20);
            this.cancelIdTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fullTextSearchRadioButton);
            this.groupBox3.Controls.Add(this.searchIdRadioButton);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchTextBox);
            this.groupBox3.Location = new System.Drawing.Point(285, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // fullTextSearchRadioButton
            // 
            this.fullTextSearchRadioButton.AutoSize = true;
            this.fullTextSearchRadioButton.Location = new System.Drawing.Point(126, 53);
            this.fullTextSearchRadioButton.Name = "fullTextSearchRadioButton";
            this.fullTextSearchRadioButton.Size = new System.Drawing.Size(61, 17);
            this.fullTextSearchRadioButton.TabIndex = 3;
            this.fullTextSearchRadioButton.Text = "Full-text";
            this.fullTextSearchRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchIdRadioButton
            // 
            this.searchIdRadioButton.AutoSize = true;
            this.searchIdRadioButton.Checked = true;
            this.searchIdRadioButton.Location = new System.Drawing.Point(9, 53);
            this.searchIdRadioButton.Name = "searchIdRadioButton";
            this.searchIdRadioButton.Size = new System.Drawing.Size(34, 17);
            this.searchIdRadioButton.TabIndex = 2;
            this.searchIdRadioButton.TabStop = true;
            this.searchIdRadioButton.Text = "Id";
            this.searchIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(45, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Искать";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(185, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 183);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.getNewTicketsButton);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.changeStatusButton);
            this.groupBox4.Controls.Add(this.courierMenuGuidTextBox);
            this.groupBox4.Controls.Add(this.checkAsDoneRadioButton);
            this.groupBox4.Controls.Add(this.takeInWorkRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(13, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 107);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Меню курьера";
            // 
            // getNewTicketsButton
            // 
            this.getNewTicketsButton.Location = new System.Drawing.Point(8, 70);
            this.getNewTicketsButton.Name = "getNewTicketsButton";
            this.getNewTicketsButton.Size = new System.Drawing.Size(458, 31);
            this.getNewTicketsButton.TabIndex = 5;
            this.getNewTicketsButton.Text = "Получить новые заявки";
            this.getNewTicketsButton.UseVisualStyleBackColor = true;
            this.getNewTicketsButton.Click += new System.EventHandler(this.getNewTicketsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Id:";
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Location = new System.Drawing.Point(263, 21);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(204, 42);
            this.changeStatusButton.TabIndex = 3;
            this.changeStatusButton.Text = "Выполнить";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // courierMenuGuidTextBox
            // 
            this.courierMenuGuidTextBox.Location = new System.Drawing.Point(34, 21);
            this.courierMenuGuidTextBox.Name = "courierMenuGuidTextBox";
            this.courierMenuGuidTextBox.Size = new System.Drawing.Size(207, 20);
            this.courierMenuGuidTextBox.TabIndex = 2;
            // 
            // checkAsDoneRadioButton
            // 
            this.checkAsDoneRadioButton.AutoSize = true;
            this.checkAsDoneRadioButton.Location = new System.Drawing.Point(111, 47);
            this.checkAsDoneRadioButton.Name = "checkAsDoneRadioButton";
            this.checkAsDoneRadioButton.Size = new System.Drawing.Size(146, 17);
            this.checkAsDoneRadioButton.TabIndex = 1;
            this.checkAsDoneRadioButton.TabStop = true;
            this.checkAsDoneRadioButton.Text = "Отметить законченным";
            this.checkAsDoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // takeInWorkRadioButton
            // 
            this.takeInWorkRadioButton.AutoSize = true;
            this.takeInWorkRadioButton.Location = new System.Drawing.Point(8, 47);
            this.takeInWorkRadioButton.Name = "takeInWorkRadioButton";
            this.takeInWorkRadioButton.Size = new System.Drawing.Size(101, 17);
            this.takeInWorkRadioButton.TabIndex = 0;
            this.takeInWorkRadioButton.TabStop = true;
            this.takeInWorkRadioButton.Text = "Взять в работу";
            this.takeInWorkRadioButton.UseVisualStyleBackColor = true;
            // 
            // getAllTicketsButton
            // 
            this.getAllTicketsButton.Location = new System.Drawing.Point(285, 329);
            this.getAllTicketsButton.Name = "getAllTicketsButton";
            this.getAllTicketsButton.Size = new System.Drawing.Size(200, 23);
            this.getAllTicketsButton.TabIndex = 5;
            this.getAllTicketsButton.Text = "Получить все тикеты";
            this.getAllTicketsButton.UseVisualStyleBackColor = true;
            this.getAllTicketsButton.Click += new System.EventHandler(this.getAllTicketsButton_Click);
            // 
            // siteUriTextBox
            // 
            this.siteUriTextBox.Location = new System.Drawing.Point(13, 554);
            this.siteUriTextBox.Name = "siteUriTextBox";
            this.siteUriTextBox.Size = new System.Drawing.Size(472, 20);
            this.siteUriTextBox.TabIndex = 6;
            this.siteUriTextBox.Text = "http://localhost:5032/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 577);
            this.Controls.Add(this.siteUriTextBox);
            this.Controls.Add(this.getAllTicketsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DeliveryClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.DateTimePicker сargoСollectionTimeDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cancelReasonTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cancelIdTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton fullTextSearchRadioButton;
        private System.Windows.Forms.RadioButton searchIdRadioButton;
        private System.Windows.Forms.Button registerCargoButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.TextBox courierMenuGuidTextBox;
        private System.Windows.Forms.RadioButton checkAsDoneRadioButton;
        private System.Windows.Forms.RadioButton takeInWorkRadioButton;
        private System.Windows.Forms.Button getAllTicketsButton;
        private System.Windows.Forms.RadioButton updateCargoRadioButton;
        private System.Windows.Forms.RadioButton registerCargoRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button getNewTicketsButton;
        private System.Windows.Forms.TextBox siteUriTextBox;
    }
}

