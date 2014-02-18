﻿namespace Twitchmote
{
    partial class FormConfigKeyboard
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewKeyboard = new System.Windows.Forms.DataGridView();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyboardSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripKeyboard = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingBindingSource)).BeginInit();
            this.menuStripKeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKeyboard
            // 
            this.dataGridViewKeyboard.AutoGenerateColumns = false;
            this.dataGridViewKeyboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKeyboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeyboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commandDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewKeyboard.DataSource = this.keyboardSettingBindingSource;
            this.dataGridViewKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKeyboard.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewKeyboard.MultiSelect = false;
            this.dataGridViewKeyboard.Name = "dataGridViewKeyboard";
            this.dataGridViewKeyboard.Size = new System.Drawing.Size(284, 237);
            this.dataGridViewKeyboard.TabIndex = 1;
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Command";
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            this.commandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.commandDataGridViewTextBoxColumn.Width = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DisplayKey";
            this.dataGridViewTextBoxColumn1.HeaderText = "DisplayKey";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // keyboardSettingBindingSource
            // 
            this.keyboardSettingBindingSource.DataSource = typeof(Twitchmote.Classes.KeyboardSetting);
            // 
            // menuStripKeyboard
            // 
            this.menuStripKeyboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStripKeyboard.Location = new System.Drawing.Point(0, 0);
            this.menuStripKeyboard.Name = "menuStripKeyboard";
            this.menuStripKeyboard.Size = new System.Drawing.Size(284, 24);
            this.menuStripKeyboard.TabIndex = 2;
            this.menuStripKeyboard.Text = "menuStripKeyboard";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // FormConfigKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridViewKeyboard);
            this.Controls.Add(this.menuStripKeyboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStripKeyboard;
            this.Name = "FormConfigKeyboard";
            this.Text = "Keyboard config";
            this.Load += new System.EventHandler(this.FormConfigKeyboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingBindingSource)).EndInit();
            this.menuStripKeyboard.ResumeLayout(false);
            this.menuStripKeyboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKeyboard;
        private System.Windows.Forms.BindingSource keyboardSettingBindingSource;
        private System.Windows.Forms.MenuStrip menuStripKeyboard;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

    }
}