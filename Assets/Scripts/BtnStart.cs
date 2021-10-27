using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnStart : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {


    public void OnPointerDown( PointerEventData eventData )
    {
        Debug.Log( "Down" );
        SceneManager.LoadScene( "_Level_1" );
    }


    public void OnPointerUp( PointerEventData eventData )
    {
        Debug.Log( "Up" );
    }

}