﻿using UnityEngine;

[System.Serializable]
public class SM_PanelData {
    [Header("Panel Settings: ")]
    [Tooltip("Name of the panel")]
    public string name;
    [Range(0, 100)]
    [Tooltip("Spawnrate of how much the panel will spawn")]
    public float spawnrate = 10;
    [Range(0, 100)]
    [Tooltip("Strength")]
    public float strength = 20;
    [Tooltip("Image of the panel")]
    public Sprite image;
}
