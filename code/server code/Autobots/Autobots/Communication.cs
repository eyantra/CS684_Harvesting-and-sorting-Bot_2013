using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
namespace Autobots
{
    class Communication
    {
        private SerialPort XBEEport;
        public bool isNew = false;
        public string data;
        public Communication(String COMPORT)
        {
            XBEEport= new SerialPort(COMPORT);
            XBEEport.Open();
            XBEEport.DataReceived += XBEEport_DataReceived;
        }
      
        void XBEEport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            isNew = true;
            data = XBEEport.ReadExisting();
            XBEEport.DiscardInBuffer();
        }
        public string recivstring()
        {
            isNew = false;
            return data;
        
        }
        static string toHAX(Byte[] array)
        {
            StringBuilder hex = new StringBuilder(array.Length * 2);
            foreach (byte b in array)
                  hex.AppendFormat("{0:x2}", b);
            return hex.ToString(); 
        }
        public string write(String Message)
        {
           string result="";
            try
            { 
             if (XBEEport.IsOpen && XBEEport != null)
                {
                    Byte[] ascii = Encoding.ASCII.GetBytes(Message);

                    foreach (byte b in System.Text.Encoding.UTF8.GetBytes(Message.ToCharArray()))
                    {
                        XBEEport.Write(ascii,0,1);
                        result+="\nSending signal-" + toHAX(ascii);
                    }
                }
                else
                   result+="\n Please open Port First";
             return result;
            }
            
             catch (Exception ex)
            {
                result += "ERROR:-" + ex.Message.ToString();
                return result;
            }
        }
        
        }
    }

