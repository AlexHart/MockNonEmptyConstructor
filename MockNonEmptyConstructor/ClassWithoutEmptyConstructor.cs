using System;
using System.Collections.Generic;
using System.Text;

namespace MockNonEmptyConstructor
{
    public class ClassWithoutEmptyConstructor : IValue
    {

        public virtual int Value { get; }

        public ClassWithoutEmptyConstructor(int value)
        {
            Value = value;
        }

    }
}
