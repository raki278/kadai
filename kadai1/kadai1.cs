using System;
using System.Windows.Forms;

class Kadai:Form
{
    private Label lb;
    private Button bt;


    public static void Main()
    {
        Application.Run(new Kadai());
    }
    public Kadai()
    {
        this.Text = "課題です。";
        this.Width = 450; this.Height= 300;

        lb = new Label();
        lb.Text = "友達と一緒に参考書";
        lb.Width = 150;
        bt = new Button();
        bt.Text = "友達と一緒にやりました。";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        bt.Parent = this;
        lb.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }
    public void bt_Click(object sender, EventArgs e)
    {
        lb.Text = "見ながらやりました。";
    }
}