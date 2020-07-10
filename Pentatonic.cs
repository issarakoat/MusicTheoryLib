using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Pentatonic
    {
        public List<Note> Major(string note)
        {
            MajorScale majorscale = new MajorScale();
            List<Note> temp = majorscale.GetNotesInMajorScale(note);
            List<Note> list = new List<Note>();
            list.Add(temp[0]);
            list.Add(temp[1]);
            list.Add(temp[2]);
            list.Add(temp[4]);
            list.Add(temp[5]);
            list.Add(temp[0]);
            return list;

        }
        public List<Note> Minor(string note)
        {
            Mode mode = new Mode();
            List<Note> temp = mode.Aeolian(note);
            List<Note> list = new List<Note>();
            list.Add(temp[0]);
            list.Add(temp[2]);
            list.Add(temp[3]);
            list.Add(temp[4]);
            list.Add(temp[6]);
            list.Add(temp[0]);
            return list;

        }
        /// <summary>
        /// japanese scale C = {C,Db,F,G,Bb}
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public List<Note> Sen(string note)
        {
            Mode mode = new Mode();
            List<Note> temp = mode.Mixolydian(note);
            List<Note> temp1 = mode.Phrygian(note);
            List<Note> list = new List<Note>();
            list.Add(temp1[0]);
            list.Add(temp1[1]);
            list.Add(temp1[3]);
            list.Add(temp[4]);
            list.Add(temp1[6]);
            list.Add(temp1[0]);
            return list;
        }
        public List<Note> Hirajoshi(string note)
        {
            Mode mode = new Mode();
            List<Note> temp = mode.Mixolydian(note);
            List<Note> temp1 = mode.Phrygian(note);
            List<Note> list = new List<Note>();
            list.Add(temp1[0]);
            list.Add(temp1[1]);
            list.Add(temp1[3]);
            list.Add(temp[4]);
            list.Add(temp1[5]);
            list.Add(temp1[0]);
            return list;
        }
        public List<Note> Melodic(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Dorian(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[1]);
            list.Add(t[2]);
            list.Add(t[4]);
            list.Add(t[5]);
            list.Add(t[0]);
            return list;
        }
        public List<Note> Blues(string note)
        {
            Mode mode = new Mode();
            List<Note> temp = mode.Aeolian(note);
            List<Note> tt = mode.Aeolian(temp[2].name);
            List<Note> list = new List<Note>();
            list.Add(temp[0]);
            list.Add(temp[2]);
            list.Add(temp[3]);
            list.Add(tt[2]);
            list.Add(temp[4]);
            list.Add(temp[6]);
            list.Add(temp[0]);
            return list;
        }
    }
}
