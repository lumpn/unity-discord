//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//---------------------------------------- 
using Lumpn.Discord.Utils;
using NUnit.Framework;
using UnityEngine;

namespace Lumpn.Discord.Tests
{
    [TestFixture]
    public sealed class ColorUtilsTest
    {
        [Test]
        public void TestColorConversion()
        {
            var cyan = ColorUtils.ToColorCode(Color.cyan);
            Assert.AreEqual(65535, cyan);

            var gray = ColorUtils.ToColorCode(Color.gray);
            Assert.AreEqual(8421504, gray);

            var yellow = ColorUtils.ToColorCode(Color.yellow);
            Assert.AreEqual(16771844, yellow);
        }

        [Test]
        public void TestColor32Extension()
        {
            var color32 = new Color32(100, 100, 100, 0);
            var code = color32.ToColorCode();
            Assert.AreEqual(6579300, code);
        }
    }
}
