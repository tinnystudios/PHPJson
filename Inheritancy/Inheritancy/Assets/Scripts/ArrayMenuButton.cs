using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArrayMenuButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //"This" refers to ArrayMenuButton component
        ArrayMenuController.Instance.GoToPageByMenuButton(this);
    }
}
