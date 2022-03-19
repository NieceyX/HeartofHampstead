using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [Header("Day Objects")]
    [SerializeField]
    private List<GameObject> dayOneItems;

    [SerializeField]
    private List<GameObject> dayTwoItems;

    [SerializeField]
    private List<GameObject> dayThreeItems;

    [Header("Day Villagers")]
    [SerializeField]
    private List<GameObject> dayOneVill;

    [SerializeField]
    private List<GameObject> dayTwoVill;

    [SerializeField]
    private List<GameObject> dayThreeVill;

    public static class Stats
    {
        public static int day = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Stats.day == 1)
        {
            foreach (GameObject item in dayOneItems)
            {
                item.SetActive(true);
            }
        }
        else if (Stats.day == 2)
        {
            foreach (GameObject item in dayTwoItems)
            {
                item.SetActive(true);
            }
        }
        else if (Stats.day == 3)
        {
            foreach (GameObject item in dayThreeItems)
            {
                item.SetActive(true);
            }
        }
    }
}
