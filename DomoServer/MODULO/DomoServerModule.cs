using DomoServer.CLASES;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DomoServer
{
    public class DomoServerModule : UBSLib.UBSVisualModule
    {
		delegate void AddDevice(string device);
		//////////////////////////////////////////////////////////////////////////////////
		public DomoServerModule(string _id)
			: base(_id)
		{ }


		//////////////////////////////////////////////////////////////////////////////////
		public override bool Init()
        {
            base.Init();
            WindowForm = new DomoServerForm(this);


			
			WriteConsole("Módulo cargado correctamente.");
            return true;
        }

        //////////////////////////////////////////////////////////////////////////////////
        public override void HandleMessages(UBSLib.UBSMessage message)
        {
			
		}
    }
}
