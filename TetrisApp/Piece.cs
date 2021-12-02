using System;
using System.Collections.Generic;
using System.Runtime;
namespace TetrisApp{
    public class Piece{
        public int[,] thisPiece{get;set;}
        public Piece(){
            this.AleatoirePiece();
        }
        public string printPiece(int[,] piece){
            string toPrint2 = "";
            for(int i=0;i<4;i++){
                for(int j=0; j<4;j++){
                toPrint2 += string.Join("", piece[i,j]);
                }
                toPrint2 += "\n";
            }
            return toPrint2;
        }
        public int[,] RotatePiece(){
            int[,] temp = (int[,]) this.thisPiece.Clone();
            int[,] a = new int[4,4];
            int y = 4;
            for(int k = 0; k < 4; k++){
                y--;
                for(int i = 0; i < 4; i++){
                    a[i,k] = temp[y,i];
                    temp = this.thisPiece;
                }
            }
            return a;
        }

        public void AleatoirePiece(){
            //Création des Pieces de base + intégration dans un tableau les contenant
            int[,] PieceL = new int[,] {{0,1,0,0}, {0,1,0,0}, {0,1,1,0}, {0,0,0,0}};
            int[,] PieceX = new int[,] {{1,1,1,1}, {2,2,2,2}, {3,3,3,3}, {4,4,4,4}};
            int[,] PieceJ = new int[,] {{0,0,1,0}, {0,0,1,0}, {0,1,1,0}, {0,0,0,0}};
            int[,] PieceO = new int[,] {{0,0,0,0}, {0,1,1,0}, {0,1,1,0}, {0,0,0,0}};
            int[,] PieceT = new int[,] {{0,1,0,0}, {0,1,1,0}, {0,1,0,0}, {0,0,0,0}};
            int[,] PieceI = new int[,] {{0,1,0,0}, {0,1,0,0}, {0,1,0,0}, {0,1,0,0}};
            int[,] PieceZ = new int[,] {{0,0,1,0}, {0,1,1,0}, {0,1,0,0}, {0,0,0,0}};
            int[,] PieceS = new int[,] {{0,1,0,0}, {0,1,1,0}, {0,0,1,0}, {0,0,0,0}};
            int[][,] a = new int[7][,] {PieceL, PieceJ, PieceO, PieceT, PieceS, PieceZ, PieceI};

            // Création d'un chiffre aléatoire pour aller chercher une pièce aléatoirement dans le tableau
            Random aleatoire = new Random();
            int indexPiece = aleatoire.Next(0,7);
            Random aleatoire2 = new Random();
            int RotateX = aleatoire2.Next(0,3);
            this.thisPiece = a[indexPiece];

            // On fait une rotation de la pièce x fois.
            for(int i = 0; i < 4; i++){
                this.thisPiece = this.RotatePiece();
            }

            // On retourne la pièce aléatoire
            // return this.thisPiece;
        }

    }
}