using Domain.Models;
using System;
using Xunit;

namespace Flora.Test.Domain
{
    public class TestHero
    {
        public static TheoryData<int, int, bool> TestData => new TheoryData<int, int, bool> {
            {1,1,false},
            {10,5,true},
            {100,40,true},
            {10,50,false}
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMethod(int bullets, int dragons, bool expected)
        {
            var actual = Kata.Hero(bullets, dragons);
            Assert.Equal(actual, expected);
        }
    }



}
/*using System;
using Xunit;

namespace Flora.Test.Domain
{
    public class TestGenerateRange
    {
        public static TheoryData<int, int, int, int[]> TestData => new TheoryData<int, int, int, int[]> {
            {2,10,2,new int[]{2,4,6,8,10}},
            {1,10,3,new int[]{1,4,7,10}},
            {1,1,5,new int[]{1}},
            {1,10,2,new int[]{1,3,5,7,9}}
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMethod(int min, int max, int step, int[] expected)
        {
            var actual = Kata.GenerateRange(min, max, step);
            Assert.Equal(actual, expected);
        }
    }



}
/*using System;
using System.Linq;
using Xunit;

namespace Flora.Test.Domain
{
    public class TestFillAnArrayPart1
    {
        public static TheoryData<int, int[]> TestData => new TheoryData<int, int[]> {
            {0,new int[]{}},
            {5,new int[]{0,1,2,3,4}},
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMethod(int count, int[] expected)
        {
            var actual = new Kata().FillAnArrayPart1(count);
            Assert.True(actual.SequenceEqual(expected));
        }
    }



}
/*using System;
using System.Linq;
using Xunit;

namespace Flora.Test.Domain
{
    public class TestInvertValues
    {
        public static TheoryData<int[], int[]> TestData => new TheoryData<int[], int[]> {
            {null,null},
            {new int[]{},new int[]{}},
            {new int[]{0},new int[]{0}},
            {new int[]{1,2},new int[]{-1,-2}},
            {new int[]{1,2,-3,4,-5,-6},new int[]{-1,-2,3,-4,5,6}}
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMethod(int[] param, int[] expected)
        {
            var actual = new Problem().InvertValues(param);

            if (param == null)
                Assert.Equal(param, expected);
            else
                Assert.True(actual.SequenceEqual(expected));
        }
    }



}

/*using System;
using Xunit;

namespace Flora.Test.Domain
{
    public class TestIndex
    {
        public static TheoryData<int[], int, double> TestData => new TheoryData<int[], int, double> {
            {new int[]{1,2,3,4},4,-1},
            {new int[]{1,2,3,4},5,-1},
            {new int[]{1,2,3,4},2,9},
            {new int[] {1, 3, 10, 100}, 3,1000000}
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMethod(int[] array, int n, double expected)
        {
            var actual = new Problem().Index(array, n);
            Assert.Equal(actual, expected);
        }
    }



}


/*using System;
using Domain.Models;
using Xunit;



namespace Flora.Test.Domain
{
    
    public class Test
    {
        public static TheoryData<int, int, int, int> TestData => new TheoryData<int, int, int, int> {
            {0,1,1,61000},
            {1,1,1,3661000}
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMethod(int h, int m, int s, int expected)
        {
            var actual = new Problem().Past(h, m, s);
            Assert.Equal(actual, expected);
        }
    }



}
*/