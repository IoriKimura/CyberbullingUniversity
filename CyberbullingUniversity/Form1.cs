using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace CyberbullingUniversity
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      var url = "https://www.mirea.ru/education/the-institutes-and-faculties/institute-for-integrated-security-and-special-instrumentation/about-the-institute/"; 
      System.Diagnostics.Process.Start(url);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
    private void btnRelease_Click(object sender, EventArgs e) //Кнопка, открывающая страницу "Автор"
    {
      var Release = new Release();
      Release.Show();
      this.Hide();
    }

    private void btnStart_Click(object sender, EventArgs e) //Кнопка, открывающая страницу "Корректировать текст"
    {
      var CorrectionForm = new CorForm();
      CorrectionForm.Show();
      this.Hide();
    }

    //Начало блока перемещения окна
    Point LastPoint;
    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }
    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }
    //Конец блока перемещения окна
    private void btnAdd_Click(object sender, EventArgs e) //Конпка, открывающая страницу "Добавить слово"
    {
      var Addition = new Addition();
      Addition.Show();
      this.Hide();
    }
  }
}
