using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class update : Form
    {
        dbConnect db = new dbConnect();

        public update()
        {
            InitializeComponent();
        }

        //마우스 클릭 이동 (상단바)
        private Point mousePoint;
        private void topP_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void topP_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                     this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            dbConnect db = new dbConnect();

            dataGridView1.RowHeadersVisible = false; //맨 앞 헤드부분 없앰
            DataSet ds = db.MenuSelect();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 287;                      
        }
        

        //검색 버튼 눌렀을 때 실행
        private void search_button_Click(object sender, EventArgs e)
        {          
            dbConnect db = new dbConnect();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Width = 287;

            string searchMenu = string.Empty;
            searchMenu = string.Format(search_Menu.Text);

            string[] menuType_Combobox = { "면류", "디저트", "밥류", "음료류", "카페" };
            string[] menuType = { "noodle", "dessert", "food", "drink", "cafe" };

            if(combobox_menu.SelectedItem.ToString() == "전체보기")
            {                
                DataSet ds = db.buttonSelectAll(searchMenu);                
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                for(int i =0; i<5; i++)
                {
                    if(combobox_menu.SelectedItem.ToString() == menuType_Combobox[i])
                    {
                        string menu = string.Empty;
                        menu = string.Format(menuType[i]);

                        DataSet ds = db.buttonSelect(menu, searchMenu);
                        dataGridView1.DataSource = ds.Tables[0];
                    }                    
                }                
            }
        }

        //수정 버튼 눌렀을 떄 실행
        private void update_button_Click(object sender, EventArgs e)
        {
            dbConnect db = new dbConnect();
                        
            string name1 = update_name.Text;
            string price1 = update_price.Text;
            string name2 = update_name2.Text;
            string price2 = update_price2.Text;
            
            if ((update_name2.Text == "") || (update_name2.Text.Equals("이름 변경")))
            {
                if ((update_price2.Text == "") || (update_price2.Text.Equals("가격 변경")))
                {
                    MessageBox.Show("이름과 가격을 변경하지 않습니다.");
                    db.update(name1, price1, name1, price1);
                }
                else
                {
                    MessageBox.Show("이름을 변경하지 않습니다.");
                    db.update(name1, price1, name1, price2);
                }
            }
            else
            {
                if ((update_price2.Text == "") || (update_price2.Text.Equals("가격 변경")))
                {
                    MessageBox.Show("가격을 변경하지 않습니다.");
                    db.update(name1, price1, name2, price1);
                }
                else
                {
                    MessageBox.Show("이름과 가격을 변경합니다");
                    db.update(name1, price1, name2, price2);
                }
            }
            //Close();
            update_Load(sender, e);
            textboxClear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            dbConnect db = new dbConnect();

            string name = update_name.Text;
            db.delete(name);
            MessageBox.Show("삭제완료");
            update_Load(sender, e);
            textboxClear();
        }

        //텍스트박스 초기화
        private void textboxClear()
        {
            update_name.Text = "변경할 제품이름";
            update_name2.Text = "이름 변경";
            update_price.Text = "변경할 제품가격";
            update_price2.Text = "가격 변경";
        }
        //그리드뷰 행 클릭시 그 정보를 불러와서 텍스트박스에 출력함
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            update_name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            update_price.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        //텍스트박스에 숫자만 입력되도록 함
        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void close_button_Click(object sender, EventArgs e) //취소버튼
        {
            Close();
        }

        #region 텍스트박스 클릭시 내부 내용 비우기
        
        private void update_name2_Click(object sender, EventArgs e) 
        {
            update_name2.Text = "";
            update_name2.ForeColor = System.Drawing.Color.Black;
        }

        private void update_price2_Click(object sender, EventArgs e)
        {
            update_price2.Text = "";
            update_price2.ForeColor = System.Drawing.Color.Black;
        }
        #endregion
    }
}
