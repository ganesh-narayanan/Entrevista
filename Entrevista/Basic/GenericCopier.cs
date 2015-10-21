// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericCopier.cs" company="">
//   
// </copyright>
// <summary>
//   The generic copier.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GaneshNarayanan.Entrevista.Basic
{
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security;

    /// <summary>The generic copier.</summary>
    /// <typeparam name="T">Any type of object</typeparam>
    public static class GenericCopier<T>
    {
        /// <summary>The deep copy.</summary>
        /// <param name="objectToCopy">The object to copy.</param>
        /// <returns>The <see cref="T"/>.</returns>
        /// <exception cref="SerializationException">An error has occurred during serialization, such as if an object in the <paramref name="graph"/> parameter is not marked as serializable. </exception>
        /// <exception cref="SecurityException">The caller does not have the required permission. </exception>
        public static T DeepCopy(object objectToCopy)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, objectToCopy);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (T)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }
}