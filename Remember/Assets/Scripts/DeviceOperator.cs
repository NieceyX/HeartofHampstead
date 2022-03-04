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

    public static class ObjectConts
    {
        public static bool set = false;
        public static string innComp;

        public static string firstObj1;
        public static string firstObj2;
        public static string firstObj3;

        public static string secObj1;
        public static string secObj2;
        public static string secObj3;

        public static string thirdObj1;
        public static string thirdObj2;
        public static string thirdObj3;
    }

    void Start()
    {
        popUp.gameObject.SetActive(false);

        if (!ObjectConts.set)
        {
            ObjectConts.innComp = "There are more clues to discover";

            ObjectConts.firstObj1 = "An object of high value was given to the royal family eons ago";
            ObjectConts.firstObj2 = "A source of great evil came to town, scorching everything in its way";
            ObjectConts.firstObj3 = "The orb's power was immense, and often overwhelming";

            ObjectConts.secObj1 = "The lord's gift kept the heirs in power, and power it gave";
            ObjectConts.secObj2 = "The evil object cursed all those who possesed it to lose their minds";
            ObjectConts.secObj3 = "The power grew, and everyone could see the glow for miles around";

            ObjectConts.thirdObj1 = "PLACEHOLDER";
            ObjectConts.thirdObj2 = "PLACEHOLDER";
            ObjectConts.thirdObj3 = "PLACEHOLDER";

            ObjectConts.set = true;
        }
    }
    public void ShowMessage(int code)
    {
        switch (code)
        {
            case 0:
                popUpText.text = ObjectConts.firstObj1;
                collected += 1;
                break;
            case 1:
                popUpText.text = ObjectConts.firstObj2;
                collected += 1;
                break;
            case 2:
                popUpText.text = ObjectConts.firstObj3;
                collected += 1;
                break;
            case 3:
                popUpText.text = ObjectConts.secObj1;
                collected += 1;
                break;
            case 4:
                popUpText.text = ObjectConts.secObj2;
                collected += 1;
                break;
            case 5:
                popUpText.text = ObjectConts.secObj3;
                collected += 1;
                break;
            case 6:
                popUpText.text = ObjectConts.innComp;
                break;
            case 7:
                popUpText.text = ObjectConts.thirdObj1;
                collected += 1;
                break;
            case 8:
                popUpText.text = ObjectConts.thirdObj2;
                collected += 1;
                break;
            case 9:
                popUpText.text = ObjectConts.thirdObj3;
                collected += 1;
                break;
        }
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
        popUp.SetActive(true);
    }


}
