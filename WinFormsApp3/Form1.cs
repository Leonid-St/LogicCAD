using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WinFormsApp3.Nodes;


namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Model model = new Model();
        public Form1()
        {
            InitializeComponent();
            model.Add(new StartNode(model) { Location = new Point(100, 200), Tag = "Start" });
            model.Add(new FinishNode(model) { Location = new Point(550, 200), Tag = "Finish", Pin = null });
            dragPanel1.Build(model);
        }

        private void Disjunction_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            model.Add(new Node(model)
            {   
                Location = new Point(r.Next(100,500), r.Next(100,500)),
                Tag = 1
            }); dragPanel1.Invalidate();
        }

        private void Implication_Click(object sender, EventArgs e)
        {

        }

        private void Conjunction_Click(object sender, EventArgs e)
        {

        }

        private void Co_implication_Click(object sender, EventArgs e)
        {

        }

        private void Addition_Modulo_Two_Click(object sender, EventArgs e)
        {

        }

        private void Webb_Element_Click(object sender, EventArgs e)
        {

        }

        private void Equivalence_Click(object sender, EventArgs e)
        {

        }

        private void Schaeffer_Element_Click(object sender, EventArgs e)
        {

        }
    }
}
