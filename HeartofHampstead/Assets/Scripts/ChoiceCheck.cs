using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChoiceCheck : MonoBehaviour
{

    [SerializeField]
    private RectTransform[] texts;
    [SerializeField]
    private RectTransform believePanel;
    [SerializeField]
    private RectTransform dontPanel;

    [SerializeField]
    private GameObject instructionPanel;

    private ChangeScene sceneControl = new ChangeScene();

    public static class Decisions
    {
        public static int royalty = 0;
        public static int power = 0;
        public static int evil = 0;
    }
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        bool completed = checkForPoints();

        if (completed)
        {
            if (ObjectController.Stats.day - 1 == 3)
            {
                sceneControl.FinalDecScreen();
            }
            else
            {
                sceneControl.StartGame();
            }
        }
        else
        {
            instructionPanel.GetComponentInChildren<TextMeshProUGUI>().text = "Please drag all clues to the center of one of the two blocks";
            instructionPanel.SetActive(true);
        }

    }

public bool checkForPoints()
    {
        int royal = 0;
        int evil = 0;
        int power = 0;
        for (int i = 0; i < texts.Length; i++)
        {
            Rect rect1 = new Rect(texts[i].position.x, texts[i].position.y, texts[i].rect.width, texts[i].rect.height);
            Rect rect2 = new Rect(believePanel.position.x, believePanel.position.y, believePanel.rect.width, believePanel.rect.height);
            Rect rect3 = new Rect(dontPanel.position.x, dontPanel.position.y, dontPanel.rect.width, dontPanel.rect.height);

            if (rect1.Overlaps(rect2))
            {
                if (i == 0) royal = 1;
                else if (i == 1) evil = 1;
                else if (i == 2) power = 1;
            }
            else if (!rect1.Overlaps(rect3))
            {
                return false;
            }
            
        }
        Decisions.royalty += royal;
        Decisions.evil += evil;
        Decisions.power += power;
        return true;
    }
}
