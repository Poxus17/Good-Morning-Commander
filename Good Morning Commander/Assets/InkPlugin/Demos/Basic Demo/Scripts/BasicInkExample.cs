using UnityEngine;
using UnityEngine.UI;
using System;
using Ink.Runtime;
using System.Collections;
using TMPro;

// This is a super bare bones example of how to play and display a ink story in Unity.
public class BasicInkExample : MonoBehaviour {
	public static event Action<Story> OnCreateStory;
	public float textDelay;
	AudioSource audioSource;
	public RoutineMngr routineMngr;
	public TextMeshProUGUI timeCanvas;

	public delegate void ChangePsyState(bool isIn);
	public static event ChangePsyState OnChangePsyState;

	public delegate void RequestFade(bool status, float time);
	public static event RequestFade OnRequestFade;


	void Awake() {
		// Remove the default message
		RemoveChildren();
		StartStory();
		audioSource = GetComponent<AudioSource>();
		Ink_Unity_Comm_Handler();
	}

	// Creates a new Story object with the compiled story which we can then play!
	public void StartStory() {
		story = new Story(inkJSONAsset.text);
		if (OnCreateStory != null) OnCreateStory(story);
		Ink_Unity_Comm_Handler();
		RefreshView();

		if (OnChangePsyState != null)
		{
			OnChangePsyState(true); //Announce start of psych
		}
	}

    private void Update()
    {
		//Ink_Unity_Comm_Handler();
	}

	// This is the main function called every time the story changes. It does a few things:
	// Destroys all the old content and choices.
	// Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
	void RefreshView() {
		// Remove all the UI on screen
		RemoveChildren();

		// Read all the content until we can't continue any more
		while (story.canContinue) {
			// Continue gets the next line of the story
			string text = story.Continue();
			// This removes any white space from the text.
			text = text.Trim();
			// Display the text on screen!
			CreateContentView(text);
		}

		// Display all the choices, if there are any!
		if (story.currentChoices.Count > 0) {
			for (int i = 0; i < story.currentChoices.Count; i++) {
				Choice choice = story.currentChoices[i];
				Button button = CreateChoiceView(choice.text.Trim());
				// Tell the button what to do when we press it
				button.onClick.AddListener(delegate {
					OnClickChoiceButton(choice);
				});
			}
		}

		// If we've read all the content and there's no choices, the story is finished!
		else 
		{			
			Button choice = CreateChoiceView("Hmm..");
			choice.onClick.AddListener(delegate {
				//StartStory();
				RemoveChildren();
				CreateContentView("End of psych \nsession");
				routineMngr.routine.State = "Sleep";
				timeCanvas.text = "Time: Sleep";

				if (OnChangePsyState != null) 
				{
					OnChangePsyState(false); //Announce end of psych session
				}
			});
			
		}
	}
	
	void Ink_Unity_Comm_Handler()
	{
		story.ObserveVariable("State_Name", (string varName, object newValue) =>
		{
			//TestFunc_02(varName, (bool)newValue);
		});

	}

	//void TestFunc_02(string varName, bool newValue)
 //   {
	//	Debug.Log("Value of" + varName + " from Ink : " + newValue);
	//}
	
	//void TestFunc_01(string boolName)
	//{
	//	Debug.Log(boolName);
	//}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton (Choice choice) {
		story.ChooseChoiceIndex (choice.index);
		RefreshView();
	}

	// Creates a textbox showing the the line of text
	void CreateContentView (string text) {
		TMP_Text storyText = Instantiate (textPrefab, canvas.transform, false);
		//textClicker.thisText = storyText;

		//storyTMP_Text.text = text;
		//StartCoroutine(DisplayTMP_Text(storyText, text));
	}

	//IEnumerator DisplayTMP_Text(TMP_Text textElement, string text)
 //   {
	//	for(int i =0; i<text.Length; i++)
 //       {
	//		textElement.text += text[i];
	//		//audioSource.Play();
	//		yield return new WaitForSeconds(textDelay);
 //       }
 //   }

	IEnumerator DisplayTMP_Text(TMP_Text textElement, string text)
	{

		textElement.text = text;
		audioSource.Play();
		yield return new WaitForSeconds(textDelay);

	}

	// Creates a button showing the choice text
	Button CreateChoiceView (string text) {
		// Creates the button from a prefab
		var choice = Instantiate (buttonPrefab);
		choice.transform.SetParent (canvas.transform, false);
		
		// Gets the text from the button prefab
		var choiceTMP_Text = choice.GetComponentInChildren<Text> ();
		choiceTMP_Text.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent <HorizontalLayoutGroup> ();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}

	// Destroys all the children of this gameobject (all the UI)
	void RemoveChildren () {
		int childCount = canvas.transform.childCount;
		for (int i = childCount - 1; i >= 0; --i) {
			GameObject.Destroy (canvas.transform.GetChild (i).gameObject);
		}
	}        

	[SerializeField]
	private TextAsset inkJSONAsset = null;
	public Story story;

	[SerializeField]
	private Canvas canvas = null;

	// UI Prefabs
	[SerializeField]
	private TMP_Text textPrefab = null;
	[SerializeField]
	private Button buttonPrefab = null;
}
