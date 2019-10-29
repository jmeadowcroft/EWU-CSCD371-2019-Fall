namespace Mailbox
{
    public static class SizeMixins
    {
        public static string GetSizeDisplay(this Sizes size)
        {
            return size switch
            {
                Sizes s when s.HasFlag(Sizes.Premium) => $"{s}: Premium",
                Sizes.Unknown => "",
                Sizes s => $"{s}"
            };
        }
    }
}