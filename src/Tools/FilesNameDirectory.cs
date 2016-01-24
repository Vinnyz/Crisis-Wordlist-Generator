//  Author:
//       Teeknofil <teeknofil@gmail.com>
//
//  Copyright (c) 2015 Teeknofil
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;

namespace crisis
{
    public class FilesNameDirectory
    {
        private static string[] filePath = new string[10];

        public static string[] FilePath
        {
            get { return FilesNameDirectory.filePath; }
            set { FilesNameDirectory.filePath = value; }
        }        
        

        private static string[] fileName = new string[10];

        public static string[] FileName
        {
            get { return FilesNameDirectory.fileName; }
            set { FilesNameDirectory.fileName = value; }
        }                 
        
        StreamWriter workFile;
        public StreamWriter WorkFile
        {
            get { return workFile; }
            set { workFile = value; }
        }

        private int numberFile = 1;
        public int NumberFile
        {
            get { return numberFile; }
            set { numberFile = value; }
        }

        private string[] locate;

        public string[] Locate
        {
            get { return locate; }
            set { locate = value; }
        }


        public FilesNameDirectory()
        {
                   
        }

       

         //A function that determines whether it is a Windows(false) or Linux (true) system
        public bool OsDetect() 
        {
            bool system = true;

            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            switch (pid)
            {
                case PlatformID.Win32NT:
                    case PlatformID.Win32S:
                    case PlatformID.Win32Windows:
                    case PlatformID.WinCE:

                    system = false;                   
                    break;

                    case PlatformID.Unix:

                    system = true;
                    break;
                    default:
                    Console.WriteLine("ERROR: This platform identifier is invalid.");
                    break;
            }
            return system;
        }

        public void FilesPathDirectory()
        {
            if (OsDetect() == true)
            {
                filePath[0] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/default";
                filePath [1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/crunch";
                filePath [2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/combination";
                filePath [3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/random";
                filePath [4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/variation";
                filePath [5] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/permutation";
                filePath [6] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/wifi";
                filePath [7] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/birthdate";                
                filePath [8] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"/crisis/leet_speak";
                
                fileName [0] = @"/default_";
                fileName [1] = @"/charset_";
                fileName [2] = @"/wordlist_";
                fileName [3] = @"/wordlist_";
                fileName [4] = @"/wordlist_";
                fileName [5] = @"/wordlist_";
                fileName [6] = @"/dico_wifi_"+Charset.CharsetName+"_";
                fileName [7] = @"/birthdate_";
                fileName [8] = @"/dico1337_";
            } 
            else
            {
                filePath [0] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\default";
                filePath [1] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\charset";
                filePath [2] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\combination";
                filePath [3] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\random";
                filePath [4] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\variation";
                filePath [5] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\permutation";                
                filePath [6] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\wifi";
                filePath [7] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\birthdate";
                filePath [8] = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\crisis\leet_speak";

                fileName [0] = @"\default_"; ;
                fileName [1] = @"\charset_";
                fileName [2] = @"\wordlist_";
                fileName [3] = @"\wordlist_";
                fileName [4] = @"\wordlist_";
                fileName [5] = @"\wordlist_";
                fileName [6] = @"\dico_wifi_" + Charset.CharsetName + "_";
                fileName [7] = @"\birthdate_";                
                fileName [8] = @"\dico1337_";                
            }
        }

        public void Setting_UpFile()
        {
            bool b = true;
            Tools obj = new Tools();

            while (b)
            {
                try
                {
                    if (!Directory.Exists(filePath[Parameter.TypesOfGeneration]))
                    {
                        System.IO.Directory.CreateDirectory(filePath[Parameter.TypesOfGeneration]);
                    }
                    else if (File.Exists(filePath[Parameter.TypesOfGeneration] + fileName[Parameter.TypesOfGeneration] + numberFile + ".txt"))
                    {
                        numberFile++;
                    }
                    else if (!Directory.Exists(filePath[Parameter.TypesOfGeneration] + fileName[Parameter.TypesOfGeneration] + numberFile + ".txt"))
                    {
                        workFile = new StreamWriter(filePath[Parameter.TypesOfGeneration] + fileName[Parameter.TypesOfGeneration] + numberFile + ".txt");
                        
                        locate = new string[] { " Generating output at" + obj.Hour() + " : " + FilesNameDirectory.FilePath[Parameter.TypesOfGeneration].ToString() + FilesNameDirectory.FileName[Parameter.TypesOfGeneration] + numberFile + ".txt" };
                        Console.WriteLine(locate[0].ToString());                         
                        
                        b = false;                      
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" {0} \n", e.Message);
                    Console.ResetColor();
                }

            } //End while
        }  //End Fonction



    }  //End class
} // End namespace;
