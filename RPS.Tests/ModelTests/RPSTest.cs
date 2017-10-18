using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace RockPaperScissor.Tests
{
  [TestClass]
  public class RockPaperScissorTest : IDisposable
  {
      [TestMethod]
      public void IsRockWinner_RockVsScissor_True()
      {
        RockPaperScissor TestRockPaperScissor = new RockPaperScissor();
        Assert.AreEqual(false, testLeapYear.)
      }
      [TestMethod]
      public void WhosTheWinner_PaperVsRock_True()
      {
        RockPaperScissor TestRockPaperScissor = new RockPaperScissor();
        Assert.AreEqual(true, TestRockPaperScissor.WhosTheWinner());
      }
      [TestMethod]
      public void WhosTheWinner_ScissorVsPaper_True()
      {
        RockPaperScissor TestRockPaperScissor = new RockPaperScissor();
        Assert.AreEqual(true, TestRockPaperScissor.WhosTheWinner());

    // [TestMethod]
    // public void IsLeapYear_NumberNotDivisibleByFour_False()
    // {
    //   LeapYear testLeapYear = new LeapYear();
    //   Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    // }
    // [TestMethod]
    // public void IsLeapYear_MultiplesOfOneHundred_False()
    // {
    //   LeapYear testLeapYear = new LeapYear();
    //   Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    // }
    //   [TestMethod]
    //   public void IsLeapYear_MultiplesOfFourHundred_True()
    //   {
    //     LeapYear testLeapYear = new LeapYear();
    //     Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
      }
    }
  }
