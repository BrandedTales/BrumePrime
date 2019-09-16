using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;

namespace BT.Brume.Managers
{
    public class HUDManager : MonoBehaviour
    {
        [SerializeField] GameEvent nextTurn;

        public void ClickNextTurn()
        {
            nextTurn.Raise();
        }

    }
}