using Godot;
using System;

public partial class GlobalScript : Node
{
	public void testUniqueNode()
	{
		GD.Print(GetNode<Hud>("%Hud"));
	}
}
