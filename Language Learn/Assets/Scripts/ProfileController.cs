using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ProfileController : MonoBehaviour
{
	[SerializeField]
	private ScrollView _view;
	[SerializeField]
	private VisualTreeAsset _treeAsset;

	public void OnEnable()
	{
		_view = GetComponent<UIDocument>().rootVisualElement.Q<ScrollView>();
		_view.Add(_treeAsset.CloneTree());
	}
}
