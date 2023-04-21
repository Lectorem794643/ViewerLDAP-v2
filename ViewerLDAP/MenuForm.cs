using System;
using System.Windows.Forms;
using System.DirectoryServices;

namespace ViewerLDAP
{
    public partial class MenuForm : Form
    {
        public MenuForm() {
            InitializeComponent();
        }

        // При загрузке начальной формы происходит проверка пользователя,
        // Пользователь имеет доступ к записям из AD если его аккаунт есть в самом AD
        private void FormMenu_Load(object sender, EventArgs e)
        {
            //string CurrentUserName = Environment.UserName;
            //DirectoryEntry direcroryEntry = new DirectoryEntry(""); // Ваш адрес
            //string filter = $"(&(&(objectClass=user)(objectClass=person))(samAccountName={CurrentUserName}))";

            //DirectorySearcher searcher = new DirectorySearcher(direcroryEntry) {
            //    PageSize = int.MaxValue,
            //    Filter = filter
            //};
            //SearchResultCollection resultCollection = searcher.FindAll();

            //if (resultCollection.Count > 0) {
            //    MessageBox.Show("Вы вошли под аккаунтом << " + CurrentUserName + " >> аккаунт проверен, вы можете начать работу.",
            //               "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //} else {
            //    MessageBox.Show("Вы вошли под аккаунтом << " + CurrentUserName + " >> аккаунт не прошел проверку, вы не можете начать работу.",
            //               "Ошибка вторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Close();
            //}
        }

        // Расширенный поиск 
        private void AdvancedSearch_Click(object sender, EventArgs e) {
            var OpenNewForm = new SearchForm();
            OpenNewForm.Location = this.Location;
            OpenNewForm.StartPosition = FormStartPosition.Manual;
            OpenNewForm.FormClosing += delegate { this.Show(); };
            OpenNewForm.Show();
            this.Hide();
        }
        private void InformationS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В данном режиме вы можете выбрать контекстный или префиксный тип поиска, " + 
                            "а так же допускать или скрываать записи с пустыми полями.",
                            "Расширенный поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Настраевавемый поиск
        private void CustomSearch_Click(object sender, EventArgs e) {
            var OpenNewForm = new CustomSearchForm();
            OpenNewForm.Location = this.Location;
            OpenNewForm.StartPosition = FormStartPosition.Manual;
            OpenNewForm.FormClosing += delegate { this.Show(); };
            OpenNewForm.Show();
            this.Hide();
        }
        private void InformationCS_Click(object sender, EventArgs e) {
            MessageBox.Show("В данном режиме вы можете самостоятельно составить набор полей, обязательных к заполнению",
                            "Настраевыемый поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}