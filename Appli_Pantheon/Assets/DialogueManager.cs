using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;
	public Animator animator;
	public int indice;
	public int cpt = 0;
	public int OeufClick = 0;
	public GameObject Oeuf;
	public Sprite Oeuf0, Oeuf1, Oeuf2, Oeuf3, Oeuf4, Oeuf5, Oeuf6, Oeuf7, Oeuf8, Oeuf9, Oeuf10;
	public GameObject Oeuff;
	public GameObject Sun;
	public GameObject Stop;
	public GameObject Continue;
	public GameObject movie;


	void Awake(){
		
	}

	private Queue<string> sentences;

	void Start () {
		sentences = new Queue<string> ();

		
	}
		

	public void StartDialogue(Dialogue dialogue){

		animator.SetBool ("IsOpen", true);

		Debug.Log ("Starting conversation with " + dialogue.name);

		nameText.text = dialogue.name;
		nameText.text = "Narrateur";



		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) {
			sentences.Enqueue (sentence);
		}
	}

		public void DisplayNextSentence(){
			if(sentences.Count == 0){

				EndDialogue();
			Sun.gameObject.SetActive (false);
			Continue.gameObject.SetActive (false);
			movie.gameObject.SetActive (true);


				return;
			}
		if(cpt != 2){
		string sentence = sentences.Dequeue ();
		dialogueText.text = sentence;
		StopAllCoroutines ();
		StartCoroutine (TypeSentence (sentence));
		cpt++;
		if (cpt == 5 || cpt == 12) {
			nameText.text = "Singe inconnu";
		} else if (cpt == 6 || cpt == 8 || cpt == 13) {
			nameText.text = "Narrateur";
				if (cpt == 13) {
					
				}
		} else if (cpt == 7) {
			nameText.text = "Singe inconnu 2";
		}
	}else{
			if (cpt == 2) {
				Stop.gameObject.SetActive (true);
				Oeuf.gameObject.SetActive (true);
			}
				if (verif ()) {
					cpt++;
			}
	}

		if (cpt == 4) {
			Oeuff.gameObject.SetActive (false);
			Sun.gameObject.SetActive (true);
		}

		if (cpt == 14) {
			Sun.gameObject.SetActive (false);
		
		}

		}

		IEnumerator TypeSentence (string sentence){
			dialogueText.text = "";

			foreach (char letter in sentence.ToCharArray()) {
				dialogueText.text += letter;
				yield return null;

			}

		}

		void EndDialogue(){
			Debug.Log("End conv");
		animator.SetBool ("IsOpen", false);


		}
		
	public void Clicked(){
		OeufClick += 1;
		Debug.Log ("click: " + OeufClick);
		switch (OeufClick) {
			case 1:
			Oeuf.GetComponent<Image> ().sprite = Oeuf1;
			break;

			case 2:
				Oeuf.GetComponent<Image> ().sprite = Oeuf2;
				break;

			case 3:
				Oeuf.GetComponent<Image> ().sprite = Oeuf3;
				break;

			case 4:
				Oeuf.GetComponent<Image> ().sprite = Oeuf4;
				break;

			case 5:
				Oeuf.GetComponent<Image> ().sprite = Oeuf5;
				break;

			case 6:
				Oeuf.GetComponent<Image> ().sprite = Oeuf6;
				break;

			case 7:
				Oeuf.GetComponent<Image> ().sprite = Oeuf7;
				break;

			case 8:
				Oeuf.GetComponent<Image> ().sprite = Oeuf8;
				break;

			case 9:
				Oeuf.GetComponent<Image> ().sprite = Oeuf9;
				break;

			case 10:
				Oeuf.GetComponent<Image> ().sprite = Oeuf10;
				break;
		}

		//Oeuf.GetComponent<SpriteRenderer> ().sprite = Oeuf1;
		if (OeufClick == 10) {
			Stop.gameObject.SetActive (false);
			Oeuf.gameObject.SetActive (false);
			Oeuff.gameObject.SetActive (true);
			verif ();
		}
	}

	public bool verif(){

		return true;
	}

			

}
