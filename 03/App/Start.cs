using Microsoft.Extensions.DependencyInjection;

namespace CrackMe_03;

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
            lblMessage.Text = "Welcome " + userLogin.UserName + Environment.NewLine + "Congratulations: you've cracked me. You come to the L3.";
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
