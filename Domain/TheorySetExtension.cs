using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public abstract class TheorySet : IEnumerable<object[]>
    {
        readonly List<object[]> data = new List<object[]>();

        protected void AddRow(params object[] values)
        {
            data.Add(values);
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class TheorySet<T1> : TheorySet
    {
        public void Add(T1 p1)
        {
            AddRow(p1);
        }
    }

    public class TheorySet<T1, T2> : TheorySet
    {
        public void Add(T1 p1, T2 p2)
        {
            AddRow(p1, p2);
        }
    }

    public class TheorySet<T1, T2, T3> : TheorySet
    {
        public void Add(T1 p1, T2 p2, T3 p3)
        {
            AddRow(p1, p2, p3);
        }
    }

    public class TheorySet<T1, T2, T3, T4> : TheorySet
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            AddRow(p1, p2, p3, p4);
        }
    }

    public class TheorySet<T1, T2, T3, T4, T5> : TheorySet
    {
        public void Add(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            AddRow(p1, p2, p3, p4, p5);
        }
    }
}

