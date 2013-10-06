using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;

            string s = textBox2.Text;
            string m = textBox3.Text;
            string f = textBox4.Text;
            string cz = textBox5.Text;

            string str = "รายการที่เลือก :" + Environment.NewLine;
            if (optMale.Checked == true)
            {
                str = str + "1.เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                str = str + "1.เพศ : หญิง" + Environment.NewLine;
            }
            {
                str = str + "2.อายุ : " + n + "ปี" + Environment.NewLine;
            }
            str = str + "3.สถานภาพ :" ;
            if (opt1.Checked == true)
            {
                str = str + "โสด" + Environment.NewLine;
            }
            if (opt2.Checked == true)
            {
                str = str + "สมรส" + Environment.NewLine;
            }
            if (opt3.Checked == true)
            {
                str = str + "หม้าย/หย่าร้าง/แยกกันอยู่" + Environment.NewLine;
            }
            str = str + "4.ระดับการศึกษาสูงสุด:" + Environment.NewLine;
        
            if (apt1.Checked == true)
            {
                str = str + "ต่ำกว่าปริญญาตรี" + Environment.NewLine;
            }
            if (apt2.Checked == true)
            {
                str = str + "ปริญญาตรี" + Environment.NewLine;
            }
            if (apt3.Checked == true)
            {

                str = str + "สูงกว่าปริญญาตรี" + Environment.NewLine;

            }
            if (radioButton1.Checked == true)
                str = str + "อื่นๆระบุ : " + s + Environment.NewLine;

            {
                str = str + "5.รายได้ : " + m +"บาทต่อเดือน" + Environment.NewLine;
            }

            {


            }
            str = str + "6.ท่านมีโรคประจำตัวหรือไม่ : " + Environment.NewLine;
            if (cpt1.Checked == true)
            {
                str = str + "ไม่มี" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "มีโรคประจำตัวคือ :" +f + Environment.NewLine;
            }
            str = str + "7.ปัจจุบันท่านออกกำลังกายเพื่อสุขภาพด้วยวิธีใด" + Environment.NewLine;
            if (radioButton2.Checked == true)
            {
                str = str + "เดิน" + Environment.NewLine;
            }
            if (radioButton3.Checked == true)
            {
                str = str + "วิ่งเยาะ ๆ" + Environment.NewLine;
            }
            if (radioButton4.Checked == true)
            {
                str = str + "เต้นแอโรบิค" + Environment.NewLine;
            }
            if (radioButton5.Checked == true)
            {
                str = str + "ไท้เก๊ก" + Environment.NewLine;



            }
            if (radioButton6.Checked == true)
            {
                str = str + "ถีบจักรยานอยู่กับที่" + Environment.NewLine;
            }
            if (radioButton7.Checked == true)
            {
                str = str + "อื่นๆคือ :" +cz + Environment.NewLine;


            }
            MessageBox.Show(str, "ผลการตรวจสอบ");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


                

           