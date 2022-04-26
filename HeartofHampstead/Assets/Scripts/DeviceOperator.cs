using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI popUpText;
    [SerializeField]
    private GameObject popUp;

    [HideInInspector]
    public int collected = 0;

    public static class VillagerText
    {
        public static string firstVill1;
        public static string secVill1;
        public static string thirdVill1;
        public static string forthVill1;
        public static string fifthVill1;
    }

    public static class ObjectConts
    {
        public static bool set = false;
        public static string innComp;

        public static string firstObj1;
        public static string firstObj2;
        public static string firstObj3;

        public static string secObj1;
        public static string secObj2;
        public static string secObj3;

        public static string thirdObj1;
        public static string thirdObj2;
        public static string thirdObj3;
    }

    void Start()
    {
        popUp.gameObject.SetActive(false);

        if (!ObjectConts.set)
        {
            ObjectConts.innComp = "There are more clues to discover";

            ObjectConts.firstObj1 = "An object of high value was given to the royal family eons ago";
            ObjectConts.firstObj2 = "A source of great evil came to town, scorching everything in its way";
            ObjectConts.firstObj3 = "The orb's power was immense, and often overwhelming";         

            ObjectConts.secObj1 = "The lord's gift kept the heirs in power, and power it gave";
            ObjectConts.secObj2 = "The evil object cursed all those who possesed it to lose their minds";
            ObjectConts.secObj3 = "The power grew, and everyone could see the glow for miles around";
            
            ObjectConts.thirdObj1 = "The Queen kept the gift safe from others, outsiders never saw it";
            ObjectConts.thirdObj2 = "The great evil brought war and famine to the land, to all except those who worshiped it";
            ObjectConts.thirdObj3 = "This power was kept safe from those who sought to use it for harm";


            VillagerText.firstVill1 = "Hey Ona! I heard a rumor that a guest in the castle stole something from the Queen!";
            VillagerText.secVill1 = "Wow, you seem to have a glow about you today, your confidence and stength is showing!";
            VillagerText.thirdVill1 = "Hey Ona, I've had these nightmares the past two nights, what could it mean?";
            VillagerText.forthVill1 = "You won't believe this! Apparently the rulers have lied about an important item they had for eons!";
            VillagerText.fifthVill1 = "I've never met anyone like you Ona. You seem more powerful than any who have come before you.";

            ObjectConts.set = true;
        }
        if (ObjectController.Stats.day == 2)
        {
            popUpText.text = "The next day has begun, time to find more information!";
            popUp.SetActive(true);
            VillagerText.firstVill1 = "What...what's in your bag? Please get rid of that right away! It's not safe.";
            VillagerText.secVill1 = "Some trader came through town asking about an object of unimaginable power.";
            VillagerText.thirdVill1 = "Did you know I had an apprentice? I never knew what happened to her. She spoke in riddles one day then dissapered.";
            VillagerText.forthVill1 = "How are you today? You look like you're not getting very good sleep.";
            VillagerText.fifthVill1 = "Hello dear, don't go too far out today, the forest has eyes.";
        }
        else if (ObjectController.Stats.day == 1)
        {
            popUpText.text = "Collect all of the information you can, find items and talk to villagers";
            popUp.SetActive(true);
        }
        else
        {
            popUpText.text = "The next day has begun, time to find more information!";
            popUp.SetActive(true);
            VillagerText.firstVill1 = "I had a dream last night that you walked into a dark mist and never came back!";
            VillagerText.secVill1 = "You always seem so sure of yourself, Ona. Can you teach me how to be as confident?";
            VillagerText.thirdVill1 = "A knight from the castle came through town last night, she said there is a reward for anyone who can return a stolen object.";
            VillagerText.forthVill1 = "Ona! It's great to see you today. I hope you stay around.";
            VillagerText.fifthVill1 = "Goodmorning. Do you have lot's of plans today? Don't get into trouble.";
        }
    }
    public void ShowMessage(int code)
    {
        switch (code)
        {
            case 0:
                popUpText.text = ObjectConts.firstObj1;
                collected += 1;
                break;
            case 1:
                popUpText.text = ObjectConts.firstObj2;
                collected += 1;
                break;
            case 2:
                popUpText.text = ObjectConts.firstObj3;
                collected += 1;
                break;
            case 3:
                popUpText.text = ObjectConts.secObj1;
                collected += 1;
                break;
            case 4:
                popUpText.text = ObjectConts.secObj2;
                collected += 1;
                break;
            case 5:
                popUpText.text = ObjectConts.secObj3;
                collected += 1;
                break;
            case 6:
                popUpText.text = ObjectConts.innComp;
                break;
            case 7:
                popUpText.text = ObjectConts.thirdObj1;
                collected += 1;
                break;
            case 8:
                popUpText.text = ObjectConts.thirdObj2;
                collected += 1;
                break;
            case 9:
                popUpText.text = ObjectConts.thirdObj3;
                collected += 1;
                break;

            case 10:
                popUpText.text = VillagerText.firstVill1;
                break;

            case 11:
                popUpText.text = VillagerText.secVill1;
                break;

            case 12:
                popUpText.text = VillagerText.thirdVill1;
                break;

            case 13:
                popUpText.text = VillagerText.forthVill1;
                break;

            case 14:
                popUpText.text = VillagerText.fifthVill1;
                break;
        }
        popUp.SetActive(true);
    }
}
