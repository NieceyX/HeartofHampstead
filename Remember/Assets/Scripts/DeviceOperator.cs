using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI popUpText;
    [SerializeField]
    private GameObject popUp;

    [HideInInspector]
    public int collected = 0;

    void Start()
    {
        popUp.gameObject.SetActive(false);
    }
    public void ShowMessage(int code)
    {
        switch (code)
        {
            case 0:
                popUpText.text = "An object of high value was given to the royal family eons ago";
                collected += 1;
                break;
            case 1:
                popUpText.text = "A source of great evil came to town, scorching everything in its way";
                collected += 1;
                break;
            case 2:
                popUpText.text = "The orb's power was immense, and often overwhelming";
                collected += 1;
                break;
            case 3:
                popUpText.text = "The lord's gift kept the heirs in power, and power it gave";
                collected += 1;
                break;
            case 4:
                popUpText.text = "The evil object cursed all those who possesed it to lose their minds";
                collected += 1;
                break;
            case 5:
                popUpText.text = "The power grew, and everyone could see the glow for miles around";
                collected += 1;
                break;
            case 6:
                popUpText.text = "There are more clues to discover";
                break;
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        popUp.SetActive(true);

    }


}
