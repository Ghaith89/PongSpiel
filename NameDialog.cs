using System.Windows.Forms;

namespace Pong
{
    public partial class NameDialog : Form
    {
        public string LiefereName()
        {
            return textBox1.Text;
        }

        public NameDialog()
        {
            InitializeComponent();
        }
    }
}
