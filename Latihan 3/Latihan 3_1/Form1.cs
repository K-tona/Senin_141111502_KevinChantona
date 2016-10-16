using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        private string clipboard;
        public Form1()
        {
            InitializeComponent();
            clipboard = "";
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += string.Format("{0}", DateTime.Now);
            richTextBox1.Select(richTextBox1.Text.Length, 0); // Select(Selection Start, how long the Selection);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(0, richTextBox1.Text.Length);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboard = richTextBox1.SelectedText.ToString(); //save in clipboard
            richTextBox1.SelectedText = ""; //clearing
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboard = richTextBox1.SelectedText.ToString();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = clipboard;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "")
            {
                MessageBox.Show("Anda tidak melakukan seleksi terhadap Text. Jika anda melakukan \"OK\" pada Fontdialog, seluruh font akan berubah.");
            }
            DialogResult hasil = fontDialog1.ShowDialog();
            if (hasil == DialogResult.OK && richTextBox1.SelectedText == "")
            {
                Font font = fontDialog1.Font;
                richTextBox1.Font = font;
            }
            else if (hasil == DialogResult.OK && richTextBox1.SelectedText != "")
            {
                Font font = fontDialog1.Font;
                richTextBox1.SelectionFont = font;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == false) { richTextBox1.WordWrap = true; wordWrapToolStripMenuItem.Checked = true; }
            else { richTextBox1.WordWrap = false; wordWrapToolStripMenuItem.Checked = false; }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Ln {0}, Col {1}", richTextBox1.SelectionStart, richTextBox1.Lines.Count());
            statusStrip1.Refresh();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible == false) { statusStrip1.Visible = true; statusBarToolStripMenuItem.Checked = true; }
            else { statusStrip1.Visible = false; statusBarToolStripMenuItem.Checked = false; }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "")
            {
                MessageBox.Show("Anda tidak melakukan seleksi terhadap Text. Jika anda melakukan \"OK\" pada Fontdialog, seluruh font akan berubah.");
            }
            if (bToolStripMenuItem.BackColor != Color.LightGray)
            {
                if (richTextBox1.SelectedText == "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Bold);
                    richTextBox1.Font = font;
                    bToolStripMenuItem.BackColor = Color.LightGray;
                }
                else if (richTextBox1.SelectedText != "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Bold);
                    richTextBox1.SelectionFont = font;
                    bToolStripMenuItem.BackColor = Color.LightGray;
                }
            }
            else if (bToolStripMenuItem.BackColor == Color.LightGray)
            {
                if (richTextBox1.SelectedText == "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Regular);
                    richTextBox1.Font = font;
                    bToolStripMenuItem.BackColor = Color.White;
                }
                else if (richTextBox1.SelectedText != "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Regular);
                    richTextBox1.SelectionFont = font;
                    bToolStripMenuItem.BackColor = Color.White;
                }
            }
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "")
            {
                MessageBox.Show("Anda tidak melakukan seleksi terhadap Text. Jika anda melakukan \"OK\" pada Fontdialog, seluruh font akan berubah.");
            }
            if (iToolStripMenuItem.BackColor != Color.LightGray)
            {
                if (richTextBox1.SelectedText == "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Italic);
                    richTextBox1.Font = font;
                    iToolStripMenuItem.BackColor = Color.LightGray;
                }
                else if (richTextBox1.SelectedText != "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Italic);
                    richTextBox1.SelectionFont = font;
                    iToolStripMenuItem.BackColor = Color.LightGray;
                }
            }
            else if (iToolStripMenuItem.BackColor == Color.LightGray)
            {
                if (richTextBox1.SelectedText == "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Regular);
                    richTextBox1.Font = font;
                    iToolStripMenuItem.BackColor = Color.White;
                }
                else if (richTextBox1.SelectedText != "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Regular);
                    richTextBox1.SelectionFont = font;
                    iToolStripMenuItem.BackColor = Color.White;
                }
            }
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "")
            {
                MessageBox.Show("Anda tidak melakukan seleksi terhadap Text. Jika anda melakukan \"OK\" pada Fontdialog, seluruh font akan berubah.");
            }
            if (uToolStripMenuItem.BackColor != Color.LightGray)
            {
                if (richTextBox1.SelectedText == "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Underline);
                    richTextBox1.Font = font;
                    uToolStripMenuItem.BackColor = Color.LightGray;
                }
                else if (richTextBox1.SelectedText != "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Underline);
                    richTextBox1.SelectionFont = font;
                    uToolStripMenuItem.BackColor = Color.LightGray;
                }
            }
            else if (uToolStripMenuItem.BackColor == Color.LightGray)
            {
                if (richTextBox1.SelectedText == "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Regular);
                    richTextBox1.Font = font;
                    uToolStripMenuItem.BackColor = Color.White;
                }
                else if (richTextBox1.SelectedText != "")
                {
                    Font font = new Font(richTextBox1.Font, FontStyle.Regular);
                    richTextBox1.SelectionFont = font;
                    uToolStripMenuItem.BackColor = Color.White;
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "")
            {
                MessageBox.Show("Anda tidak melakukan seleksi terhadap Text. Jika anda melakukan \"OK\" pada Fontdialog, seluruh font akan berubah.");
            }
            DialogResult hasil = colorDialog1.ShowDialog();
            if (hasil == DialogResult.OK && richTextBox1.SelectedText == "")
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
            else if (hasil == DialogResult.OK && richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectedText == "")
                {
                    MessageBox.Show("Anda tidak melakukan seleksi terhadap Text. Jika anda melakukan \"OK\" pada Fontdialog, seluruh font akan berubah.");
                }
                if (richTextBox1.SelectedText == "")
                {
                    richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(domainUpDown1.Text));
                }
                else if (richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(domainUpDown1.Text));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout = new About();
            formAbout.Show();
        }
    }
}
