using System.Windows.Forms;

namespace WinformEvents
{
    class Element
    {
        private string objectType;
        private TextBox textBox;
        private CheckBox checkBox;
        private string origString;
        private bool origState;

        public Element()
        {
        }

        public Element(TextBox textBox)
        {
            this.TextBox = textBox;
            this.origString = textBox.Text;
            this.objectType = "TextBox";
        }

        public Element(CheckBox checkBox)
        {
            this.checkBox = checkBox;
            this.origState = checkBox.Checked;
            this.objectType = "CheckBox";
        }

        public TextBox TextBox { get => textBox; set => textBox = value; }
        public CheckBox CheckBox { get => checkBox; set => checkBox = value; }
        public string ObjectType { get => objectType; set => objectType = value; }
        public string OrigString { get => origString; set => origString = value; }
        public bool OrigState { get => origState; set => origState = value; }
    }
}
