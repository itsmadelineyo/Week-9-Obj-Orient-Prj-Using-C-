using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CheckDigitVerificationPrjct
{
    public partial class frmCheckDigit : Form
    {
        private const int AccountLength = 8;

        public frmCheckDigit()
        {
            InitializeComponent();

            // Event handlers are usually set in the Designer, but you can ensure they're set here if needed:
            btnProcess.Click += btnProcess_Click;
            btnReset.Click += btnReset_Click;
            btnExit.Click += btnExit_Click;

            this.AcceptButton = btnProcess;
            this.CancelButton = btnExit;
            this.StartPosition = FormStartPosition.CenterScreen;
            rtbMessages.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtConfirm.Clear();
            txtAmount.Clear();
            rtbMessages.Clear();
            txtAccount.Focus();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            rtbMessages.Clear();
            ProcessInput();
        }

        private void ProcessInput()
        {
            string account = RemoveNonDigits(txtAccount.Text.Trim());
            string confirm = RemoveNonDigits(txtConfirm.Text.Trim());
            string rawAmount = txtAmount.Text.Trim();

            if (string.IsNullOrWhiteSpace(account) ||
                string.IsNullOrWhiteSpace(confirm) ||
                string.IsNullOrWhiteSpace(rawAmount))
            {
                AppendMessage("Error: All fields are required. Please enter Account, Confirm Account, and Payment Amount.");
                return;
            }

            if (!IsAllDigits(account) || !IsAllDigits(confirm))
            {
                AppendMessage("Error: Account numbers must contain digits only (no letters). You may enter spaces or dashes which will be ignored.");
                return;
            }

            if (account.Length != AccountLength)
            {
                AppendMessage($"Error: Account number must be exactly {AccountLength} digits long (after removing spaces/dashes). You entered {account.Length} digits.");
                return;
            }

            if (account != confirm)
            {
                AppendMessage("Error: Account and confirmation do not match.");
                return;
            }

            if (!IsValidCheckDigit(account))
            {
                AppendMessage("Error: Account number failed the check-digit validation. Please verify the account number.");
                return;
            }

            if (!TryParsePayment(rawAmount, out decimal paymentValue))
            {
                AppendMessage("Error: Payment amount invalid. Enter a numeric amount (examples: 100, 100.00, $1,234.56).");
                return;
            }

            string formattedPayment = paymentValue.ToString("C", CultureInfo.CurrentCulture);
            string today = DateTime.Now.ToString("MMMM d, yyyy");
            AppendMessage($"A payment of {formattedPayment} was applied to account {account} on {today}.");
        }

        private void AppendMessage(string message)
        {
            rtbMessages.AppendText($"{message}{Environment.NewLine}");
            rtbMessages.ScrollToCaret();
        }

        private string RemoveNonDigits(string input) =>
            string.Concat(input?.Where(char.IsDigit) ?? Enumerable.Empty<char>());

        private bool IsAllDigits(string s) =>
            !string.IsNullOrEmpty(s) && s.All(char.IsDigit);

        private bool IsValidCheckDigit(string account)
        {
            if (account?.Length != AccountLength) return false;
            int sum = account.Take(AccountLength - 1).Sum(c => c - '0');
            int checkDigit = sum % 10;
            int lastDigit = account[AccountLength - 1] - '0';
            return checkDigit == lastDigit;
        }

        private bool TryParsePayment(string input, out decimal amount)
        {
            amount = 0m;
            if (string.IsNullOrWhiteSpace(input)) return false;
            var styles = NumberStyles.Currency | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint;
            return decimal.TryParse(input, styles, CultureInfo.CurrentCulture, out amount);
        }
    }
}
