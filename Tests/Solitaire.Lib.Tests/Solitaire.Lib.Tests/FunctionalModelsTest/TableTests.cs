﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Solitaire.Lib.Models;
using Solitaire.Lib.FunctionalModels.Tables;

namespace Solitaire.Lib.Tests.FunctionalModelsTest
{
  [TestClass]
  public class TableTests
  {
    private List<Card> GenerateDeck()
    {
      List<Card> cards = new List<Card>();
      for (int i = 1; i <= 4; i++)
      {
        for (int j = 1; j <= 13; j++)
        {
          cards.Add(new Card((Enums.Values)j, (Enums.Suits)i, false));
        }
      }

      return cards;
    }

    [TestMethod]
    public void Deal_CheckFirstStackCount_ReturnsOne()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.AreEqual(1, table.GetTableauStack(0).Count());
    }

    [TestMethod]
    public void Deal_CheckSecondStackCount_ReturnsTwo()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.AreEqual(2, table.GetTableauStack(1).Count());
    }

    [TestMethod]
    public void Deal_CheckSeventhStackCount_ReturnsSeven()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.AreEqual(7, table.GetTableauStack(6).Count());
    }

    [TestMethod]
    public void Deal_CheckFirstStackFirstCard_IsFaceUp()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.IsTrue(table.GetTableauStack(0).ViewTopCard().IsFaceUp);
    }

    [TestMethod]
    public void Deal_CheckHandCount_ReturnsTwentyFour()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.AreEqual(24, table.GetHand().Count());
    }

    [TestMethod]
    public void Deal_CheckFirstFoundationStack_IsNotNull()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.IsNotNull(table.GetFoundationStack(0));
    }

    public void AvailableMoves_CountMoves_IsNotNull()
    {
      Table table = new Table();

      table.Deal(GenerateDeck());

      Assert.IsNotNull(table.GetAvailableMoves());
    }
  }
}
