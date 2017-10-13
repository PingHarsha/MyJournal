using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal
{
    class Journal
    {
        public static string journalMessage = "Welcome to my Journal";
        private static string journalPassword = "1234";
        private static bool journalUnlocked = false;

        private static JournalEntry entry = new JournalEntry();
        public static JournalEntry Entry
        {
            get
            {
                if(journalUnlocked)
                {
                    return entry;
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool UnlockJournal(string password)
        {
            if(journalPassword == password)
            {
                journalUnlocked = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void LockJournal()
        {
            journalUnlocked = false;
        }

    }
}
