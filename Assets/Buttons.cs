using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Buttons SecondButton;
    [SerializeField] private Question question;
    [SerializeField] private string[] Answers;
    private Text text;
    public int i;
    private void Start()
    {
        text = GetComponentInChildren<Text>();
    }
    private void Update()
    {
        if (i < Answers.Length)
            text.text = Answers[i];
    }
    public void OnClick()
    {
        question.OnClick();
        SecondButton.i++;
        i++;
    }
}
