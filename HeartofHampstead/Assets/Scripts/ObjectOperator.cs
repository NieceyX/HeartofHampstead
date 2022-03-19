using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOperator : MonoBehaviour
{
    [SerializeField] 
    public int code;
    [SerializeField] 
    GameObject control;

    [SerializeField]
    private GameObject objCont;

    ChangeScene sceneCont = new ChangeScene();

    void Start()
    {

    }


    public void Operate()
    {
        if (this.gameObject.layer == 6)
        {
            control.GetComponent<DeviceOperator>().ShowMessage(code);
            Destroy(this.gameObject);
        }
        else if (this.gameObject.layer == 7)
        {
            control.GetComponent<DeviceOperator>().ShowMessage(code);
        }
        else
        {
            if(control.GetComponent<DeviceOperator>().collected == 3)
            {
                //go to choice scene
                ObjectController.Stats.day += 1;
                sceneCont.ChoiceScreen();
            }
            else
            {
                //not everything collected
                control.GetComponent<DeviceOperator>().ShowMessage(code);
            }
        }

    }
}