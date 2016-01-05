using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci2.Core.ViewModels;

namespace Fibonacci2.Core.Tests
{
    [TestClass]
    public class MainViewViewModelTests
    {
        [TestMethod]
        public void ConstructionTest()
        {
            var viewModel = new MainViewViewModel();

            if(viewModel.LongMax >=1)
            {
                Assert.AreEqual(viewModel.Numbers[0], 1);
                Assert.AreEqual(viewModel.Numbers[1], 1);
            }
        }
    }
}
