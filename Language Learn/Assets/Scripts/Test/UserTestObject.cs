using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new User", menuName = "TestData/User")]
public class UserTestObject : ScriptableObject
{
	public UserTestObject(string name, Texture2D texture, string languageId, int currency)
	{
		_name = name;
		_image = texture;
		_language = Resources.Load<Texture2D>($"Language Images/{languageId}");
	}

	[SerializeField]
	private string _name;
	public string Name => _name;
	[SerializeField]
	private Texture2D _image;
	public Texture2D Image => _image;
	[SerializeField]
	private Texture2D _language;
	public Texture2D Language => _language;
	[SerializeField]
	private int _currency;
	public int Currency => _currency;
}
