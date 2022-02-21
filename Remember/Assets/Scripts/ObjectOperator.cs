using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOperator : MonoBehaviour
{
    [SerializeField] public int code;
    [SerializeField] GameObject control;
    //[SerializeField] DeviceOperator instance = GameObject.AddComponent<DeviceOperator>();
    //[SerializeField] var instance = new DeviceOperator();
    void Start()
    {
        control = GameObject.Find("Stuff");
    }


    public void Operate()
    {
        control.GetComponent<DeviceOperator>().ShowMessage(code);
        //StartCoroutine(instance.ShowMessage(code, 10));
        Destroy(this.gameObject);
    }
}