using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] float healthPoints = 100f;

    int weaponLength;
    int weaponActiveRN;

    // Start is called before the first frame update
    void Start()
    {
        weaponLength = weapons.Length;
        weaponActiveRN = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //WeaponToggle(weapons);      

    }

    private void WeaponToggle(GameObject[] weapons)
    {
        if (CrossPlatformInputManager.GetButtonDown("Weapon Swap"))
        //if (Input.GetKeyDown(KeyCode.Q))
        {
            if (weaponActiveRN == weaponLength - 1)
            {
                weapons[weaponActiveRN].SetActive(false);
                weaponActiveRN = 0;
                weapons[weaponActiveRN].SetActive(true);
                weaponActiveRN--;
            }
            else
            {

                weapons[weaponActiveRN].SetActive(false);
                weapons[weaponActiveRN + 1].SetActive(true);
            }

            weaponActiveRN++;
        }

    }

    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
        if(healthPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
            //Debug.Log("WE JUST TOOK A FAT L");
        }
    }
}
