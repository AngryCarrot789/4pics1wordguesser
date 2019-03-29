using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPOWGuesser
{
    public class MainViewModel
    {
        public GenerateWords generateWords { get; set; }
        public MainViewModel()
        {
            generateWords = new GenerateWords();
        }
    }
}
