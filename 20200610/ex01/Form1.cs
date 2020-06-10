using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView_Dummy.Columns.Add("Name",180,HorizontalAlignment.Left);
            listView_Dummy.Columns.Add("Depth",81,HorizontalAlignment.Left);
            listView_Dummy.View = View.Details;
        }

        // 폰트 변경 함수
        private void changeFont()
        {
            if (combo_Font.SelectedIndex < 0)
            {
                return;
            }

            FontStyle style = FontStyle.Regular;

            // 체크박스가 체크되었는지 확인
            if (check_Bold.Checked)
            {
                style |= FontStyle.Bold;

            }
            if (check_Italic.Checked)
            {
                style |= FontStyle.Italic;
            }

            textBox_FontTest.Font = new Font((string)combo_Font.SelectedItem, 10, style);
        }

        // form이 실행 될 때
        private void formLoad(object sender, EventArgs e)
        {
            // 폰트 정보 초기화
            var Fonts = FontFamily.Families;
            foreach (FontFamily item in Fonts)
            {
                // 콤보박스에 폰트들 저장
                combo_Font.Items.Add(item.Name);
            }
        }

        // 콤보박스 폰트 선택해서 클릭시 폰트 변경 함수 실행
        private void onFontSelect(object sender, EventArgs e)
        {
            changeFont();
        }

        // 굵게 체크 시 폰트 변경 함수 실행
        private void onBold(object sender, EventArgs e)
        {
            changeFont();
        }

        // 기울임 체크 시 폰트 변경 함수 실행
        private void onItalic(object sender, EventArgs e)
        {
            changeFont();
        }

        //-----------------------------------------------------------------------------------------------------

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            progressBar_Dummy.Value = trackBar_Dummy.Value;
        }

        //-----------------------------------------------------------------------------------------------------

        private void onModal(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modal Form";
            form.Width = 300;
            form.Height = 200;
            form.BackColor = Color.Beige;
            form.ShowDialog(); // Modal은 ShowDialog
        }

        private void onModaless(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modaless Form";
            form.Width = 300;
            form.Height = 200;
            form.BackColor = Color.Coral;
            form.Show(); // Modaless는 Show
        }

        private void onMessageBox(object sender, EventArgs e)
        {
            MessageBox.Show(textBox_FontTest.Text, "메세지박스", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        //-----------------------------------------------------------------------------------------------------
        private Random rand = new Random();

        private void treeToList()
        {
            listView_Dummy.Items.Clear();
            foreach (TreeNode item in treeView_Dummy.Nodes)
            {
                treeToList(item);
            }
        }

        private void treeToList(TreeNode node)
        {
            listView_Dummy.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode item in node.Nodes)
            {
                treeToList(item);
            }
        }

        private void onAddRoot(object sender, EventArgs e)
        {
            treeView_Dummy.Nodes.Add(rand.Next().ToString());
            treeToList();
        }

        private void onAddChild(object sender, EventArgs e)
        {
            if(treeView_Dummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다", "Tree View", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            treeView_Dummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            treeView_Dummy.SelectedNode.Expand();
            treeToList();
        }
    }
}
