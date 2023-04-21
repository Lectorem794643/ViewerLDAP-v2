using System.DirectoryServices;
using System.Windows.Forms;

namespace ViewerLDAP.Controller
{
    public class Controller 
    {
        private SearchResultCollection resultCollection; // Хранилище полученных с сервера записей
        private int MaxPage; // Страница максимального номера (число страниц)
        private int CurrentPage = 1; // Текущая страница, по умолчанию равно 1
        private int NumberElementsOnPage = 17; // Кол-во заисей на страничке, по умолчанию равно 25
        private int NumberEntries; // Всего найдено записей
        private DataGridView dataGridView; // Таблица в которую выводятся данные 
        private TextBox textBoxCurrentPage; // TextBox в который выводим текущую страницу
        private TextBox textBoxNumberElements; // TextBox в который количество найденых запмсей

        public Controller(string filter, DataGridView DGV, TextBox textBox, TextBox NumberElementsTextBox)
        {
            dataGridView = DGV;
            textBoxCurrentPage = textBox;
            textBoxNumberElements = NumberElementsTextBox;

            // Подключаемся к LDAP
            DirectoryEntry direcroryEntry = new DirectoryEntry(""); // Ваш адрес 
            DirectorySearcher searcher = new DirectorySearcher(direcroryEntry) {
                PageSize = int.MaxValue,
                Filter = filter
            };

            resultCollection = searcher.FindAll(); // Хранилище полученных с сервера записей
            NumberEntries = resultCollection.Count; // Всего найдено записей
            MaxPage = GetMaxPage(); // Кол-во страниц

            PageOutputByIndex(1); // Вызов первой страници до нажатия кнопок переключения стр
            textBoxNumberElements.Text = NumberEntries.ToString(); // Вывели кол-во найденных эдементов на форму
        }

        // Функция расчета общего количества страниц
        private int GetMaxPage() {
            int result = NumberEntries % NumberElementsOnPage;
            if (result != 0) {
                return NumberEntries / NumberElementsOnPage + 1;
            } else {
                return NumberEntries / NumberElementsOnPage;
            }
        }

        // Функция отображения предидущей страницы
        public void PreviousPage() {
            if ((CurrentPage - 1) <= MaxPage & (CurrentPage - 1) >= 1) {
                CurrentPage--;
                PageOutputByIndex(CurrentPage);
            };
        }

        // Функция отображения следующей страницы
        public void NextPage() {
            if ((CurrentPage + 1) <= MaxPage & (CurrentPage + 1) >= 1) {
                CurrentPage++;
                PageOutputByIndex(CurrentPage);
            };
        }

        // Функция заполняюбщая пустые поля записей спец. символом (отметкой)
        private string GetProperty(int index, string propertyName) {
            try {
                return resultCollection[index].Properties[propertyName][0].ToString();
            } catch {
                return " - Empty - "; // Символ в случае пустой строки
            }
        }

        // Функция создания новой строки в таблице, принимает значения выводимой записи
        private void CreateNewRows(string ID, string Name, string Mail, string Title, string Delivery) {
            DataGridViewCell userEmployeeNumber = new DataGridViewTextBoxCell();
            DataGridViewCell userName = new DataGridViewTextBoxCell();
            DataGridViewCell userMail = new DataGridViewTextBoxCell();
            DataGridViewCell userTitle = new DataGridViewTextBoxCell();
            DataGridViewCell userPhysicalDeliveryOfficeName = new DataGridViewTextBoxCell();

            userEmployeeNumber.Value = ID;
            userName.Value = Name;
            userMail.Value = Mail;
            userTitle.Value = Title;
            userPhysicalDeliveryOfficeName.Value = Delivery;

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.AddRange(userEmployeeNumber, userName, userMail, userTitle, userPhysicalDeliveryOfficeName);
            dataGridView.Rows.Add(newRow);
        }

        // Функция отобращения страницы по индексу 
        private void PageOutputByIndex(int Page) {
            dataGridView.Rows.Clear(); // Чистим табличку перед выводом
            textBoxCurrentPage.Text = CurrentPage.ToString() + "/" + MaxPage.ToString(); // вывели текущую страницу

            if (Page * NumberElementsOnPage <= NumberEntries) {
                int index = Page * NumberElementsOnPage - NumberElementsOnPage;

                for (int i = 0; i < NumberElementsOnPage; i++)
                {
                    string ID = GetProperty(i + index, "employeeNumber");
                    string Name = GetProperty(i + index, "cn");
                    string Mail = GetProperty(i + index, "mail");
                    string Title = GetProperty(i + index, "title");
                    string Delivery = GetProperty(i + index, "physicalDeliveryOfficeName");

                    CreateNewRows(ID, Name, Mail, Title, Delivery);
                }
            } else {
                int index = Page * NumberElementsOnPage - NumberElementsOnPage;
                int RemainderElements = NumberEntries - ((Page - 1) * NumberElementsOnPage);

                for (int i = 0; i < RemainderElements; i++)
                {
                    string ID = GetProperty(i + index, "employeeNumber");
                    string Name = GetProperty(i + index, "cn");
                    string Mail = GetProperty(i + index, "mail");
                    string Title = GetProperty(i + index, "title");
                    string Delivery = GetProperty(i + index, "physicalDeliveryOfficeName");

                    CreateNewRows(ID, Name, Mail, Title, Delivery);
                }
            }
        }
    };
}