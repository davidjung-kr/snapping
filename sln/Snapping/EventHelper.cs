/*
 * Created by SharpDevelop.
 * User: ZHANITEST
 * Date: 2019-07-14
 * Time: 오전 3:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;					 // 시리얼
using System.Management; 			 // 윈도우
using System.Net.NetworkInformation; // MAC
using Microsoft.VisualBasic; 		 // RAM 정보 
namespace Snapping
{
	/// <summary>
	/// Description of EventHelper.
	/// </summary>
	public class EventHelper
	{
		public EventHelper()
		{
		}
		//
		// 포트번호 얻기: 문자열 배열
		//
		public string[] getPortNames(){
			return System.IO.Ports.SerialPort.GetPortNames();
		}
		//
		// 포트번호 얻기: 한 줄로(구분 문자열 넣음)
		//
		public string getPortNames(string separator="\n"){
			return String.Join(separator, System.IO.Ports.SerialPort.GetPortNames());
		}
		//
		// 서비스팩 버전 얻기
		//
		public string getServicePackName(){
			OperatingSystem os = Environment.OSVersion;
			return os.ServicePack;
		}
		//
		// 윈도우 버전 얻기
		//
		public string getWindowsName(){
			string win_name = "";
			ManagementObjectSearcher   mgtObj  = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
			ManagementObjectCollection infoObj = mgtObj.Get();
			
			if (infoObj != null){
				foreach (ManagementObject obj in infoObj){
					win_name = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
				}
				win_name = win_name.Replace("NT 5.1.2600", "XP");
				win_name = win_name.Replace("NT 5.2.3790", "Server 2003");
			}
			else { win_name = "Unknown OS"; }
			return win_name;
		}
		//
		// CPU 이름 얻기
		//
		public string getCpuName(){
			string cpu_name = "";
			ManagementObjectSearcher mgtObj  = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			
			foreach (ManagementObject obj in mgtObj.Get()){
				cpu_name = obj["Name"].ToString();
			}
			return cpu_name;
		}
		//
		// GPU 이름 얻기
		//
		public string getGpuName(){
			string gpu_name = "";
			ManagementObjectSearcher mgtObj  = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
			
			foreach (ManagementObject obj in mgtObj.Get()){
				foreach (PropertyData property in obj.Properties){
					if (property.Name == "Description"){
						gpu_name = property.Value.ToString();
					}
				}
			}
			
			return gpu_name;
		}
		//
		// RAM 용량 얻기(MB)
		//
		public string getRamCapacity(){
			return (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024).ToString()+"MB";
		}
	}
}
