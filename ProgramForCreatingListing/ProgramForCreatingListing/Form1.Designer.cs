﻿namespace ProgramForCreatingListing
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage1 = new System.Windows.Forms.TabPage();
            this.buttonOpenFile = new ProgramForCreatingListing.Components.ButtonOpenFile();
            this.progressBarLoadingFiles = new ProgramForCreatingListing.Components.ProgressBarLoadingFiles();
            this.textBoxDelimiterBtwFiles = new ProgramForCreatingListing.Components.TextBoxDelimiterWithHint();
            this.checkBoxMsWordTypeListing = new ProgramForCreatingListing.Components.CheckBoxMsWordType();
            this.checkBoxTxtTypeListing = new ProgramForCreatingListing.Components.CheckBoxTxtType();
            this.checkBoxChooseAllElements = new ProgramForCreatingListing.Components.CheckBoxChooseAllElements();
            this.buttonDelete = new ProgramForCreatingListing.Components.ButtonDelete();
            this.buttonWrite = new ProgramForCreatingListing.Components.ButtonWrite();
            this.listOfFiles = new ProgramForCreatingListing.Components.ListOfFiles();
            this.buttonSearchFiles = new ProgramForCreatingListing.Components.ButtonSearch();
            this.textBoxChooseType = new ProgramForCreatingListing.Components.TextBoxWithHint();
            this.mainTabPage2 = new System.Windows.Forms.TabPage();
            this.informationLabel = new ProgramForCreatingListing.Components.InformationLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainTabControl.SuspendLayout();
            this.mainTabPage1.SuspendLayout();
            this.mainTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTabPage1);
            this.mainTabControl.Controls.Add(this.mainTabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(982, 489);
            this.mainTabControl.TabIndex = 3;
            // 
            // mainTabPage1
            // 
            this.mainTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.mainTabPage1.Controls.Add(this.buttonOpenFile);
            this.mainTabPage1.Controls.Add(this.progressBarLoadingFiles);
            this.mainTabPage1.Controls.Add(this.textBoxDelimiterBtwFiles);
            this.mainTabPage1.Controls.Add(this.checkBoxMsWordTypeListing);
            this.mainTabPage1.Controls.Add(this.checkBoxTxtTypeListing);
            this.mainTabPage1.Controls.Add(this.checkBoxChooseAllElements);
            this.mainTabPage1.Controls.Add(this.buttonDelete);
            this.mainTabPage1.Controls.Add(this.buttonWrite);
            this.mainTabPage1.Controls.Add(this.listOfFiles);
            this.mainTabPage1.Controls.Add(this.buttonSearchFiles);
            this.mainTabPage1.Controls.Add(this.textBoxChooseType);
            this.mainTabPage1.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabPage1.Name = "mainTabPage1";
            this.mainTabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabPage1.Size = new System.Drawing.Size(974, 463);
            this.mainTabPage1.TabIndex = 0;
            this.mainTabPage1.Text = "Формирование листинга";
            this.mainTabPage1.Click += new System.EventHandler(this.mainTabPage1_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(611, -1);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(182, 26);
            this.buttonOpenFile.TabIndex = 16;
            this.buttonOpenFile.Text = "Открыть файл через Notepad++";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // progressBarLoadingFiles
            // 
            this.progressBarLoadingFiles.Location = new System.Drawing.Point(337, 5);
            this.progressBarLoadingFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarLoadingFiles.Name = "progressBarLoadingFiles";
            this.progressBarLoadingFiles.Size = new System.Drawing.Size(258, 19);
            this.progressBarLoadingFiles.TabIndex = 15;
            // 
            // textBoxDelimiterBtwFiles
            // 
            this.textBoxDelimiterBtwFiles.Hint = "Строка, разделяющая файлы в листинге";
            this.textBoxDelimiterBtwFiles.Location = new System.Drawing.Point(380, 421);
            this.textBoxDelimiterBtwFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDelimiterBtwFiles.Name = "textBoxDelimiterBtwFiles";
            this.textBoxDelimiterBtwFiles.Size = new System.Drawing.Size(245, 20);
            this.textBoxDelimiterBtwFiles.TabIndex = 14;
            this.textBoxDelimiterBtwFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDelimiterBtwFiles_MouseDoubleClick);
            // 
            // checkBoxMsWordTypeListing
            // 
            this.checkBoxMsWordTypeListing.AutoSize = true;
            this.checkBoxMsWordTypeListing.Checked = true;
            this.checkBoxMsWordTypeListing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMsWordTypeListing.Location = new System.Drawing.Point(14, 255);
            this.checkBoxMsWordTypeListing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMsWordTypeListing.Name = "checkBoxMsWordTypeListing";
            this.checkBoxMsWordTypeListing.Size = new System.Drawing.Size(156, 17);
            this.checkBoxMsWordTypeListing.TabIndex = 13;
            this.checkBoxMsWordTypeListing.Text = "Запись в .doc/.docx файл";
            this.checkBoxMsWordTypeListing.UseVisualStyleBackColor = true;
            // 
            // checkBoxTxtTypeListing
            // 
            this.checkBoxTxtTypeListing.AutoSize = true;
            this.checkBoxTxtTypeListing.Location = new System.Drawing.Point(14, 233);
            this.checkBoxTxtTypeListing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTxtTypeListing.Name = "checkBoxTxtTypeListing";
            this.checkBoxTxtTypeListing.Size = new System.Drawing.Size(118, 17);
            this.checkBoxTxtTypeListing.TabIndex = 12;
            this.checkBoxTxtTypeListing.Text = "Запись в .txt файл";
            this.checkBoxTxtTypeListing.UseVisualStyleBackColor = true;
            // 
            // checkBoxChooseAllElements
            // 
            this.checkBoxChooseAllElements.AutoSize = true;
            this.checkBoxChooseAllElements.Location = new System.Drawing.Point(183, 5);
            this.checkBoxChooseAllElements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxChooseAllElements.Name = "checkBoxChooseAllElements";
            this.checkBoxChooseAllElements.Size = new System.Drawing.Size(151, 17);
            this.checkBoxChooseAllElements.TabIndex = 11;
            this.checkBoxChooseAllElements.Text = "Выделить все элементы";
            this.checkBoxChooseAllElements.ThreeState = true;
            this.checkBoxChooseAllElements.UseVisualStyleBackColor = true;
            this.checkBoxChooseAllElements.CheckedChanged += new System.EventHandler(this.checkBoxChooseAllElements_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(14, 93);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 53);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить выбранные элементы из списка";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(14, 176);
            this.buttonWrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(126, 46);
            this.buttonWrite.TabIndex = 8;
            this.buttonWrite.Text = "Сформировать листинг";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // listOfFiles
            // 
            this.listOfFiles.CheckOnClick = true;
            this.listOfFiles.FormattingEnabled = true;
            this.listOfFiles.HorizontalScrollbar = true;
            this.listOfFiles.Location = new System.Drawing.Point(183, 36);
            this.listOfFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listOfFiles.Name = "listOfFiles";
            this.listOfFiles.Size = new System.Drawing.Size(770, 349);
            this.listOfFiles.TabIndex = 7;
            this.listOfFiles.SelectedIndexChanged += new System.EventHandler(this.listOfFiles_SelectedIndexChanged);
            // 
            // buttonSearchFiles
            // 
            this.buttonSearchFiles.Location = new System.Drawing.Point(14, 36);
            this.buttonSearchFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearchFiles.Name = "buttonSearchFiles";
            this.buttonSearchFiles.Size = new System.Drawing.Size(126, 33);
            this.buttonSearchFiles.TabIndex = 6;
            this.buttonSearchFiles.Text = "Поиск файлов";
            this.buttonSearchFiles.UseVisualStyleBackColor = true;
            this.buttonSearchFiles.Click += new System.EventHandler(this.buttonSearchFiles_Click);
            // 
            // textBoxChooseType
            // 
            this.textBoxChooseType.Hint = "Расширение файла с точкой";
            this.textBoxChooseType.Location = new System.Drawing.Point(183, 421);
            this.textBoxChooseType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxChooseType.Name = "textBoxChooseType";
            this.textBoxChooseType.Size = new System.Drawing.Size(163, 20);
            this.textBoxChooseType.TabIndex = 5;
            this.textBoxChooseType.TextChanged += new System.EventHandler(this.textBoxChooseType_TextChanged);
            // 
            // mainTabPage2
            // 
            this.mainTabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.mainTabPage2.Controls.Add(this.informationLabel);
            this.mainTabPage2.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabPage2.Name = "mainTabPage2";
            this.mainTabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabPage2.Size = new System.Drawing.Size(974, 463);
            this.mainTabPage2.TabIndex = 1;
            this.mainTabPage2.Text = "Справка";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.informationLabel.Location = new System.Drawing.Point(6, 14);
            this.informationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(858, 228);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = resources.GetString("informationLabel.Text");
            this.informationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 485);
            this.Controls.Add(this.mainTabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Приложение по формированию листинга";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.mainTabControl.ResumeLayout(false);
            this.mainTabPage1.ResumeLayout(false);
            this.mainTabPage1.PerformLayout();
            this.mainTabPage2.ResumeLayout(false);
            this.mainTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTabPage1;
        private System.Windows.Forms.TabPage mainTabPage2;
        private Components.TextBoxWithHint textBoxChooseType;
        private Components.ButtonSearch buttonSearchFiles;
        private Components.ListOfFiles listOfFiles;
        private Components.ButtonWrite buttonWrite;
        private Components.ButtonDelete buttonDelete;
        private Components.CheckBoxChooseAllElements checkBoxChooseAllElements;
        private Components.CheckBoxTxtType checkBoxTxtTypeListing;
        private Components.CheckBoxMsWordType checkBoxMsWordTypeListing;
        private Components.TextBoxDelimiterWithHint textBoxDelimiterBtwFiles;
        private Components.ProgressBarLoadingFiles progressBarLoadingFiles;
        private System.Windows.Forms.ImageList imageList1;
        private Components.ButtonOpenFile buttonOpenFile;
        private Components.InformationLabel informationLabel;

        
    }
}

