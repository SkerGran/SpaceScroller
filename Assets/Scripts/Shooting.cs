using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public GameObject bullet;
    public float timeBetweenShots;
    private bool canShot = true;

    public static Shooting instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.instance.isPaused)
        {
            if (Input.GetMouseButtonDown(0) && canShot)
            {
                Shoot();
            }
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
        StartCoroutine(ShootDelay());
        AudioManager.Instance.PlaySfx(3);
    }

    IEnumerator ShootDelay()
    {
        canShot = false;
        yield return new WaitForSeconds(timeBetweenShots);
        canShot = true;
    }

}
