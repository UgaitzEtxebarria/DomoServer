using DomoServer.CLASES;
using System.Windows.Forms;

namespace DomoServer.VISTA
{
	public partial class Devices : Form
	{
		public delegate void DelDevices(string DeviceName);
		
		public Devices(UBSLib.UBSModule mod)
		{
			InitializeComponent();

			NetServices ns = new NetServices(mod);
			ns.Ping_all(AddDevice);
		}

		public void AddDevice(string device)
		{

		}
	}
}
