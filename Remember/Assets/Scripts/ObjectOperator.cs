using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOperator : MonoBehaviour
{
    [SerializeField] public int code;
    [SerializeField] GameObject control;
    [SerializeField] private bool item;

    void Start()
    {
    }


    public void Operate()
    {
        if (item)
        {
            control.GetComponent<DeviceOperator>().ShowMessage(code);
            Destroy(this.gameObject);
        }
        else
        {
            if(control.GetComponent<DeviceOperator>().collected == 3)
            {
                //go to choice scene
            }
            else
            {
                //not everything collected
                control.GetComponent<DeviceOperator>().ShowMessage(code);
            }
        }

    }
}