using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioBros83
{
	class Player
	{
		public int x, y, scale, width, height, jumpTime;
		public string direction;
		Image sprite;
		public bool jump = false, left = false, right = false, isGrounded = false;

		public Player(int _x, int _y, int _scale, int _width, int _height, Image _sprite)
		{
			x = _x;
			y = _y;
			scale = _scale;
			width = _width;
			height = _height;
			sprite = _sprite;
		}
	}
}
