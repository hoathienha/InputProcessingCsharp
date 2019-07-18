using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4;
using System.Collections; //must add this class library for LIST
using System.IO; // reading files
using Assignment_8;

namespace Assignment_4
{
    public partial class Assignment4 : Form
    {
        public Assignment4()
        {
            InitializeComponent();

            BankAccount account = new BankAccount(1000m);
            balanceLabel.Text = account.Balance.ToString("c2");
        }

        #region Chapter 8

        #region Array List
        private void addButton_Click(object sender, EventArgs e)
        {
            string str = nameTextBox.Text;
            nameListBox.Items.Add(str);

            nameTextBox.Clear();
            nameTextBox.Focus();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != -1)
            {
                int index = nameListBox.SelectedIndex;
                nameListBox.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Select an item to remove.");
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            int count = nameListBox.Items.Count;
            string[] name = new string[count]; 

            nameListBox.Items.CopyTo(name, 0);
            nameListBox.Items.Clear();

            Array.Sort(name);

            foreach (string val in name)
                nameListBox.Items.Add(val);
        }


        #endregion

        #region ref vs out
        private void refButton_Click(object sender, EventArgs e)
        {
            int num = 1;

            SetRef(ref num);

            refLabel.Text = num.ToString();
        }

        private void SetRef(ref int a)
        {
            a = 0;
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            int num;

            SetOut(out num);

            outLabel.Text = num.ToString();
        }

        private void SetOut(out int a)
        {
            a = 0;
        }


        #endregion

        #region Character testing for Password
        private void countCharButton_Click(object sender, EventArgs e)
        {
            string str = countCharTextBox.Text;

            if (str != "")
            {
                int check = 0;

                //More than 6 chars
                MoreSixChars(str, ref check);

                //Check if first character is letter
                FirstLetter(str, ref check);

                //Check if last character is digit
                LastDigit(str, ref check);

                //Check if string contains digit
                ContainsDigit(str, ref check);

                //Check if string contains 1 capital letter
                ContainsCapLetter(str, ref check);

                //Check if string contains no spaces
                NoSpace(str, ref check);

                //Count number of letters and digits
                CountLetterDigit(str);

                //Check if password is strong
                IsSecure(check);
            }
            else
            {
                MessageBox.Show("Insert a string");
                countCharsLabel.BackColor = Color.White;
                firstCharacterLabel.BackColor = Color.White;
                lastCharacterLabel.BackColor = Color.White;
                isDigitLabel.BackColor = Color.White;
                oneCapitalLabel.BackColor = Color.White;
                noSpacesLabel.BackColor = Color.White;
            }

        }

        private void MoreSixChars(string str, ref int check)
        {
            countCharsLabel.Text = str.Length.ToString();

            if (str.Length > 6)
            {
                countCharsLabel.BackColor = Color.LightGreen;
                check++;
            }
            else
                countCharsLabel.BackColor = Color.White;
        }

        private void FirstLetter(string str, ref int check)
        {
            firstCharacterLabel.Text = str[0].ToString();
            if (char.IsLetter(str[0]))
            {
                firstCharacterLabel.BackColor = Color.LightGreen;
                check++;
            }
            else
                firstCharacterLabel.BackColor = Color.White;
        }

        private void LastDigit(string str, ref int check)
        {
            if (char.IsDigit(str[str.Length - 1]))
            {
                lastCharacterLabel.Text = str[str.Length - 1].ToString();
                lastCharacterLabel.BackColor = Color.LightGreen;
                check++;
            }
            else
            {
                lastCharacterLabel.Text = "No";
                lastCharacterLabel.BackColor = Color.White;
            }
        }

        private void ContainsDigit(string str, ref int check)
        {
            int flag = 0;
            for (int i = 0; i < str.Length; i++)
                if (char.IsDigit(str[i]))
                    flag = 1;
            if (flag == 1)
            {
                isDigitLabel.Text = "Yes";
                isDigitLabel.BackColor = Color.LightGreen;
                check++;
            }
            else
            {
                isDigitLabel.Text = "No";
                isDigitLabel.BackColor = Color.White;
            }
        }

