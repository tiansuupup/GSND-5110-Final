using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{

    public Transform[] CardPoints; //Create the positions
    public GameObject[] Cards; //load all the cards
    private int UpCards = 0;
    public int CompareID1 = 0;
    public int CompareID2 = 0;
    public string CardName1 = "";
    public string CardName2 = "";
    void Start()
    {
        Cards.Shuffle(24);//Randomly shuffle swap 24 cards
        PutCards();


    }

    // Update is called once per frame
    void Update()
    {
        if (UpCards == 2)
        {
            StartCoroutine(CompareTwoCards());
        }
    }

    void PutCards()
    {
        for (int i = 0; i < Cards.Length; i++)
        {
            Cards[i].transform.position = CardPoints[i].position;
        }
    }

    public void CardTurningUp()
    {
        UpCards++;
    }
    
    IEnumerator CompareTwoCards()
    {
        if (CompareID1 == CompareID2)
        {
            Debug.Log("Yes");

            CompareID1 = 0;
            CompareID2 = 0;
            CardName1 = "";
            CardName2 = "";
            yield return new WaitForSeconds(0.8f);
        }


        else
        {
            Debug.Log("No");
            GameObject.Find(CardName1).transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
            GameObject.Find(CardName2).transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
            CompareID1 = 0;
            CompareID2 = 0;
            CardName1 = "";
            CardName2 = "";

            yield return new WaitForSeconds(1.5f);
        }

    }


}
