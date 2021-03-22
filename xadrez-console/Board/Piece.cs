namespace board {
    class Piece {

        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qtyMovements { get; protected set; }
        public Board board { get; protected set; }

        public Piece() {

        }

        public Piece(Board board, Color color) {
            this.color = color;
            this.board = board;
            position = null;
            qtyMovements = 0;
        }
    }
}
