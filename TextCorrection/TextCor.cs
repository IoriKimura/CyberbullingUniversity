using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextCorrection
{
  public class correct
  {
    private string sense;
    private double bully;
    public string Sense
    {
      set {
        if (value.Length != 0)
          sense = value;
      }
      get {
        return sense;
      }
    }
    public double Bully
    {
      set {
        bully = value;
      }
      get {
        return bully;
      }
    }
    public correct()//Первый конструктор. Пустой.
    {
      sense = "Здесь пусто. Проверьте данные.";
    }
    public correct(string ar, double i)
    {
      if (ar.Length == 1)//Второй конструктор
      {
        sense = $"Здесь всего один символ. Нецензурной лексики в тексте: { bully}";
        return;
      }
      else
      {
        return;
      }
    }
    public correct(double i) //Третий конструктор
    {
      bully = i;
      if (bully < 0)
        sense = "Ваша оценка отрицательная. Так нельзя!";
      else
        sense = $"Ты сказал, что нецензурной лексики здесь на { i}.";
    }
    public correct(string s)
    {
      Console.WriteLine(s);
    }
    public void GetInfo()//Первый метод. Не возвращает значения.
    {
      Console.WriteLine($"{sense}");
    }
    public string Check(string sen)//Второй метод с значениями.
    {
      sense = sen.ToLower();
      StreamReader Compare = new StreamReader("file.txt", System.Text.Encoding.UTF8);
      string NLine = Compare.ReadToEnd(); //занесение базы слов в массив
      Compare.Close();
      string[] NBase = NLine.Split(new char[] { ' ' });
      bully = 0;
      for (int j = 0; j < NBase.Length; j++)
      {
        string NWord = "";
        if (sense.Contains(NBase[j]) == true)
        {
          NWord = NBase[j];
          //NWord = "сука";
          bully = bully + 1;
          sense = sense.Replace(NWord, "deleted");
        }
      }
      return sense;
    }
  }//Базовый класс
  public class Calculate : correct
  {
    public double RangeOfBully(string sen)
    {
      string[] sens = sen.Split(new char[] { ' ' });
      Check(sen);
      double Range = (Bully / sens.Length) * 100;
      return Range;
    }
  }
  public class Correction : correct
  {
    public string Correction1(string oldSen)
    {
      Sense = oldSen;
      string[] temp = Sense.Split(new char[] { ' ' });
      for (int i = 0; i < temp.Length; i++)
      {
        if (temp[i].Contains("@"))
        {
          string Nword = temp[i];
          Sense = Sense.Replace(Nword, "deleted");
        }
      }
      return Sense;
    }
  }
}
