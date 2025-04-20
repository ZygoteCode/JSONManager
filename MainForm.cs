using MetroSuite;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System;

public partial class MainForm : MetroForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        try
        {
            JToken.Parse(guna2TextBox1.Text);
            MessageBox.Show("The JSON string is valid.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"The JSON string is NOT valid.\r\n\r\nError message > {ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        try
        {
            guna2TextBox1.Text = JToken.Parse(guna2TextBox1.Text).ToString(Formatting.Indented);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"The JSON string is NOT valid.\r\n\r\nError message > {ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        try
        {
            guna2TextBox1.Text = JToken.Parse(guna2TextBox1.Text).ToString(Formatting.None);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"The JSON string is NOT valid.\r\n\r\nError message > {ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}