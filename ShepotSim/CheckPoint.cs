using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShepotSim
{
    internal class CheckPoint
    {
        public int CheckPointId
        {
            get;
            set;
        }

        public string CheckPointName
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Channel
        {
            get;
            set;
        }

        public string InterceptionPlace
        {
            get;
            set;
        }

        public int SpeechLevel
        {
            get;
            set;
        }

        public double R
        {
            get;
            set;
        }

        public double W
        {
            get;
            set;
        }

        public bool SZY
        {
            get;
            set;
        }

        public string ElapsedTime
        {
            get;
            set;
        }

        public string DateOfCreate
        {
            get;
            set;
        }

        public bool PovData1
        {
            get;
            set;
        }
        public bool PovData2
        {
            get;
            set;
        }

        public int UserID
        {
            get;
            set;
        }
    }
}
