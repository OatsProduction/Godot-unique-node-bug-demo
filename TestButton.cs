using Godot;
using System;

public partial class TestButton : Button
{
	public void _on_pressed()
	{
		GD.Print(GetNode<Hud>("%Hud"));
		GetNode<GlobalScript>("/root/GlobalScript").testUniqueNode();
	}
}
