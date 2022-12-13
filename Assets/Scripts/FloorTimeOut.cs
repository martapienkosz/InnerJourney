using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTimeOut : MonoBehaviour
{

    public Transform spawnCard;
    public GameObject Card;


    public void Update()
    {
        Debug.Log(Card.transform.position);
        if (Card.transform.position.y < 0)
        {
            Debug.Log("itworks");
            Card.transform.position = spawnCard.position;
        }
    }
}