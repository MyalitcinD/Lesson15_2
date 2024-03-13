using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int start;
        int step;
        int curr;
        public ArithProgression() { }
        public ArithProgression(int startvalue, int stepValue)
        {
            start = startvalue;
            step = stepValue;
            curr = startvalue;
        }
        public int GetNext()
        {
            curr += step;
            return curr;
        }

        public void Reset()
        {
            curr = start;
        }

        public void SetStart(int x)
        {
            start = x;
            curr = x;
        }
        public void SetStep(int x)
        {
            step = x;
        }
    }
    class GeomProgression : ISeries
    {
        int start;
        int commRatio;
        int curr;
        public GeomProgression() { }
        public GeomProgression(int StartValue, int CommonRatio)
        {
            start = StartValue;
            curr = StartValue;
            commRatio = CommonRatio;
        }
        public int GetNext()
        {
            curr = curr * commRatio;
            return curr;
        }

        public void Reset()
        {
            curr = start;
        }

        public void SetStart(int x)
        {
            start = x;
            curr = x;
        }
        public void SetCommRatio(int x)
        {
            commRatio = x;
        }
    }
}
