namespace Mailbox
{
    public class Mailbox
    {
        public Sizes Size { get; }

        public (int X, int Y) Location { get; }

        public Person Owner { get; }

        public Mailbox((int, int) location, Sizes size, Person owner)
        {
            Location = location;
            Size = size;
            Owner = owner;
        }

        public override string ToString()
        {
            return $"({Location.X}, {Location.Y}) {Size.GetSizeDisplay()} {Owner}";
        }
    }
}
