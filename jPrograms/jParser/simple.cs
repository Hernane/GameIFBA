using UnityEngine;
using System;
using System.Collections;
using System.IO;

using jParser; // load library

public class simple : MonoBehaviour {

	private string reText = "Simple";
	private string reText1 = "Hernane";
	private jParse parse;
	private string file;
	
	void Start () {
		
		file = Application.dataPath + "/jPrograms/jParser/simple.ini"; // Set ini file path
		parse = new jParse(file);
		//parse.Default = "ERROR"; // for Empty value
	}
	
	void OnGUI()
	{
		
		// LOAD VALUE
		//parse.Int("Category","Key"); // for int values
		//parse.Float("Category","Key"); // for float values
		//float Float = parse.Float("Category","Key");
		//string String = parse.String("Category","Key"); // for string values
		GUILayout.BeginArea(new Rect(10,10,400,800));
		//GUILayout.Label(String);
		reText = GUILayout.TextArea(reText,GUILayout.Width(200));
		reText1 = GUILayout.TextArea(reText1,GUILayout.Width(200));
		
		if (GUILayout.Button("Change Value",GUILayout.Width(200)))
		{
		parse.Save("Variaveis", "VarA", reText); // save new Value to ini file
		parse.Save("Variaveis", "VarB", reText1);
		}
		GUILayout.Button("Variavel",GUILayout.Width(200));
		GUILayout.EndArea();
	}
	
	
}
