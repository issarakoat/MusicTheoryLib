using System.Collections.Generic;

namespace MusicTheory
{
    public class Bebop
    {
        string Root { get; set; }
        public List<Note> Mixolydian(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Mixolydian(note);
            List<Note> tt = mode.Ionion(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[1]);
            list.Add(t[2]);
            list.Add(t[3]);
            list.Add(t[4]);
            list.Add(t[5]);
            list.Add(t[6]);
            list.Add(tt[6]);
            list.Add(t[0]);
            return list;
        }
        public List<Note> Dorian(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Dorian(note);
            List<Note> tt = mode.Ionion(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[1]);
            list.Add(t[2]);
            list.Add(tt[2]); //major 3rd
            list.Add(t[3]);           
            list.Add(t[4]);
            list.Add(t[5]);
            list.Add(t[6]);
            list.Add(t[0]);
            return list;
        }
        public List<Note> Major(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Ionion(note);
            List<Note> tt = mode.Aeolian(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[1]);
            list.Add(t[2]);
            list.Add(t[3]); 
            list.Add(t[4]);
            list.Add(tt[5]);
            list.Add(t[5]);
            list.Add(t[6]);
            list.Add(t[0]);
            return list;
        }
    }
}
