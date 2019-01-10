using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bottletoggle : MonoBehaviour
{
    public void Togglechanged(bool state)
    {
        GetComponent<Button>().interactable = state;
    }
}
