using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PcrommV2
{
    public partial class MainForm : Form
    {
        //
        DataManager dm = new DataManager();
        public List<Cartdata> cart_data_list = new List<Cartdata>();
        public static List<OrderItem> list = new List<OrderItem>(); // 장바구니 카운트 부분 
        string orderCash = string.Empty;
        int orderCard = 0;
        int menuCount = 1;
        static MainForm instance;
        int allPrice = 0;//장바구니 최종금액
        string pcName; //사용자pc이름
        public int Allprice { get { return allPrice; } set { allPrice = value; } }
        public MainForm()
        {
            InitializeComponent();
        }
        public static MainForm getInstance() //싱글톤
        {
            if (instance == null)
            {
                instance = new MainForm();
            }
            return instance;
        }
        //pcName받기
        public void inPcName()
        {
            LoginData da = new LoginData();
            da.ReadIni();
            pcName = da.cls_Pcnum;
        }
        //폼 로드 이벤트
        private void MainForm_Load(object sender, EventArgs e)
        {
            cashP.Visible = false;
            LoginData login_data = new LoginData();
            inPcName();
            if (pcName == null)
                MessageBox.Show("pc이름이 지정되지 않았습니다");
            try
            {
                itemlistAll();
                itemlistDessert();
                itemlistFood();
                itemlistNoodle();
                itemlistDrink();
                itemlistCafe();

            }
            catch (Exception)
            {
                MessageBox.Show("데이터를 불러오는데 실패했습니다.\n서버주소를 확인하세요");
                throw;
            }

        }
        #region 아이템에 관한 마수
        public void itemlistAll()
        {
            DataSet dsCount = dm.pcRoomAllMenu();
            DataTable dtCount = dsCount.Tables[0];
            int menu_num = int.Parse(dtCount.Rows[0][0].ToString());

            DataSet ds = dm.pcRoomBeta("");
            DataTable dt = ds.Tables[0];
            foodItem[] fItem = new foodItem[menu_num];

            for (int i = 0; i < menu_num; i++)
            {
                string menu_name = dt.Rows[i][0].ToString();
                int menu_price = int.Parse(dt.Rows[i][1].ToString());

                fItem[i] = new foodItem();

                fItem[i].initFoodInfo(menu_name, menu_price);

                itemListFlow.Controls.Add(fItem[i]);
            }
        }

        public void itemlistDessert()
        {
            DataSet dsCount = dm.pcRoomCount("dessert");
            DataTable dtCount = dsCount.Tables[0];
            int menu_num = int.Parse(dtCount.Rows[0][0].ToString());

            DataSet ds = dm.pcRoomBeta("where dessert=1");
            DataTable dt = ds.Tables[0];
            int item = menu_num;
            foodItem[] fItem = new foodItem[item];

            for (int i = 0; i < item; i++)
            {
                string menu_name = dt.Rows[i][0].ToString();
                int menu_price = int.Parse(dt.Rows[i][1].ToString());
                fItem[i] = new foodItem();

                fItem[i].initFoodInfo(menu_name, menu_price);

                itemListDessert.Controls.Add(fItem[i]);
            }
        }
        public void itemlistFood()
        {
            DataSet dsCount = dm.pcRoomCount("food");
            DataTable dtCount = dsCount.Tables[0];
            int menu_num = int.Parse(dtCount.Rows[0][0].ToString());

            DataSet ds = dm.pcRoomBeta("where food=1");
            DataTable dt = ds.Tables[0];
            foodItem[] fItem = new foodItem[menu_num];

            for (int i = 0; i < menu_num; i++)
            {
                string menu_name = dt.Rows[i][0].ToString();
                int menu_price = int.Parse(dt.Rows[i][1].ToString());
                fItem[i] = new foodItem();

                fItem[i].initFoodInfo(menu_name, menu_price);

                itemListFood.Controls.Add(fItem[i]);
            }
        }
        public void itemlistNoodle()
        {
            DataSet dsCount = dm.pcRoomCount("noodle");
            DataTable dtCount = dsCount.Tables[0];
            int menu_num = int.Parse(dtCount.Rows[0][0].ToString());

            DataSet ds = dm.pcRoomBeta("where noodle=1");
            DataTable dt = ds.Tables[0];
            foodItem[] fItem = new foodItem[menu_num];

            for (int i = 0; i < menu_num; i++)
            {
                string menu_name = dt.Rows[i][0].ToString();
                int menu_price = int.Parse(dt.Rows[i][1].ToString());
                fItem[i] = new foodItem();

                fItem[i].initFoodInfo(menu_name, menu_price);

                itemListNoodle.Controls.Add(fItem[i]);
            }
        }
        public void itemlistDrink()
        {
            DataSet dsCount = dm.pcRoomCount("drink");
            DataTable dtCount = dsCount.Tables[0];
            int menu_num = int.Parse(dtCount.Rows[0][0].ToString());

            DataSet ds = dm.pcRoomBeta("where drink=1");
            DataTable dt = ds.Tables[0];
            foodItem[] fItem = new foodItem[menu_num];

            for (int i = 0; i < menu_num; i++)
            {
                string menu_name = dt.Rows[i][0].ToString();
                int menu_price = int.Parse(dt.Rows[i][1].ToString());
                fItem[i] = new foodItem();

                fItem[i].initFoodInfo(menu_name, menu_price);

                itemListDrink.Controls.Add(fItem[i]);
            }
        }
        public void itemlistCafe()
        {
            DataSet dsCount = dm.pcRoomCount("cafe");
            DataTable dtCount = dsCount.Tables[0];
            int menu_num = int.Parse(dtCount.Rows[0][0].ToString());

            DataSet ds = dm.pcRoomBeta("where cafe=1");
            DataTable dt = ds.Tables[0];
            foodItem[] fItem = new foodItem[menu_num];

            for (int i = 0; i < menu_num; i++)
            {
                string menu_name = dt.Rows[i][0].ToString();
                int menu_price = int.Parse(dt.Rows[i][1].ToString());
                fItem[i] = new foodItem();

                fItem[i].initFoodInfo(menu_name, menu_price);

                itemListCafe.Controls.Add(fItem[i]);
            }
        }
        #endregion
        #region 메뉴버튼 클릭이벤트

        private void menuAllB_Click(object sender, EventArgs e)
        {
            itemListFlow.BringToFront();
        }

        private void menuDessertB_Click(object sender, EventArgs e)
        {
            itemListDessert.BringToFront();
        }

        private void menuFoodB_Click(object sender, EventArgs e)
        {
            itemListFood.BringToFront();
        }

        private void menuNodleB_Click(object sender, EventArgs e)
        {
            itemListNoodle.BringToFront();
        }

        private void menuDrinkB_Click(object sender, EventArgs e)
        {
            itemListDrink.BringToFront();

        }
        private void menuCafeB_Click(object sender, EventArgs e)
        {
            itemListCafe.BringToFront();
        }
        #endregion
        //좌측상단 로고 더블 클릭 이벤트, 관리자 창 로그인
        private void logoPB_DoubleClick(object sender, EventArgs e)
        {
            managerLogin mlogin = new managerLogin();
            mlogin.Show();
        }

        //장바구니
        #region
        public void initPriceList(Cartdata cd)
        {
            cart_data_list.Add(cd);
            OrderItem item = new OrderItem();
            list.Add(item);
            for (int i = 0; i < cart_data_list.Count; i++)
            {
                item.getItem(cart_data_list[i].Menu_name, cart_data_list[i].Menu_price, cart_data_list[i].Menu_count);
                reAllPrice();
            }
            orderBy.Controls.Add(item);
        }
        public void reAllPrice()
        {
            allPrice = 0;
            for (int i = 0; i < cart_data_list.Count; i++)
            {
                allPrice += cart_data_list[i].Menu_price * cart_data_list[i].Menu_count;
            }
            addCartPriceL();
        }

        public void cart(string name, int price, int count)
        {
            cart_data_list.Add(new Cartdata(name, price, count));
        }
        #endregion
        //최종결제 금액
        public void addCartPriceL()
        {
            cartPriceL.Text = Convert.ToString(allPrice);
        }
        //좌측 버튼 호버 이벤트
        #region
        private void buttonLeave()
        {
            menuAllB.Size = new System.Drawing.Size(300, 131);
            menuFoodB.Size = new System.Drawing.Size(300, 131);
            menuDessertB.Size = new System.Drawing.Size(300, 131);
            menuNodleB.Size = new System.Drawing.Size(300, 131);
            menuDrinkB.Size = new System.Drawing.Size(300, 131);
            menuCafeB.Size = new System.Drawing.Size(300, 131);

            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 215);
            menuFoodB.Location = new System.Drawing.Point(0, 346);
            menuNodleB.Location = new System.Drawing.Point(0, 477);
            menuDrinkB.Location = new System.Drawing.Point(0, 608);
            menuCafeB.Location = new System.Drawing.Point(0, 739);
        }
        private void menuAllB_MouseMove(object sender, MouseEventArgs e)
        {
            menuAllB.Size = new System.Drawing.Size(300, 201);
            menuDessertB.Size = new System.Drawing.Size(300, 117);
            menuFoodB.Size = new System.Drawing.Size(300, 117);
            menuNodleB.Size = new System.Drawing.Size(300, 117);
            menuDrinkB.Size = new System.Drawing.Size(300, 117);
            menuCafeB.Size = new System.Drawing.Size(300, 117);

            //39
            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 285);
            menuFoodB.Location = new System.Drawing.Point(0, 402);
            menuNodleB.Location = new System.Drawing.Point(0, 519);
            menuDrinkB.Location = new System.Drawing.Point(0, 636);
            menuCafeB.Location = new System.Drawing.Point(0, 753);

            //MessageBox.Show(Environment.SpecialFolder.ApplicationData.ToString());
            //Bitmap img = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("btn_0001_food.png"));
            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0002_Allfood.png";

            Image img = Image.FromFile(path);
            menuAllB.BackgroundImage = img;
            menuAllB.ForeColor = Color.White;

        }

        private void menuAllB_MouseLeave(object sender, EventArgs e)
        {
            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0002_Allfood01.png";

            Image img = Image.FromFile(path);
            menuAllB.BackgroundImage = img;
            menuAllB.ForeColor = Color.Black;

            buttonLeave();
        }

        private void menuDessertB_MouseMove(object sender, MouseEventArgs e)
        {
            menuAllB.Size = new System.Drawing.Size(300, 117);
            menuDessertB.Size = new System.Drawing.Size(300, 201);
            menuFoodB.Size = new System.Drawing.Size(300, 117);
            menuNodleB.Size = new System.Drawing.Size(300, 117);
            menuDrinkB.Size = new System.Drawing.Size(300, 117);
            menuCafeB.Size = new System.Drawing.Size(300, 117);

            //39
            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 201);
            menuFoodB.Location = new System.Drawing.Point(0, 402);
            menuNodleB.Location = new System.Drawing.Point(0, 519);
            menuDrinkB.Location = new System.Drawing.Point(0, 636);
            menuCafeB.Location = new System.Drawing.Point(0, 753);

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0004_dessert.png";

            Image img = Image.FromFile(path);
            menuDessertB.BackgroundImage = img;
            menuDessertB.ForeColor = Color.White;
        }

        private void menuDessertB_MouseLeave(object sender, EventArgs e)
        {

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0004_dessert01.png";

            Image img = Image.FromFile(path);
            menuDessertB.BackgroundImage = img;
            menuDessertB.ForeColor = Color.Black;

            buttonLeave();
        }

        private void menuFoodB_MouseMove(object sender, MouseEventArgs e)
        {
            menuAllB.Size = new System.Drawing.Size(300, 117);
            menuDessertB.Size = new System.Drawing.Size(300, 117);
            menuFoodB.Size = new System.Drawing.Size(300, 201);
            menuNodleB.Size = new System.Drawing.Size(300, 117);
            menuDrinkB.Size = new System.Drawing.Size(300, 117);
            menuCafeB.Size = new System.Drawing.Size(300, 117);

            //39
            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 201);
            menuFoodB.Location = new System.Drawing.Point(0, 318);
            menuNodleB.Location = new System.Drawing.Point(0, 519);
            menuDrinkB.Location = new System.Drawing.Point(0, 636);
            menuCafeB.Location = new System.Drawing.Point(0, 753);

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0001_food.png";

            Image img = Image.FromFile(path);
            menuFoodB.BackgroundImage = img;
            menuFoodB.ForeColor = Color.White;
        }

        private void menuFoodB_MouseLeave(object sender, EventArgs e)
        {
            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0001_food01.png";

            Image img = Image.FromFile(path);
            menuFoodB.BackgroundImage = img;
            menuFoodB.ForeColor = Color.Black;

            buttonLeave();
        }

        private void menuNodleB_MouseMove(object sender, MouseEventArgs e)
        {
            menuAllB.Size = new System.Drawing.Size(300, 117);
            menuDessertB.Size = new System.Drawing.Size(300, 117);
            menuFoodB.Size = new System.Drawing.Size(300, 117);
            menuNodleB.Size = new System.Drawing.Size(300, 201);
            menuDrinkB.Size = new System.Drawing.Size(300, 117);
            menuCafeB.Size = new System.Drawing.Size(300, 117);

            //39
            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 201);
            menuFoodB.Location = new System.Drawing.Point(0, 318);
            menuNodleB.Location = new System.Drawing.Point(0, 435);
            menuDrinkB.Location = new System.Drawing.Point(0, 636);
            menuCafeB.Location = new System.Drawing.Point(0, 753);

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0000_noodle.png";

            Image img = Image.FromFile(path);
            menuNodleB.BackgroundImage = img;
            menuNodleB.ForeColor = Color.White;
        }

        private void menuNodleB_MouseLeave(object sender, EventArgs e)
        {
            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0000_noodle01.png";

            Image img = Image.FromFile(path);
            menuNodleB.BackgroundImage = img;
            menuNodleB.ForeColor = Color.Black;

            buttonLeave();
        }

        private void menuDrinkB_MouseMove(object sender, MouseEventArgs e)
        {
            menuAllB.Size = new System.Drawing.Size(300, 117);
            menuDessertB.Size = new System.Drawing.Size(300, 117);
            menuFoodB.Size = new System.Drawing.Size(300, 117);
            menuNodleB.Size = new System.Drawing.Size(300, 117);
            menuDrinkB.Size = new System.Drawing.Size(300, 201);
            menuCafeB.Size = new System.Drawing.Size(300, 117);

            //39
            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 201);
            menuFoodB.Location = new System.Drawing.Point(0, 318);
            menuNodleB.Location = new System.Drawing.Point(0, 435);
            menuDrinkB.Location = new System.Drawing.Point(0, 552);
            menuCafeB.Location = new System.Drawing.Point(0, 753);

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0003_drink.png";

            Image img = Image.FromFile(path);
            menuDrinkB.BackgroundImage = img;
            menuDrinkB.ForeColor = Color.White;
        }

        private void menuDrinkB_MouseLeave(object sender, EventArgs e)
        {
            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0003_drink01.png";

            Image img = Image.FromFile(path);
            menuDrinkB.BackgroundImage = img;
            menuDrinkB.ForeColor = Color.Black;

            buttonLeave();
        }

        private void menuCafeB_MouseMove(object sender, MouseEventArgs e)
        {
            menuAllB.Size = new System.Drawing.Size(300, 117);
            menuDessertB.Size = new System.Drawing.Size(300, 117);
            menuFoodB.Size = new System.Drawing.Size(300, 117);
            menuNodleB.Size = new System.Drawing.Size(300, 117);
            menuDrinkB.Size = new System.Drawing.Size(300, 117);
            menuCafeB.Size = new System.Drawing.Size(300, 201);

            //39
            menuAllB.Location = new System.Drawing.Point(0, 84);
            menuDessertB.Location = new System.Drawing.Point(0, 201);
            menuFoodB.Location = new System.Drawing.Point(0, 318);
            menuNodleB.Location = new System.Drawing.Point(0, 435);
            menuDrinkB.Location = new System.Drawing.Point(0, 552);
            menuCafeB.Location = new System.Drawing.Point(0, 669);

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0005_cafe.png";

            Image img = Image.FromFile(path);
            menuCafeB.BackgroundImage = img;
            menuCafeB.ForeColor = Color.White;

        }

        private void menuCafeB_MouseLeave(object sender, EventArgs e)
        {

            string path = Application.StartupPath + $@"\..\..\Data\img\btn_0005_cafe01.png";

            Image img = Image.FromFile(path);
            menuCafeB.BackgroundImage = img;
            menuCafeB.ForeColor = Color.Black;

            buttonLeave();
        }
        #endregion
        //계산 현금,카드 선택 버튼이벤트
        #region
        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            orderCard = 0;
            cashP.Visible = true;
        }

        private void cardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";
            orderCard = 1;
            cashP.Visible = false;

        }
        #endregion
        //요청사항 이벤트
        private void requestTextBox_Click(object sender, EventArgs e)
        {
            if (requestTextBox.Text == "요청사항을 입력해주세요")
            {
                requestTextBox.Text = "";
                requestTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        //지불수단
        #region
        private void cashChecked()
        {
            if (cashDirect.Checked)
            {
                gotoOrder(cashTextbox.Text);
            }
            else if (cash50000.Checked)
            {
                gotoOrder("오만원권");
            }
            else if (cash10000.Checked)
            {
                gotoOrder("일만원권");
            }
            else if (cash5000.Checked)
            {
                gotoOrder("오천원권");
            }
            else if (cash1000.Checked)
            {
                gotoOrder("천원권");
            }
            else if (cashAll.Checked)
            {
                gotoOrder(allPrice.ToString());
            }
        }
        private void cash50000_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";
        }

        private void cash10000_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";
        }

        private void cash5000_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";
        }

        private void cash1000_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";
        }

        private void cashAll_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";

        }

        private void cashDirect_CheckedChanged(object sender, EventArgs e)
        {
            orderCash = "";
        }

        public void gotoOrder(string cashkinds = "", int card = 0)
        {

            orderCash += cashkinds;
            orderCard += card;
        }
        #endregion
        //결제버튼 이후 초기화
        private void cashRadioButtonClear()
        {
            cashRadioButton.Checked = false;
            cardRadioButton.Checked = false;
            cash50000.Checked = false;
            cash10000.Checked = false;
            cash1000.Checked = false;
            cash5000.Checked = false;
            cashDirect.Checked = false;
            cashAll.Checked = false;
        }
        private void allReset()
        {
            orderCash = string.Empty;
            orderCard = 0;
            cartPriceL.Text = "0";
            cart_data_list.Clear();
            list.Clear();
            requestTextBox.ForeColor = System.Drawing.Color.Gray;
            requestTextBox.Text = "요청사항을 입력해주세요";
            orderBy.Controls.Clear();
            cashRadioButtonClear();
            allPrice = 0;
            cashP.Visible = false;
        }
        private void payB_Click(object sender, EventArgs e)
        {
            if (cardRadioButton.Checked || cash50000.Checked || cash10000.Checked || cash5000.Checked || cash1000.Checked || cashAll.Checked || cashDirect.Checked)
            {
                MessageBox.Show("주문완료");
                cashChecked();
                DataManager.getinstance().orderAdd(pcName, orderCard, orderCash, allPrice, requestTextBox.Text);
                for (int i = 0; i < cart_data_list.Count; i++)
                {
                    DataManager.getinstance().addMenu(pcName, cart_data_list[i].Menu_name, cart_data_list[i].Menu_count);
                }
                allReset();
            }
            else
            {
                MessageBox.Show("결제수단을 선택하세요");
            }
        }

    }
}
