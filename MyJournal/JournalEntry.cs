using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal
{
    class JournalEntry
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                LastEditTime = DateTime.Now;
            }
        }
        public DateTime LastEditTime { get; set; }
    }
}
