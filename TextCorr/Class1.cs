using System.IO;

namespace TextCorr
{
  public class correct //Коррекция текста
  {
    private string sense;
    private double bully = 0;
    public string Sense
    {
      set {
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

    public string Check(string sen)
    {
      sense = sen.ToLower();
      StreamReader Compare = new StreamReader("rudedate.txt", System.Text.Encoding.UTF8);
      string NLine = Compare.ReadToEnd(); //Занесение содержимого файла в массив
      Compare.Close();
      string[] NBase = NLine.Split(new char[] { ' ' });
      string NWord = "";
      for (int j = 0; j < NBase.Length; j++)
      {
        if (sense.Contains(NBase[j]) == true)
        {
          NWord = NBase[j];  
          sense = sense.Replace(NWord, "deleted"); //Замена грубого слова из файла на "deleted"
        }
      }
      NBase = Sense.Split(new char[] { ' ' });
      for (int i = 0; i < NBase.Length; i++)
      {
        if (NBase[i].Contains("deleted"))
          Bully++;
      }
      return sense;
    }
  }
  public class Calculate : correct //Считает кол-во нецензурных слов. Выдаёт процент содержания мата и грубых слов в тексте
  {
    public double RangeOfBully(string sen)
    {
      string[] sens = sen.Split(new char[] { ' ' });
      Check(sen);
      double Range = (Bully / sens.Length) * 100;
      return Range;
    }
  }
  public class ToUp : correct //Восстановление регистра в новом тексте
  {
    public string Upper(string s, string s1)
    {
      string[] old = s1.Split(new char[] { ' ' }); //Старый текст
      string[] newS = s.Split(new char[] { ' ' }); //Новый текст
      for (int i = 0; i < newS.Length; i++)
      {
        if (newS[i].Contains("deleted") == false)
          newS[i] = old[i];
      }
      for (int i = 0; i < newS.Length; i++)
      {
        Sense += newS[i] + " ";
      }
      return Sense;
    }
  }
}
