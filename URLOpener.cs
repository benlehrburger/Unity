using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class URLOpener : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }
}
