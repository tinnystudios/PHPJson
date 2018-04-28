using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerClickHandler
{
    public PageView pageToOpen;

    public void OnPointerClick(PointerEventData eventData)
    {
        MenuController.Instance.GoToPage(pageToOpen);
    }
}
