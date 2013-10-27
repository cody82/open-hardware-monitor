using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace OpenHardwareMonitor.Utilities
{
    public class Serial
    {
        public string Port = "COM9";
        SerialPort serial = new SerialPort("COM9", 9600);

        public bool Open()
        {
            if (serial.IsOpen)
                serial.Close();
            serial.PortName = Port;
            try
            {
                serial.Open();
            }
            catch (IOException e)
            {
                return false;
            }
            return true;
        }

        public void Close()
        {
            if(serial.IsOpen)
                serial.Close();
        }

        public void Write(byte[] data)
        {
            if(serial.IsOpen)
                serial.Write(data, 0, data.Length);
        }
    }
}
