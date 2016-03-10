using System.Text;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using NSoup;
using NSoup.Nodes;
using NSoup.Select;


namespace NsoupTest
{
    class NS
    {
         bool isLuan(string txt)
        {
            var bytes = Encoding.UTF8.GetBytes(txt);
            //239 191 189
            for (var i = 0; i < bytes.Length; i++)
            {
                if (i < bytes.Length - 3)
                    if (bytes[i] == 239 && bytes[i + 1] == 191 && bytes[i + 2] == 189)
                    {
                        return true;
                    }
            }
            return false;
        }
        public string getHtml(string url)
        {
            string htm = "";
            var data = new System.Net.WebClient { }.DownloadData(url); //根据网址下载html
            var r_utf8 = new System.IO.StreamReader(new System.IO.MemoryStream(data), Encoding.UTF8); //将html放到utf8编码的StreamReader内
            var r_gbk = new System.IO.StreamReader(new System.IO.MemoryStream(data), Encoding.Default); //将html放到gbk编码的StreamReader内
            var t_utf8 = r_utf8.ReadToEnd(); //读出html内容
            var t_gbk = r_gbk.ReadToEnd(); //读出html内容
            if (!isLuan(t_utf8)) //判断utf8是否有乱码
            {
                htm = t_utf8;
                //this.Text = "utf8";
            }
            else
            {
                htm = t_gbk;
                //this.Text = "gbk";
            }
            return htm;
        }
        
        
        public List<Books> Book(List<Document> s)
        {
            List<Books> retult = new List<Books>();

            foreach (var doc in s)
            {
                Elements lk = doc.Select("dl.soft-con");

                foreach (var item in lk)
                {
                    retult.Add(new Books()
                    {
                        BookName = item.Select("dt>a").Attr("title"),
                        url = item.Select("dt>a").Attr("href"),
                        size = item.Select("dd.soft-ext>span.size").Text,
                        date = item.Select("dd.soft-ext>span.date*").Text,
                        acc = item.Select("dd.soft-ext>span.acc>a").Text,
                        accUrl = item.Select("dd.soft-ext>span.acc>a").Attr("href"),
                        info = item.Select("dd.desc").Text,
                    });
                }
            }
            retult.Reverse();
            return retult;
            
        }
        
    }
}
