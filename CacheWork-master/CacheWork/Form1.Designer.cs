﻿namespace CacheWork
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
            this.textBox_OP = new System.Windows.Forms.TextBox();
            this.textBox_Cache = new System.Windows.Forms.TextBox();
            this.label_OP = new System.Windows.Forms.Label();
            this.label_CACHE = new System.Windows.Forms.Label();
            this.label_Page = new System.Windows.Forms.Label();
            this.label_String = new System.Windows.Forms.Label();
            this.label_Items = new System.Windows.Forms.Label();
            this.textBox_Page = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.textBox_String = new System.Windows.Forms.TextBox();
            this.textBox_Items = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_ItemSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_StringSearch = new System.Windows.Forms.TextBox();
            this.textBox_PageSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ItemChange = new System.Windows.Forms.TextBox();
            this.button_Change = new System.Windows.Forms.Button();
            this.label_WhereFrom = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label_StringFrom = new System.Windows.Forms.Label();
            this.label_ItemFrom = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TimeFrom = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_OP
            // 
            this.textBox_OP.Location = new System.Drawing.Point(12, 151);
            this.textBox_OP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_OP.Multiline = true;
            this.textBox_OP.Name = "textBox_OP";
            this.textBox_OP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_OP.Size = new System.Drawing.Size(332, 366);
            this.textBox_OP.TabIndex = 0;
            // 
            // textBox_Cache
            // 
            this.textBox_Cache.Location = new System.Drawing.Point(366, 342);
            this.textBox_Cache.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Cache.Multiline = true;
            this.textBox_Cache.Name = "textBox_Cache";
            this.textBox_Cache.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Cache.Size = new System.Drawing.Size(303, 175);
            this.textBox_Cache.TabIndex = 1;
            // 
            // label_OP
            // 
            this.label_OP.AutoSize = true;
            this.label_OP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OP.Location = new System.Drawing.Point(124, 122);
            this.label_OP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OP.Name = "label_OP";
            this.label_OP.Size = new System.Drawing.Size(86, 25);
            this.label_OP.TabIndex = 2;
            this.label_OP.Text = "Память";
            // 
            // label_CACHE
            // 
            this.label_CACHE.AutoSize = true;
            this.label_CACHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CACHE.Location = new System.Drawing.Point(457, 313);
            this.label_CACHE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CACHE.Name = "label_CACHE";
            this.label_CACHE.Size = new System.Drawing.Size(129, 25);
            this.label_CACHE.TabIndex = 3;
            this.label_CACHE.Text = "Кэш-память";
            // 
            // label_Page
            // 
            this.label_Page.AutoSize = true;
            this.label_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Page.Location = new System.Drawing.Point(9, 20);
            this.label_Page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Page.Name = "label_Page";
            this.label_Page.Size = new System.Drawing.Size(81, 18);
            this.label_Page.TabIndex = 4;
            this.label_Page.Text = "Страницы:";
            // 
            // label_String
            // 
            this.label_String.AutoSize = true;
            this.label_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_String.Location = new System.Drawing.Point(119, 20);
            this.label_String.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_String.Name = "label_String";
            this.label_String.Size = new System.Drawing.Size(63, 18);
            this.label_String.TabIndex = 5;
            this.label_String.Text = "Строки:";
            // 
            // label_Items
            // 
            this.label_Items.AutoSize = true;
            this.label_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Items.Location = new System.Drawing.Point(228, 20);
            this.label_Items.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Items.Name = "label_Items";
            this.label_Items.Size = new System.Drawing.Size(85, 18);
            this.label_Items.TabIndex = 6;
            this.label_Items.Text = "Элементы:";
            // 
            // textBox_Page
            // 
            this.textBox_Page.Location = new System.Drawing.Point(13, 42);
            this.textBox_Page.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Page.Name = "textBox_Page";
            this.textBox_Page.Size = new System.Drawing.Size(87, 22);
            this.textBox_Page.TabIndex = 7;
            this.textBox_Page.Text = "10";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(12, 72);
            this.button_Create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(185, 46);
            this.button_Create.TabIndex = 10;
            this.button_Create.Text = "Создать";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // textBox_String
            // 
            this.textBox_String.Location = new System.Drawing.Point(123, 42);
            this.textBox_String.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_String.Name = "textBox_String";
            this.textBox_String.Size = new System.Drawing.Size(87, 22);
            this.textBox_String.TabIndex = 11;
            this.textBox_String.Text = "10";
            // 
            // textBox_Items
            // 
            this.textBox_Items.Location = new System.Drawing.Point(232, 42);
            this.textBox_Items.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Items.Name = "textBox_Items";
            this.textBox_Items.Size = new System.Drawing.Size(87, 22);
            this.textBox_Items.TabIndex = 12;
            this.textBox_Items.Text = "4";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(503, 63);
            this.button_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(88, 46);
            this.button_Search.TabIndex = 14;
            this.button_Search.Text = "Найти";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_ItemSearch
            // 
            this.textBox_ItemSearch.Location = new System.Drawing.Point(395, 170);
            this.textBox_ItemSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ItemSearch.Name = "textBox_ItemSearch";
            this.textBox_ItemSearch.Size = new System.Drawing.Size(87, 22);
            this.textBox_ItemSearch.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Страница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(396, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Строка";
            // 
            // textBox_StringSearch
            // 
            this.textBox_StringSearch.Location = new System.Drawing.Point(396, 116);
            this.textBox_StringSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_StringSearch.Name = "textBox_StringSearch";
            this.textBox_StringSearch.Size = new System.Drawing.Size(87, 22);
            this.textBox_StringSearch.TabIndex = 25;
            // 
            // textBox_PageSearch
            // 
            this.textBox_PageSearch.Location = new System.Drawing.Point(398, 63);
            this.textBox_PageSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_PageSearch.Name = "textBox_PageSearch";
            this.textBox_PageSearch.Size = new System.Drawing.Size(87, 22);
            this.textBox_PageSearch.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(400, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(610, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Элемент";
            // 
            // textBox_ItemChange
            // 
            this.textBox_ItemChange.Location = new System.Drawing.Point(612, 63);
            this.textBox_ItemChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ItemChange.Name = "textBox_ItemChange";
            this.textBox_ItemChange.Size = new System.Drawing.Size(87, 22);
            this.textBox_ItemChange.TabIndex = 28;
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(611, 94);
            this.button_Change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(88, 26);
            this.button_Change.TabIndex = 34;
            this.button_Change.Text = "Задать";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // label_WhereFrom
            // 
            this.label_WhereFrom.AutoSize = true;
            this.label_WhereFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WhereFrom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_WhereFrom.Location = new System.Drawing.Point(399, 293);
            this.label_WhereFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_WhereFrom.Name = "label_WhereFrom";
            this.label_WhereFrom.Size = new System.Drawing.Size(221, 20);
            this.label_WhereFrom.TabIndex = 35;
            this.label_WhereFrom.Text = "Элемент загружен из ОП";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label111.Location = new System.Drawing.Point(396, 205);
            this.label111.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(65, 18);
            this.label111.TabIndex = 38;
            this.label111.Text = "Строка";
            // 
            // label_StringFrom
            // 
            this.label_StringFrom.AutoSize = true;
            this.label_StringFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_StringFrom.Location = new System.Drawing.Point(492, 205);
            this.label_StringFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_StringFrom.Name = "label_StringFrom";
            this.label_StringFrom.Size = new System.Drawing.Size(100, 18);
            this.label_StringFrom.TabIndex = 39;
            this.label_StringFrom.Text = "---- ---- ---- ----";
            // 
            // label_ItemFrom
            // 
            this.label_ItemFrom.AutoSize = true;
            this.label_ItemFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ItemFrom.Location = new System.Drawing.Point(492, 234);
            this.label_ItemFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ItemFrom.Name = "label_ItemFrom";
            this.label_ItemFrom.Size = new System.Drawing.Size(28, 18);
            this.label_ItemFrom.TabIndex = 41;
            this.label_ItemFrom.Text = "----";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label121.Location = new System.Drawing.Point(396, 234);
            this.label121.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(77, 18);
            this.label121.TabIndex = 40;
            this.label121.Text = "Элемент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(395, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Время";
            // 
            // label_TimeFrom
            // 
            this.label_TimeFrom.AutoSize = true;
            this.label_TimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeFrom.Location = new System.Drawing.Point(491, 264);
            this.label_TimeFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TimeFrom.Name = "label_TimeFrom";
            this.label_TimeFrom.Size = new System.Drawing.Size(64, 18);
            this.label_TimeFrom.TabIndex = 43;
            this.label_TimeFrom.Text = "00:00:00";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Adress.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Adress.Location = new System.Drawing.Point(459, 20);
            this.label_Adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(129, 17);
            this.label_Adress.TabIndex = 44;
            this.label_Adress.Text = "Адрес элемента";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 530);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_TimeFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ItemFrom);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.label_StringFrom);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.label_WhereFrom);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ItemChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_StringSearch);
            this.Controls.Add(this.textBox_PageSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ItemSearch);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Items);
            this.Controls.Add(this.textBox_String);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.textBox_Page);
            this.Controls.Add(this.label_Items);
            this.Controls.Add(this.label_String);
            this.Controls.Add(this.label_Page);
            this.Controls.Add(this.label_CACHE);
            this.Controls.Add(this.label_OP);
            this.Controls.Add(this.textBox_Cache);
            this.Controls.Add(this.textBox_OP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(731, 577);
            this.MinimumSize = new System.Drawing.Size(731, 577);
            this.Name = "Form1";
            this.Text = "Моделирование работы Кэш-памяти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OP;
        private System.Windows.Forms.TextBox textBox_Cache;
        private System.Windows.Forms.Label label_OP;
        private System.Windows.Forms.Label label_CACHE;
        private System.Windows.Forms.Label label_Page;
        private System.Windows.Forms.Label label_String;
        private System.Windows.Forms.Label label_Items;
        private System.Windows.Forms.TextBox textBox_Page;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox textBox_String;
        private System.Windows.Forms.TextBox textBox_Items;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_ItemSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_StringSearch;
        private System.Windows.Forms.TextBox textBox_PageSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ItemChange;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Label label_WhereFrom;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label_StringFrom;
        private System.Windows.Forms.Label label_ItemFrom;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TimeFrom;
        private System.Windows.Forms.Label label_Adress;
    }
}

