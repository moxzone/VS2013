using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NSoup;
using NSoup.Nodes;
using NSoup.Select;

namespace NsoupTest
{
    public partial class MainForm : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            bw.DoWork +=new DoWorkEventHandler(DoWork);
            bw.RunWorkerCompleted +=new RunWorkerCompletedEventHandler(RunWorkerCompleted);
            bw.ProgressChanged +=new ProgressChangedEventHandler(ProgressChanged);
            bw.WorkerReportsProgress = true;
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lb1.Text = e.ProgressPercentage.ToString();
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DGVbook.DataSource = e.Result;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            NS ns = new NS();
            List<Books> book = new List<Books>();
            List<Document> dc = new List<Document>();
            for (int i = 1; i <= (int)e.Argument; i++)
            {
                dc.Add(NSoupClient.Parse(ns.getHtml("http://www.jb51.net/books/list422_"+i.ToString()+".html")));
                bw.ReportProgress(i+1);
            }
            book=ns.Book(dc);
            var result = (from b in book
                          where b.acc== "[C/C++/C#]"
                          select new { b.BookName,b.acc,b.date }).ToList();
            e.Result = result;
                    
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            NS ns = new NS();
            List<Document> dc = new List<Document>();
            Document doc = NSoupClient.Parse(ns.getHtml("http://www.jb51.net/books/list422_1.html"));
            Elements lk = doc.Select("div.plist>a:contains(末页)");
            int p =Convert.ToInt32(lk[0].Attr("href").Split('_')[1].Replace(".html", ""));
            bw.RunWorkerAsync(p);
        }
    }
}
