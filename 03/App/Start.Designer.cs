namespace CrackMe_03;

partial class Start
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
        lblMessage = new Label();
        panel1 = new Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // lblMessage
        // 
        lblMessage.AutoSize = true;
        lblMessage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblMessage.ForeColor = Color.FromArgb(192, 0, 192);
        lblMessage.Location = new Point(222, 37);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(348, 30);
        lblMessage.TabIndex = 0;
        lblMessage.Text = "Congratulations: you've cracked me.";
        // 
        // panel1
        // 
        panel1.BackColor = Color.Transparent;
        panel1.Controls.Add(lblMessage);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 100);
        panel1.TabIndex = 1;
        // 
        // Start
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Center;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        DoubleBuffered = true;
        Name = "Start";
        Text = "CrackMe 03 - Level 3";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label lblMessage;
    private Panel panel1;
}
