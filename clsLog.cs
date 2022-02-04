using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HLBBWS
{
    public class clsLog
    {
        public enum ChannelType
        {
            EDMS = 0,
            EAI = 1
        }

        public enum MessageType
        {
            Info = 0,
            Error = 1 
        }

        public static void WriteIntegratedLog(ChannelType channel, MessageType type, string message1, string message2)
        {
            lock (clsGlobal.objLockLog)
            {
                if (clsGlobal.SYSTEM_SAVE_LOG)
                {
                    System.IO.StreamWriter sw = null;
                    System.Text.StringBuilder strMsg = null;
                    try
                    {
                        if (!System.IO.Directory.Exists(clsGlobal.SYSTEM_LOG_PATH))
                        {
                            System.IO.Directory.CreateDirectory(clsGlobal.SYSTEM_LOG_PATH);
                        }

                        string strFilePath = clsGlobal.SYSTEM_LOG_PATH + @"\OUT_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                        sw = new System.IO.StreamWriter(strFilePath, true);

                        strMsg = new System.Text.StringBuilder();
                        strMsg.Append(type.ToString());
                        strMsg.Append("\t");
                        strMsg.Append(channel.ToString());
                        strMsg.Append("\t");
                        strMsg.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));            //yyyy-MM-dd HH:mm:ss.fff
                        strMsg.Append("\t");
                        strMsg.Append(message1);
                        strMsg.Append("\t");
                        strMsg.Append(message2);

                        sw.WriteLine(strMsg);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        if (sw != null)
                        {
                            sw.Flush();
                            sw.Close();
                            sw = null;
                        }
                        strMsg = null;
                    }
                }
                
            }
        }

        public static void WriteSystemLog(MessageType type, string message1, string message2)
        {
            /*
            lock (clsGlobal.objLockLog)
            {
                if (clsGlobal.SYSTEM_SAVE_LOG)
                {
                    System.IO.StreamWriter sw = null;
                    System.Text.StringBuilder strMsg = null;
                    try
                    {
                        if (!System.IO.Directory.Exists(clsGlobal.SYSTEM_LOG_PATH))
                        {
                            System.IO.Directory.CreateDirectory(clsGlobal.SYSTEM_LOG_PATH);
                        }

                        string strFilePath = clsGlobal.SYSTEM_LOG_PATH + @"\IN_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                        sw = new System.IO.StreamWriter(strFilePath, true);

                        strMsg = new System.Text.StringBuilder();
                        strMsg.Append(type.ToString());
                        strMsg.Append("\t");
                        strMsg.Append(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));            //yyyy-MM-dd HH:mm:ss.fff
                        strMsg.Append("\t");
                        strMsg.Append(message1);
                        strMsg.Append("\t");
                        strMsg.Append(message2);

                        sw.WriteLine(strMsg);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        if (sw != null)
                        {
                            sw.Flush();
                            sw.Close();
                            sw = null;
                        }
                        strMsg = null;
                    }
                }

            }
            */
        }

    }
}