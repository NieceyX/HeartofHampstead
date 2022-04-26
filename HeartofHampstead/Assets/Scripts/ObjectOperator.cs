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
    private Animator villAnim;

    [SerializeField]
    private List<Transform> places;

    ChangeScene sceneCont = new ChangeScene();

    void Start()
    {
        if (ObjectController.Stats.day == 2 && this.gameObject.layer == 7)
        {
            this.gameObject.transform.position = places[0].position;
            this.gameObject.transform.rotation = places[0].rotation;
        }
        else if (ObjectController.Stats.day == 3 && this.gameObject.layer == 7)
        {
            this.gameObject.transform.position = places[1].position;
            this.gameObject.transform.rotation = places[1].rotation;
        }

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
            villAnim.SetTrigger("talk");
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