
// INHERITANCE IMPLEMENTED
using System;
using UnityEngine;

public class Sloth : Animal
{
    public float slothMaxSpeed;
    public string animalName;

    public override void PrintInformation()
    {       
        print("Animal Max Speed: " + slothMaxSpeed);
    }

    private void OnMouseDown()
    {
        AnimalSpeed = slothMaxSpeed;
        PrintInformation();
    }
}
