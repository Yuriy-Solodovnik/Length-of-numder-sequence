using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SPZ4
{
    public static class FileOperations
    {
        public static string SaveFile()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
            return saveFileDialog1.FileName;
        }
        public static string openFile(string Name)
        {
            StreamReader re = new StreamReader(Name);
            return re.ReadToEnd();
        }
        public static void writeFile(string fm, string Name)
        {
            StreamWriter wr = new StreamWriter(Name);
            wr.Write(fm);
            wr.Close();
        }
        public static string writeResult(string fm, string Name)
        {
            Name = Name.Replace(".txt", ".out");
            StreamWriter wr = new StreamWriter(Name);
            wr.Write(fm);
            wr.Close();
            return fm;
        }
        public static int[] GetFromFileIntoMassive(string Name)
        {
            int count = 0, k = 0;
            string temp = openFile(Name);
            for (int i = 0; i < temp.Length; i++)
            {
                if (Char.IsDigit(temp[i]) == true)
                {
                    count++;
                }
            }
            string[] mass = new string[count];
            for (int i = 0; i < temp.Length; i++)
            {
                if (Char.IsDigit(temp[i]) == true)
                {
                    mass[k] += temp[i];
                }
                else if (temp[i] == ',')
                    k++;
            }
            count = 0;
            for (int i = 0; i < mass.Length; i++)
                if (mass[i] != null)
                    count++;
            int[] integers = new int[count];
            for (int i = 0; i < count; i++)
            {
                integers[i] = Int32.Parse(mass[i]);
            }
            return integers;
        }
        public static string CountOfElements(int [] integers)
        {
            var intlist = new List<int>();
            for (int i = 0; i < integers.Length; i++)
                if (intlist.Contains(integers[i]) == false)
                    intlist.Add(integers[i]);
            int[] result = new int[intlist.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }
            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (intlist[j] == integers[i])
                    {
                        result[j] += 1;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (i == result.Length - 1)
                    res += result[i].ToString() + '.';
                else
                    res += result[i].ToString() + ", ";
            }
            return res;
        }
        public static string CountOfGroupElements(int[] integers)
        {
            string res = "";
            var col = new List<int>();
            int sum = 1;
            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] == integers[i - 1])
                {
                    sum++;
                }
                else
                {
                    col.Add(sum);
                    sum = 1;
                }
            }
            col.Add(sum);
            for (int i = 0; i < col.Count; i++)
            {
                if (i == col.Count - 1)
                    res += col[i].ToString() + '.';
                else
                    res += col[i].ToString() + ", ";
            }
            return res;
        }
    }
}
