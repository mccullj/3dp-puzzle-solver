using System;

namespace puzzlesolver.Data
{
    public class PuzzlePieceDefinitions
    {
        public static List<PuzzlePiece> initializePieceList()
        {
            //Init.
            PuzzlePiece piece;
            List<PuzzlePiece> pieceList = new List<PuzzlePiece>();

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------1x1 pieces---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********1x1c********//
            bool[,] space1 = {
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside1 = {
                {'C', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside1 = {
                {'_', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("1x1c", 1, 1, space1, topside1, flipside1);
            pieceList.Add(piece);

            //********1x1g********//
            bool[,] space2 = {
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside2 = {
                {'G', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside2 = {
                {'_', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("1x1g", 1, 1, space2, topside2, flipside2);
            pieceList.Add(piece);

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------1x2 pieces---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********1x215********//
            bool[,] space3 = {
                {true, true, false, false},
                {false, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside3 = {
                {'1', '5', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside3 = {
                {'O', 'K', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("1x215", 2, 1, space3, topside3, flipside3);
            pieceList.Add(piece);

            //********1x2DE********//
            bool[,] space4 = {
                {true, true, false, false},
                {false, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside4 = {
                {'D', 'E', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside4 = {
                {'B', '=', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("1x2DE", 1, 1, space4, topside4, flipside4);
            pieceList.Add(piece);

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------1x4 piece---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********1x4BASE********//
            bool[,] space5 = {
                {true, true, true, true},
                {false, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside5 = {
                {'B', 'A', 'S', 'E'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside5 = {
                {'V', 'U', 'C', 'L'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("1x4BASE", 4, 1, space5, topside5, flipside5);
            pieceList.Add(piece);

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------2x1 pieces---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********2x1P2********//
            bool[,] space6 = {
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside6 = {
                {'P', '-', '-', '-'},
                {'2', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside6 = {
                {'=', '-', '-', '-'},
                {'_', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("2x1P2", 1, 2, space6, topside6, flipside6);
            pieceList.Add(piece);

            //********2x1_I********//
            bool[,] space7 = {
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside7 = {
                {'_', '-', '-', '-'},
                {'I', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside7 = {
                {'A', '-', '-', '-'},
                {'M', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("2x1_I", 1, 2, space7, topside7, flipside7);
            pieceList.Add(piece);

            //********2x1RM********//
            bool[,] space8 = {
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside8 = {
                {'R', '-', '-', '-'},
                {'M', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside8 = {
                {'R', '-', '-', '-'},
                {'_', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("2x1RM", 1, 2, space8, topside8, flipside8);
            pieceList.Add(piece);

            //********2x1TO********//
            bool[,] space9 = {
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside9 = {
                {'T', '-', '-', '-'},
                {'O', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside9 = {
                {'V', '-', '-', '-'},
                {'Y', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("2x1TO", 1, 2, space9, topside9, flipside9);
            pieceList.Add(piece);

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------3x1 pieces---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********3x1SWT********//
            bool[,] space10 = {
                {true, false, false, false},
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false}
            };
            char[,] topside10 = {
                {'S', '-', '-', '-'},
                {'W', '-', '-', '-'},
                {'T', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside10 = {
                {'=', '-', '-', '-'},
                {'_', '-', '-', '-'},
                {'=', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("3x1SWT", 1, 3, space10, topside10, flipside10);
            pieceList.Add(piece);

            //********3x1DBC********//
            bool[,] space11 = {
                {true, false, false, false},
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false}
            };
            char[,] topside11 = {
                {'D', '-', '-', '-'},
                {'B', '-', '-', '-'},
                {'C', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside11 = {
                {'V', '-', '-', '-'},
                {'V', '-', '-', '-'},
                {'?', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("3x1DBC", 1, 3, space11, topside11, flipside11);
            pieceList.Add(piece);

            //********3x1==D********//
            bool[,] space12 = {
                {true, false, false, false},
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false}
            };
            char[,] topside12 = {
                {'=', '-', '-', '-'},
                {'=', '-', '-', '-'},
                {'D', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside12 = {
                {'N', '-', '-', '-'},
                {'E', '-', '-', '-'},
                {'?', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("3x1==D", 1, 3, space12, topside12, flipside12);
            pieceList.Add(piece);

            //********3x1__K********//
            bool[,] space13 = {
                {true, false, false, false},
                {true, false, false, false},
                {true, false, false, false},
                {false, false, false, false}
            };
            char[,] topside13 = {
                {'_', '-', '-', '-'},
                {'_', '-', '-', '-'},
                {'K', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside13 = {
                {'E', '-', '-', '-'},
                {'Z', '-', '-', '-'},
                {'?', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("3x1__K", 1, 3, space13, topside13, flipside13);
            pieceList.Add(piece);

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------Corner Pieces---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********cornADS********//
            bool[,] space14 = {
                {true, true, false, false},
                {true, false, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside14 = {
                {'A', 'D', '-', '-'},
                {'S', '-', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside14 = {
                {'R', 'E', '-', '-'},
                {'-', 'Y', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("cornADS", 2, 2, space14, topside14, flipside14);
            pieceList.Add(piece);

            //********cornIEN********//
            bool[,] space15 = {
                {false, true, false, false},
                {true, true, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside15 = {
                {'-', 'I', '-', '-'},
                {'E', 'N', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside15 = {
                {'_', '-', '-', '-'},
                {'_', '_', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("cornIEN", 2, 2, space15, topside15, flipside15);
            pieceList.Add(piece);

            //********cornULU********//
            bool[,] space16 = {
                {false, true, false, false},
                {true, true, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside16 = {
                {'-', 'U', '-', '-'},
                {'L', 'U', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside16 = {
                {'U', '-', '-', '-'},
                {'?', '?', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("cornULU", 2, 2, space16, topside16, flipside16);
            pieceList.Add(piece);

            //********cornCOO********//
            bool[,] space17 = {
                {false, true, false, false},
                {true, true, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside17 = {
                {'-', 'C', '-', '-'},
                {'O', 'O', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside17 = {
                {'N', '-', '-', '-'},
                {'?', '?', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("cornULU", 2, 2, space17, topside17, flipside17);
            pieceList.Add(piece);

            //---------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------Other Pieces---------------------------------------------//
            //---------------------------------------------------------------------------------------------------------//
            //********4x1TMNG********//
            bool[,] space18 = {
                {true, false, false, false},
                {true, false, false, false},
                {true, false, false, false},
                {true, false, false, false}
            };
            char[,] topside18 = {
                {'T', '-', '-', '-'},
                {'M', '-', '-', '-'},
                {'N', '-', '-', '-'},
                {'G', '-', '-', '-'}
            };
            char[,] flipside18 = {
                {'=', '-', '-', '-'},
                {'_', '-', '-', '-'},
                {'=', '-', '-', '-'},
                {'N', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("4x1TMNG", 1, 4, space18, topside18, flipside18);
            pieceList.Add(piece);

            //********squareUXSA********//
            bool[,] space19 = {
                {true, true, false, false},
                {true, true, false, false},
                {false, false, false, false},
                {false, false, false, false}
            };
            char[,] topside19 = {
                {'U', 'X', '-', '-'},
                {'S', 'A', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside19 = {
                {'I', '_', '-', '-'},
                {'6', '_', '-', '-'},
                {'-', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("4x1TMNG", 2, 2, space19, topside19, flipside19);
            pieceList.Add(piece);

            //********Lpiece__LE********//
            bool[,] space20 = {
                {true, false, false, false},
                {true, false, false, false},
                {true, true, false, false},
                {false, false, false, false}
            };
            char[,] topside20 = {
                {'_', '-', '-', '-'},
                {'_', '-', '-', '-'},
                {'L', 'E', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside20 = {
                {'-', 'R', '-', '-'},
                {'-', 'H', '-', '-'},
                {'R', 'E', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("Lpiece__LE", 2, 3, space20, topside20, flipside20);
            pieceList.Add(piece);

            //********triangle_ARD********//
            bool[,] space21 = {
                {false, true, false, false},
                {true, true, false, false},
                {false, true, false, false},
                {false, false, false, false}
            };
            char[,] topside21 = {
                {'-', '_', '-', '-'},
                {'A', 'R', '-', '-'},
                {'-', 'D', '-', '-'},
                {'-', '-', '-', '-'}
            };
            char[,] flipside21 = {
                {'S', '-', '-', '-'},
                {'H', 'T', '-', '-'},
                {'O', '-', '-', '-'},
                {'-', '-', '-', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("triangle_ARD", 2, 3, space21, topside21, flipside21);
            pieceList.Add(piece);

            //********finger_T_ES_********//
            bool[,] space22 = {
                {false, true, false, false},
                {false, true, false, false},
                {false, true, false, false},
                {true, true, true, false}
            };
            char[,] topside22 = {
                {'-', '_', '-', '-'},
                {'-', 'T', '-', '-'},
                {'-', '_', '-', '-'},
                {'E', 'S', '_', '-'}
            };
            char[,] flipside22 = {
                {'-', 'I', '-', '-'},
                {'-', 'A', '-', '-'},
                {'-', 'G', '-', '-'},
                {'C', 'V', 'A', '-'}
            };
            //desc, width, height, space, topside, flipside
            piece = new PuzzlePiece("finger_T_ES_", 3, 4, space22, topside22, flipside22);
            pieceList.Add(piece);

            return pieceList;
        }
    }
}
