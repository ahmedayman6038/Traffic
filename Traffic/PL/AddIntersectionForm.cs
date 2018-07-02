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
        public static List<IntersectionData> intersect = new List<IntersectionData>();
        public AddIntersectionForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < intersections.Rows.Count-1; rows++)
            {
                IntersectionData temp=new IntersectionData();
                temp.numberOfIntersection = rows + 1;
                temp.pointIndex = Int32.Parse(intersections.Rows[rows].Cells[0].Value.ToString());
                temp.caseOfIntersection = Int32.Parse(intersections.Rows[rows].Cells[1].Value.ToString());

                intersect.Add(temp);

            }
            this.Close();
        }

        private void intersections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public partial class IntersectionData
    {
        public int numberOfIntersection;
        public int pointIndex;
       public int caseOfIntersection;
    }
}
