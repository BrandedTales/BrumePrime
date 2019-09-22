using UnityEngine;
using System.Collections;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Runtime/ActivePiece")]
    public class ActivePiece : ScriptableObject
    {
        public enum PieceType
        {
            Land,
            Hero,
            Token
        }


        public PieceType pieceType;
        public LandPiece activeLand;
        public HeroPiece activeHero;
        public HeroToken activeToken;
        

    }
}