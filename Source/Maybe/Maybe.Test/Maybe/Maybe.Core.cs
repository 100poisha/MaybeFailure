﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maybe.Test
{
    using Maybe = System.Maybe;

    [TestFixture]
    class MaybeCoreTest
    {
        [Test]
        public void HasValue()
        {
            Maybe.HasValue("").HasValue.IsTrue();
            Maybe.HasValue("").Value.Is("");

            Maybe.HasValue((string)null).HasValue.IsFalse();
        }
    }
}
