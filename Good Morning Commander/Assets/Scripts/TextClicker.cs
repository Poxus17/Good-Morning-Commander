using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class TextClicker : MonoBehaviour, IPointerClickHandler
{
    public Camera camera;
    public TextMeshProUGUI brainText;
    public void OnPointerClick(PointerEventData eventData)
    {
        var text = GetComponent<TextMeshProUGUI>();
        //Debug.Log(text.text);
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            int linkIndex = TMP_TextUtilities.FindIntersectingLink(text, Input.mousePosition, camera);
            Debug.Log("Link Index : " + linkIndex + "(if -1, no link was detected)");
            if (linkIndex > -1)
            {
                var linkInfo = text.textInfo.linkInfo[linkIndex];

                var linkId = linkInfo.GetLinkID();

                var Word = FindObjectOfType<WordData>().Get(linkId);

                brainText.text += Word.Name + ", ";
                Debug.Log("linkId variable: " + linkId);
                Debug.Log("Link text: " + linkInfo.GetLinkText());
                Debug.Log("Word.LinkId: " + Word.LinkId);
                Debug.Log("Word.Description: " + Word.Description);
                Debug.Log("Word.Name: " + Word.Name);
                Debug.Log("RETURN");
            }
        }
    }
}