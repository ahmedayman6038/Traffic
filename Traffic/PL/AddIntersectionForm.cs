using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Traffic.PL
{
    public partial class AddIntersectionForm : MetroForm
    {
        public AddIntersectionForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < intersections.Rows.Count-1; rows++)
            {
                MessageBox.Show(intersections.Rows[rows].Cells[0].Value.ToString() + "   " + intersections.Rows[rows].Cells[1].Value.ToString());
                // Do Something Here

            }
        }
    }
}
