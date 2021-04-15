using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class TextClicker : MonoBehaviour, IPointerClickHandler
{
    public Camera camera;
    public TextMeshProUGUI brainText;
    public PlayerController playerController;
    public TMP_Text thisText;

    public void OnPointerClick(PointerEventData eventData)
    {
        thisText = GetComponentInChildren<TMP_Text>();

        //Debug.Log(text.text);
        if(playerController.brainVisible == true)
        {

            if (eventData.button == PointerEventData.InputButton.Left)
            {
                int linkIndex = TMP_TextUtilities.FindIntersectingLink(thisText, Input.mousePosition, camera);
                //Debug.Log("Link Index : " + linkIndex + "(if -1, no link was detected)");
                if (linkIndex > -1)
                {
                    var linkInfo = thisText.textInfo.linkInfo[linkIndex];

                    var linkId = linkInfo.GetLinkID();

                    var Word = FindObjectOfType<WordData>().Get(linkId);

                    brainText.text += Word.Name + ", ";
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
            thisText.text += " <color=green>Press M to think about words ! </color> ";
        }

    }
}