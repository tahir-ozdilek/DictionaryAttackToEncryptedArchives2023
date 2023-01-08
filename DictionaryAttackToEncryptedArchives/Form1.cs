using SevenZip;
using SharpCompress;
using SharpCompress.Common;
using SharpCompress.Compressors.ADC;
using SharpCompress.Readers;
using System.IO;
using System.Reflection;
using System.Text;

namespace DictionaryAttackToEncryptedArchives
{
    public partial class DictionaryAttackToArchiveFiles : Form
    {
        public DictionaryAttackToArchiveFiles()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            SevenZipBase.SetLibraryPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Environment.CurrentDirectory, "7z.dll"));

            string dictionaryPath = dicpathBox.Text;
            string filePath = arcPathBox.Text;
            string fileExtension = ""; //we will have to check if the file chosen is ok
            fileExtension = Path.GetExtension(filePath);

            bool isFound = false;
            int counter = 0;
            String pass;
            using (Stream dicStream = File.OpenRead(dictionaryPath))
            using (StreamReader dicStreamReader = new StreamReader(dicStream, Encoding.UTF8, true))
            while ((pass = dicStreamReader.ReadLine()) != null)
            {
                if (fileExtension == ".zip" || fileExtension == ".GZip" || fileExtension == ".BZip2" ||
                    fileExtension == ".Tar" || fileExtension == ".Rar" || fileExtension == "LZip" || fileExtension == "XZ")
                {
                    ReaderOptions ops = new ReaderOptions();
                    ops.Password = pass;

                    using (Stream archStream = File.OpenRead(filePath))
                    using (IReader reader = ReaderFactory.Open(archStream, ops))
                    {
                        while (reader.MoveToNextEntry())
                        {
                            if (!reader.Entry.IsDirectory)
                            {
                                try
                                {
                                    reader.WriteEntryToDirectory(@".\", new ExtractionOptions()
                                    {
                                        ExtractFullPath = true,
                                        Overwrite = true
                                    });
                                    isFound = true;
                                    resultLabel.Text = "Found Pass: " + pass;
                                }
                                catch
                                {
                                    counter++;
                                    counterLabel.Text = "Tried Passwords: " + counter.ToString();
                                }
                            }
                        }
                    }
                }
                else if (fileExtension == ".7z")
                {
                    try
                    {
                        SevenZipExtractor extractor = new SevenZipExtractor(filePath, pass);
                        extractor.ExtractArchive(@".\");

                        isFound = true;
                        resultLabel.Text = "Found Pass: " + pass;
                    }
                    catch
                    {
                        counter++;
                        counterLabel.Text = "Tried Passwords: " + counter.ToString();
                    }
                }
            }
            if(!isFound)
            {
                resultLabel.Text = "Result: not found";
            }
        }
    }
}