        private void ContainsCapLetter(string str, ref int check)
        {
            int flag = 0;
            for (int i = 0; i < str.Length; i++)
                if (char.IsUpper(str[i]))
                    flag = 1;
            if (flag == 1)
            {
                oneCapitalLabel.Text = "Yes";
                oneCapitalLabel.BackColor = Color.LightGreen;
                check++;
            }
            else
            {
                oneCapitalLabel.Text = "No";
                oneCapitalLabel.BackColor = Color.White;
            }
        }

        private void NoSpace(string str, ref int check)
        {
            int flag = 1;
            for (int i = 0; i < str.Length; i++)
                if (char.IsWhiteSpace(str[i]))
                    flag = 0;
            if (flag == 1)
            {
                noSpacesLabel.Text = "No";
                noSpacesLabel.BackColor = Color.LightGreen;
                check++;
            }
            else
            {
                noSpacesLabel.Text = "Yes";
                noSpacesLabel.BackColor = Color.White;
            }
        }

        private void CountLetterDigit(string str)
        {
            int numChar = 0;
            int numDigit = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                    numChar++;
                if (char.IsDigit(str[i]))
                    numDigit++;
            }
            numberOFCharsLabel.Text = numChar.ToString();
            numberOfDigitsLabel.Text = numDigit.ToString();
        }

        private void IsSecure(int check)
        {
            if (check == 6)
                strongPasswordLabel.Text = "Secure";
            else
                strongPasswordLabel.Text = "Weak";
        }

        #endregion

        #region Search string
        private void searchButton_Click(object sender, EventArgs e)
        {
            string str = stringSearchLabel.Text;
            char search = searchStringTextBox.Text[0];
            int count = 0;

            SearchCount(str, search, ref count);
        }
        
