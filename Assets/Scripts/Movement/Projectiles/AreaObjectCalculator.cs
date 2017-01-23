using System.Collections.Generic;
using UnityEngine;

public class AreaObjectCalculator : MonoBehaviour
{
    /// <summary>
    /// Gets all gameobjects with certain tags in the area.
    /// </summary>
    /// <param name="_range">The size of the area.</param>
    /// <param name="_acceptedTags">All of the tags which will be accepted.</param>
    /// <returns>All the gameobjects with the given tags in the area.</returns>
	public GameObject[] GetObjectsInArea(float _range = 1, params string[] _acceptedTags)
    {
        var allColliders = Physics.OverlapSphere(this.transform.position, _range);
        var acceptedGameobjects = new List<GameObject>();

        foreach (var collider in allColliders)
        {
            for (int i = 0; i < _acceptedTags.Length; i++)
            {
                if (collider.CompareTag(_acceptedTags[i]))
                {
                    acceptedGameobjects.Add(collider.gameObject);
                }
            }
        }
        return acceptedGameobjects.ToArray();
    }
}