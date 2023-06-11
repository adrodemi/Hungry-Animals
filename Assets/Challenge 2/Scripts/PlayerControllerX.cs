using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float cooldown = 2;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            cooldown = 2;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        else if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }
}
