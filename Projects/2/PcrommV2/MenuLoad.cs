using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcrommV2
{
    class MenuLoad
    {
        static MenuLoad instance;
        public static MenuLoad getInstance()
        {
            if (instance == null)
            {
                instance = new MenuLoad();
            }
            return instance;
        }
        DataManager dm = new DataManager();
        private int allMenu()
        {
            DataSet ds = dm.pcRoomAllMenu();
            DataTable dt = ds.Tables[0];
            int num = int.Parse(dt.Rows[0][0].ToString());
            return num;
        }
    }
}
