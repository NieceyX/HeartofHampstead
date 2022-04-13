using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChoiceCheck : MonoBehaviour
{
    /*
    [SerializeField]
    private Collider2D[] textColliders;
    [SerializeField]
    private Collider2D believeCollider;
    [SerializeField]
    private Collider2D dontCollider;
    */

    [SerializeField]
    private RectTransform[] texts;
    [SerializeField]
    private RectTransform believePanel;
    [SerializeField]
    private RectTransform dontPanel;

    private ChangeScene scenceControl = new ChangeScene();

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
            Debug.Log(Decisions.royalty);
            Debug.Log(Decisions.power);
            Debug.Log(Decisions.evil);
            scenceControl.StartGame();
        }
        else
        {
            //promt to finish
        }

    }

public bool checkForPoints()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            Rect rect1 = new Rect(texts[i].localPosition.x, texts[i].localPosition.y, texts[i].rect.width, texts[i].rect.height);
            Rect rect2 = new Rect(believePanel.localPosition.x, believePanel.localPosition.y, believePanel.rect.width, believePanel.rect.height);
            Rect rect3 = new Rect(dontPanel.localPosition.x, dontPanel.localPosition.y, dontPanel.rect.width, dontPanel.rect.height);
            
            if (rect1.Overlaps(rect2))
            {
                Debug.Log("Touching!");
                if (i == 0) { Debug.Log("ROYALTY ADD"); Decisions.royalty += 1; }
                else if (i == 1) { Debug.Log("EVIL ADD"); Decisions.evil += 1; }
                else if (i == 2) { Debug.Log("POWER ADD"); Decisions.power += 1; }
            }
            else if (!rect1.Overlaps(rect3))
            {
                Debug.Log("Not Touching!");
                return false;
            }
            
        }
        return true;
    }
}
