using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
//using System.Windows.Forms;

namespace WpfControlX
{
    /// <summary>
    /// Commonly used functions
    /// </summary>
    public class Common
    {
        private static Exception ex;
        public static Exception EX
        {
            get { return ex; }
        }


        public static event EventHandler HasText;


        //public static string SelectFolder(string folder)
        //{
        //    string newFolder = folder;
        //    FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        //    folderBrowser.ShowDialog();

        //    return newFolder;
        //}

        //public static string SelectFileToUse(string filename)
        //{
        //    if (filename == null) { filename = string.Empty; }
        //    string newFile = filename;
        //    OpenFileDialog fileDialog = new OpenFileDialog();
        //    fileDialog.InitialDirectory = string.IsNullOrEmpty(filename) ? Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) : System.IO.Path.GetDirectoryName(filename);

        //    DialogResult result = fileDialog.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        filename = fileDialog.FileName;
        //    }
        //    return filename;
        //}

        public static bool SaveToFile(string fullName, string text)
        {
            bool result = false;
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fullName))
                {
                    file.Write(text);
                }

                result = true;

            }
            catch (Exception Ex)
            {
                ex = Ex;
                result = false;
            }

            return result;
        }

        public static bool IsValidFilename(string testName)
        {
            if (string.IsNullOrEmpty(testName)) { return false; };
            Regex containsABadCharacter = new Regex("["
                  + Regex.Escape(new string(System.IO.Path.GetInvalidPathChars())) + "]");
            if (containsABadCharacter.IsMatch(testName)) { return false; };

            return true;
        }

        public static bool ReadFromXML<t>(ref t classObj, string filename)
        {
            bool result = false;
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
                    result = classObj != null;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            xs = null;

            return result;
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
                    // SystemMessage = ex.Message;
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
                // SystemMessage = "Emptyfilename.";
            }

        }

        public static void ReadXMLFromString<T>(T rec, string xml)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xs = null;
                byte[] byteArray = Encoding.ASCII.GetBytes(xml);
                MemoryStream stream = new MemoryStream(byteArray);
                xs = new System.Xml.Serialization.XmlSerializer(rec.GetType());
                rec = (T)xs.Deserialize(stream);
            }
            catch (Exception ex)
            {
                string mess = ex.ToString();
            }
        }

    }
}
