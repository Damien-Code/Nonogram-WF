using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Models
{
    public class History
    {
        private int _level;
        //private TimeSpan _time;
        private int _hintCount;
        private bool _usedSolver;

        public int Level
        {
            get => _level;
            set => _level = value;
        }
        public int HintCount
        {
            get => _hintCount;
            set => _hintCount = value;
        }
        public bool UsedSolver
        {
            get => _usedSolver;
            set => _usedSolver = value;
        }


        public History(int level, int hintCount, bool usedSolver)
        {
            Level = level;
            HintCount = hintCount;
            UsedSolver = usedSolver;
        }
    }
}
