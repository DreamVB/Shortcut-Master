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
        private string StartLocOne = string.Empty;
        private string StartLocTwo = string.Empty;
        private int lb_index = (-1);

        public frmmain()
        {
            InitializeComponent();
        }

        private string GetPathFromShortCut(string link)
        {
            IWshRuntimeLibrary.IWshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(link);
            return shortcut.TargetPath;
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
                //Display the numbers found in list
                UpdateStatus(_Files);
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
        }

        private void RefreshLists()
        {
            StartLocOne = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
            @"\Microsoft\Windows\Start Menu\Programs\";

            lstResults.Items.Clear();

            QueryResult = new List<TFileDesc>();
            //Create list object
            _Files = new List<TFileDesc>();

            StartLocTwo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Microsoft\Windows\Start Menu\Programs\";

            //Get a list of all short cuts
            AddItemsToLists(StartLocOne);
            AddItemsToLists(StartLocTwo);
            UpdateStatus(_Files);
        }

        private void AddItemsToLists(string Loccation)
        {
            string[] Items = Directory.GetFiles(Loccation, "*.lnk", SearchOption.AllDirectories);

            TFileDesc f_info;
            int s_pos;
            
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
            RefreshLists();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Files.Count.Equals(0))
                {
                    return;
                }
            }
            catch
            {
                return;
            }

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(0, 122, 204), 1);

            Graphics g = panel3.CreateGraphics();

            g.DrawRectangle(p, 0, 0, panel3.Width - 1, panel3.Height - 1);
            g.Dispose();

        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            panel3.Invalidate();
            panel3.Update();
        }

        private void butMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                mnuMenu.Show(ptLowerLeft);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Display about box.
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Files.Clear();
            lstResults.Items.Clear();
        }

        private void ImgOpenFolder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lb_index.Equals(-1))
                {
                    return;
                }
                else
                {
                    FileInfo fi = new FileInfo(QueryResult[lb_index].FilePath);
                    string lzDir = new FileInfo(GetPathFromShortCut(fi.FullName)).Directory.ToString();
                    ExecApp(lzDir);
                }
            }
        }

        private void ImgRunApp_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lb_index.Equals(-1))
                {
                    return;
                }
                else
                {
                    FileInfo fi = new FileInfo(QueryResult[lb_index].FilePath);
                    ExecApp(fi.FullName);
                }
            }
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            RefreshLists();
            txtFind_TextChanged(sender, e);

            if (lb_index != -1)
            {
                //Select the list item
                lstResults.SelectedIndex = lb_index;
            }
        }

        private void mnuVInfo_Click(object sender, EventArgs e)
        {
            ExecApp("version.txt");
        }
    }
}
