using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    int hP = 3;

    float timer;
    bool invincible = false;

    Material mWhite;
    Material mDefault;
    SpriteRenderer sRend;

    // Start is called before the first frame update
    void Start()
    {
        sRend = GetComponent<SpriteRenderer>();
        mDefault = sRend.material;
        mWhite = Resources.Load("mWhite", typeof(Material)) as Material;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            invincible = false;
        }
        if (hP <= 0)
        {
            Time.timeScale = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            if (hP == 3)
            {
                Resize();
            }
            --hP;
        }
    }

    void Resize()
    {
        gameObject.transform.localScale -= new Vector3(0,0.5f,0);
        StartCoroutine("Flash");
    }

    void InvinciblePeriod()
    {
        timer = 1;
        if (timer > 0)
        {
            invincible = true;
        }
    }

    IEnumerator Flash()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(0.25f);
            sRend.material = mWhite;
            Invoke("ResetMaterial",0f);
        }
    }

    void ResetMaterial()
    {
        sRend.material = mDefault;
    }
}
