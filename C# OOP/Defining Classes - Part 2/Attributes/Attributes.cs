
using System;
namespace Attributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
  AllowMultiple = true)]

    class Attributes : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public Attributes(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return string.Format("v.{0}.{1}", this.Major, this.Minor).ToString();
        }

    }
}
