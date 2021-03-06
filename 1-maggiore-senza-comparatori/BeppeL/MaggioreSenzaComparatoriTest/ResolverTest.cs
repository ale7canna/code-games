﻿using FluentAssertions;
using MaggioreSenzaComparatori;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaggioreSenzaComparatoriTest
{
    public class ResolverTest
    {
        Resolver _sut = new Resolver();

        [TestCase(0, 0, 0)]
        [TestCase(10, 0, 10)]
        [TestCase(0, 10, 10)]
        [TestCase(-1, 0, 0)]
        [TestCase(-1, 1, 1)]
        [TestCase(-10, -1, -1)]
        [TestCase(9, 10, 10)]
        [TestCase(10, 9, 10)]
        [TestCase(-10, -9, -9)]
        [TestCase(-9, -10, -9)]        
        [TestCase(-9, -9, -9)]        
        [TestCase(-10, -10, -10)]
        [TestCase(9, 9, 9)]
        [TestCase(10, 10, 10)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(-5, 5, 5)]
        [TestCase(5, -5, 5)]
        public void Max_should_work_correctly(short a, short b, short expected)
        {
            _sut.Max(a, b).Should().Be(expected);
        }
    }
}
