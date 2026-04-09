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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 定義學生成績資料結構
        private class StudentScore
        {
            public string StudentId { get; set; }
            public int Score { get; set; }
        }

        // 成績列表，作為類別變數以便在多個方法間使用
        private List<StudentScore> scoresList = new List<StudentScore>();

        public Form1()
        {
            InitializeComponent();
        }

        // 從檔案讀取成績並添加至 List
        private void ReadScores(List<StudentScore> scoresList)
        {
            string filePath = "TestScores.txt";
            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                            {
                                scoresList.Add(new StudentScore { StudentId = parts[0], Score = score });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取成績時發生錯誤：" + ex.Message);
            }
        }

        // 在列表方塊中顯示所有成績
        private void DisplayScores(List<StudentScore> scoresList)
        {
            testScoresListBox.Items.Clear();
            foreach (StudentScore student in scoresList)
            {
                testScoresListBox.Items.Add(student.StudentId + ": " + student.Score);
            }
        }

        // 計算平均分數
        private double Average(List<StudentScore> scoresList)
        {
            if (scoresList.Count == 0)
                return 0;
            
            int total = 0;
            foreach (StudentScore student in scoresList)
            {
                total += student.Score;
            }
            return (double)total / scoresList.Count;
        }

        // 計算高於平均分數的數量
        private int AboveAverage(List<StudentScore> scoresList, double averageScore)
        {
            int count = 0;
            foreach (StudentScore student in scoresList)
            {
                if (student.Score > averageScore)
                {
                    count++;
                }
            }
            return count;
        }

        // 計算低於平均分數的數量
        private int BelowAverage(List<StudentScore> scoresList)
        {
            double averageScore = Average(scoresList);
            int count = 0;
            foreach (StudentScore student in scoresList)
            {
                if (student.Score < averageScore)
                {
                    count++;
                }
            }
            return count;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 用來保存平均分數
            int numAboveAverage;    // 高於平均分數的數量
            int numBelowAverage;    // 低於平均分數的數量

            // 清空舊的成績列表
            scoresList.Clear();

            // 從檔案讀取成績到 List 中
            ReadScores(scoresList);

            // 顯示成績
            DisplayScores(scoresList);

            // 顯示平均分數
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 顯示高於平均分數的數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 顯示低於平均分數的數量
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // 搜尋成績按鈕點擊事件
        private void searchScoreButton_Click(object sender, EventArgs e)
        {
            // 清空之前的搜尋結果
            searchResultLabel.Text = "";

            // 檢查輸入框是否為空
            if (string.IsNullOrWhiteSpace(searchScoreTextBox.Text))
            {
                searchResultLabel.Text = "請輸入要搜尋的成績或學號";
                return;
            }

            string searchInput = searchScoreTextBox.Text.Trim();
            bool found = false;

            // 先嘗試按分數搜尋（如果輸入為數字）
            if (int.TryParse(searchInput, out int targetScore))
            {
                for (int i = 0; i < scoresList.Count; i++)
                {
                    if (scoresList[i].Score == targetScore)
                    {
                        searchResultLabel.Text = $"分數 {targetScore} 的學號：{scoresList[i].StudentId}（位於第 {i + 1} 筆）";
                        found = true;
                        break;
                    }
                }
            }

            // 如果沒找到，按學號搜尋
            if (!found)
            {
                for (int i = 0; i < scoresList.Count; i++)
                {
                    if (scoresList[i].StudentId == searchInput)
                    {
                        searchResultLabel.Text = $"學號 {searchInput} 的分數：{scoresList[i].Score}（位於第 {i + 1} 筆）";
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                searchResultLabel.Text = "查無此成績或學號";
            }
        }

        private void searchScoreDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
