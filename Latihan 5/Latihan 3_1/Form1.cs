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
    public partial class Form1 : Form
    {
        private string clipboard;
        private bool perubahan_text;
        public Form1()
        {
            InitializeComponent();
            setcbColor();
            setcbFont();
            setcbFontSize();
            setcbBgColor();
            comboBox1.SelectedItem = comboBox1.Items[8];
            comboBox2.SelectedItem = comboBox2.Items[2];
            comboBox3.SelectedItem = comboBox3.Items[4];
            comboBox4.SelectedItem = comboBox4.Items[137];
            clipboard = "";
            perubahan_text = false;
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

        public Color form1_RichTextBox
        {
            get { return this.richTextBox1.BackColor; }
            set { this.richTextBox1.BackColor = value; }
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
            perubahan_text = true;
            statusStrip1.Refresh();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible == false) { statusStrip1.Visible = true; statusBarToolStripMenuItem.Checked = true; }
            else { statusStrip1.Visible = false; statusBarToolStripMenuItem.Checked = false; }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perubahan_text)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    ActiveForm.Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                }
            }
            else
            {
                ActiveForm.Hide();
                Form1 newform = new Form1();
                newform.ShowDialog();
            }
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAbout = new About();
            formAbout.Show();
        }

        private void setcbFontSize()
        {
            int[] size = new int[16] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            for (int i = 0; i < 16; i++)
                comboBox3.Items.Add(size[i]);
        }

        private void setcbFont()
        {
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox2.Items.Add(font.Name.ToString());
            }
        }

        private void setcbBgColor()
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.comboBox4.Items.Add(c.Name);
            }
        }

        private void setcbColor()
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.comboBox1.Items.Add(c.Name);
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = this.comboBox1.SelectedItem.ToString();
            richTextBox1.SelectionColor = Color.FromName(color);
            richTextBox1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = this.comboBox2.SelectedItem.ToString();
            richTextBox1.SelectionFont = new Font(font, richTextBox1.SelectionFont.SizeInPoints);
            richTextBox1.Focus();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size;
            try
            {

                size = Int32.Parse(comboBox3.Text);
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size);

                richTextBox1.Focus();
            }
            catch
            {
                richTextBox1.Focus();
            }
        }

        private void comboBox4_DrawItem(object sender, DrawItemEventArgs e)
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = this.comboBox4.SelectedItem.ToString();
            richTextBox1.SelectionBackColor = Color.FromName(color);
            richTextBox1.Focus();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(this);
            setting.Show();
        }
    }
}
