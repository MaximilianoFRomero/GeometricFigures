using GeometricFigures.Controllers;
using GeometricFigures.Model;
using Microsoft.VisualBasic;
using System.Drawing.Text;

namespace GeometricFigures
{
    public partial class Form1 : Form
    {
        private FigureController figureController;
        public Form1()
        {
            InitializeComponent();
            figureController = new FigureController();
            InitScreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (GetCmbIndex())
            {
                case 0:
                    figureController.NewFigure(new Circle(double.Parse(textBox1.Text)));
                    label11.Text = ShowArea().ToString();
                    label12.Text = ShowPerimeter().ToString();
                    break;
                case 1:
                    figureController.NewFigure(new Square(double.Parse(textBox3.Text)));
                    label11.Text = ShowArea().ToString();
                    label12.Text = ShowPerimeter().ToString();
                    break;
                case 2:
                    figureController.NewFigure(new Triangle(double.Parse(textBox3.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text)));
                    label11.Text = ShowArea().ToString();
                    label12.Text = ShowPerimeter().ToString();
                    break;
                case 3:
                    figureController.NewFigure(new RegPoligon(double.Parse(textBox6.Text), Int32.Parse(textBox2.Text)));
                    label11.Text = ShowArea().ToString();
                    label12.Text = ShowPerimeter().ToString();
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GetCmbIndex())
            {
                case 0:
                    CircleSelected();
                    break;
                case 1:
                    SquareSelected();
                    break;
                case 2:
                    TriangleSelected();
                    break;
                case 3:
                    RegPoligonSelected();
                    break;
            }
        }
        private int GetCmbIndex()
        {
            int index = comboBox1.SelectedIndex;
            return index;
        }
        private void CircleSelected()
        {
            textBox1.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Resources/circle.jpeg");
        }
        private void SquareSelected()
        {
            textBox1.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Resources/cuadrado.jpg");
        }

        private void TriangleSelected()
        {
            textBox1.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("../../Resources/triangle.jpg");
        }

        private void RegPoligonSelected() 
        {
            InitScreen();
            textBox2.Enabled = true;
            textBox6.Enabled = true;
            pictureBox1.Visible = false;
        }
        private void InitScreen()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled= false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
        }
        public double ShowArea()
        {
            double area = figureController.ListFigure().Last().CalculateArea();
            return area;
        }
        public double ShowPerimeter()
        {
            double perimeter = figureController.ListFigure().Last().CalculatePerimeter();
            return perimeter;
        }
    }
}
