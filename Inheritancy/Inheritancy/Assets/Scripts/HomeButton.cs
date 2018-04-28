using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HomeButton : MonoBehaviour, IPointerClickHandler {

    public HomePage homePage;

    //This gets called in unity
    void OnValidate() {
        homePage = FindObjectOfType<HomePage>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        MenuController.Instance.GoToPage(homePage);
    }
}
