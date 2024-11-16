using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbookinfo_Click(object sender, EventArgs e)
        {
            book book = new book
            {
                title = "از قیطریه تا اورنج کانتی",
                author = "حمیدرضا صدر",
                year = int.Parse("1400")
            };
            book.printinfo();
        }

        private void btnshowmember_Click(object sender, EventArgs e)
        {
            member mb = new member
            {
                name = "یارا",
                memeberid = 112,
                phone = "09331109593"
            };
            mb.prinmemberinfo();
        }
    }
}
    public class book
    {
    public string title;
    public string author;
    public int year;
    public void printinfo()
    {
        MessageBox.Show("اطلاعات کتاب \n" + "عنوان کتاب:" + title + "\n" + " نویسنده: "  + author + "\n" + "سال انتشار:" + year + "\n");
    }
    }
     public class member
     {
    public string name;
    public int memeberid;
    public string phone;
    public void prinmemberinfo()
    {
        MessageBox.Show("اطلاعات کاربر\n " + "اسم کاربر:"  + name  + "\n"  +   "ایدی کاربر:"  + memeberid + "\n" + "شماره تماس:" + phone); 
    }
     }
     
