using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdjustSizeBox : MonoBehaviour
{
    public Text adjustableText;
    public RectTransform objectToAdjust;
    
    public float sizeChange = 30;
    public float addSize = 80;
    public float minSize = 40;
    private void Update()
    {
        AdjustHeight();
    }

    private void AdjustHeight()
    {
        string text = adjustableText.text;

        if (text.Length > sizeChange)
        {
            objectToAdjust.sizeDelta = new Vector2(objectToAdjust.rect.width, objectToAdjust.rect.height + addSize);
            sizeChange *= 2;
        }
        if (text.Length < sizeChange && objectToAdjust.rect.height > minSize)
        {
            objectToAdjust.sizeDelta = new Vector2(objectToAdjust.rect.width, objectToAdjust.rect.height - addSize);
            sizeChange *= .5f;
        }
    }
}
