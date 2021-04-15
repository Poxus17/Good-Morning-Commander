using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class TextClicker : MonoBehaviour, IPointerClickHandler
{
    public Camera camera;
    public TextMeshProUGUI brainText;
<<<<<<< HEAD
    public void OnPointerClick(PointerEventData eventData)
    {
        var text = GetComponent<TextMeshProUGUI>();
        //Debug.Log(text.text);
        if (eventData.button == PointerEventData.InputButton.Left)
=======
    public PlayerController playerController;
    public TMP_Text thisText;
    //public RoutineMngr routineMngr;
    void Start()
    {
        thisText = GetComponentInChildren<TMP_Text>();
        thisText.text = "Points of interest: <link=SolfieldID><color=blue>Solfield</color></link>,  <link=SixAM><color=blue>SixAM</color></link>, then more text. " +
            "\n\nGood morning, Commander. Mars is planning to assassinate Terran General Henry Vizan with minimum collateral damage. " +
            "Unfortunately, he works in the <b>United Nations building</b>. He arrives to work every day at <b>08:00</b> and leaves not before <b>19:00</b>. " +
            "Once every week, he inspects ongoing procedures at the nearby <link=SolfieldID><color=blue>Solfield military base</color></link>,  where he is taken by car at <b><link=SixAM>06:00</link></b>. " +
            "He lives in a densely populated area, where he returns every day at about <b>20:00</b>, but has also been known to visit a mistress <b>in a distant suburb</b> at about 20:00, in which case he returns home around <b>01:00</b>. " +
            "\n\nMars is asking <b>when</b>  and <b>where</b> should our drones strike.";
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        

        //Debug.Log(text.text);
        if (playerController.brainVisible == true)
>>>>>>> parent of c8edddb (Revert "TMP Fixes")
        {
            int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, camera);
            Debug.Log("Link Index : " + linkIndex + "(if -1, no link was detected)");
            if (linkIndex > -1)
            {
<<<<<<< HEAD
                var linkInfo = text.textInfo.linkInfo[linkIndex];
=======
                int linkIndex = TMP_TextUtilities.FindIntersectingLink(thisText, Input.mousePosition, camera);
                Debug.Log("Link Index : " + linkIndex + "(if -1, no link was detected)");
                if (linkIndex > -1)
                {
                    var linkInfo = thisText.textInfo.linkInfo[linkIndex];
>>>>>>> parent of c8edddb (Revert "TMP Fixes")

                var linkId = linkInfo.GetLinkID();

                var Word = FindObjectOfType<WordData>().Get(linkId);

<<<<<<< HEAD
                brainText.text += Word.Name + ", ";
                Debug.Log("linkId variable: " + linkId);
                Debug.Log("Link text: " + linkInfo.GetLinkText());
                Debug.Log("Word.LinkId: " + Word.LinkId);
                Debug.Log("Word.Description: " + Word.Description);
                Debug.Log("Word.Name: " + Word.Name);
                Debug.Log("RETURN");
            }
        }
=======
                  

                    brainText.text += Word.Name + ", ";
                    //if (Word.Name == "SixAM" || Word.Name == "Solfield")
                    //{
                    //    playerController.routineMngr.routine.State = "Psych";
                    //}
                    if (Word.Name == "SixAM" || Word.Name == "Solfield")
                    {
                        playerController.routineMngr.routine.State = "Psych";
                    }
                    //Debug.Log("linkId variable: " + linkId);
                    //Debug.Log("Link text: " + linkInfo.GetLinkText());
                    //Debug.Log("Word.LinkId: " + Word.LinkId);
                    //Debug.Log("Word.Description: " + Word.Description);
                    //Debug.Log("Word.Name: " + Word.Name);
                    //Debug.Log("RETURN");
                }
            }
        }
        else if (playerController.brainVisible == false && playerController.computerVisible == true)
        {
            thisText.text += "\n<color=green>Press M to think about words ! </color>";
        }

>>>>>>> parent of c8edddb (Revert "TMP Fixes")
    }
}