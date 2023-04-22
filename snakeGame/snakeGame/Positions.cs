using System.Collections.Generic;

namespace snakeGame
{
    public class Positions
    {

        public int Row { get; }
        public int Col { get; }

        public Positions(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public Positions Translate(Direction dir)
        {
            return new Positions(Row + dir.RowOffset, Col + dir.ColOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Positions positions &&
                   Row == positions.Row &&
                   Col == positions.Col;
        }

        public override int GetHashCode()
        {
            int hashCode = 1084646500;
            hashCode = hashCode * -1521134295 + Row.GetHashCode();
            hashCode = hashCode * -1521134295 + Col.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Positions left, Positions right)
        {
            return EqualityComparer<Positions>.Default.Equals(left, right);
        }

        public static bool operator !=(Positions left, Positions right)
        {
            return !(left == right);
        }
    }
}
