using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    [RequireComponent(typeof(HeroDisplay))]
    public class HeroPiece : MonoBehaviour, IPointerClickHandler
    {
        public HeroRunTimeSet heroRTS;
        public Hero hero;
        public ActivePiece activePiece;
        [SerializeField] GameEvent heroClicked;

        public HeroPiece(Hero newHero)
        {
            hero = newHero;
        }

        public void Awake()
        {
            heroRTS.Add(this);
        }

        public void OnDisable()
        {
            heroRTS.Remove(this);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            activePiece.pieceType = ActivePiece.PieceType.Hero;
            activePiece.activeHero = this;
            heroClicked.Raise();
        }
    }
}
