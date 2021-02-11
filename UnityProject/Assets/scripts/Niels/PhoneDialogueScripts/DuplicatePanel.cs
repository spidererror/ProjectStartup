using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DuplicatePanel : MonoBehaviour
{
    public Text textChange;
    public RectTransform objectToDuplicate;
    public Transform parent;
    public float offset = 20;
    private int textLength;

    private List<RectTransform> allDuplicates = new List<RectTransform>();

    private void Start()
    {
        textLength = textChange.text.Length;
    }

    private void Update()
    {
        duplicate();
    }

    private void duplicate()
    {
        string currentText = textChange.text;
        if (currentText.Length != textLength)
        {
            Instantiate(objectToDuplicate, parent);
            //positoinPreviousDuplicates();
            allDuplicates.Add(objectToDuplicate);
            textLength = currentText.Length;
        }
    }

    private void positoinPreviousDuplicates()
    {
        for (int i = 0; i < allDuplicates.Count; i++)
        {
            if (i > 0)
            {
                allDuplicates[i].transform.position = new Vector3(allDuplicates[i].transform.position.x, allDuplicates[i].transform.position.y + offset, allDuplicates[i].transform.position.z);
            }

        }
    }


}
