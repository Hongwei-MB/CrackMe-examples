using System.ComponentModel;

namespace CrackMe_03
{
    public partial class UserLogin : Form, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private readonly ILoginService loginService;

        public UserLogin(ILoginService loginService)
        {
            InitializeComponent();
            this.loginService = loginService;
            txtUserName.DataBindings.Add(nameof(TextBox.Text), this, nameof(UserName), false, DataSourceUpdateMode.OnPropertyChanged);
            txtPassword.DataBindings.Add(nameof(TextBox.Text), this, nameof(Password), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private string? userName;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? UserName
        {
            get => userName;
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }

        private string? password;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginService.CheckPermission(UserName, Password);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
