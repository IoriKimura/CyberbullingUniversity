namespace CyberbullingUniversity
{
  partial class CorForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorForm));
      this.InPut = new System.Windows.Forms.RichTextBox();
      this.Head = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.OutPut1 = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnExit = new System.Windows.Forms.Button();
      this.Add = new System.Windows.Forms.Button();
      this.Menu = new System.Windows.Forms.Button();
      this.btnBegin = new System.Windows.Forms.Button();
      this.Further = new System.Windows.Forms.Button();
      this.Head.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // InPut
      // 
      this.InPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
      this.InPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.InPut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.InPut.Location = new System.Drawing.Point(164, 169);
      this.InPut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.InPut.Name = "InPut";
      this.InPut.Size = new System.Drawing.Size(625, 135);
      this.InPut.TabIndex = 0;
      this.InPut.Text = "";
      // 
      // Head
      // 
      this.Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.Head.Controls.Add(this.label1);
      this.Head.Dock = System.Windows.Forms.DockStyle.Top;
      this.Head.Location = new System.Drawing.Point(0, 0);
      this.Head.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Head.Name = "Head";
      this.Head.Size = new System.Drawing.Size(797, 60);
      this.Head.TabIndex = 1;
      this.Head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Head_MouseDown);
      this.Head.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Head_MouseMove);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.Window;
      this.label1.Location = new System.Drawing.Point(269, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(278, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Страница коррекции текста";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // OutPut1
      // 
      this.OutPut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
      this.OutPut1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.OutPut1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.OutPut1.Location = new System.Drawing.Point(164, 67);
      this.OutPut1.Name = "OutPut1";
      this.OutPut1.ReadOnly = true;
      this.OutPut1.Size = new System.Drawing.Size(625, 96);
      this.OutPut1.TabIndex = 2;
      this.OutPut1.Text = "";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.panel1.Controls.Add(this.btnExit);
      this.panel1.Controls.Add(this.Add);
      this.panel1.Controls.Add(this.Menu);
      this.panel1.Controls.Add(this.btnBegin);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 60);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(158, 320);
      this.panel1.TabIndex = 4;
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
      this.btnExit.Location = new System.Drawing.Point(0, 261);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(158, 59);
      this.btnExit.TabIndex = 10;
      this.btnExit.Text = "Выход";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // Add
      // 
      this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Add.FlatAppearance.BorderSize = 0;
      this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Add.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Add.ForeColor = System.Drawing.SystemColors.Window;
      this.Add.Location = new System.Drawing.Point(0, 56);
      this.Add.Name = "Add";
      this.Add.Size = new System.Drawing.Size(158, 59);
      this.Add.TabIndex = 9;
      this.Add.Text = "Добавить слово";
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
      this.Menu.Location = new System.Drawing.Point(0, 109);
      this.Menu.Name = "Menu";
      this.Menu.Size = new System.Drawing.Size(158, 59);
      this.Menu.TabIndex = 8;
      this.Menu.Text = "Главное меню";
      this.Menu.UseVisualStyleBackColor = false;
      this.Menu.Click += new System.EventHandler(this.Menu_Click);
      // 
      // btnBegin
      // 
      this.btnBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.btnBegin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBegin.FlatAppearance.BorderSize = 0;
      this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBegin.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnBegin.ForeColor = System.Drawing.SystemColors.Window;
      this.btnBegin.Location = new System.Drawing.Point(0, 0);
      this.btnBegin.Name = "btnBegin";
      this.btnBegin.Size = new System.Drawing.Size(158, 59);
      this.btnBegin.TabIndex = 6;
      this.btnBegin.Text = "Заново";
      this.btnBegin.UseVisualStyleBackColor = false;
      this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
      // 
      // Further
      // 
      this.Further.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.Further.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Further.FlatAppearance.BorderSize = 0;
      this.Further.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Further.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Further.ForeColor = System.Drawing.SystemColors.Window;
      this.Further.Location = new System.Drawing.Point(631, 310);
      this.Further.Name = "Further";
      this.Further.Size = new System.Drawing.Size(158, 59);
      this.Further.TabIndex = 7;
      this.Further.Text = "Корректировать";
      this.Further.UseVisualStyleBackColor = false;
      this.Further.Click += new System.EventHandler(this.Further_Click);
      // 
      // CorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
      this.ClientSize = new System.Drawing.Size(797, 380);
      this.Controls.Add(this.Further);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.OutPut1);
      this.Controls.Add(this.Head);
      this.Controls.Add(this.InPut);
      this.Font = new System.Drawing.Font("Hack", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "CorForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Коррекция";
      this.Load += new System.EventHandler(this.CorForm_Load);
      this.Head.ResumeLayout(false);
      this.Head.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox InPut;
    private System.Windows.Forms.Panel Head;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox OutPut1;
    private System.Windows.Forms.Button btnBegining;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnMainMenu;
    private System.Windows.Forms.Button btnCorrect;
    private System.Windows.Forms.Button Further;
    private System.Windows.Forms.Button btnBegin;
    private System.Windows.Forms.Button Menu;
    private System.Windows.Forms.Button Add;
    private System.Windows.Forms.Button btnExit;
  }
}