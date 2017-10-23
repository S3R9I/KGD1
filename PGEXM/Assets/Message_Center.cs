﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message_Center : MonoBehaviour {
    [Header("Text Screen")]
    [SerializeField]
    private Text Main_Text;

    private void Start() {
        ResetText();
        Event_Manager.SetMessageText += SetText;
    }

    private void SetText(string text) {
        Main_Text.text = text;
    }

    void ResetText() {
        Main_Text.text = "";
    }
}