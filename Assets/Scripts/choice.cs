using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class choice : MonoBehaviour
{
    public dialogue YesDialogue;
    public dialogue NoDialogue;
    public GameObject choiceCanvas;
    public GameObject yesCanvas;
    public GameObject NoCanvas;
    public GameObject Enemy;

       public void Yes(){
        choiceCanvas.SetActive(false);
        yesCanvas.SetActive(true);
        YesDialogue.startDialogue();
    }
    public void No(){
        choiceCanvas.SetActive(false);
        NoCanvas.SetActive(true);
    NoDialogue.startDialogue();
    Enemy.SetActive(true);
    }
    
}