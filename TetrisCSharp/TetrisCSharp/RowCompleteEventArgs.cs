﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisCSharp
  {
  class RowCompleteEventArgs:EventArgs
    {
    internal RowCompleteEventArgs(int rowAnzahl)
      {
      RowsComplete = rowAnzahl;
      }
    public int RowsComplete { get; }
    }
  }