        private void SearchCount(string str, char ch, ref int count)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    count++;
            }

            if (count != 0)
                searchLabel.Text = "Found " + count.ToString() + " character!";
            else
                searchLabel.Text = "Not Found";
        }

        #endregion

        #region Average Student Marks       
        private void averageStudentButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            int sum = 0;
            int count = 0;
            double avg = 0;
            string str = "";

            LoadToListB(ref sum, ref count, ref avg, str);

        }

        private void LoadToListB(ref int s, ref int count, ref double average, string str)
        {
            StreamReader inputFile = File.OpenText("Grades.csv");

            while (!inputFile.EndOfStream)
            {
                str = inputFile.ReadLine();
                count++;
                string[] tokens = str.Split(',');

                foreach (string val in tokens)
                    s += int.Parse(val);
                average = (double)s / tokens.Length;
                averageStudentListBox.Items.Add("The Average for student " + count.ToString() + " is " + average.ToString("n1"));

                s = 0;
                average = 0;
            }

            inputFile.Close();
        }

        #endregion

        #region Struct Add a Car
        private void button_AddCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car_Inventory car = new Car_Inventory();

                AssignCar(ref car);

                string str = car.Year.ToString() + " " + car.Make + " with" + " miles.";
                listBox_Display.Items.Add(str);
            }
            catch
            {
                MessageBox.Show("Provide wrong input");
                comboBox_Make.Text = "";
                comboBox_Year.Text = "";
                comboBox_Milage.Text = "";

                comboBox_Make.Focus();
            }
        }

        private void AssignCar(ref Car_Inventory car)
        {
            car.Make = comboBox_Make.SelectedItem.ToString();
            car.Year = int.Parse(comboBox_Year.SelectedItem.ToString());
            car.Mileage = int.Parse(comboBox_Milage.Text);
        }

        #endregion

        #region Phone List
        private void Assignment4_Load(object sender, EventArgs e)
        {
            //open the PhoneList file
            StreamReader inputFile = File.OpenText("PhoneList.txt");

            string str = "";
            string[] tokens;

            while (!inputFile.EndOfStream)
            {
                str = inputFile.ReadLine();
                tokens = str.Split(',');
                listBox_Contacts.Items.Add(tokens[0]);
            }

            inputFile.Close();
        }

        private void listBox_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display phone number and email address.
            StreamReader inputFile = File.OpenText("PhoneList.txt");

            string str = "";
            string[] tokens;

            while (!inputFile.EndOfStream)
            {
                str = inputFile.ReadLine();
                tokens = str.Split(',');
                if (tokens[0] == listBox_Contacts.SelectedItem.ToString())
                {
                    label_PhoneNumber.Text = tokens[1];
                    label_eMail.Text = tokens[2];
                }
            }
            inputFile.Close();
        }
        #endregion

        #endregion

        #region Chapter 9

        #region Toss The Coin
        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin coin = new Coin();
            int countHead = 0;
            int countTail = 0;

            TossCount(ref coin, ref countHead, ref countTail);


        }
        private void TossCount(ref Coin coin, ref int cHead, ref int cTail)
        {
            for (int i = 0; i < 27; i++)
            {
                coin.Toss();
                coinTossListBox.Items.Add(coin.Side);
                if (coin.Side == "Heads")
                    cHead++;
                else
                    cTail++;
            }

            totalHeadsLabel.Text = cHead.ToString();
            totalTailsLabel.Text = cTail.ToString();
        }
        #endregion

        #region Cell Phone Data
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone phone = new CellPhone();
            string str = "";

            decimal price;

            if (decimal.TryParse(priceTextBox.Text, out price))
                SetPhone(phone, brandTextBox.Text, modelTextBox.Text, priceTextBox.Text);
            else
            {
                MessageBox.Show("Invalid price");

                SetPhone(phone, brandTextBox.Text, modelTextBox.Text, "0");
            }

            DisplayPhone(phone);

            AddtoListbox(phoneListBox, str, phone);

            ResetPhone();
        }

        private void SetPhone(CellPhone p, string a, string b, string c)
        {
            p.Brand = a;
            p.Model = b;
            p.Price = decimal.Parse(c);
        }

        private void DisplayPhone(CellPhone p)
        {
            brandLabel.Text = p.Brand;
            modelLabel.Text = p.Model;
            priceLabel.Text = p.Price.ToString("c2");
        }

        private void AddtoListbox(ListBox l, string a, CellPhone p)
        {
            a = p.Brand + " " + p.Model + " is " + p.Price.ToString("c2");
            phoneListBox.Items.Add(a);
        }

        private void ResetPhone()
        {
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            brandTextBox.Focus();
        }

        #endregion

        #region Bank Account
        BankAccount account = new BankAccount(1000);

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal deposit = 0m;

            if (decimal.TryParse(depositTextBox.Text, out deposit))
            {
                account.Deposit(deposit);
                balanceLabel.Text = account.Balance.ToString("c2");
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal withdraw = 0m;

            if (decimal.TryParse(withdrawTextBox.Text, out withdraw))
            {
                account.Withdraw(withdraw);
                balanceLabel.Text = account.Balance.ToString("c2");
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }


        #endregion

        #region Automotive Service Charges
        private void buttonCharges_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalCharge = 0m;
                double taxRate = double.Parse(textBoxTaxRate.Text);
                ServiceRequest service = new ServiceRequest();

                service.PartsCharge = decimal.Parse(textBoxPartsCharge.Text);
                service.LaborCharge = decimal.Parse(textBoxLaborCharge.Text);

                totalCharge = service.GetTotal() * (decimal)(taxRate / 100) + service.GetTotal();

                labelTotalCharge.Text = totalCharge.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }
        #endregion
        #endregion

        #region About
        private void buttonAboutBox_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        #endregion

        #region Exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

 
    }
}