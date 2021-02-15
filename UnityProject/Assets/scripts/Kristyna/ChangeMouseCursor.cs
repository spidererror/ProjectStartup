using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMouseCursor : MonoBehaviour
{
    [SerializeField]
    public Texture2D CursorBMP;//needs bit map image
    void Start()
    {
        Cursor.SetCursor(CursorBMP, Vector2.zero, CursorMode.ForceSoftware);
    }
}
