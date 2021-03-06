﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Message_Center : MonoBehaviour {
    [Header("Text Screen")]
    [SerializeField]
    private Text Main_Text;

    private void Start() {
        ResetText();
        Event_Manager.SetMessageText += SetText;
    }
    
    //Set the text in the textfield
    private void SetText(string text) {
        Main_Text.DOText(text, 2, true, ScrambleMode.All);
    }

    //Clear the text in the textfield
    void ResetText() {
        Main_Text.text = "";
    }
}
