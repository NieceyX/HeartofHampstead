using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinalDecision : MonoBehaviour
{
    private int royal;
    private int evil;
    private int power;

    [SerializeField]
    private GameObject tog;

    /*
    [SerializeField]
    private GameObject gif;
    [SerializeField]
    private Texture[] frames;
    [SerializeField]
    private int framesPerSecond = 10;
    */

    // Start is called before the first frame update
    void Start()
    {
        royal = ChoiceCheck.Decisions.royalty;
        evil = ChoiceCheck.Decisions.evil;
        power = ChoiceCheck.Decisions.power;

        int max = Mathf.Max(royal, Mathf.Max(evil, power));
        if (max == royal)
        {
            tog.GetComponentInChildren<TextMeshProUGUI>().text = "The Orb belongs to the royal family. I should return it to them for their safe keeping.";
        }
        else if (max == evil)
        {
            tog.GetComponentInChildren<TextMeshProUGUI>().text = "The Orb is the worst evil this world has faced. I should destroy it to rid the world from it.";
        }
        else
        {
            tog.GetComponentInChildren<TextMeshProUGUI>().text = "The orb is the most powerful item that has ever existed. I should keep it and use it to help others.";
        }
    }


    /*
    void Update() 
    { 
        for(int i=0; i<=frames.Length; i++)
        {
            float t = (Time.time * framesPerSecond) % frames.Length; 
            gif.GetComponent<Renderer>().material.mainTexture = frames[i];
        }
 
    }
    */
}
