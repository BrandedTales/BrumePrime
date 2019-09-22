using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    [RequireComponent(typeof(LandDisplay))]
    public class LandPiece : MonoBehaviour, IPointerClickHandler
    {
        public LandRunTimeSet landRTS;
        public Land land;
        public ActivePiece activePiece;
        [SerializeField] GameEvent landClicked;

        [SerializeField] GameObject tokenPanel;
        [SerializeField] HeroToken tokenPrefab;

        public void Awake()
        {
            landRTS.Add(this);
        }

        public void OnDisable()
        {
            landRTS.Remove(this);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            land.isDiscovered = true;

            activePiece.pieceType = ActivePiece.PieceType.Land;
            activePiece.activeLand = this;
            landClicked.Raise();
        }

        public void AddToken()
        {
            HeroToken newToken = Instantiate(tokenPrefab, tokenPanel.transform);
            newToken.hero = activePiece.activeToken.hero;
        }
    }
}
