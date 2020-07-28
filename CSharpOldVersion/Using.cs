using System.Collections.Generic;
using System.IO;

namespace CSharpNewVersion
{
    class MyFile : StreamWriter
    {
        public bool IsDead { get; set; } = false;

        public MyFile(string path) : base(path)
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            IsDead = true;
        }
    }

    class Using
    {
        private MyFile myFile;

        private void WriteLines(IEnumerable<string> lines)
        {
            using (var file = new MyFile("test.txt"))
            {

                foreach (var line in lines)
                {
                    file.WriteLine(line);
                }

                myFile = file;
            }
        }
    }
}
