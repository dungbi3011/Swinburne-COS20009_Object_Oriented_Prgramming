using System;
using System.Collections.Generic;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        public float _height, _width;
        private bool _selected;
        private static Dictionary<string, Type> _shapeClassRegistry = new Dictionary<string, Type>();

        public Shape(int x, int y)
        {
            _color = Color.Green;
            _x = x;
            _y = y;
            _width = 100;
            _height = 100;
            _selected = false;
        }

        public Shape() : this(0, 0)
        {

        }

        public static void RegisterShape(string name, Type t)
        {
            _shapeClassRegistry[name] = t;
        }

        public static Shape CreateShape(string name)
        {
            return (Shape)Activator.CreateInstance(_shapeClassRegistry[name]);
        }

        public static string GetShapeKeyValue(Type type)
        {
            foreach (string key in _shapeClassRegistry.Keys)
            {
                if (_shapeClassRegistry[key] == type)
                {
                    return key;
                }
            }
            return null;
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }

            set
            {
                _selected = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }

        public bool IsAt(Point2D pt)
        {
            return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, Width, Height));
        }
    }
}

//Tran Quoc Dung 103803891 