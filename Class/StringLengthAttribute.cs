using System;

namespace Model
{
    internal class StringLengthAttribute : Attribute
    {
        private int v;
        private int minimumLength;

        public StringLengthAttribute(int v, int MinimumLength)
        {
            this.v = v;
            minimumLength = MinimumLength;
        }

        public int MinimumLength { get; set; }
    }
}