using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace Latihan_3_1
{
    public partial class Setting : Form
    {
        Form1 form1;
        public Setting(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void setcbColor()
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbColor.Items.Add(c.Name);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            setcbColor();
            cbColor.SelectedItem = cbColor.Items[137];
        }

        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string color = this.cbColor.SelectedItem.ToString();
            form1.form1_RichTextBox = Color.FromName(color);
            Close();
        }
    }
}
