using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_13_Part_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           if(MainTabControl.SelectedIndex!=0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SourceTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            SourceTextBox.DoDragDrop(SourceTextBox.Text, DragDropEffects.Move);
            SourceTextBox.Clear();
        }

        private void TargetTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void TargetTextBox_DragDrop(object sender, DragEventArgs e)
        {
            TargetTextBox.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
