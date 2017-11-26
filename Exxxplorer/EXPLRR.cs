using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Exxxplorer
{
    public partial class Explrr : Form
    {
        public Explrr()
        {
            InitializeComponent();
        }
        Stack<string> DiscsStack = new Stack<string>();
        private void Explrr_Load(object sender, EventArgs e)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivers)
                Discsinfo.Rows.Add(drive);
            Discsinfo.ClearSelection();
            Discsinfo.SelectionChanged += new System.EventHandler(this.DiscsInfo_SelChan);
        }
        private void RefreshInfo(string Directry)
        {
            if (DiscsStack.Count <= 1) goBack.Enabled = false;
            else goBack.Enabled = true;
            try { Directory.SetCurrentDirectory(Directry); }
            catch
            {
                Looking_for_what.Text = DiscsStack.Pop();
                MessageBox.Show("N/A");
                return;
            }
            DirInfo.Rows.Clear();
            var directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
            DirectoryInfo dir;
       
            for( int i = 0; i< directories.Length; i++)
            {
                int n = DirInfo.Rows.Add();
                DirInfo.Rows[n].Cells[0].Value = NameFileOrDir(directories[i]);
                DirInfo.Rows[n].Cells[1].Value = "Папка с файлами";
                dir = new DirectoryInfo(directories[i]);
                try { DirInfo.Rows[n].Cells[2].Value = DirSize(dir); }
                catch { DirInfo.Rows[n].Cells[2].Value = "N/A"; continue; }
                DirInfo.Rows[n].Cells[2].Value = Math.Round(double.Parse(DirInfo.Rows[n].Cells[2].Value.ToString()) / 1048576, 2);
                DirInfo.Rows[n].Cells[2].Value += " мб";
            }
            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
         
            for (int i = 0; i < files.Length; i++) 
            {
                int n = DirInfo.Rows.Add();
                FileInfo file = new FileInfo(NameFileOrDir(files[i]));
                DirInfo.Rows[n].Cells[0].Value = file.Name;
                DirInfo.Rows[n].Cells[1].Value = typename(file.Extension);
                DirInfo.Rows[n].Cells[2].Value = Math.Round((double)file.Length / 1048576, 2);
            }
        }
        private void DiscsInfo_SelChan(object sender, EventArgs e)
        {
            DiscsStack.Clear();
            DiscsStack.Push(Discsinfo.CurrentRow.Cells[0].Value.ToString());
            Looking_for_what.Text = Discsinfo.CurrentRow.Cells[0].Value.ToString();
            RefreshInfo(Looking_for_what.Text);
        }
        public long DirSize(DirectoryInfo dir)
        {
            try
            {
                long Size = 0;
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo fi in files)
                {
                    Size += fi.Length;
                }
                DirectoryInfo[] dis = dir.GetDirectories();
                foreach (DirectoryInfo dInf in dis)
                {
                    Size += DirSize(dInf);
                }
                return Size;
            }
            catch { throw new Exception(); }
        }
        private static string NameFileOrDir(string str)
        {
            string result = null;
            int i = str.Length - 1;
            while (str[i--] != (char)92) ;
            i += 2;
            for (int q = i; q < str.Length; q++)
                result += str[q];
            return result;
        }
        private string typename(string str)
        {
            switch (str)
            {
                case ".docx":
                    return "Документ Microsoft Word";
                case ".txt":
                    return "Текстовый документ";
                case ".png":
                case ".jpg":
                case ".ico":
                case ".gif":
                case ".tif":
                    return "Картиночка";
                default:
                    return "Extension";
            }
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            Looking_for_what.Text = DiscsStack.Pop();
            RefreshInfo(Looking_for_what.Text);
        }

        private void Dir_Info_2Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DirInfo.CurrentRow.Cells[1].Value.ToString() != "Папка с файлами")
            {
                System.Diagnostics.Process.Start(Looking_for_what.Text + DirInfo.CurrentRow.Cells[0].Value.ToString());
                return;
            }
            DiscsStack.Push(Looking_for_what.Text);
            Looking_for_what.Text += DirInfo.CurrentRow.Cells[0].Value.ToString() + ((char)92).ToString();
            RefreshInfo(Looking_for_what.Text);
        }

        private void Looking_for_what_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.PrintScreen != e.KeyCode) return;
            if (!Directory.Exists(Looking_for_what.Text))
            {
                MessageBox.Show("Твоё путь - ложь");
                return;
            }
            RefreshInfo(Looking_for_what.Text);
        }

        private void EXTNSION_SEARCH_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.PrintScreen != e.KeyCode || DirInfo.RowCount == 0) return;
            for(int i = 0; i < DirInfo.RowCount; i++)
            {
                FileInfo file = new FileInfo(NameFileOrDir(Looking_for_what.Text + DirInfo.Rows[i].Cells[0].Value.ToString()));
                if (file.Extension != type_search.Text) DirInfo.Rows[i].Visible = false;
            }
        }
    }
}