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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化Form1的建構函式
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「讀取成績」按鈕的點擊事件處理程序
        /// </summary>
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                char[] delim = {','};
                using (inputFile = new StreamReader("Grades.csv", System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        string[] fields = line.Split(delim);
                        if (fields.Length == 8)
                        {
                            string className = fields[0].Trim();
                            string studentId = fields[1].Trim();
                            string studentName = fields[2].Trim();
                            
                            int total = 0;
                            bool validScores = true;

                            for (int i = 3; i < 8; i++)
                            {
                                total += int.Parse(fields[i].Trim());
                            }
                            double average = (double)total / 5;
                            averagesListBox.Items.Add($"{className} {studentId} {studentName} {average.ToString("F2")}");
                        }  
                        else
                        {
                            MessageBox.Show("資料格式錯誤: " + line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取csv檔案時發生錯誤: " + ex.Message);
            }
        }

        /// <summary>
        /// 「離開」按鈕的點擊事件處理程序
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void averagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
