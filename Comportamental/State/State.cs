using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
