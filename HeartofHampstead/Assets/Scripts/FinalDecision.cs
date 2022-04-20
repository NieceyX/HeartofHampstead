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
    private TextMeshProUGUI decText;

    [SerializeField]
    private GameObject decButton;
    [SerializeField]
    private GameObject contButton;

    public static int final;

    private ChangeScene sceneControl = new ChangeScene();

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
            final = 1;
            decText.text = "The Orb belongs to the royal family. I should return it to them for their safe keeping.";
        }
        else if (max == evil)
        {
            final = 2;
            decText.text = "The Orb is the worst evil this world has faced. I should destroy it to rid the world from it.";
        }
        else
        {
            final = 3;
            decText.text = "The orb is the most powerful item that has ever existed. I should keep it and use it to help others.";
        }
    }

    public void controlButton()
    {
        final = 0;
        sceneControl.EpilogScreen();
    }
    public void decisionButton()
    {
        sceneControl.EpilogScreen();
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
