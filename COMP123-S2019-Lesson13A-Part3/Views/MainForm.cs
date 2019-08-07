using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson13A_Part3.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void SourceTextbox_MouseDown(object sender, MouseEventArgs e)
        {
            SourceTextbox.DoDragDrop(SourceTextbox.Text, DragDropEffects.Move);
            SourceTextbox.Clear();
            Cursor.CopyHandle();
        }

        private void TargetTextbox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void TargetTextbox_DragDrop(object sender, DragEventArgs e)
        {
            TargetTextbox.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
