using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputeSquare_Click(object sender, EventArgs e)
        {
            Square sq = new Square();

            sq.Name = "Name: "+"Square";
            sq.NoSide = 0;
            sq.Color = "Color: " +"Blue";
            sq.Length = double.Parse(txtSide.Text);
            lblName.Text = sq.Name;
            lblColor.Text = sq.Color;
            lblNoSide.Text = sq.NoSide+"";
            lblArea.Text = "Area: "+sq.computeArea().ToString();
            lblPerimeter.Text = "Perimeter: " + sq.computePerimeter().ToString();
        }

        private void btnComputeRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle();

            rec.Name = "Name: " + "Rectangle";
            rec.NoSide = 0;
            rec.Color = "Color: " + "Blue";
            rec.Length = double.Parse(txtLength.Text);
            rec.Width = double.Parse(txtWidth.Text);
            lblName.Text = rec.Name;
            lblColor.Text = rec.Color;
            lblNoSide.Text = rec.NoSide + "";
            lblArea.Text = "Area: " + rec.computeArea().ToString();
            //lblPerimeter.Text = "Perimeter: " + rec.computePerimeter().ToString();
        }

        private void btnComputeTriangle_Click(object sender, EventArgs e)
        {
           Triangle tri = new Triangle();

            tri.Name = "Name: " + "Rectangle";
            tri.NoSide = 0;
            tri.Color = "Color: " + "Blue";
            tri.Base1 = double.Parse(txtBase.Text);
            tri.Height = double.Parse(txtHeight.Text);
            lblName.Text = tri.Name;
            lblColor.Text = tri.Color;
            lblNoSide.Text = tri.NoSide + "";
            lblArea.Text = "Area: " + tri.computeArea().ToString();
        }

        private void btnComputeCircle_Click(object sender, EventArgs e)
        {
            Circle circ = new Circle();

            circ.Name = "Name: " + "Rectangle";
            circ.NoSide = 0;
            circ.Color = "Color: " + "Blue";
            circ.Radius = double.Parse(txtRadius.Text);
            lblName.Text = circ.Name;
            lblColor.Text = circ.Color;
            lblNoSide.Text = circ.NoSide + "";
            lblArea.Text = "Area: " + circ.computeArea().ToString();
        }
    }
}
