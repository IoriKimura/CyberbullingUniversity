using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CyberbullingUniversity
{
  public partial class Release : Form
  {
    public Release()
    {
      InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var url = "https://vk.com/id_sergee";
        System.Diagnostics.Process.Start(url);
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      var Main = new Form1();
      Main.Show();
      this.Close();
    }

    Point LastPoint;
    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      LastPoint = new Point(e.X, e.Y);
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.Left += e.X - LastPoint.X;
        this.Top += e.Y - LastPoint.Y;
      }
    }
  }
}
