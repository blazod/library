namespace main.models
{
    partial class frm_cateogry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cateogry));
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcateogry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtprevious = new DevExpress.XtraEditors.SimpleButton();
            this.txtnext = new DevExpress.XtraEditors.SimpleButton();
            this.txtfirst = new DevExpress.XtraEditors.SimpleButton();
            this.txtlast = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del_all = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(6, 35);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(457, 36);
            this.txtid.TabIndex = 0;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(469, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "المسلسل :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcateogry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات التصنيفات";
            // 
            // txtcateogry
            // 
            this.txtcateogry.Location = new System.Drawing.Point(6, 88);
            this.txtcateogry.Name = "txtcateogry";
            this.txtcateogry.Size = new System.Drawing.Size(457, 36);
            this.txtcateogry.TabIndex = 2;
            this.txtcateogry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(469, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "التصنيف :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtlast);
            this.groupBox2.Controls.Add(this.txtfirst);
            this.groupBox2.Controls.Add(this.txtnext);
            this.groupBox2.Controls.Add(this.txtprevious);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(62, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 73);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسهم التنقل";
            // 
            // txtprevious
            // 
            this.txtprevious.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtprevious.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.txtprevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.txtprevious.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.txtprevious.Location = new System.Drawing.Point(242, 20);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(47, 47);
            this.txtprevious.TabIndex = 0;
            // 
            // txtnext
            // 
            this.txtnext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtnext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.txtnext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.txtnext.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.txtnext.Location = new System.Drawing.Point(178, 20);
            this.txtnext.Name = "txtnext";
            this.txtnext.Size = new System.Drawing.Size(47, 47);
            this.txtnext.TabIndex = 1;
            // 
            // txtfirst
            // 
            this.txtfirst.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtfirst.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.txtfirst.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.txtfirst.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.txtfirst.Location = new System.Drawing.Point(309, 20);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(47, 47);
            this.txtfirst.TabIndex = 2;
            // 
            // txtlast
            // 
            this.txtlast.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtlast.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.txtlast.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.txtlast.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.txtlast.Location = new System.Drawing.Point(111, 20);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(47, 47);
            this.txtlast.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_del_all);
            this.groupBox3.Controls.Add(this.btn_del);
            this.groupBox3.Controls.Add(this.btn_save);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(54, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // btn_new
            // 
            this.btn_new.Appearance.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.btn_new.Location = new System.Drawing.Point(299, 35);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 31);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(378, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(89, 31);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "إضافة";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(204, 35);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 31);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "حفظ";
            // 
            // btn_del
            // 
            this.btn_del.Appearance.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton8.ImageOptions.SvgImage")));
            this.btn_del.Location = new System.Drawing.Point(121, 35);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(77, 31);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "حذف";
            // 
            // btn_del_all
            // 
            this.btn_del_all.Appearance.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_all.Appearance.Options.UseFont = true;
            this.btn_del_all.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton9.ImageOptions.SvgImage")));
            this.btn_del_all.Location = new System.Drawing.Point(10, 35);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(105, 31);
            this.btn_del_all.TabIndex = 4;
            this.btn_del_all.Text = "حذف الكل";
            // 
            // frm_cateogry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(587, 356);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_cateogry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcateogry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton txtprevious;
        private DevExpress.XtraEditors.SimpleButton txtlast;
        private DevExpress.XtraEditors.SimpleButton txtfirst;
        private DevExpress.XtraEditors.SimpleButton txtnext;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_del_all;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_new;
    }
}