using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new Language", menuName = "Core/Language")]
public class Language : ScriptableObject
{
	[SerializeField]
	private string _name;
	public string Name => _name;
	[SerializeField]
	private Texture2D _flag;
	public Texture2D Flag => _flag;
}
