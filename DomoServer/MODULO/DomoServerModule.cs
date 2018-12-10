namespace DomoServer
{
    public class DomoServerModule : UBSLib.UBSVisualModule
    {

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

        //////////////////////////////////////////////////////////////////////////////////
        public string GetWifiDevices()
        {


            return "";
        }

        string NetworkGateway()
        {
            string ip = null;

            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        ip = d.Address.ToString();
                    }
                }
            }

            return ip;
        }

    }
}
