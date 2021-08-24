using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Shortcut_Master
{
    public partial class frmmain : Form
    {

        private struct TFileDesc
        {
            public string FileTile;
            public string FilePath;
        }

        private List<TFileDesc> _Files = null;
        private List<TFileDesc> QueryResult = null;
        private string RootPath = string.Empty;
        private int lb_index = (-1);

        public frmmain()
        {
            InitializeComponent();
        }

        private void UpdateStatus(List<TFileDesc> l)
        {
            if (l.Count == 0)
            {
                sTip1.Text = "Nothing found";
            }
            else
            {
                sTip1.Text = "Found " + l.Count().ToString() + " items";
            }
        }

        private void OpenApp()
        {
            if (lb_index.Equals(-1)) { return; }

            try
            {
                //Execute the application
                ExecApp(QueryResult[lb_index].FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ExecApp(string Filename)
        {
            Process p = new Process();
            try
            {
                p.StartInfo.FileName = Filename;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FillAppsList(string sFind)
        {
            //Clear list box
            lstResults.Items.Clear();
            QueryResult = new List<TFileDesc>();

            if (sFind == string.Empty)
            {
                //Clear results
                QueryResult.Clear();
                //Clear list box items
                lstResults.Items.Clear();
            }
            else
            {
                foreach (TFileDesc fd in _Files)
                {
                    //Check if a item in the fd.FileTile matches sFind
                    if (fd.FileTile.IndexOf(sFind, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        //Add item to results list
                        QueryResult.Add(fd);
                    }
                }
            }
            //Clear list box
            lstResults.Items.Clear();
            //Fill list box with results
            foreach (TFileDesc fd in QueryResult)
            {
                //Add item to list box.
                lstResults.Items.Add(fd.FileTile);
            }
            UpdateStatus(QueryResult);
        }

        private void RefreshApps()
        {
            string[] Items = Directory.GetFiles(RootPath, "*.lnk", SearchOption.AllDirectories);

            TFileDesc f_info;
            int s_pos;

            _Files = new List<TFileDesc>();
            
            foreach (string f in Items)
            {
                //Get file info
                FileInfo fi = new FileInfo(f);
                //Remove link from name
                //Get position of the dot in the filename
                s_pos = fi.Name.IndexOf('.');

                if (s_pos != -1)
                {
                    //Extract up to the files .ext
                    f_info.FileTile = fi.Name.Substring(0, s_pos);
                    //Set filename
                    f_info.FilePath = fi.FullName;
                    //Add to list object
                    _Files.Add(f_info);
                }
            }
            Array.Clear(Items, 0, Items.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RootPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                "\\Microsoft\\Windows\\Start Menu\\Programs\\";
            //Get a list of all short cuts
            RefreshApps();
            UpdateStatus(_Files);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            FillAppsList(txtFind.Text.Trim());
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_index = lstResults.SelectedIndex;
        }

        private void lstResults_DoubleClick(object sender, EventArgs e)
        {
            OpenApp();
        }

        private void lstResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                OpenApp();
            }
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }

        private void frmmain_Shown(object sender, EventArgs e)
        {
            txtFind.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstResults_DrawItem(object sender, DrawItemEventArgs e)
        {
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1)
            {
                /* If the item is selected set the background color to SystemColors.Highlight 
                 or else set the color to either WhiteSmoke or White depending if the item index is even or odd */
                Color color = isSelected ? Color.FromArgb(0,91,166) :
                    e.Index % 2 == 0 ? Color.WhiteSmoke : Color.White;

                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(color);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(lstResults.Items[e.Index].ToString(), e.Font, textBrush, 12, e.Bounds.Y, 
                    StringFormat.GenericTypographic);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }
    }
}
