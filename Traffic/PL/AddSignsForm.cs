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
using Traffic.Models;

namespace Traffic.PL
{
    public partial class AddSignsForm : MetroForm
    {
        public static List<TrafficBoard> boards = new List<TrafficBoard>();
        public AddSignsForm()
        {
            InitializeComponent();
        }

        private void AddSignsForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
          
            for (int rows = 0; rows < signs.Rows.Count - 1; rows++)
            {
                TrafficBoard temp = new TrafficBoard();
                Point1 pt1 = new Point1();
                pt1.name = signs.Rows[rows].Cells[0].Value.ToString();
                temp.point1 = pt1;
                Point2 pt2 = new Point2();
                pt2.name = signs.Rows[rows].Cells[1].Value.ToString();
                temp.point2 = pt2;
                temp.boardNumber = Int32.Parse(signs.Rows[rows].Cells[2].Value.ToString());

                boards.Add(temp);

            }
            this.Close();
        }

        private void signs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
