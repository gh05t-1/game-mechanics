using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animation : MonoBehaviour
{
    //Maak een variabele aan voor je animator component
    private Animator ani;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        //Pak het animator component en sla die op in de variabele
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {//Check voor verticale input
        if (Input.GetAxis("Vertical") > 0)
        {
            //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt
            //Roep de juiste trigger aan!
            ani.SetTrigger("Walk");
            //SetTrigger is trigger activeren
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("WalkR");
            //ResetTrigger is Trigger de-activeren
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            //is de waarde kleiner dan 0 dan heb je een knop naar beneden ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("WalkR");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Walk");
        }
        else
        {
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Idle");
            ani.ResetTrigger("Walk");
            ani.ResetTrigger("WalkR");
        }




        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKeyDown(KeyCode.P))
        {


            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("Jump");

        }


    }
}
