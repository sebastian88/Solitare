﻿using Solitaire.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Lib.FunctionalModels.Stacks
{
  public interface PopableStack
  {
    bool IsEmpty();
    Card ViewTopCard();
    Card PopTopCard();
  }
}
