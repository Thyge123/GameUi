using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoUI : MonoBehaviour
{
    public static AmmoUI Instance;

    [SerializeField]
    private int _currentAmmo;

    [SerializeField]
    private int _maxAmmo = 30;

    private int _minAmmo = 0;

    public TMP_Text AmmoText;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        _currentAmmo = _maxAmmo;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fireWeapon();
        }
    }

    private void fireWeapon()
    {
        _currentAmmo--;
        int ammoClamp = Mathf.Clamp(_currentAmmo, _minAmmo, _maxAmmo);
        _currentAmmo = ammoClamp;
        UpdateAmmoText();
    }

    private void UpdateAmmoText()
    {
        AmmoText.text = "Ammo: " + _currentAmmo.ToString();
    }

    public void InceaseAmmo(int value)
    {
        if (_currentAmmo < _maxAmmo)
        {
            while (_currentAmmo < _maxAmmo)
            {
                _currentAmmo += value;
                UpdateAmmoText();
            }
        }
    }
}