﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace DomoServer.CLASES
{
	public delegate void AddDeviceDelegate(string deviceName);

	public class NetServices
	{
		private UBSLib.UBSModule parent;
		private AddDeviceDelegate m_AddDevice;
		public Dictionary<string, string> Devices;

		public NetServices(UBSLib.UBSModule ubs)
		{
			parent = ubs;
			Devices = new Dictionary<string, string>();
		}

		public void SetAddDeviceDelegate(AddDeviceDelegate AddFunc)
		{
			this.m_AddDevice = AddFunc;
		}

		private string NetworkGateway()
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

		public void Ping_all()
		{

			string gate_ip = NetworkGateway();

			//Extracting and pinging all other ip's.
			string[] array = gate_ip.Split('.');

			for (int i = 2; i <= 255; i++)
			{

				string ping_var = array[0] + "." + array[1] + "." + array[2] + "." + i;

				//time in milliseconds           
				Ping(ping_var, 4, 4000);
			}
		}

		public void Ping(string host, int attempts, int timeout)
		{
			for (int i = 0; i < attempts; i++)
			{
				new Thread(delegate ()
				{
					try
					{
						Ping ping = new Ping();
						ping.PingCompleted += new PingCompletedEventHandler(PingCompleted);
						ping.SendAsync(host, timeout, host);
					}
					catch
					{
						// Do nothing and let it try again until the attempts are exausted.
						// Exceptions are thrown for normal ping failurs like address lookup
						// failed.  For this reason we are supressing errors.
					}
				}).Start();
			}
		}


		private void PingCompleted(object sender, PingCompletedEventArgs e)
		{
			string ip = (string)e.UserState;
			if (e.Reply != null && e.Reply.Status == IPStatus.Success)
			{
				string hostname = GetHostName(ip);
				string macaddres = GetMacAddress(ip);
				string[] arr = new string[3];

				//store all three parameters to be shown on ListView
				arr[0] = ip;
				arr[1] = hostname;
				arr[2] = macaddres;

				// Logic for Ping Reply Success

				if (hostname != null)
					hostname = "movil";
				if (!Devices.ContainsKey(macaddres))
					Devices.Add(macaddres, ip + "-" + hostname + "-" + macaddres);
			}
			else
			{
				// MessageBox.Show(e.Reply.Status.ToString());
			}
		}

		
		public string GetHostName(string ipAddress)
		{
			try
			{
				IPAddress ip = IPAddress.Parse(ipAddress);
				IPHostEntry entry = Dns.GetHostEntry(ip);
				if (entry != null)
				{
					return entry.HostName;
				}
			}
			catch (SocketException e)
			{
				// MessageBox.Show(e.Message.ToString());
			}
			return null;
		}


		//Get MAC address
		public string GetMacAddress(string ipAddress)
		{
			string macAddress = string.Empty;
			System.Diagnostics.Process Process = new System.Diagnostics.Process();
			Process.StartInfo.FileName = "arp";
			Process.StartInfo.Arguments = "-a " + ipAddress;
			Process.StartInfo.UseShellExecute = false;
			Process.StartInfo.RedirectStandardOutput = true;
			Process.StartInfo.CreateNoWindow = true;
			Process.Start();
			string strOutput = Process.StandardOutput.ReadToEnd();
			string[] substrings = strOutput.Split('-');
			if (substrings.Length >= 8)
			{
				macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
						 + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
						 + "-" + substrings[7] + "-"
						 + substrings[8].Substring(0, 2);
				return macAddress;
			}
			else
			{
				return "OWN Machine";
			}
		}
	}
}
