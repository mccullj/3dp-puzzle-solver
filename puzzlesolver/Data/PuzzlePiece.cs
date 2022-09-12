using System;

namespace puzzlesolver.Data
{
    public class PuzzlePiece
    {
        public String desc;     //plaintext description of piece
        public int width;
        public int height;
        public  bool[,] space; // true = occupied, false = not occupied
        public  char[,] topside;  // _ = blank space
        public  char[,] flipside; // _ = blank space

        public int inPlayX;
        public int inPlayY;
        public Boolean isInPlay = false;


        public PuzzlePiece(String desc, int width, int height, bool[,] space, char[,] topside, char[,] flipside)
        {
            this.desc = desc;
            this.width = width;
            this.height = height;
            this.space = space;
            this.topside = topside;
            this.flipside = flipside;
        }

        override
        public String ToString ()
        {
            return ("desc: " + desc + "\n" +
                "width: " + width + "\n" +
                "height: " + height + "\n" +
                "space: " + space.ToString() + "\n" +
                "topside: " + topside.ToString() + "\n" +
                "flipside: " + flipside.ToString());
        }

        public void setInPlay (int x, int y)
        {
            isInPlay = true;
            inPlayX = x;
            inPlayY = y;
        }
    }
}
