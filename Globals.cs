using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.CodeDom.Compiler;
using System.CodeDom;
using System.Text.RegularExpressions;

namespace TagExplorer
{
    static class Globals
    {
        //Define Global Variables
        public static string jsonFolders;
        public static string jsonTags;
        public static string jsonFiles;
        public static List<Folder> folders;
        public static List<FileTags> files;
        public static List<FileTags> fileTags;
        public static List<Tag> tags;
        public static FileTags currFile;
        public static List<FileTags> multiFiles;
        public static Stack<FileTags> lastFileTags;

        public static List<string> filterTags;
        public static List<string> warnings;

        public static string tagSeparator = "; "; //Separator for Tags in listview

        public static string jFolderPath = Application.StartupPath + "\\folderConfig.json";
        public static string jTagsPath = Application.StartupPath + "\\tagConfig.json";
        public static string jFilePath = Application.StartupPath + "\\fileConfig.json";

        public static bool settingsChanged;
        public static bool folderChanged;
        public static bool isResetTags;
        public static bool isChangeByClick;
        public static bool isFilterMode; //UNUSED
        public static int totalFiles;
        public static bool isMultiActive;

        public static bool betaMode = false;
        
        public static DataObject draggedFiles;

        public static List<DebugCount> debugCount = new List<DebugCount>();

        public static string invalidChars = new string(Path.GetInvalidFileNameChars());

        public static void populateFiles(BackgroundWorker bgWork = null)
        {
            if (bgWork == null)
            {
                bgWork = new BackgroundWorker();
            }


            //---- To find videos resolution; Used to placed in separate method, but to replace get all files method here
            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder shellFolder;

            List<string> allFolders = new List<string>();
            List<string> allFiles = new List<string>();
            Dictionary<int, string> shellHeaders = new Dictionary<int, string>();

            int errorFolders = 0;
            foreach (Folder item in folders)
            {
                if (Directory.Exists(item.path))
                {
                    allFolders.Add(item.path); //Add root Directories

                    string[] subdir = Directory.GetDirectories(item.path,"*",SearchOption.AllDirectories);
                    allFolders.AddRange(subdir); //Add root All Sub-Directories
                }
                else
                {
                    warnings.Add("\"" + item.path + "\" not found!");
                    errorFolders++;
                }
            }

            if (folders.Count <= errorFolders)
            {
                return;
            }

            totalFiles = 0;
            foreach (string x in allFolders)
            {
                
                totalFiles = totalFiles + Directory.GetFiles(x).Count();
                DebugCount dc = new DebugCount(x,totalFiles);
                debugCount.Add(dc);
            }

            if (totalFiles <= 0)
            {
                warnings.Add("No file(s) found in directory(s)!");
                return;
            }

            double progBGStep = (double)100 / (double)totalFiles;
            double currProg = 0;
            double lastStep = 0;
            bool tooLong = false;

            foreach (string fitem in allFolders)
            {
                shellFolder = shell.NameSpace(fitem);

                //To find out the header in shell 32
                if (shellHeaders.Count <= 0)
                {
                    for (int i = 0; i < short.MaxValue; i++)
                    {
                        string header = shellFolder.GetDetailsOf(null, i);
                        if (String.IsNullOrEmpty(header))
                            break;
                        if (header.Contains("Name") || header.Contains("Frame") || header.Contains("Path"))
                        {
                            shellHeaders.Add(i, header);
                        }
                    }
                }

                string[] folderFiles = Directory.GetFiles(fitem);
                foreach (string filename in folderFiles)
                {
                    //debugCount[debugCount.FindIndex(0, x => x.folder.Equals(fitem))].increaseAcc(); //#DEBUGONLY
                    string sFilename = Path.GetFileName(filename);
                    Shell32.FolderItem2 aa = null;

                    string fullPath = fitem + "\\" + sFilename;

                    if (fullPath.Length > 260)
                    {
                        continue;
                        tooLong = true;
                    }
                    FileAttributes attr = File.GetAttributes(fitem + "\\" + sFilename);


                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        continue; //is Directory
                    }
                    
                    var item = shellFolder.ParseName(sFilename);
                    string sFrameheight = shellFolder.GetDetailsOf(item, shellHeaders.FirstOrDefault(k => k.Value.Equals("Frame height")).Key);

                    int videoHeight = 0;
                    videoHeight = cIntNull(sFrameheight);
                    FileTags newFile = new FileTags(fitem, videoHeight, sFilename);
                    files.Add(newFile);

                    currProg = currProg + progBGStep;
                    if (currProg - lastStep < 1 || currProg > 100 ) //To make progress +1% only and not overlimit
                    {
                        continue;
                    }
                    lastStep = currProg;
                    System.Threading.Thread.Sleep(1); // if using sleep thread sometimes get stucked
                    bgWork.ReportProgress(Convert.ToInt32(currProg));
                }

                if (tooLong)
                {
                    //warnings.Add("
                }
            }

        }

        public static bool isValidFileName(string fName)
        {
            bool isValid = true;
            Regex containsABadCharacter = new Regex("[" + Regex.Escape(Globals.invalidChars) + "]");
            if (containsABadCharacter.IsMatch(fName))
            {
                isValid = false;
            }
            return isValid;
        }
        public static int cIntNull(string sFrameheight)
        {
            int iFrame = 0;
            if (sFrameheight == null || sFrameheight == "")
            {
                iFrame = 0;
            }
            else
            {
                iFrame = Convert.ToInt32(sFrameheight);
            }
            return iFrame;
        }
    }


    public class Folder
    {
        public string path;
    }

    public class FileTags
    {
        public string filename;
        public int resolution;
        public List<Tag> tags;
        public Folder folder;

        public FileTags(string pPath, int pResolution, string pFile)
        {
            folder = new Folder();
            folder.path = pPath;
            filename = pFile;
            resolution = pResolution;
            tags = new List<Tag>();
        }

        public void CopyFrom(FileTags copyFT)
        {
            folder = new Folder();
            folder.path = copyFT.folder.path;
            filename = copyFT.filename;
            resolution = copyFT.resolution;
            tags = new List<Tag>();
            foreach (Tag cTag in copyFT.tags)
            {
                tags.Add(cTag);
            }

        }

        public void addTags(string pTag)
        {
            Tag tt = Globals.tags.Find(fTag => fTag.text == pTag);
            if (tt != null)
            {
                bool isAdded = tags.Contains(tt);
                if (!isAdded) { tags.Add(tt); }
            }
        }
        public void delTags(string pTag)
        {
            Tag tt = tags.Find(fTag => fTag.text == pTag);
            if (tt != null)
            {
                tags.Remove(tt);
            }
        }
        public void clearTags()
        {
            tags.Clear();
        }

        public void updateTags(List<Tag> pTags)
        {
            tags = new List<Tag>();
            tags = pTags;
        }

        public bool containTags(List<string> pTags)
        {
            bool rsult = true;
            foreach (string iTag in pTags)
            {
                Tag tt = tags.Find(fTag => fTag.text == iTag);
                if (tt == null)
                {
                    rsult = false;
                    break;
                }
            }
            return rsult;
        }

        public bool isSameFile(FileTags pFile)
        {
            return filename.Equals(pFile.filename) && folder.path.Equals(pFile.folder.path);
        }

    }
    public class Tag
    {
        public int order;
        public string text;
    }

    public class DebugCount
    {
        public string folder;
        public int initCount;
        public int accCount;

        public DebugCount(string pFolder, int pInit)
        {
            folder = pFolder;
            initCount = pInit;
            accCount = 0;
        }

        public void increaseAcc()
        {
            accCount++;
        }
    }

}
