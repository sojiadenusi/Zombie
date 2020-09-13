using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    [SerializeField] int currWeapon = 0;


    
    void Start()
    {
        SetWeaponActive();
    }

    

  
    void Update()
    {
        int previousWeapon = currWeapon;

        ProcessKeyInput();

        ProcessScrollWheel();

        if(previousWeapon != currWeapon)
        {
            SetWeaponActive();
        }
    }

    private void ProcessScrollWheel()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currWeapon >= transform.childCount - 1)
            {
                currWeapon = 0;
            }
            else
            {
                currWeapon++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currWeapon <= 0)
            {
                currWeapon = transform.childCount - 1;
            }
            else
            {
                currWeapon--;
            }
        }
        
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currWeapon = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currWeapon = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currWeapon = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currWeapon = 5;
        }
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;

        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }
}
