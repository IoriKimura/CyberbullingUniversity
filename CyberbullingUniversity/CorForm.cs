using System;
using System.Drawing;
using System.Windows.Forms;
using TextCorr;

namespace CyberbullingUniversity
{
  public partial class CorForm : Form
  {
    public CorForm()
    {
      InitializeComponent();
      OutPut1.Hide();
      InPut.Hide();
      Further.Hide();
    }

    private void btnBegin_Click(object sender, EventArgs e) //Конпка "Заново"
    {
      OutPut1.Show();
      OutPut1.Text = "Повторите ввод!";
      InPut.Show();
      Further.Show();
      btnBegin.Enabled = false;
    }
    private void Menu_Click(object sender, EventArgs e)
    {
      var Main = new Form1();
      Main.Show();
      this.Close();
    }
    private void Further_Click(object sender, EventArgs e) //Конпка коррекции текста
    {
      string Sense = InPut.Text; //Запись введённого текста в переменную
      string newSen = ""; //Изменённый текст. Конечный результат работы программы

      //Проверка на пустой текст. Страница коррекции закончит работу и откроется возможность повтороного ввода
      if (Sense == "")
      {
        OutPut1.Text = "Вы ничего не ввели!";
        Further.Hide();
        btnBegin.Enabled = true;
        return;
      }

      //Проверка, дабы исключить ввод одного символа. Страница коррекции закончит работу и откроется возможность повтороного ввода
      if (Sense.Length == 1)
      {
        OutPut1.Text = "Здесь всего один символ!";
        Further.Hide();
        btnBegin.Enabled = true;
        return;
      }

      Calculate Ca = new Calculate(); //Создание объекта класса подсчёта процента мата
      correct Correcting = new correct(); //Создание объекта класса коррекции текста

      double bully = Ca.RangeOfBully(Sense);
      newSen = Correcting.Check(Sense);
      ToUp Up = new ToUp();
      newSen = Up.Upper(newSen, Sense);
      OutPut1.Text = $"Процент грубости в тексте: {bully}\n" +
      $"Общее количество грубых слов в тексте: {Correcting.Bully}\n" +
      $"{newSen}";
      InPut.Text = String.Empty;
      Further.Hide();
      btnBegin.Enabled = true;
    }

    //Начало блока перемещение окна
    Point LastPoint;
    private void Head_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }

    private void Head_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }
    //Конец блока перемещение окна
    private void CorForm_Load(object sender, EventArgs e)
    {
      OutPut1.Show();
      OutPut1.Text = "Приветствуем вас на странице корректировки текста.\nВведите ваш текст!";
      InPut.Show();
      Further.Show();
      btnBegin.Enabled = false;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Add_Click(object sender, EventArgs e)
    {
      var Addition = new Addition();
      Addition.Show();
      this.Close();
    }
  }
}

