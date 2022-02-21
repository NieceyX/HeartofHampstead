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
    void Start()
    {
        popUp.gameObject.SetActive(false);
    }
    public void ShowMessage(int code)
    {
        switch (code)
        {
            case 0:
                popUpText.text = "Item 1 description";
                break;
            case 1:
                popUpText.text = "Item 2 description";
                break;
            case 2:
                popUpText.text = "Item 3 description";
                break;
            case 3:
                popUpText.text = "Item 4 description";
                break;
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        popUp.SetActive(true);

    }


}
