using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;
using UnityEngine.Playables;
public class introDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public PlayableDirector timeline;
    public dialogue dialogue;
        void Start()
    {
        textComponent.text= string.Empty;
        startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(textComponent.text==lines[index]){
                NextLine();
            }
            else{
                StopAllCoroutines();
                textComponent.text=lines[index];
            }
        }   
    }
    void startDialogue(){
        index=0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine(){
        foreach( char c in lines[index].ToCharArray()){
            textComponent.text+=c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine(){
        if(index< lines.Length -1){
            index++;
            textComponent.text= string.Empty;
            if (index == 2){
                dialogue.gameObject.SetActive(true);
                StartCoroutine(PlayTimeline());
            }
            else{
                StartCoroutine(TypeLine());
            }
        }
        else{
            gameObject.SetActive(false);
            Destroy(GameObject.Find("Bg image"));
            timeline.Play();
        }
    }
    IEnumerator PlayTimeline(){
        timeline.Play();
        yield return new WaitForSeconds((float)timeline.duration);
        dialogue.startDialogue();
    }
}
