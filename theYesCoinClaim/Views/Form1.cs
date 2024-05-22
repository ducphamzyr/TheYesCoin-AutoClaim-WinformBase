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
using theYesCoinClaim.Controls;
using theYesCoinClaim.Models;

namespace theYesCoinClaim
{
    public partial class Main : Form
    {
        Bots bots = new Bots();
        public Main()
        {
            InitializeComponent();
            LoadAccountsFromJson();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm();
            addingForm.ShowDialog();
            LoadAccountsFromJson();
        }
        int accountIdNow;
        private void dataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dataShow.Rows[e.RowIndex].Cells["ID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int accountId))
                {
                    accountIdNow = accountId;
                }
            }
        }
        List<Account> accounts = new List<Account>();
        private void LoadAccountsFromJson()
        {
            try
            {
                string filePath = "accounts.json";
                string json = File.ReadAllText(filePath);
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
                dataShow.DataSource = accounts;
                dataShow.Columns["ID"].HeaderText = "ID";
                dataShow.Columns["ID"].Width = 50;
                dataShow.Columns["Name"].HeaderText = "Tên";
                dataShow.Columns["Name"].Width = 120;
                dataShow.Columns["Status"].HeaderText = "Trạng Thái";
                dataShow.Columns["Status"].Width = 120;
                dataShow.Columns["AmountCoin"].HeaderText = "Số lượng Coin";
                dataShow.Columns["AmountCoin"].Width = 200;
                dataShow.Columns["Token"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi đọc tệp JSON: {ex.Message}");
            }
        }
        private void DeleteAccountFromJson(int accountId)
        {
            try
            {
                Account accountToRemove = accounts.FirstOrDefault(account => account.ID == accountId);

                if (accountToRemove != null)
                {
                    accounts.Remove(accountToRemove);

                    string filePath = "accounts.json";
                    string json = JsonConvert.SerializeObject(accounts);
                    File.WriteAllText(filePath, json);

                    MessageBox.Show("Tài khoản đã được xóa thành công.");
                    LoadAccountsFromJson();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi xóa tài khoản: {ex.Message}");
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAccountFromJson(accountIdNow);
        }

        private async void runAllBtn_Click(object sender, EventArgs e)
        {
            string accountInfo = await Bots.GetAccountInfo();
            MessageBox.Show(accountInfo.ToString());
        }
    }
}
