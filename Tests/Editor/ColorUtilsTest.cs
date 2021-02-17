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
        public void TestColor32()
        {
            var color = new Color32(100, 100, 100, 0);
            var code = ColorUtils.ToColorCode(color);
            Assert.AreEqual(6579300, code);
        }

        [Test]
        public void TestColor()
        {
            var cyan = ColorUtils.ToColorCode(Color.cyan);
            Assert.AreEqual(65535, cyan);

            var gray = ColorUtils.ToColorCode(Color.gray);
            Assert.AreEqual(8421504, gray);

            var yellow = ColorUtils.ToColorCode(Color.yellow);
            Assert.AreEqual(16771844, yellow);
        }

        [Test]
        public void TestHTML()
        {
            var cyan = ColorUtils.ToColorCode("#00FFFF");
            Assert.AreEqual(65535, cyan);
        }
    }
}
