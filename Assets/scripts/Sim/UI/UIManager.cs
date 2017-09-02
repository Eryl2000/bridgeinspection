﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    //private GameManager gameManager;
   
    
	// Use this for initialization
	void Start () {
                
        //gameManager = GameManager.getInstance();
        


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", false);
        
    }

    public void EnableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", true);
    }

    public void ToggleBoolAnimator(Animator anim)
    {
        //bool displayed;
       // displayed = anim.GetBool("IsDisplayed");

        anim.SetBool("IsDisplayed", !anim.GetBool("IsDisplayed"));
    }

}
