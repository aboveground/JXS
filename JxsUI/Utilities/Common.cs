using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JxsUI.Utilities
{
    public class Common
    {
        public static event EventHandler HasText;
        private static StringBuilder systemMessage = new StringBuilder();
        public static string SystemMessage
        {
            get
            { return systemMessage.ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    systemMessage.AppendLine(value);
                    HasText?.Invoke(systemMessage.ToString(), EventArgs.Empty);
                }
            }
        }
        public static void ClearMessages()
        {
            if (systemMessage != null)
            {
                systemMessage.Clear();
                HasText?.Invoke(systemMessage.ToString(), EventArgs.Empty);
            }
        }

        public static void WriteToXML<T>(T rec, string filename)
        {
            System.IO.StreamWriter streamWriter = null;
            if (!string.IsNullOrEmpty(filename))
            {
                try
                {
                    streamWriter = new System.IO.StreamWriter(filename);
                    System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(rec.GetType());
                    xml.Serialize(streamWriter, rec);
                }
                catch (Exception ex)
                {
                    SystemMessage = ex.Message;
                }
                finally
                {
                    if (streamWriter != null)
                    {
                        streamWriter.Close();
                    }
                }
            }
            else
            {
                SystemMessage = "Emptyfilename.";
            }

        }
        public static string ReadFromXML<t>(ref t classObj, string filename)
        {
            string result = filename;
            System.Xml.Serialization.XmlSerializer xs = null;
            try
            {
                if (!string.IsNullOrEmpty(filename) && classObj != null)
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(filename);
                    if (fi.Exists)
                    {
                        using (var sr = new System.IO.StreamReader(filename))
                        {
                            xs = new System.Xml.Serialization.XmlSerializer(classObj.GetType());
                            classObj = (t)xs.Deserialize(sr);
                        }
                    }
                }
                else
                {
                    result = "Error - Empty Filename or null object passed.";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            xs = null;

            return result;
        }

        public static bool NextCenter(float target, float test, ref int min, ref int max, ref int newCenter)
        {
            bool result = false;

            if (test == target)
            {
                result = true;
            }
            else if (test < target)
            {
                max = newCenter;
                newCenter = max - (Math.Abs(max - min) / 2);
            }
            else if (test > target)
            {
                min = newCenter;
                newCenter = min + (Math.Abs(max - min) / 2);
            }
            return result;
        }

        public static string SelectFolder(string folder)
        {
            string newFolder = folder;
            System.Windows.Forms.FolderBrowserDialog folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = folder;
            System.Windows.Forms.DialogResult result = folderDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                newFolder = folderDialog.SelectedPath;
            }
            return newFolder;
        }
        public static string SelectFile(string fileName)
        {
            if (fileName == null) { fileName = string.Empty; }
            string newFileName = fileName;
            System.Windows.Forms.SaveFileDialog saveFile = new System.Windows.Forms.SaveFileDialog();
            if (!string.IsNullOrEmpty(fileName))
            {
                saveFile.InitialDirectory = System.IO.Path.GetFullPath(fileName);
            }
            System.Windows.Forms.DialogResult result = saveFile.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                newFileName = saveFile.FileName;
            }
            return newFileName;
        }
    }
}
