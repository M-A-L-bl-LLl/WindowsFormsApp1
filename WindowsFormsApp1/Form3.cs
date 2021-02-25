using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Model1 db = new Model1();
        public static Form1 FORMA { get; set; }
        public static User USER { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  if (textBox1.Text == "" || textBox2.Text == "")
          //  {
          //      MessageBox.Show("Нужно задать логин и пароль!");
          //      return;
          //  }

         //   User usr = db.User.Find(textBox1.Text);

          //  if ((usr != null) && (usr.Password == textBox2.Text))
          //  {
           //     USER = usr;

           //     FORMA = this;


            //    if (usr.RoleId == "A")
            //    {
            //        Form2 frm = new Form2();
             //       frm.Show();
             //       this.Hide();
            //    }
            //    else if (usr.RoleID == "C")
             //   {
             //       Form3 frm = new Form3();
             //       frm.Show();
              //      this.Hide();
             //   }
              //  else if (usr.RoleID == "R")
             //   {

             //   }
             //   else
            //    {
               //     MessageBox.Show($"Роли {usr.RoleID} в системе нет!");
              //      return;
           //     }
          //  }
          //  else
          //  {
           //     MessageBox.Show("Пользователя с таким логином и паролем нет!");
          //      return;
          //  }
        }
    }
}
