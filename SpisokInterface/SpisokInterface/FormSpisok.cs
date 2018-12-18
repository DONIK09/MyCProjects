using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokInterface
{
    public partial class FormSpisok : Form
    {
        private MyContainer myContainer;
        public FormSpisok()
        {
            InitializeComponent();
        }

        private void FormSpisok_Load(object sender, EventArgs e)
        {
            this.myContainer = new MyContainer(this.listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myContainer.AddElement(this.textBox1.Text);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.myContainer.ClearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.myContainer.RemoveElement();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.myContainer.Find(this.textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            this.myContainer.changeElement(this.textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.myContainer.sortElements();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                string getFileData = sr.ReadLine();
                string[] splited = getFileData.Split(',');
                List<string> splitedList = splited.ToList<string>();
                splitedList.ForEach(value => { this.myContainer.AddElement(value); });
            }
        }
    }
}
