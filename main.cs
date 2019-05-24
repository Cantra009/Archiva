using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archive
{
    public partial class main : Form
    {
        private int childFormNumber = 0;

        public main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
     

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            AddNew AddNew = new AddNew();
            AddNew.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditFile EditFile = new EditFile();
            EditFile.Show();

        }

        private void repotyViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports Reports  = new Reports();
            Reports.Show();
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }

        private void districtDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
        }

        private void d26JuneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scanFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanFiles scan = new ScanFiles();
            scan.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void districtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Districts district = new Districts();
            district.Show();
        }

        private void viewFileFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAddFile F = new ViewAddFile();
            F.Show();
        }
    }
}
