using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReaderConsoleProject.Services
{
    public class ReaderServices
    {
        private readonly string[] rows;
        public ReaderServices()
        {
            rows = File.ReadAllLines(@"");
        }


        public void Handle()
        {

        }

    }
}
