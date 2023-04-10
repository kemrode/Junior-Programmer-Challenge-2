using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float launchDog;
    private const float timeBetweenTwoLaunches = 0.25f;

    // Update is called once per frame
    private void Start()
    {
    }

    void Update()
    {
        if(launchDog > 0)
        {
            launchDog -= Time.deltaTime;
        }
        LaunchDogOnSpacebarAction();
    }

    void LaunchDogOnSpacebarAction()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(launchDog <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                launchDog = timeBetweenTwoLaunches;
            }
        }
    }
}
