using System;
using System.Collections.Generic;


namespace MusicTheory
{
    public class Mode
    {

        public List<Note> Ionion(string note)
        {
            MajorScale temp = new MajorScale();
            return temp.GetNotesInMajorScale(note);
        }
        private List<Note> Helper_Calculate(int num,List<Note> list_input)
        {           
            List<Note> To_return = new List<Note>();
            for (int i = num; i < num+8; i++)
            {
                To_return.Add(list_input[i]);
            }
            return To_return;
        }
        public List<Note> Dorian(string note)
        {
            List<Note> temp = new List<Note>();
            switch (note)
            {
                case "C":
                    MajorScale Bb = new MajorScale();
                    temp = Bb.GetNotesInMajorScale("Bb");
                    return Helper_Calculate(1, temp);
                case "F":
                    MajorScale Eb = new MajorScale();
                    temp = Eb.GetNotesInMajorScale("Eb");
                    return Helper_Calculate(1, temp);
                case "Bb":
                    MajorScale Ab = new MajorScale();
                    temp = Ab.GetNotesInMajorScale("Ab");
                    return Helper_Calculate(1, temp);
                case "Eb":
                    MajorScale Db = new MajorScale();
                    temp = Db.GetNotesInMajorScale("Db");
                    return Helper_Calculate(1, temp);
                case "Ab":
                    MajorScale Gb = new MajorScale();
                    temp = Gb.GetNotesInMajorScale("Gb");
                    return Helper_Calculate(1, temp);
                case "Db":
                    MajorScale Cb = new MajorScale();
                    temp = Cb.GetNotesInMajorScale("Cb");
                    return Helper_Calculate(1, temp);
                case "Gb":
                    MajorScale Fb = new MajorScale();
                    temp = Fb.GetNotesInMajorScale("Fb");
                    return Helper_Calculate(1, temp);
                case "Cb":
                    MajorScale Bbb = new MajorScale();
                    temp = Bbb.GetNotesInMajorScale("Bbb");
                    return Helper_Calculate(1, temp);
                case "Fb":
                    MajorScale Ebb = new MajorScale();
                    temp = Ebb.GetNotesInMajorScale("Ebb");
                    return Helper_Calculate(1, temp);
                case "G":
                    MajorScale F = new MajorScale();
                    temp = F.GetNotesInMajorScale("F");
                    return Helper_Calculate(1, temp);
                case "D":
                    MajorScale C = new MajorScale();
                    temp = C.GetNotesInMajorScale("C");
                    return Helper_Calculate(1, temp);
                case "A":
                    MajorScale G = new MajorScale();
                    temp = G.GetNotesInMajorScale("G");
                    return Helper_Calculate(1, temp);
                case "E":
                    MajorScale D = new MajorScale();
                    temp = D.GetNotesInMajorScale("D");
                    return Helper_Calculate(1, temp);
                case "B":
                    MajorScale A = new MajorScale();
                    temp = A.GetNotesInMajorScale("A");
                    return Helper_Calculate(1, temp);
                case "F#":
                    MajorScale E = new MajorScale();
                    temp = E.GetNotesInMajorScale("E");
                    return Helper_Calculate(1, temp);
                case "C#":
                    MajorScale B = new MajorScale();
                    temp = B.GetNotesInMajorScale("B");
                    return Helper_Calculate(1, temp);
                case "G#":
                    MajorScale F_sharp = new MajorScale();
                    temp = F_sharp.GetNotesInMajorScale("F#");
                    return Helper_Calculate(1, temp);
                case "D#":
                    MajorScale C_sharp = new MajorScale();
                    temp = C_sharp.GetNotesInMajorScale("C#");
                    return Helper_Calculate(1, temp);
                case "A#":
                    MajorScale G_sharp = new MajorScale();
                    temp = G_sharp.GetNotesInMajorScale("G#");
                    return Helper_Calculate(1, temp);
                case "E#":
                    MajorScale D_sharp = new MajorScale();
                    temp = D_sharp.GetNotesInMajorScale("D#");
                    return Helper_Calculate(1, temp);
                case "B#":
                    MajorScale A_sharp = new MajorScale();
                    temp = A_sharp.GetNotesInMajorScale("A#");
                    return Helper_Calculate(1, temp);
            }
            throw new Exception("Dorian exception");
        }
        public List<Note> Phrygian(string note)
        {

            List<Note> temp = new List<Note>();
            switch (note)
            {
                case "C":
                    MajorScale Ab = new MajorScale();
                    temp = Ab.GetNotesInMajorScale("Ab");
                    return Helper_Calculate(2, temp);
                case "F":
                    MajorScale Db = new MajorScale();
                    temp = Db.GetNotesInMajorScale("Db");
                    return Helper_Calculate(2, temp);
                case "Bb":
                    MajorScale Gb = new MajorScale();
                    temp = Gb.GetNotesInMajorScale("Gb");
                    return Helper_Calculate(2, temp);
                case "Eb":
                    MajorScale Cb = new MajorScale();
                    temp = Cb.GetNotesInMajorScale("Cb");
                    return Helper_Calculate(2, temp);
                case "Ab":
                    MajorScale Fb = new MajorScale();
                    temp = Fb.GetNotesInMajorScale("Fb");
                    return Helper_Calculate(2, temp);
                case "Db":
                    MajorScale Bbb = new MajorScale();
                    temp = Bbb.GetNotesInMajorScale("Bbb");
                    return Helper_Calculate(2, temp);
                case "Gb":
                    MajorScale Ebb = new MajorScale();
                    temp = Ebb.GetNotesInMajorScale("Ebb");
                    return Helper_Calculate(2, temp);
                case "Cb":
                    MajorScale Abb = new MajorScale();
                    temp = Abb.GetNotesInMajorScale("Abb");
                    return Helper_Calculate(2, temp);
                case "Fb":
                    MajorScale Dbb = new MajorScale();
                    temp = Dbb.GetNotesInMajorScale("Dbb");
                    return Helper_Calculate(2, temp);
                case "G":
                    MajorScale Eb = new MajorScale();
                    temp = Eb.GetNotesInMajorScale("Eb");
                    return Helper_Calculate(2, temp);
                case "D":
                    MajorScale Bb = new MajorScale();
                    temp = Bb.GetNotesInMajorScale("Bb");
                    return Helper_Calculate(2, temp);
                case "A":
                    MajorScale F = new MajorScale();
                    temp = F.GetNotesInMajorScale("F");
                    return Helper_Calculate(2, temp);
                case "E":
                    MajorScale C = new MajorScale();
                    temp = C.GetNotesInMajorScale("C");
                    return Helper_Calculate(2, temp);
                case "B":
                    MajorScale G = new MajorScale();
                    temp = G.GetNotesInMajorScale("G");
                    return Helper_Calculate(2, temp);
                case "F#":
                    MajorScale D = new MajorScale();
                    temp = D.GetNotesInMajorScale("D");
                    return Helper_Calculate(2, temp);
                case "C#":
                    MajorScale A = new MajorScale();
                    temp = A.GetNotesInMajorScale("A");
                    return Helper_Calculate(2, temp);
                case "G#":
                    MajorScale E = new MajorScale();
                    temp = E.GetNotesInMajorScale("E");
                    return Helper_Calculate(2, temp);
                case "D#":
                    MajorScale B = new MajorScale();
                    temp = B.GetNotesInMajorScale("B");
                    return Helper_Calculate(2, temp);
                case "A#":
                    MajorScale F_sharp = new MajorScale();
                    temp = F_sharp.GetNotesInMajorScale("F#");
                    return Helper_Calculate(2, temp);
                case "E#":
                    MajorScale C_sharp = new MajorScale();
                    temp = C_sharp.GetNotesInMajorScale("C#");
                    return Helper_Calculate(2, temp);
                case "B#":
                    MajorScale G_sharp = new MajorScale();
                    temp = G_sharp.GetNotesInMajorScale("G#");
                    return Helper_Calculate(2, temp);
            }
            throw new Exception("Phrygian exception");
        }
        public List<Note> Lydian(string note)
        {
            List<Note> temp = new List<Note>();
            switch (note)
            {
                case "C":
                    MajorScale G = new MajorScale();
                    temp = G.GetNotesInMajorScale("G");
                    return Helper_Calculate(3, temp);
                case "F":
                    MajorScale C = new MajorScale();
                    temp = C.GetNotesInMajorScale("C");
                    return Helper_Calculate(3, temp);
                case "Bb":
                    MajorScale F = new MajorScale();
                    temp = F.GetNotesInMajorScale("F");
                    return Helper_Calculate(3, temp);
                case "Eb":
                    MajorScale Bb = new MajorScale();
                    temp = Bb.GetNotesInMajorScale("Bb");
                    return Helper_Calculate(3, temp);
                case "Ab":
                    MajorScale Eb = new MajorScale();
                    temp = Eb.GetNotesInMajorScale("Eb");
                    return Helper_Calculate(3, temp);
                case "Db":
                    MajorScale Ab = new MajorScale();
                    temp = Ab.GetNotesInMajorScale("Ab");
                    return Helper_Calculate(3, temp);
                case "Gb":
                    MajorScale Db = new MajorScale();
                    temp = Db.GetNotesInMajorScale("Db");
                    return Helper_Calculate(3, temp);
                case "Cb":
                    MajorScale Gb = new MajorScale();
                    temp = Gb.GetNotesInMajorScale("Gb");
                    return Helper_Calculate(3, temp);
                case "Fb":
                    MajorScale Cb = new MajorScale();
                    temp = Cb.GetNotesInMajorScale("Cb");
                    return Helper_Calculate(3, temp);
                case "G":
                    MajorScale D = new MajorScale();
                    temp = D.GetNotesInMajorScale("D");
                    return Helper_Calculate(3, temp);
                case "D":
                    MajorScale A = new MajorScale();
                    temp = A.GetNotesInMajorScale("A");
                    return Helper_Calculate(3, temp);
                case "A":
                    MajorScale E = new MajorScale();
                    temp = E.GetNotesInMajorScale("E");
                    return Helper_Calculate(3, temp);
                case "E":
                    MajorScale B = new MajorScale();
                    temp = B.GetNotesInMajorScale("B");
                    return Helper_Calculate(3, temp);
                case "B":
                    MajorScale F_sharp = new MajorScale();
                    temp = F_sharp.GetNotesInMajorScale("F#");
                    return Helper_Calculate(3, temp);
                case "F#":
                    MajorScale C_sharp = new MajorScale();
                    temp = C_sharp.GetNotesInMajorScale("C#");
                    return Helper_Calculate(3, temp);
                case "C#":
                    MajorScale G_sharp = new MajorScale();
                    temp = G_sharp.GetNotesInMajorScale("G#");
                    return Helper_Calculate(3, temp);
                case "G#":
                    MajorScale D_sharp = new MajorScale();
                    temp = D_sharp.GetNotesInMajorScale("D#");
                    return Helper_Calculate(3, temp);
                case "D#":
                    MajorScale A_sharp = new MajorScale();
                    temp = A_sharp.GetNotesInMajorScale("A#");
                    return Helper_Calculate(3, temp);
                case "A#":
                    MajorScale E_sharp = new MajorScale();
                    temp = E_sharp.GetNotesInMajorScale("E#");
                    return Helper_Calculate(3, temp);
                case "E#":
                    MajorScale B_sharp = new MajorScale();
                    temp = B_sharp.GetNotesInMajorScale("B#");
                    return Helper_Calculate(3, temp);
                case "B#":
                    MajorScale F_double_sharp = new MajorScale();
                    temp = F_double_sharp.GetNotesInMajorScale("F##");
                    return Helper_Calculate(3, temp);
            }
            throw new Exception("Lydian exception");

        }
        public List<Note> Mixolydian(string note)
        {
            List<Note> temp = new List<Note>();
            switch (note)
            {
                case "C":
                    MajorScale F = new MajorScale();
                    temp = F.GetNotesInMajorScale("F");
                    return Helper_Calculate(4, temp);
                case "F":
                    MajorScale Bb = new MajorScale();
                    temp = Bb.GetNotesInMajorScale("Bb");
                    return Helper_Calculate(4, temp);
                case "Bb":
                    MajorScale Eb = new MajorScale();
                    temp = Eb.GetNotesInMajorScale("Eb");
                    return Helper_Calculate(4, temp);
                case "Eb":
                    MajorScale Ab = new MajorScale();
                    temp = Ab.GetNotesInMajorScale("Ab");
                    return Helper_Calculate(4, temp);
                case "Ab":
                    MajorScale Db = new MajorScale();
                    temp = Db.GetNotesInMajorScale("Db");
                    return Helper_Calculate(4, temp);
                case "Db":
                    MajorScale Gb = new MajorScale();
                    temp = Gb.GetNotesInMajorScale("Gb");
                    return Helper_Calculate(4, temp);
                case "Gb":
                    MajorScale Cb = new MajorScale();
                    temp = Cb.GetNotesInMajorScale("Cb");
                    return Helper_Calculate(4, temp);
                case "Cb":
                    MajorScale Fb = new MajorScale();
                    temp = Fb.GetNotesInMajorScale("Fb");
                    return Helper_Calculate(4, temp);
                case "Fb":
                    MajorScale Bbb = new MajorScale();
                    temp = Bbb.GetNotesInMajorScale("Bbb");
                    return Helper_Calculate(4, temp);
                case "G":
                    MajorScale C = new MajorScale();
                    temp = C.GetNotesInMajorScale("C");
                    return Helper_Calculate(4, temp);
                case "D":
                    MajorScale G = new MajorScale();
                    temp = G.GetNotesInMajorScale("G");
                    return Helper_Calculate(4, temp);
                case "A":
                    MajorScale D = new MajorScale();
                    temp = D.GetNotesInMajorScale("D");
                    return Helper_Calculate(4, temp);
                case "E":
                    MajorScale A = new MajorScale();
                    temp = A.GetNotesInMajorScale("A");
                    return Helper_Calculate(4, temp);
                case "B":
                    MajorScale E = new MajorScale();
                    temp = E.GetNotesInMajorScale("E");
                    return Helper_Calculate(4, temp);
                case "F#":
                    MajorScale B = new MajorScale();
                    temp = B.GetNotesInMajorScale("B");
                    return Helper_Calculate(4, temp);
                case "C#":
                    MajorScale F_sharp = new MajorScale();
                    temp = F_sharp.GetNotesInMajorScale("F#");
                    return Helper_Calculate(4, temp);
                case "G#":
                    MajorScale C_sharp = new MajorScale();
                    temp = C_sharp.GetNotesInMajorScale("C#");
                    return Helper_Calculate(4, temp);
                case "D#":
                    MajorScale G_sharp = new MajorScale();
                    temp = G_sharp.GetNotesInMajorScale("G#");
                    return Helper_Calculate(4, temp);
                case "A#":
                    MajorScale D_sharp = new MajorScale();
                    temp = D_sharp.GetNotesInMajorScale("D#");
                    return Helper_Calculate(4, temp);
                case "E#":
                    MajorScale A_sharp = new MajorScale();
                    temp = A_sharp.GetNotesInMajorScale("A#");
                    return Helper_Calculate(4, temp);
                case "B#":
                    MajorScale E_sharp = new MajorScale();
                    temp = E_sharp.GetNotesInMajorScale("E#");
                    return Helper_Calculate(4, temp);
            }
            throw new Exception("Mixolydian exception");

        }
        /// <summary>
        /// A Aeolian = A,B,C,D,E,F,G
        /// its also relative minor
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public List<Note> Aeolian(string note)
        {
            List<Note> temp = new List<Note>();
            switch (note)
            {
                case "C":
                    MajorScale Eb = new MajorScale();
                    temp = Eb.GetNotesInMajorScale("Eb");
                    return Helper_Calculate(5, temp);
                case "F":
                    MajorScale Ab = new MajorScale();
                    temp = Ab.GetNotesInMajorScale("Ab");
                    return Helper_Calculate(5, temp);
                case "Bb":
                    MajorScale Db = new MajorScale();
                    temp = Db.GetNotesInMajorScale("Db");
                    return Helper_Calculate(5, temp);
                case "Eb":
                    MajorScale Gb = new MajorScale();
                    temp = Gb.GetNotesInMajorScale("Gb");
                    return Helper_Calculate(5, temp);
                case "Ab":
                    MajorScale Cb = new MajorScale();
                    temp = Cb.GetNotesInMajorScale("Cb");
                    return Helper_Calculate(5, temp);
                case "Db":
                    MajorScale Fb = new MajorScale();
                    temp = Fb.GetNotesInMajorScale("Fb");
                    return Helper_Calculate(5, temp);
                case "Gb":
                    MajorScale Bbb = new MajorScale();
                    temp = Bbb.GetNotesInMajorScale("Bbb");
                    return Helper_Calculate(5, temp);
                case "Cb":
                    MajorScale Ebb = new MajorScale();
                    temp = Ebb.GetNotesInMajorScale("Ebb");
                    return Helper_Calculate(5, temp);
                case "Fb":
                    MajorScale Abb = new MajorScale();
                    temp = Abb.GetNotesInMajorScale("Abb");
                    return Helper_Calculate(5, temp);
                case "G":
                    MajorScale Bb = new MajorScale();
                    temp = Bb.GetNotesInMajorScale("Bb");
                    return Helper_Calculate(5, temp);
                case "D":
                    MajorScale F = new MajorScale();
                    temp = F.GetNotesInMajorScale("F");
                    return Helper_Calculate(5, temp);
                case "A":
                    MajorScale C = new MajorScale();
                    temp = C.GetNotesInMajorScale("C");
                    return Helper_Calculate(5, temp);
                case "E":
                    MajorScale G = new MajorScale();
                    temp = G.GetNotesInMajorScale("G");
                    return Helper_Calculate(5, temp);
                case "B":
                    MajorScale D = new MajorScale();
                    temp = D.GetNotesInMajorScale("D");
                    return Helper_Calculate(5, temp);
                case "F#":
                    MajorScale A = new MajorScale();
                    temp = A.GetNotesInMajorScale("A");
                    return Helper_Calculate(5, temp);
                case "C#":
                    MajorScale E = new MajorScale();
                    temp = E.GetNotesInMajorScale("E");
                    return Helper_Calculate(5, temp);
                case "G#":
                    MajorScale B = new MajorScale();
                    temp = B.GetNotesInMajorScale("B");
                    return Helper_Calculate(5, temp);
                case "D#":
                    MajorScale F_sharp = new MajorScale();
                    temp = F_sharp.GetNotesInMajorScale("F#");
                    return Helper_Calculate(5, temp);
                case "A#":
                    MajorScale C_sharp = new MajorScale();
                    temp = C_sharp.GetNotesInMajorScale("C#");
                    return Helper_Calculate(5, temp);
                case "E#":
                    MajorScale G_sharp = new MajorScale();
                    temp = G_sharp.GetNotesInMajorScale("G#");
                    return Helper_Calculate(5, temp);
                case "B#":
                    MajorScale D_sharp = new MajorScale();
                    temp = D_sharp.GetNotesInMajorScale("D#");
                    return Helper_Calculate(5, temp);
            }
            throw new Exception("Aeolian exception");

        }
        public List<Note> Locrian(string note)
        {
            List<Note> temp = new List<Note>();
            switch (note)
            {
                case "C":
                    MajorScale Db = new MajorScale();
                    temp = Db.GetNotesInMajorScale("Db");
                    return Helper_Calculate(6, temp);
                case "F":
                    MajorScale Gb = new MajorScale();
                    temp = Gb.GetNotesInMajorScale("Gb");
                    return Helper_Calculate(6, temp);
                case "Bb":
                    MajorScale Cb = new MajorScale();
                    temp = Cb.GetNotesInMajorScale("Cb");
                    return Helper_Calculate(6, temp);
                case "Eb":
                    MajorScale Fb = new MajorScale();
                    temp = Fb.GetNotesInMajorScale("Fb");
                    return Helper_Calculate(6, temp);
                case "Ab":
                    MajorScale Bbb = new MajorScale();
                    temp = Bbb.GetNotesInMajorScale("Bbb");
                    return Helper_Calculate(6, temp);
                case "Db":
                    MajorScale Ebb = new MajorScale();
                    temp = Ebb.GetNotesInMajorScale("Ebb");
                    return Helper_Calculate(6, temp);
                case "Gb":
                    MajorScale Abb = new MajorScale();
                    temp = Abb.GetNotesInMajorScale("Abb");
                    return Helper_Calculate(6, temp);
                case "Cb":
                    MajorScale Dbb = new MajorScale();
                    temp = Dbb.GetNotesInMajorScale("Dbb");
                    return Helper_Calculate(6, temp);
                case "Fb":
                    MajorScale Gbb = new MajorScale();
                    temp = Gbb.GetNotesInMajorScale("Gbb");
                    return Helper_Calculate(6, temp);
                case "G":
                    MajorScale Ab = new MajorScale();
                    temp = Ab.GetNotesInMajorScale("Ab");
                    return Helper_Calculate(6, temp);
                case "D":
                    MajorScale Eb = new MajorScale();
                    temp = Eb.GetNotesInMajorScale("Eb");
                    return Helper_Calculate(6, temp);
                case "A":
                    MajorScale Bb = new MajorScale();
                    temp = Bb.GetNotesInMajorScale("Bb");
                    return Helper_Calculate(6, temp);
                case "E":
                    MajorScale F = new MajorScale();
                    temp = F.GetNotesInMajorScale("F");
                    return Helper_Calculate(6, temp);
                case "B":
                    MajorScale C = new MajorScale();
                    temp = C.GetNotesInMajorScale("C");
                    return Helper_Calculate(6, temp);
                case "F#":
                    MajorScale G = new MajorScale();
                    temp = G.GetNotesInMajorScale("G");
                    return Helper_Calculate(6, temp);
                case "C#":
                    MajorScale D = new MajorScale();
                    temp = D.GetNotesInMajorScale("D");
                    return Helper_Calculate(6, temp);
                case "G#":
                    MajorScale A = new MajorScale();
                    temp = A.GetNotesInMajorScale("A");
                    return Helper_Calculate(6, temp);
                case "D#":
                    MajorScale E = new MajorScale();
                    temp = E.GetNotesInMajorScale("E");
                    return Helper_Calculate(6, temp);
                case "A#":
                    MajorScale B = new MajorScale();
                    temp = B.GetNotesInMajorScale("B");
                    return Helper_Calculate(6, temp);
                case "E#":
                    MajorScale F_sharp = new MajorScale();
                    temp = F_sharp.GetNotesInMajorScale("F#");
                    return Helper_Calculate(6, temp);
                case "B#":
                    MajorScale C_sharp = new MajorScale();
                    temp = C_sharp.GetNotesInMajorScale("C#");
                    return Helper_Calculate(6, temp);
            }
            throw new Exception("Locrian exception");

        }
    }
}
