using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BT.Variables;

namespace BT.Brume
{
    public class HUDDisplay : MonoBehaviour
    {

        [SerializeField] Text uiTurnDisplay;
        [SerializeField] FloatReference turnNumber;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            string turnText = "Turn: " + turnNumber.variable.value.ToString();
            uiTurnDisplay.text = turnText;
        }
    }
}
