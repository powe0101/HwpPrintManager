using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HwpPrintManager
{
    public partial class Form1 : Form
    {
        bool isReverse = false;

        public Form1()
        {
            InitializeComponent();
            axHwpCtrl1.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Hwp 한글 파일 (*.hwp) | *.hwp";
            dialog.Multiselect = true;

            dialog.ShowDialog();
            if(dialog.FileNames.Length > 0)
            {
                for(int i = 0; i < dialog.FileNames.Length; ++i)
                {
                    string temp = dialog.FileNames[i];
                    if (string.IsNullOrEmpty(temp) == true)
                        continue;
                    pathList.Items.Add(temp);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var index = pathList.SelectedIndex;
            if (index < 0)
                return;
            pathList.Items.RemoveAt(index);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (isReverse == true)
            {
                for (int i = pathList.Items.Count - 1; i >= 0; --i)
                {
                    string path = pathList.Items[i].ToString();
                    bool isOpen = axHwpCtrl1.Open(path);
                    if (isOpen == true)
                    {
                        axHwpCtrl1.Run("Print");
                    }
                    axHwpCtrl1.Clear(1);
                }
                return;
            }
            else
            {
                for (int i = 0; i < pathList.Items.Count; ++i)
                {
                    string path = pathList.Items[i].ToString();
                    bool isOpen = axHwpCtrl1.Open(path);
                    if (isOpen == true)
                    {
                        axHwpCtrl1.Run("Print");
                    }
                    axHwpCtrl1.Clear(1);
                }
            }
        }

        private void buttonSortPrev_Click(object sender, EventArgs e)
        {
            var index = pathList.SelectedIndex;

            if (pathList.Items.Count < 1 || index < 1)
                return;

            if(index > 0)
            {
                var temp = pathList.Items[index];
                pathList.Items[index] = pathList.Items[index - 1];
                pathList.Items[index - 1] = temp;
            }
            pathList.SelectedIndex = index - 1;
        }

        private void buttonSortNext_Click(object sender, EventArgs e)
        {
            var index = pathList.SelectedIndex;

            if (pathList.Items.Count < 1 || index >= pathList.Items.Count - 1)
                return;

            if (index > 0)
            {
                var temp = pathList.Items[index];
                pathList.Items[index] = pathList.Items[index + 1];
                pathList.Items[index + 1] = temp;
            }
            pathList.SelectedIndex = index + 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isReverse = checkBox1.Checked;
        }
    }
}
