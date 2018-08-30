using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTwo
{
    public interface IObserver
    {
        void Update(float temp, float hum, float press);
    }
}
