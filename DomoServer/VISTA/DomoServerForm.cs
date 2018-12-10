using DomoServer.VISTA;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DomoServer
{
    public partial class DomoServerForm : Form
    {
        ///////////////////////////////////
        private UBSLib.UBSVisualModule parent;
        ///////////////////////////////////
        
        public DomoServerForm(UBSLib.UBSVisualModule _parent)
        {
            this.parent = _parent;
            InitializeComponent();

            Init();
        }

        ///////////////////////////////////
        private void Init()
        {
            
        }

        private void btnAddCell_Click(object sender, System.EventArgs e)
        {
			Devices dev = new Devices(parent);
			dev.Show();
        }
    }
}
