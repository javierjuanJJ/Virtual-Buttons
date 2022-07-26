using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonBehaviour : MonoBehaviour
{

    [SerializeField]
    private GameObject cube;

    private VirtualButtonBehaviour vButton;


    private void Awake()
    {
        vButton = GetComponent<VirtualButtonBehaviour>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(false);
        
        vButton.RegisterOnButtonPressed(onButtonPressed);
        vButton.RegisterOnButtonReleased(onButtonReleased);

    }

    private void onButtonReleased(VirtualButtonBehaviour obj)
    {
        cube.SetActive(false);
    }

    private void onButtonPressed(VirtualButtonBehaviour obj)
    {
        cube.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
