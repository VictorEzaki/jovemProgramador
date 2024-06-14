namespace view
{
    public class Home : Form
    {
        private readonly Form ParentForm;
        private readonly Label LabelMsg;
        private readonly Button ButtonFechar;
        
        public Home(Form parent)
        {
            ParentForm = parent;
            ControlBox = false;
            Size = new Size(300, 300);
            StartPosition = FormStartPosition.CenterScreen;

            BackColor = Color.Black;
            ForeColor = Color.White;

            LabelMsg = new Label
            {
                Text = "Parabéns, você logou!",
                Size = new Size(200, 50),
                Location = new Point(50, 50),
            };

            ButtonFechar = new Button
            {
                Text = "Fechar",
                Location = new Point(50, 100),
            };
            ButtonFechar.Click += ClickFechar;

            Controls.Add(LabelMsg);
            Controls.Add(ButtonFechar);
    
        }
        private void ClickFechar(object? sender, EventArgs e)
        {
            Close();
            ParentForm.Show();
        }
    }

}