using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Spanish
    {
        public List<Note> SpanishScale(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Phrygian(note);
            List<Note> tt = mode.Ionion(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[1]);
            list.Add(tt[2]);
            list.Add(t[3]);
            list.Add(t[4]);
            list.Add(t[5]);
            list.Add(t[6]);
            list.Add(t[0]);
            return list;
        }
    }
}
