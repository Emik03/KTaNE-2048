﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class TileStyles
{
	public static readonly List<TileStyle> Styles = new List<TileStyle>
	{
		new TileStyle(2, "eee4da", true),
		new TileStyle(4, "eee1c9", true),
		new TileStyle(8, "f3b27a"),
		new TileStyle(16, "f69664"),
		new TileStyle(32, "f77c5f"),
		new TileStyle(64, "f75f3b"),
		new TileStyle(128, "edd073"),
		new TileStyle(256, "edcc62"),
		new TileStyle(512, "edc950"),
		new TileStyle(1024, "edc53f"),
		new TileStyle(2048, "edc22e")
	};

	public static readonly string BlackColor = "776e65";
	public static readonly string WhiteColor = "f9f6f2";

	public static Color ParseColor(string colorString)
	{
		Color color;
		if (ColorUtility.TryParseHtmlString("#" + colorString, out color)) return color;
		return Color.black;
	}

	public static TileStyle GetStyleForValue(int value)
	{
		return Styles.Any(s => s.Value == value) ? Styles.First(s => s.Value == value) : Styles.First();
	}
}

public class TileStyle
{
	public int Value;
	public Color Color;
	public Color TextColor;
	public TileStyle(int value, string colorString, bool blackText = false)
	{
		Value = value;
		Color = TileStyles.ParseColor(colorString);
		TextColor = TileStyles.ParseColor(blackText ? TileStyles.BlackColor : TileStyles.WhiteColor);
	}
}