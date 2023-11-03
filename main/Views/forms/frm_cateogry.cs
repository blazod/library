using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using main.Execute.presenter;
using main.Views.face;

namespace main.models
{
    public partial class frm_cateogry : DevExpress.XtraEditors.XtraForm,icateogry
    {
      cateogry_presenter cateogry_presenter;
        public int id { get => Convert.ToInt32(txtid.Text); set => txtid.Text = value.ToString(); }
        public string name { get => txtcateogry.Text; set => txtcateogry.Text = value.ToString(); }

        public frm_cateogry()
        {
            InitializeComponent();
            cateogry_presenter = new cateogry_presenter(this);
        }
               
       
        private void btn_add_Click(object sender, EventArgs e)
        {

            bool check= cateogry_presenter.catinsert();
            if (check==true)
            {
                XtraMessageBox.Show("تم الادخال للبيانات بنجاح");

            }
            else
            {
                XtraMessageBox.Show("لم ينم الاضافة للبيانات");
            }
        }
    }
}