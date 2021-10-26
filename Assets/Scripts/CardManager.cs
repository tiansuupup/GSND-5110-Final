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
            UpCards = 0;
            yield return new WaitForSeconds(0.8f);
            yield break;
        }


        else
        {
            if (CompareID1 != CompareID2)
            {
                Debug.Log("No");
                UpCards = 0;
                yield return new WaitForSeconds(1.5f);
                GameObject.Find(CardName1).transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
                GameObject.Find(CardName2).transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);



                   if (GameObject.Find(CardName1).GetComponent<Card1>() != null)       //Now try to flip the first wrong card
                {
                    GameObject.Find(CardName1).GetComponent<Card1>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card2>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card2>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card3>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card3>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card4>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card4>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card5>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card5>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card6>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card6>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card7>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card7>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card8>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card8>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card9>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card9>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card10>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card10>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card11>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card11>().isUp = false;
                }
                if (GameObject.Find(CardName1).GetComponent<Card12>() != null)
                {
                    GameObject.Find(CardName1).GetComponent<Card12>().isUp = false;
                }


                if (GameObject.Find(CardName2).GetComponent<Card1>() != null)       //Now try to flip the second wrong card
                {
                    GameObject.Find(CardName2).GetComponent<Card1>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card2>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card2>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card3>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card3>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card4>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card4>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card5>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card5>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card6>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card6>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card7>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card7>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card8>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card8>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card9>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card9>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card10>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card10>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card11>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card11>().isUp = false;
                }
                if (GameObject.Find(CardName2).GetComponent<Card12>() != null)
                {
                    GameObject.Find(CardName2).GetComponent<Card12>().isUp = false;
                }









                CompareID1 = 0;
                CompareID2 = 0;
                CardName1 = "";
                CardName2 = "";
                
                
                yield break;

            }
               
        }

    }


}
