using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace bc190405727
{
    interface GPA
    {
        void getinput();
        void calculate(object sender, EventArgs la);
    }

    class Student : Form, GPA
    {
        int subject; double GPA, CGPA; int ch = 3;
        public Student()
        {
            Button Laiba = new Button();
            Laiba.Parent = this;
            Laiba.Text = "Calculate";
            Laiba.Location = new Point(
                (ClientSize.Width - Laiba.Width) / 2,
                (ClientSize.Height - Laiba.Height) / 2);

            getinput();
            Laiba.Click += new EventHandler(calculate);
        }
        public void getinput()
        {
            Console.WriteLine("Enter the Number of Subject");
             subject = int.Parse(Console.ReadLine());
             if (subject == 0)
            {
                subject += 3;
            }
            else if(subject==1)
            {
                subject+=2;
            }
            else if (subject == 2)
            {
                subject += 1;
            }
            for (int k = 1; k <= subject; k++)
            {
                Console.WriteLine("Enter the GPA of the Subject: " + k);
                GPA = Convert.ToDouble(Console.ReadLine());
                CGPA = CGPA + GPA;
            }
            Console.WriteLine("Total Credit Hours : " + subject * ch);
        }
        public void calculate(object sender, EventArgs la)
        {
            MessageBox.Show("CGPA: " + (CGPA / subject).ToString("0.0"), "CGPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your VUID");
            string VUID = Console.ReadLine();
            Application.Run(new Student());

        }
    }
}
