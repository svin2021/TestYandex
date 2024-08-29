using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNGAnswere : MonoBehaviour
{
    [SerializeField] private string[] Answeres;
    void Start()
    {
        Text text = GetComponent<Text>();
        text.text = Answeres[Random.RandomRange(0, Answeres.Length)];
    }
}
