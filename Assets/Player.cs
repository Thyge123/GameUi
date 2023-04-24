using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Health;
    public int Ammo;

    public Text HealthText;
    public Text AmmoText;

    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP: {Health}";
    }

    public void IncreaseAmmo(int value)
    {
        Ammo += value;
        AmmoText.text = $"Ammo: {Ammo}";
    }
}