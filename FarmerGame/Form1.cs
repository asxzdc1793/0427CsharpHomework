namespace FarmerGame
{
    public partial class Form1 : Form
    {
        private List<string> _List1;
        private List<string> _List2;
        private List<string> _List3;
        private Stack<(List<string>, List<string>, int)> _history
            = new Stack<(List<string>, List<string>, int)>();
        public Form1()
        {
            InitializeComponent();
            Createlist();
            ChangeData();

        }

        private void Createlist()
        {

            _List1 = new List<string>
            {
                "農夫","羊","狼","蔬菜"
            };
            _List2 = new List<string>();
        }

        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _List1;
            listBox2.DataSource = _List2;
        }
        private bool IsGameOver()
        {
            bool wolf_sheep_List1 = _List1.Contains("狼") && _List1.Contains("羊") && !_List1.Contains("農夫");
            bool sheep_vagetable_List1 = _List1.Contains("羊") && _List1.Contains("蔬菜") && !_List1.Contains("農夫");
            bool wolf_sheep_List2 = _List2.Contains("狼") && _List2.Contains("羊") && !_List2.Contains("農夫");
            bool sheep_vagetable_List2 = _List2.Contains("羊") && _List2.Contains("蔬菜") && !_List2.Contains("農夫");
            return wolf_sheep_List1 || sheep_vagetable_List1 || wolf_sheep_List2 || sheep_vagetable_List2;
        }

        private bool IsGameWin()
        {
            bool win_List2 = _List2.Contains("狼") && _List2.Contains("羊") && _List2.Contains("蔬菜") && _List2.Contains("農夫");
            return win_List2;
        }


        //左到右
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var item = (string)listBox1.SelectedItem;
                var recordCount = (item == "農夫") ? 1 : 2;
                _history.Push((new List<string>(_List1), new List<string>(_List2), recordCount));
                _List1.Remove(item);
                _List2.Add(item);
                listBox3.Items.Add(item + "移動到了右岸");
                // 農夫跟著過河
                if (_List1.Contains("農夫") && item != "農夫")
                {
                    _List1.Remove("農夫");
                    _List2.Add("農夫");
                    listBox3.Items.Add("農夫移動到了右岸");
                }
                ChangeData();
                if (IsGameOver())
                {
                    MessageBox.Show("Game Over!");
                    Close();
                }
                if (IsGameWin())
                {
                    MessageBox.Show("Game Win!");
                    Close();
                }
            }
        }

        //右到左
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var item = (string)listBox2.SelectedItem;
                var recordCount = (item == "農夫") ? 1 : 2;
                _history.Push((new List<string>(_List1), new List<string>(_List2), recordCount));
                _List2.Remove(item);
                _List1.Add(item);
                listBox3.Items.Add(item + "移動到了左岸");
                // 農夫跟著過河
                if (_List2.Contains("農夫") && item != "農夫")
                {
                    _List2.Remove("農夫");
                    _List1.Add("農夫");
                    listBox3.Items.Add("農夫移動到了左岸");
                }
                ChangeData();
                if (IsGameOver())
                {
                    MessageBox.Show("Game Over!");
                    Close();
                }
                if (IsGameWin())
                {
                    MessageBox.Show("Game Win!");
                    Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Createlist();
            ChangeData();
            listBox3.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_history.Count > 0)
            {
                var previous = _history.Pop();
                _List1 = previous.Item1;
                _List2 = previous.Item2;
                for (int i = 0; i < previous.Item3; i++)
                {
                    listBox3.Items.RemoveAt(listBox3.Items.Count - 1);
                }
                ChangeData();
            }
        }
    }
}
