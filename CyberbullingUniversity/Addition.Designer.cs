namespace CyberbullingUniversity
{
  partial class Addition
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addition));
      this.InputBox = new System.Windows.Forms.RichTextBox();
      this.HeadPanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.Add = new System.Windows.Forms.Button();
      this.Menu = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.HeadPanel.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // InputBox
      // 
      this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
      this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.InputBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.InputBox.Location = new System.Drawing.Point(12, 76);
      this.InputBox.Name = "InputBox";
      this.InputBox.Size = new System.Drawing.Size(615, 98);
      this.InputBox.TabIndex = 0;
      this.InputBox.Text = "";
      // 
      // HeadPanel
      // 
      this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.HeadPanel.Controls.Add(this.label1);
      this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.HeadPanel.Location = new System.Drawing.Point(0, 0);
      this.HeadPanel.Name = "HeadPanel";
      this.HeadPanel.Size = new System.Drawing.Size(797, 60);
      this.HeadPanel.TabIndex = 1;
      this.HeadPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseDown);
      this.HeadPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadPanel_MouseMove);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.Window;
      this.label1.Location = new System.Drawing.Point(294, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(173, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Добавление слов";
      // 
      // Add
      // 
      this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Add.FlatAppearance.BorderSize = 0;
      this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Add.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Add.ForeColor = System.Drawing.SystemColors.Window;
      this.Add.Location = new System.Drawing.Point(0, 0);
      this.Add.Name = "Add";
      this.Add.Size = new System.Drawing.Size(158, 59);
      this.Add.TabIndex = 8;
      this.Add.Text = "Добавить";
      this.Add.UseVisualStyleBackColor = false;
      this.Add.Click += new System.EventHandler(this.Add_Click);
      // 
      // Menu
      // 
      this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Menu.FlatAppearance.BorderSize = 0;
      this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Menu.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Menu.ForeColor = System.Drawing.SystemColors.Window;
      this.Menu.Location = new System.Drawing.Point(0, 55);
      this.Menu.Name = "Menu";
      this.Menu.Size = new System.Drawing.Size(164, 59);
      this.Menu.TabIndex = 9;
      this.Menu.Text = "В главное меню";
      this.Menu.UseVisualStyleBackColor = false;
      this.Menu.Click += new System.EventHandler(this.Menu_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.panel2.Controls.Add(this.Add);
      this.panel2.Controls.Add(this.Menu);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel2.Location = new System.Drawing.Point(642, 60);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(155, 234);
      this.panel2.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
      this.label2.Location = new System.Drawing.Point(12, 186);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(141, 25);
      this.label2.TabIndex = 11;
      this.label2.Text = "Инструкция:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.ForeColor = System.Drawing.SystemColors.Info;
      this.label3.Location = new System.Drawing.Point(12, 210);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(369, 22);
      this.label3.TabIndex = 12;
      this.label3.Text = "1. Убедитесь, что такого слова нет в базе";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.ForeColor = System.Drawing.SystemColors.Info;
      this.label4.Location = new System.Drawing.Point(12, 234);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(418, 22);
      this.label4.TabIndex = 13;
      this.label4.Text = "2. Убедитесь, что слово ругательное или грубое";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.ForeColor = System.Drawing.SystemColors.Info;
      this.label5.Location = new System.Drawing.Point(12, 258);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(298, 22);
      this.label5.TabIndex = 14;
      this.label5.Text = "3. Вводите без знаков пунктуации";
      // 
      // Addition
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
      this.ClientSize = new System.Drawing.Size(797, 294);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.HeadPanel);
      this.Controls.Add(this.InputBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Addition";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Добавление слов";
      this.HeadPanel.ResumeLayout(false);
      this.HeadPanel.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox InputBox;
    private System.Windows.Forms.Panel HeadPanel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button Add;
    private System.Windows.Forms.Button Menu;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
  }
}