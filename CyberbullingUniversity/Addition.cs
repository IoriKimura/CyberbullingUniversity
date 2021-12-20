using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CyberbullingUniversity
{
  public partial class Addition : Form
  {
    public Addition()
    {
      InitializeComponent();
    }

    private void Add_Click(object sender, EventArgs e) //Кнопка, добавления слова в базу и переход к окну коррекции
    {
      if (InputBox.Text == "" || InputBox.TextLength == 1 || InputBox.TextLength == 2)
      {
        InputBox.Text = String.Empty;
        this.Close();
        var CorrectionPage = new CorForm();
        CorrectionPage.Show();
      }
      else
      {
        string Add = InputBox.Text.ToLower();
        StreamWriter Writer = new StreamWriter("rudedate.txt", true, System.Text.Encoding.UTF8);
        Writer.Write(" " + Add);
        Writer.Close();
        var CorrectionPage = new CorForm();
        CorrectionPage.Show();
        this.Close();
      }
    }

    private void Menu_Click(object sender, EventArgs e) //Конпка, которая переносит в главное меню
    {
      var Main = new Form1();
      Main.Show();
      this.Close();
    }
    //Начало блока перемещения окна
    Point LastPoint;
    private void HeadPanel_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }

    private void HeadPanel_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }
    //Конец блока перемещения окна
  }

}
