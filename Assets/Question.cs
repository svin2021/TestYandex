using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] private string[] questions;
    private int i;
    [SerializeField] private Text text;

    public void OnClick()
    {
        i++;
    }
    private void Update()
    {
        if (i >= questions.Length)
            SceneManager.LoadScene(1);
        else
            text.text = questions[i];
    }
}
