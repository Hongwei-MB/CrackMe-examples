using Crack_me_01;
using Microsoft.Extensions.DependencyInjection;

namespace crack_me_01;

public partial class Start : Form
{
    private readonly IServiceProvider serviceProvider;

    public Start(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        this.serviceProvider = serviceProvider;
    }

    private void Login()
    {
        lblMessage.Text = "Please login to continue";
        var userLogin = serviceProvider.GetRequiredService<UserLogin>();
        if (DialogResult.OK == userLogin.ShowDialog())
        {
            lblMessage.Text = "Welcome " + userLogin.UserName + Environment.NewLine + "Congratulations: you've cracked me.";
        }
        else
        {
            Application.Exit();
        }
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        Login();
    }
}