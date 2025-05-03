using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimator : MonoBehaviour
{
    private bool animStarted = false;
    private Vector3 newCoinPosition;
    private GameObject coinsAudio;

    private void Start()
    {
        coinsAudio = GameObject.FindWithTag("CoinsAudio");
        newCoinPosition = new Vector3(transform.position.x, transform.position.y + 3.5f, transform.position.z);
    }

    private void FixedUpdate()
    {
        if(animStarted)
        {
            transform.position = Vector3.Lerp(transform.position, newCoinPosition, 3f * Time.deltaTime);
        }
    }

    public void StartAnimation()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        coinsAudio.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<Animator>().SetBool("isActive", true);
        animStarted = true;
    }

    public void EndAnimation()
    {
        Destroy(gameObject);
    }
}
