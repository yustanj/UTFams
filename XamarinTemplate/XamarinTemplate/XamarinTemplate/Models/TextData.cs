using PCLStorage;
using System;

namespace XamarinTemplate.Models
{
    public class TextData
    {
        public static void SaveData(dynamic[] data)
        {
            try
            {
                // get hold of the file system
                IFolder rootFolder = FileSystem.Current.LocalStorage;

                // create a folder, if one does not exist already
                IFolder folder = rootFolder.CreateFolderAsync(GlobalVar.DataFolderName, CreationCollisionOption.OpenIfExists).GetAwaiter().GetResult();

                // create a file, overwriting any existing file
                IFile file = folder.CreateFileAsync(GlobalVar.DataFileName + ".txt", CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();

                // populate the file with some text
                string alltext = "";
                foreach (var item in data)
                {
                    alltext += item + "|";
                }
                alltext = alltext.Substring(0, alltext.Length - 1);
                file.WriteAllTextAsync(alltext).GetAwaiter();
            }
            catch (Exception exc)
            { }
        }
        public static void Reset()
        {
            try
            {
                IFolder rootFolder = FileSystem.Current.LocalStorage;

                // create a folder, if one does not exist already
                IFolder folder = rootFolder.CreateFolderAsync(GlobalVar.DataFolderName, CreationCollisionOption.OpenIfExists).GetAwaiter().GetResult();

                // create a file, overwriting any existing file
                IFile file = folder.CreateFileAsync(GlobalVar.DataFileName + ".txt", CreationCollisionOption.ReplaceExisting).GetAwaiter().GetResult();

                GlobalVar.DataToSave = new dynamic[] { null, "false" };
            }
            catch (Exception exc)
            { }
        }
        public static void LoadData()
        {
            try
            {
                // get hold of the file system
                IFolder rootFolder = FileSystem.Current.LocalStorage;

                // create a folder, if one does not exist already
                IFolder folder = rootFolder.CreateFolderAsync(GlobalVar.DataFolderName, CreationCollisionOption.OpenIfExists).GetAwaiter().GetResult();

                // create a file, overwriting any existing file
                IFile file = folder.CreateFileAsync(GlobalVar.DataFileName + ".txt", CreationCollisionOption.OpenIfExists).GetAwaiter().GetResult();

                string alltext = file.ReadAllTextAsync().GetAwaiter().GetResult();
                dynamic[] alldata = alltext.Split('|');

                GlobalVar.DataToSave = alldata;

                //GlobalVar.isDataLoaded = true;
            }
            catch (Exception exc)
            {
            }
        }
    }
}