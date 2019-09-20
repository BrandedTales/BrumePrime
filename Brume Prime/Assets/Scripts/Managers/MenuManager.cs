using UnityEngine;
using System.Collections;
using BT.Variables;
using BT.Events;

namespace BT.Brume.Managers
{
    public class MenuManager : MonoBehaviour
    {
        public void CloseMenu()
        {
            Destroy(this.gameObject);
        }


    }
}