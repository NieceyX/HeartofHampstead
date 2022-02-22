using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [Header("Day Objects")]
    [SerializeField]
    private List<GameObject> dayOne;

    [SerializeField]
    private List<GameObject> dayTwo;

    [SerializeField]
    private List<GameObject> dayThree;

    [HideInInspector]
    public int day = 1;


    // Start is called before the first frame update
    void Start()
    {
        if (day == 1)
        {
            foreach (GameObject item in dayOne)
            {
                item.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
