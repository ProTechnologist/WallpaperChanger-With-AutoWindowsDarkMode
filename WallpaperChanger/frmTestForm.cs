using Newtonsoft.Json;

namespace WallpaperChanger
{
    public partial class frmTestForm : Form
    {
        private DarkModeCS DM = null;

        public frmTestForm()
        {
            InitializeComponent();
            DM = new DarkModeCS(this);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //sample query
            //https://wallhaven.cc/api/v1/search?q=cars&sorting=views&categories=001&purity=010&ratios=16x9
            //https://wallhaven.cc/api/v1/search?sorting=random&categories=100&purity=010&ratios=16x9

            flowLayoutPanel1.Controls.Clear();

            HttpClient Client = new HttpClient();
            HttpResponseMessage response = await Client.GetAsync(textBox1.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WallhavenResponse list = JsonConvert.DeserializeObject<WallhavenResponse>(json);

                foreach (WallpaperData wallpaper in list.data)
                {
                    string url = wallpaper.thumbs.large;
                    string temp = string.Empty;

                    PictureBox picture_box = new PictureBox();
                    picture_box.ImageLocation = url;
                    picture_box.Width = 300;
                    picture_box.Height = 300;
                    picture_box.SizeMode = PictureBoxSizeMode.AutoSize;

                    flowLayoutPanel1.Controls.Add(picture_box);

                }
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
