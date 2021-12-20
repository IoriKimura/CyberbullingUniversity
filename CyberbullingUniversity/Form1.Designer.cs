namespace CyberbullingUniversity
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.btnRelease = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(530, 77);
      this.panel1.TabIndex = 0;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.label1.Location = new System.Drawing.Point(154, 24);
      this.label1.Name = "label1";
      this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label1.Size = new System.Drawing.Size(246, 32);
      this.label1.TabIndex = 0;
      this.label1.Text = "Цензуратор текста";
      // 
      // btnRelease
      // 
      this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.btnRelease.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRelease.FlatAppearance.BorderSize = 0;
      this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRelease.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnRelease.ForeColor = System.Drawing.SystemColors.Window;
      this.btnRelease.Location = new System.Drawing.Point(0, 110);
      this.btnRelease.Name = "btnRelease";
      this.btnRelease.Size = new System.Drawing.Size(153, 58);
      this.btnRelease.TabIndex = 1;
      this.btnRelease.Text = "Автор";
      this.btnRelease.UseVisualStyleBackColor = false;
      this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
      // 
      // btnStart
      // 
      this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnStart.FlatAppearance.BorderSize = 0;
      this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStart.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnStart.ForeColor = System.Drawing.Color.White;
      this.btnStart.Location = new System.Drawing.Point(0, 0);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(153, 58);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "Корректировать текст";
      this.btnStart.UseVisualStyleBackColor = false;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAdd.FlatAppearance.BorderSize = 0;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdd.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
      this.btnAdd.Location = new System.Drawing.Point(0, 55);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(153, 58);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Добавить слово";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
      this.btnExit.Location = new System.Drawing.Point(0, 164);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(153, 58);
      this.btnExit.TabIndex = 4;
      this.btnExit.Text = "Выход";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Controls.Add(this.btnStart);
      this.panel2.Controls.Add(this.btnAdd);
      this.panel2.Controls.Add(this.btnExit);
      this.panel2.Controls.Add(this.btnRelease);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 77);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(151, 280);
      this.panel2.TabIndex = 6;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(127)))), ((int)(((byte)(143)))));
      this.panel3.Location = new System.Drawing.Point(0, 217);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(151, 63);
      this.panel3.TabIndex = 5;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pictureBox1.Location = new System.Drawing.Point(181, 83);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(315, 268);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
      this.ClientSize = new System.Drawing.Size(530, 357);
      this.ControlBox = false;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.ForeColor = System.Drawing.Color.Black;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Цензуратор";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnRelease;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel3;
  }
}

