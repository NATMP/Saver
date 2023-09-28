using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerButtonSense : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private bool isBtnLeft;
    private float direction;
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerInputManager.Instance.IsMoving = true;
        direction = (isBtnLeft) ? -1 : 1;
        PlayerInputManager.Instance.Direction = direction;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        if (PlayerInputManager.Instance.IsMoving)
        {
            direction = (isBtnLeft) ? -1 : 1;
            PlayerInputManager.Instance.Direction = direction;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        if (PlayerInputManager.Instance.IsMoving)
        {
            PlayerInputManager.Instance.Direction = 0;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerInputManager.Instance.IsMoving = false;
    }
}
