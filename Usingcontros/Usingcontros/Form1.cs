using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usingcontros
{
    public partial class MainForm : Form
    {
        Random random = new Random(19);
        public MainForm()
        {
            InitializeComponent();
          
            lvDummy.Columns.Add("Name");
       
            lvDummy.Columns.Add("Depth");
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }

        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(new ListViewItem(new string[]
            {
                Node.Text, Node.FullPath.Count(f => f=='\\').ToString()
            }));
            foreach(TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void GrpBar_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                rpTreeList.Items.Add(font.Name);
        }
        void ChangeFont()
        {
            if (rpTreeList.SelectedIndex < 0) return;
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkltalic.Checked)
                style |= FontStyle.Italic;
            txtSampleText.Font = new Font((string)rpTreeList.SelectedItem, 10, style);
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void Chkltalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "Test",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Green;
            frm.ShowDialog();

        }

        private void TvDummy_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
           
        }

        private void LvDummy_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
