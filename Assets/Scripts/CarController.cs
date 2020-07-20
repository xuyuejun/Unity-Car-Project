using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
[RequireComponent(typeof(LightingManager))]

public class CarController : MonoBehaviour
{
    public InputManager im;
    public LightingManager lm;
    // public UIManager uim;
    public List<GameObject> tailLights;


    void Start() {
        im = GetComponent<InputManager>();
    }

    void Update()
    {
        if (im.l)
        {
            lm.ToggleHeadlights();
        }

        foreach (GameObject tl in tailLights)
        {
            tl.GetComponent<Renderer>().material.SetColor("_EmissionColor", im.brake ? new Color(0.5f, 0.111f, 0.111f) : Color.black);
        }

        //  uim.changeText(transform.InverseTransformVector(rb.velocity).z);
    }

    // Update is called once per frame
}