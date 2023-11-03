using main.Views.face;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using main.models;

namespace main.Execute.presenter
{
    class cateogry_presenter
    {
        // linking mvp
        main.Views.face.icateogry icat;

        Var.cateogry cat = new Var.cateogry();

       

        public cateogry_presenter(icateogry view)
        {
            this.icat = view;

        }

     

       

        private void connectbetweenmodelandinterface()
        {
            cat.id = icat.id;
            cat.name = icat.name;


        }

        public  bool catinsert ()
            {
            connectbetweenmodelandinterface();
            return services.cateogry_services.cateogryinsert(cat.id, cat.name);

            }


    }
}
