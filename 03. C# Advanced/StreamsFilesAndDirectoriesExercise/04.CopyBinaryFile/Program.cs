using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DEF_SIZE = 4096;
            //като се чете stream се използва buffer, като дължината по деф е 4096

            using (FileStream reader = new FileStream("./copyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../copied.png", FileMode.Create))
                //създаваме папката в която ще записваме 3 директории на зад
                {
                    byte[] buffer = new byte[DEF_SIZE];
                    while (reader.CanRead)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                        // може да копираме всякакви снимки(музика и т.н.), защото копираме байт по байт
                        // може много по-лесно с File.Copy(но по условие трябва без него)
                    }
                }
            }
        }
    }
}
