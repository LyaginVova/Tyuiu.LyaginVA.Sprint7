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
using Tyuiu.LyaginVA.Sprint7.Project.V4.Lib;

namespace Tyuiu.LyaginVA.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void buttonInfo_LVA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonSaveData_LVA_Click(object sender, EventArgs e)
        {
            
            saveFileDialogData_LVA.FileName = "OutPutFileProject.csv";
            saveFileDialogData_LVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogData_LVA.ShowDialog();

            string path = saveFileDialogData_LVA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_LVA.RowCount;
            int columns = dataGridViewData_LVA.ColumnCount;
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewData_LVA.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewData_LVA.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewData_LVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewData_LVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                
            }
        }

        private void buttonOpenData_LVA_Click(object sender, EventArgs e)
        {
            openFileDialogData_LVA.ShowDialog();
            openFilePath = openFileDialogData_LVA.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_LVA.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_LVA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_LVA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 5] == "True")
                    dataGridViewData_LVA.Rows[i].Cells[5].Value = true;
                else
                    dataGridViewData_LVA.Rows[i].Cells[5].Value = false;
            }
        }

        private void buttonAddBook_LVA_Click(object sender, EventArgs e)
        {
            dataGridViewData_LVA.Rows.Add();
            for (int i = 0; i < dataGridViewData_LVA.Rows.Count; i++)
            {
                dataGridViewData_LVA.Rows[i].Cells[0].Value = i;
            }
        }

        private void ToolStripAboutProgram_LVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа является читательской базой данных пользователя, куда он может добавить книги, которые хочет прочитать, и отмечать уже прочитанные.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripExit_LVA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_LVA_Click(object sender, EventArgs e)
        {
            openFileDialogData_LVA.ShowDialog();
            openFilePath = openFileDialogData_LVA.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewData_LVA.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewData_LVA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewData_LVA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 4] == "True")
                    dataGridViewData_LVA.Rows[i].Cells[4].Value = true;
                else
                    dataGridViewData_LVA.Rows[i].Cells[4].Value = false;
            }

        }

        private void saveToolStripMenuItem_LVA_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.Default;
            saveFileDialogData_LVA.FileName = "OutPutFileTask7.csv";
            saveFileDialogData_LVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogData_LVA.ShowDialog();

            string path = saveFileDialogData_LVA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewData_LVA.RowCount;
            int columns = dataGridViewData_LVA.ColumnCount;
            string header = "";
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    header += dataGridViewData_LVA.Columns[j].HeaderText + ";";
                }
                else
                {
                    header += dataGridViewData_LVA.Columns[j].HeaderText;
                }
            }
            File.AppendAllText(path, header + Environment.NewLine);


            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {

                    if (j != columns - 1)
                    {
                        str += dataGridViewData_LVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewData_LVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
            }

        }

        private void addToolStripMenuItem_LVA_Click(object sender, EventArgs e)
        {
            dataGridViewData_LVA.Rows.Add();
            for (int i = 0; i < dataGridViewData_LVA.Rows.Count; i++)
            {
                dataGridViewData_LVA.Rows[i].Cells[0].Value = i;
            }

        }

        private void infoToolStripMenuItem_LVA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();

        }

        
        private void dataGridViewData_LVA_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewData_LVA.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewData_LVA.Rows[index].HeaderCell.Value = indexStr;
        }

    }
}
