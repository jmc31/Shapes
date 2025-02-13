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
        //for square
        private void btnComputeSquare_Click(object sender, EventArgs e)
        {
            if (!chkArea.Checked && !chkPerimeter.Checked)
            {
                MessageBox.Show("Please select what to compute.");
                return;
            }

            if (!rdoSquare.Checked)
            {
                MessageBox.Show("Please select the exact shape to compute.");
                return;
            }

            Square sq = new Square();
            sq.Name = "Square";
            sq.NoSide = 4;
            sq.Color = "Blue";
            sq.Length = double.Parse(txtSide.Text);

            lblName.Text = "Name: " + sq.Name;
            lblColor.Text = "Color: " + sq.Color;
            lblNoSide.Text = "No. of Sides: " + sq.NoSide;

            // selected computation
            lblArea.Text = chkArea.Checked ? "Area: " + sq.computeArea().ToString() : "";
            lblPerimeter.Text = chkPerimeter.Checked ? "Perimeter: " + sq.computePerimeter().ToString() : "";
        }
        //for rec
        private void btnComputeRectangle_Click(object sender, EventArgs e)
        {
            if (!chkArea.Checked && !chkPerimeter.Checked)
            {
                MessageBox.Show("Please select what to compute.");
                return;
            }

            if (!rdoRectangle.Checked)
            {
                MessageBox.Show("Please select the exact shape to compute.");
                return;
            }

            Rectangle rec = new Rectangle();
            rec.Name = "Rectangle";
            rec.NoSide = 4;
            rec.Color = "Blue";
            rec.Length = double.Parse(txtLength.Text);
            rec.Width = double.Parse(txtWidth.Text);

            lblName.Text = "Name: " + rec.Name;
            lblColor.Text = "Color: " + rec.Color;
            lblNoSide.Text = "No. of Sides: " + rec.NoSide;

            // selected computation
            lblArea.Text = chkArea.Checked ? "Area: " + rec.computeArea().ToString() : "";
            lblPerimeter.Text = chkPerimeter.Checked ? "Perimeter: " + rec.computePerimeter().ToString() : "";
        }
        
        //for tri
        private void btnComputeTriangle_Click(object sender, EventArgs e)
        {
            if (!chkArea.Checked && !chkPerimeter.Checked)
            {
                MessageBox.Show("Please select what to compute.");
                return;
            }

            if (!rdoTriangle.Checked)
            {
                MessageBox.Show("Please select the exact shape to compute.");
                return;
            }

            Triangle tri = new Triangle();
            tri.Name = "Triangle";
            tri.NoSide = 3;
            tri.Color = "Blue";
            tri.Base1 = double.Parse(txtBase.Text);
            tri.Height = double.Parse(txtHeight.Text);

            lblName.Text = "Name: " + tri.Name;
            lblColor.Text = "Color: " + tri.Color;
            lblNoSide.Text = "No. of Sides: " + tri.NoSide;

            // selected computation
            lblArea.Text = chkArea.Checked ? "Area: " + tri.computeArea().ToString() : "";
            lblPerimeter.Text = chkPerimeter.Checked ? "Perimeter: " + tri.computePerimeter().ToString() : "";
        }

        //for circle
        private void btnComputeCircle_Click(object sender, EventArgs e)
        {
            if (!chkArea.Checked && !chkPerimeter.Checked)
            {
                MessageBox.Show("Please select what to compute.");
                return;
            }

            if (!rdoCircle.Checked)
            {
                MessageBox.Show("Please select the exact shape to compute.");
                return;
            }

            Circle circ = new Circle();
            circ.Name = "Circle";
            circ.NoSide = 0;
            circ.Color = "Blue";
            circ.Radius = double.Parse(txtRadius.Text);

            lblName.Text = "Name: " + circ.Name;
            lblColor.Text = "Color: " + circ.Color;
            lblNoSide.Text = "No. of Sides: " + circ.NoSide;

            // selected computation
            lblArea.Text = chkArea.Checked ? "Area: " + circ.computeArea().ToString() : "";
            lblPerimeter.Text = chkPerimeter.Checked ? "Perimeter: " + circ.computePerimeter().ToString() : "";
        }
    }
}
