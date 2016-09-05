using System.IO;

namespace Helpers
{
    public class Streaming
    {
        public Stream LoadFromDisk(string filename)
        {
            MemoryStream stream = new MemoryStream();
            using (FileStream strFile = File.OpenRead(filename))
            {
                strFile.CopyTo(stream);
                stream.Seek(0, SeekOrigin.Begin);
            }

            return stream;
        }

        public void SaveToDisk(Stream strPerson, string filename)
        {
            using (Stream file = File.Create(filename))
            {
                CopyStream(strPerson, file);
            }
        }

        private void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }
    }
}
