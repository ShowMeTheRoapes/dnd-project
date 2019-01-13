using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace dnd_project.Core
{
    public class SaverLoader
    {
        /// <summary>
        /// Writes the given object instance to a binary file.
        /// Object type (and all child types) must be decorated with the [Serializable] attribute.
        /// To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.
        /// </summary>
        /// <typeparam name="T">The type of object being written to the binary file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the binary file.</param>
        public static void WriteToBinaryFile<T>(string fileDirectory, string fileName, T objectToWrite)
        {
            fileDirectory = Environment.ExpandEnvironmentVariables(fileDirectory);
            if (!Directory.Exists(fileDirectory))
            {
                string parentDir = fileDirectory.Substring(0, fileDirectory.LastIndexOf(@"\"));
                AddDirectorySecurity(parentDir, FileSystemRights.CreateDirectories, AccessControlType.Allow);
                Directory.CreateDirectory(fileDirectory);
            }

            if (!fileDirectory.EndsWith(@"\"))
            {
                fileDirectory += @"\";
            }

            using (Stream stream = File.Open(fileDirectory + fileName, FileMode.Create))
            { 
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the binary file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            filePath = Environment.ExpandEnvironmentVariables(filePath);
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Updates security on a file so application is allowed to create directories, and save.
        /// </summary>
        /// <param name="fileDirectory">path to the file directory</param>
        /// <param name="rights">the permissions allowed</param>
        /// <param name="controlType">is access given</param>
        public static void AddDirectorySecurity(string fileDirectory, FileSystemRights rights, AccessControlType controlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(fileDirectory);

            // Get a DirectorySecurity object that represents the 
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings. 
            dSecurity.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().Name, rights, controlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
