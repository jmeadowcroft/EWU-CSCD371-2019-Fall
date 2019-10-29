using System;

namespace Mailbox
{
    [Flags]
    public enum Sizes
    {
        Unknown = 0,
        Premium = 0b_0001,
        Small = 0b_0010,
        SmallPremium = Small | Premium,
        Medium = 0b_0100,
        MediumPremium = Medium | Premium,
        Large = 0b_1000,
        LargePremium = Large | Premium 
    }
}
