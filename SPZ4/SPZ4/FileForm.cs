using System;
using System.Windows.Forms;

namespace SPZ4
{
    public partial class FileForm : Form
    {
        string fileName=null;
        bool able = false;
        public FileForm()
        {
            InitializeComponent();
            comboBox.Items.Add("Рассчитать количество элементов группы");
            comboBox.Items.Add("Рассчитать количество каждого элемента");
        }
        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            if (able)
            {
                for (int i = 0; i < FileContent.Text.Length; i++)
                {
                    if (FileContent.Text[i] != ',' && FileContent.Text[i] != ' ' && FileContent.Text[i] != '.' && Char.IsDigit(FileContent.Text[i]) != true)
                    {
                        MessageBox.Show("Ошибка ввода!");
                        FileContent.Text = "";
                        return;
                    }
                    if ((FileContent.Text[i] == ',' && FileContent.Text[i + 1] != ' ') ||
                        (i != 0 && FileContent.Text[i] == ' ' && FileContent.Text[i - 1] != ',') || (Char.IsDigit(FileContent.Text[0]) != true))
                    {
                        MessageBox.Show("Ошибка ввода!");
                        FileContent.Text = "";
                        return;
                    }
                }
                FileOperations.writeFile(FileContent.Text, fileName);
                MessageBox.Show("Данные записаны в файл!");
                FileContent.Text = "";
                able = false;
            }
            else
                MessageBox.Show("Невозможно записать в файл, так как он не создан!");
        }
        private void ReadFromFile_Click(object sender, EventArgs e)
        {
            if(fileName == null)
                MessageBox.Show("Невозможно прочитать файл, так как он не создан!");
            else
            FromFile.Text = FileOperations.openFile(fileName);
        }
        private void Count_Click(object sender, EventArgs e)
        {
                if (comboBox.SelectedIndex == 0)
                {
                    CountOfIntegers.Text = FileOperations.writeResult(FileOperations.CountOfGroupElements(FileOperations.GetFromFileIntoMassive(fileName)), fileName);
                    MessageBox.Show("Данные записаны в файл!");
                }
                else if (comboBox.SelectedIndex == 1)
                {
                    CountOfIntegers.Text = FileOperations.writeResult(FileOperations.CountOfElements(FileOperations.GetFromFileIntoMassive(fileName)), fileName);
                    MessageBox.Show("Данные записаны в файл!");
                }
                else
                    MessageBox.Show("Выберите пункт!");
        }
        private void CreateFile_Click(object sender, EventArgs e)
        {
            fileName = FileOperations.SaveFile();
            able = true;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            FileContent.Text = null;
            var r = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                    FileContent.Text += r.Next(1, 200).ToString() + '.';
                else
                    FileContent.Text += r.Next(1, 200).ToString() + ", ";
            }
        }
    }
}
