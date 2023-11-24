using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animal: MonoBehaviour
{
    [SerializeField] private float m_AnimalSpeed;

    // ENCAPSULATION IMPLEMENTED
    public float AnimalSpeed
    {
        get { return m_AnimalSpeed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Speed can't be a negative value");
            }
            else
            {
                m_AnimalSpeed = value;
            }
        }
    }

    // POLYMORPHISM IMPLEMENTED
    public virtual void PrintInformation(float speed)
    {
        m_AnimalSpeed = speed;
        print("Animal Max Speed: " + m_AnimalSpeed);
    }
}
