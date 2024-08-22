using System;
using System.Windows.Forms;

namespace Task_2_Web_Application
{
    public static class Interaction
    {
        public static string InputBox(string message, string title, string defaultValue)
        {
            Form inputForm = new Form()
            {
                Width = 450,
                Height = 200,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 50, Top = 20, Text = message };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300, Text = defaultValue };
            Button buttonOk = new Button() { Text = "OK", Left = 200, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            Button buttonCancel = new Button() { Text = "Cancel", Left = 310, Width = 100, Top = 100, DialogResult = DialogResult.Cancel };

            buttonOk.Click += (sender, e) => { inputForm.Close(); };
            buttonCancel.Click += (sender, e) => { inputForm.Close(); };

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(buttonOk);
            inputForm.Controls.Add(buttonCancel);
            inputForm.AcceptButton = buttonOk;
            inputForm.CancelButton = buttonCancel;

            return inputForm.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
    }
}
