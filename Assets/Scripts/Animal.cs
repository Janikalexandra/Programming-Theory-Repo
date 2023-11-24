using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private float m_AnimalSpeed;
    [SerializeField] private GameObject[] animals;

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

    protected void Start()
    {
        SpawnAnimals();
        PrintInformation();
    }

    // ABSTRACTION
    protected void SpawnAnimals()
    {
        for(int i = 0; i < animals.Length; i++)
        {
            Instantiate(animals[i]);
        }
    }
    // POLYMORPHISM IMPLEMENTED
    public virtual void PrintInformation()
    {
        print("Animal Max Speed: " + m_AnimalSpeed);
    }
}
