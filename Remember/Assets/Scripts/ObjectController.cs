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

    public static class Stats
    {
        public static int day = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Stats.day == 1)
        {
            foreach (GameObject item in dayOne)
            {
                item.SetActive(true);
            }
        }
        else if (Stats.day == 2)
        {
            foreach (GameObject item in dayTwo)
            {
                item.SetActive(true);
            }
        }
        else if (Stats.day == 3)
        {
            foreach (GameObject item in dayThree)
            {
                item.SetActive(true);
            }
        }
    }
}
