using System;
using System.Collections.Generic;
using System.Text;

namespace lv2
{
    class Termin
    {
        private string name;
        private DateTime time;
        private TimeSpan duration;

        public Termin(string name, DateTime time, TimeSpan duration)
        {
            this.name = name;
            this.time = time;
            this.duration = duration;
        }
        public string Name()
        {
            return name;
        }
        public DateTime Time()
        {
            return time;
        }
        public TimeSpan Duration()
        {
            return duration;
        }
        public void odgoda(DateTime vrijeme)
        {
            time = vrijeme;
        }
        public static List<Termin> SortAscending(List<Termin> list)
        {
            list.Sort((a, b) => a.time.CompareTo(b));
            return list;
        }
        
    }
}
