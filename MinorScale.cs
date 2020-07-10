using System.Collections.Generic;


namespace MusicTheory
{
    public class MinorScale
    {
        
        public Note Root { get; set; }
        
        public List<Note> Natural (string note)
        {
            Mode mode = new Mode();
            List<Note> list = mode.Aeolian(note);
            Root = list[0];
            return list;
            
        }
        public List<Note> Harmonic (string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Aeolian(note); 
            List<Note> tt = mode.Ionion(note);
            List<Note> list = mode.Aeolian(note);
            list[0] = t[0];
            list[1] = t[1];
            list[2] = t[2];
            list[3] = t[3];
            list[4] = t[4];
            list[5] = t[5];
            list[6] = tt[6];
            list[0] = t[0];
            return list;
        }
        public List<Note> Melodic (string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Aeolian(note);
            List<Note> tt = mode.Dorian(note);
            List<Note> ttt = mode.Ionion(note);
            List<Note> list = new List<Note>();
            //the first 6 notes are from dorian
            list.Add(tt[0]);
            list.Add(tt[1]);
            list.Add(tt[2]);
            list.Add(tt[3]);
            list.Add(tt[4]);
            list.Add(tt[5]);
            // the 7th note is from Ionion
            list.Add(ttt[6]);
            // these are just natural minor(Aeolian)
            list.Add(t[0]);
            Root = list[0];
            return list;
        }
    }
}
