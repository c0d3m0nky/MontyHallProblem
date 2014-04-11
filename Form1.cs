using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontyHallProblem
{

  public partial class Form1 : Form
  {

    private ulong swapped = 0;
    private ulong stuck = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      bgwDo.RunWorkerAsync((ulong)nudIts.Value * 1000);
    }

    private int Rand
    {
      get
      {
        Random rand = new Random();
        int r = rand.Next(1, 300);

        return (int)Math.Ceiling((decimal)r / 100) - 1;
      }
    }

    private void bgwDo_DoWork(object sender, DoWorkEventArgs e)
    {
      swapped = 0;
      stuck = 0;
      ulong len = (ulong)e.Argument;

      for (ulong i = 0; i < len; i++)
      {
        bool[] doors = new bool[] { false, false, false };
        int door = Rand;

        doors[door] = true;
        System.Threading.Thread.Sleep(Rand * Rand + 10);
        int choice = Rand;

        if (door == choice)
        {
          stuck += 1;
        }
        else
        {
          swapped += 1;
        }
        bgwDo.ReportProgress((int)((i * 100) / len));
      }
    }

    private void bgwDo_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      ulong tot = stuck + swapped;

      lblStick.Text = stuck.ToString();
      lblSwap.Text = swapped.ToString();
      lblTotal.Text = tot.ToString();
      lblSwapPerc.Text = ((swapped * 100) / tot).ToString();
      lblStickPerc.Text = ((stuck * 100) / tot).ToString();
    }

    private void bgwDo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {

    }
  }
}
