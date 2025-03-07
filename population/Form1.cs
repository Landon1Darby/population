namespace population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<int> popList = new List<int>();
        List<int> changeList = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize population list
            string line;
            StreamReader streamReader = new StreamReader("USPopulation.txt");
            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                popList.Add(int.Parse(line) * 1000);
            }
            streamReader.Close();

            // Initialize change list
            for (int i = 1; i < popList.Count; i++)
                changeList.Add(popList[i] - popList[i - 1]);


            averageLabel.Text = Average().ToString("n");
            increaseLabel.Text = MaxChange().ToString();
            decreaseLabel.Text = MinChange().ToString();

        }

        private int Average()
        {
            int total = 0;
            foreach (int i in changeList)
            {
                total += i;
            }
            return total / changeList.Count;
        }

        private int MaxChange()
        {
            int largest = 0;
            for (int i = 0; i < changeList.Count; i++)
                if (changeList[i] > largest) largest = i;

            return 1950 + largest;
        }

        private int MinChange()
        {
            int min = int.MaxValue;
            for (int i = 0; i < changeList.Count; i++)
                if (changeList[i] < min) min = i;

            return 1950 + min;
        }

    }
}
