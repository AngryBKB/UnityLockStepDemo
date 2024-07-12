﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class RecordSystemBase :SystemBase
{
    public abstract void Record(int frame,EntityBase entity);

    public abstract void Record(int frame);

    public abstract void RevertToFrame(int frame);

    public abstract void ClearAfter(int frame);

    public abstract void ClearBefore(int frame);

    public abstract MomentComponentBase GetRecord(int id,int frame);

    public abstract void PrintRecord(int id);
}
