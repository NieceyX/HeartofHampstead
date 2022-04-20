using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Epilog : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI epi;

    // Start is called before the first frame update
    void Start()
    {
        if (FinalDecision.final == 0)
        {
            //control
            epi.text = "Everyone loves to spread grandios rumors. There are weird objects all around us. This orb isn't any more special than a blade of grass, " +
                "why would it be? You toss the orb in the well, hoping that you can at least get a decent wish out of it.";
        }
        else if (FinalDecision.final == 1)
        {
            //royal
            epi.text = "You return the mysterious orb to the Queen. She is grateful for your actions, though looks slightly puzzled. " +
                "She thanks you for your generosity and invites you to attend a meal with her and her family. The orb is back where it belongs.";
        }
        else if (FinalDecision.final == 2)
        {
            //evil
            epi.text = "The orb cannot be allowed to get into any other hands. You set off to the middle of the woods to destroy the orb and bury it where no one would" +
                " ever be able to find it again. This was the right thing to do.";
        }
        else
        {
            //power
            epi.text = "The orb has brought you clarity. It is obvious what you must do - use the orb to help everyone who cannot help themselves." +
                " The orb will surely let you bring light and happiness to many others.";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
