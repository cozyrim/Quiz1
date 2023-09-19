using System.IO;
namespace quiz
{
    public partial class Form1 : Form
    {
        private string studentFileName1 = "student1.txt";
        private string studentFileName2 = "student2.txt";
        private string studentFileName3 = "student3.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 학생 1 정보 불러오기
            if (File.Exists(studentFileName1))
            {
                using (StreamReader reader = new StreamReader(studentFileName1))
                {
                    studentName1.Text = reader.ReadLine();
                    studentID1.Text = reader.ReadLine();
                    gender1.Text = reader.ReadLine();
                    string memo;
                    while ((memo = reader.ReadLine()) != null)
                    {
                        memo1.Text = memo;
                    }
                }
            }

            // 학생 2 정보 불러오기
            if (File.Exists(studentFileName2))
            {
                using (StreamReader reader = new StreamReader(studentFileName2))
                {
                    studentName2.Text = reader.ReadLine();
                    studentID2.Text = reader.ReadLine();
                    gender2.Text = reader.ReadLine();
                    string memo;
                    while ((memo = reader.ReadLine()) != null)
                    {
                        memo2.Text = memo;
                    }
                }
            }

            // 학생 3 정보 불러오기
            if (File.Exists(studentFileName3))
            {
                using (StreamReader reader = new StreamReader(studentFileName3))
                {
                    studentName3.Text = reader.ReadLine();
                    studentID3.Text = reader.ReadLine();
                    gender3.Text = reader.ReadLine();
                    string memo;
                    while ((memo = reader.ReadLine()) != null)
                    {
                        memo3.Text = memo;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 학생1 정보를 파일로 저장
            using (StreamWriter writer = new StreamWriter(studentFileName1))
            {
                writer.WriteLine(studentName1.Text);
                writer.WriteLine(studentID1.Text);
                writer.WriteLine(gender1.Text);

                    writer.WriteLine(memo1.Text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete(studentFileName1);
            studentName1.Clear();
            studentID1.Clear();
            gender1.SelectedIndex = -1;
            memo1.Clear();
            studentName1.Text = "학생정보 없음";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(studentFileName2))
            {
                writer.WriteLine(studentName2.Text);
                writer.WriteLine(studentID2.Text);
                writer.WriteLine(gender2.Text);
                writer.WriteLine(memo2.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.Delete(studentFileName1);
            studentName2.Clear();
            studentID2.Clear();
            gender2.SelectedIndex = -1;
            memo2.Clear();
            studentName2.Text = "학생정보 없음";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(studentFileName3))
            {
                writer.WriteLine(studentName3.Text);
                writer.WriteLine(studentID3.Text);
                writer.WriteLine(gender3.Text);
                writer.WriteLine(memo3.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete(studentFileName1);
            studentName3.Clear();
            studentID3.Clear();
            gender3.SelectedIndex = -1;
            memo3.Clear();
            studentName3.Text = "학생정보 없음";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}