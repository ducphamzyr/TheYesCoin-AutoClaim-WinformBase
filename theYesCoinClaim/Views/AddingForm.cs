using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theYesCoinClaim.Models;

namespace theYesCoinClaim
{
    public partial class AddingForm : Form
    {
        public AddingForm()
        {
            InitializeComponent();
        }
        private List<Account> accounts = new List<Account>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account
            {
                ID = Convert.ToInt32(idTxt.Text),
                Name = nameTxt.Text,
                Status = "Thêm mới",
                AmountCoin = "0",
                Token = tokenTxt.Text,
            };

            AddAccountToJson(newAccount);
        }

        private void AddAccountToJson(Account newAccount)
        {
            try
            {
                string filePath = "accounts.json";

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    accounts = JsonConvert.DeserializeObject<List<Account>>(json);
                }

                accounts.Add(newAccount);

                string updatedJson = JsonConvert.SerializeObject(accounts);
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show("Tài khoản đã được thêm mới thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu tệp JSON: {ex.Message}");
            }
        }

    }
}

