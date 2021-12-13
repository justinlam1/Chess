namespace Chess
{
    public struct PieceLocation
    {
        public PieceLocation(int column, int row)
        {
            this.Row = row;
            this.Column = column;
        }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}