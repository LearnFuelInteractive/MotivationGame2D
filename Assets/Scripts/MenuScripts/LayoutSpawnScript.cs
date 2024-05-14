using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LayoutSpawnScript : MonoBehaviour
{

    private string selectedClassLayoutKey = "SelectedClassLayout";
    public List<GameObject> classLayouts;
    // Start is called before the first frame update
    void Start()
    {
        var selectedLayout = PlayerPrefs.GetString(selectedClassLayoutKey);
      //  Instantiate(GetGameObjectWithRightTagFromList(selectedLayout, classLayouts), transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private static GameObject GetGameObjectWithRightTagFromList(string tag, List<GameObject> objects)
    {
        foreach (var obj in objects)
        {
            if (obj.tag == tag)
            {
                return obj;
            }
        }
        return null;
    }
}
