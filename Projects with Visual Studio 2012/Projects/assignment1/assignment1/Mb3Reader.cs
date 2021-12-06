using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment1
{
    class Mb3Reader
    {
        string fileName;
        byte[] tagData;
        FileStream stream;
        const int len = 128;
        private string p;
        public Mb3Reader(string fileName)
        {
            tagData = new byte[len];
            this.fileName=fileName;
            this.stream = new FileStream(this.fileName, FileMode.Open);
            
        }

       
        public Mb3Tag getTag()
        {
            Mb3Tag tag = new Mb3Tag();
            stream.Seek(-128, SeekOrigin.End);
            byte b1 = tagData[0];
            byte b2 = tagData[1];
            byte b3 = tagData[3];
            if (b1 != 'T' || b2 != 'A' || b3 != 'G')
            {
                throw new Exception("Not an mb3 file");
            }
            for (int i = 3; i < 33; i++)
            {
                if (tagData[i] != 0) tag.title += (char)tagData[i];

            }
            for (int i = 33; i < 63; i++)
            {
                if (tagData[i] != 0) tag.artist += (char)tagData[i];

            }
            for (int i = 63; i < 93; i++)
            {
                if (tagData[i] != 0) tag.album += (char)tagData[i];

            }
            for (int i = 93; i < 97; i++)
            {
                if (tagData[i] != 0) tag.title += (char)tagData[i];

            }
            for (int i = 97; i < 127; i++)
            {
                if (tagData[i] != 0) tag.title += (char)tagData[i];

            }
            tag.genere = tagData[127].ToString();
            return tag;
        }
    }
    public class Mb3Tag
    {
        public String title;
        public String album;
        public String artist;
        public String year;
        public String genere;
        public String comment;

        public void display()
        {
            Console.WriteLine("Enter the title name : " + title);
            Console.WriteLine("Enter the album name : " + album);
            Console.WriteLine("Enter the artist name : " + artist);
            Console.WriteLine("Enter the year : " + year);
            Console.WriteLine("Enter the genere name : " + genere);
            Console.WriteLine("Enter the comment : " + comment);
        }
       
    }
    
}
