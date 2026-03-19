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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算平均分數，接受一個整數陣列並返回該陣列中所有數值的平均值。
        private double Average(int[] sArray)
        {
            int total = 0;
            for (int i = 0; i < sArray.Length; i++)
            {
                total += sArray[i];
            }
            return (double)total / sArray.Length;
        }

        // 計算最高分數，接受一個整數陣列並返回該陣列中的最大值。
        private int Highest(int[] sArray)
        {
            int highScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i];
                }
            }
            return highScore;
        }

        // 計算最低分數，接受一個整數陣列並返回該陣列中的最小值。
        private int Lowest(int[] sArray)
        {
            int lowScore = sArray[0];
            for (int i = 1; i < sArray.Length; i++)
            {
                if (sArray[i] < lowScore)
                {
                    lowScore = sArray[i];
                }
            }
            return lowScore;
        }

        private int GetFileScoreCount()
        {
            int count = 0;
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream)
                {
                    inputFile.ReadLine();
                    count++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }


        private void getScoresButton_Click(object sender, EventArgs e)
        {
            int SIZE = GetFileScoreCount();
            int[] scores = new int[GetFileScoreCount()];
            StreamReader inputFile;
            int index = 0;

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                foreach (int val in scores)
                {
                    testScoresListBox.Items.Add(val);
                }

                // 計算並顯示最高分、最低分、平均分
            
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }

            double averageScore = Average(scores);
            averageScoreLabel.Text = Average(scores).ToString("n1");
            highScoreLabel.Text = Highest(scores).ToString();
            lowScoreLabel.Text = Lowest(scores).ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗。
            this.Close();
        }
    }
}
