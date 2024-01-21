using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class OnMouse : MonoBehaviour
{

    [SerializeField] Texture2D cursorTextureDefault;
    [SerializeField] Texture2D cursorTexture;
    [SerializeField] CursorMode cursorMode = CursorMode.Auto;
    [SerializeField] Vector2 hotSpot = Vector2.zero;
    [SerializeField] Animator CameraAnimator;
    [SerializeField] Animator Door;
    private void Start()
    {
        Cursor.SetCursor(cursorTextureDefault, hotSpot, cursorMode);
    }
    private void OnMouseUpAsButton()
    {
        CameraAnimator.SetTrigger("ClickDoor");
        Door.SetTrigger("OpenDoor");
    }
    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture,hotSpot,cursorMode);
    }
    private void OnMouseExit()
    {
        Cursor.SetCursor (cursorTextureDefault, Vector2.zero,CursorMode.Auto);
    }
}
