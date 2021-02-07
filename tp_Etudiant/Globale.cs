using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Etudiant
{
    static class Globale
    {
        static public string conn = string.Format("Data Source=DESKTOP-ESFK467;Initial Catalog=Etudiant_1;"
        + "Integrated Security=true;");
        static public void confirmation()
        {
            Confirmation confirmation = new Confirmation();
            confirmation.Show();

        }
        static public bool hide = false;
    }
}
