using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    [SerializeField] Text text;
    private string text1;
    private void Update() {
        text1 = Convert.ToString(Health_Enemy.score);
        text.text = text1;
    }
}
