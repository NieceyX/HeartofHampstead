using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Beliefs : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text1; // royal
    [SerializeField]
    private TextMeshProUGUI text2; // evil
    [SerializeField]
    private TextMeshProUGUI text3; // power

    // Start is called before the first frame update
    void Start()
    {
        if (ObjectController.Stats.day-1 == 1)
        {
            text1.text = DeviceOperator.ObjectConts.firstObj1;
            text2.text = DeviceOperator.ObjectConts.firstObj2;
            text3.text = DeviceOperator.ObjectConts.firstObj3;
        }
        else if (ObjectController.Stats.day-1 == 2)
        {
            text1.text = DeviceOperator.ObjectConts.secObj1;
            text2.text = DeviceOperator.ObjectConts.secObj2;
            text3.text = DeviceOperator.ObjectConts.secObj3;
        }
        else if (ObjectController.Stats.day-1 == 3)
        {
            text1.text = DeviceOperator.ObjectConts.thirdObj1;
            text2.text = DeviceOperator.ObjectConts.thirdObj2;
            text3.text = DeviceOperator.ObjectConts.thirdObj3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
