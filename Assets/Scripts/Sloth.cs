
// INHERITANCE IMPLEMENTED
using System;
using UnityEngine;

public class Sloth : Animal
{
    public override void PrintInformation(float speed)
    {
        print("Animal Max Speed: " + speed);
        AnimalSpeed = speed;
    }

    private void OnMouseDown()
    {
        AnimalSpeed = 3;
        PrintInformation(3);
    }
}
