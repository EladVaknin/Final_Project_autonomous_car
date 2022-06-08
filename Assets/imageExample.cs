using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class imageExample : MonoBehaviour
{
    private ARTrackedImageManager _arARTrackedImageManager;

    private void Awake()
    {
        _arARTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }
    public void OnEnable()
    {
        _arARTrackedImageManager.trackedImagesChanged += OnImageChange;
    }
    public void OnDisable()
    {
        _arARTrackedImageManager.trackedImagesChanged -= OnImageChange;
    }


    public void OnImageChange(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }

    }
}
