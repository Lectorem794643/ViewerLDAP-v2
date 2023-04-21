using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ViewerLDAP
{
    public partial class CustomSearchForm : Form
    {
        private Controller.Controller _controller; // Подключаем самописный класс   // Кол-во заисей на страничке

        public CustomSearchForm() {
            InitializeComponent();
        }

        // Чистим форму, возвращаем флажки в значения по умолчанию
        private void Button_CleanForm_Click(object sender, EventArgs e) {     
            dataGridViewTable.Rows.Clear();
            comboBoxSearchField.SelectedIndex = -1;
            checkBoxId.Checked = true;
            checkBoxName.Checked = true;
            checkBoxMail.Checked = true;
            checkBoxPost.Checked = true;
            checkBoxWorkplace.Checked = true;
            textBoxNumberElements.Text = string.Empty;
            textBoxCurrentPage.Text = string.Empty;
            textBoxRequest.Text = string.Empty;
        }

        // Проверка что запрос пользователя содержит только русские буквы или цифры
        bool ChekRequest(string Request) {
            // Под проверку поподают поля Фамилия, Должность и Рабочее место
            if (comboBoxSearchField.SelectedIndex == 1 || comboBoxSearchField.SelectedIndex == 3) {
                if (!Regex.IsMatch(Request, @"\P{IsCyrillic}") || int.TryParse(Request, out int integer)) {
                    return true;
                }
                return false;
            }
            return true;
        }

        // Вывод предидущей страницы 
        private void Button_PreviousPage_Click(object sender, EventArgs e) {
            if (_controller != null) {
                _controller.PreviousPage();
            }
        }

        // Вывод следующей страницы 
        private void Button_NextPage_Click(object sender, EventArgs e) {
            if (_controller != null) {
                _controller.NextPage();
            }
        }

        // Вспомгательная функция, формирует фильтр на основе запроса и комбобокса 
        private string GetFilter(string request) {
            switch (comboBoxSearchField.SelectedIndex) {
                case 0:
                    return "(|(employeeNumber=*" + request + "*)(employeeNumber=" + request + "*)(employeeNumber=*" + request + ")(employeeNumber=" + request + "))";
                case 1:
                    return "(|(cn=*" + request + "*)(cn=" + request + "*)(cn=*" + request + ")(cn=" + request + "))";
                case 2:
                    return "(|(mail=*" + request + "*)(mail=" + request + "*)(mail=*" + request + ")(mail=" + request + "))";
                case 3:
                    return "(|(title=*" + request + "*)(title=" + request + "*)(title=*" + request + ")(title=" + request + "))";
                case 4:
                    return "(|(physicalDeliveryOfficeName=*" + request + "*)(physicalDeliveryOfficeName=" + request + "*)(physicalDeliveryOfficeName=*" + request + ")(physicalDeliveryOfficeName=" + request + "))";
                default:
                    return string.Empty;
            }
        }

        // Функция вытягивания данных из AD по протоколу LDAP. Работает через класс Controller
        private void Button_ProcessRequest_Click(object sender, EventArgs e)
        {
            string Request = textBoxRequest.Text; // Считываем запрос пользователя

            /*  Блок проверки корректности ввода значений, возвращает ошибку если:
             *  не выбрано поле поиска, поисковый запрос пуст или содержит недопустимые символы */
            if (false == comboBoxSearchField.SelectedIndex > -1) {
                MessageBox.Show("Выберите поле поиска из пердложденных вариантов.",
                                "Вы не выбрали поле поиска!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (Request == string.Empty) {
                MessageBox.Show("Поисковой запрос не может быть пустым, пожалуйста заполните поле запроса.",
                                "Вы ввели пустой запрос!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (!ChekRequest(Request)) {
                MessageBox.Show("Поисковой запрос должен содержать только цифры или буквы русского языка. " +
                                "Использование любых других символов не допускается",
                                "Вы ввели недопустимый символ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NewFilter = GetFilter(Request);

            // Формируем фильтр пустых полей на основе выбора пользователя
            string FilterForNotEmpty = string.Empty;
            if (checkBoxId.Checked == true) // ID
                FilterForNotEmpty += "(employeeNumber=*)";
            if (checkBoxName.Checked == true) // Фамилия
                FilterForNotEmpty += "(cn=*)";
            if (checkBoxMail.Checked == true) // Почта
                FilterForNotEmpty += "(mail=*)";
            if (checkBoxPost.Checked == true) // Должность
                FilterForNotEmpty += "(title=*)";
            if (checkBoxWorkplace.Checked == true) // Рабочее место
                FilterForNotEmpty += "(physicalDeliveryOfficeName=*)";

            string filter = $"(&(&(objectClass=user)(objectClass=person)){NewFilter}{FilterForNotEmpty})"; // Готовый фильтр для LDAP

            /* Передаем в класс Controller фильтр и информацию о том, куда выводить полученные значения 
             * (таблица типа dataGridView и textBox ) */
            _controller = new Controller.Controller(filter, dataGridViewTable, textBoxCurrentPage, textBoxNumberElements);
        }
    }
}