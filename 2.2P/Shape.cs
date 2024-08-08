using System;
using System.Collections.Generic;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x, _y;
        public int _height = 100;
        public int _width = 100;
        private Color _background;
        private static Dictionary<string, Type> _shapeClassRegistry = new Dictionary<string, Type>();

        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
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

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
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
        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }
        

        public bool IsAt(Point2D pt)
        {
            if (pt.X >= _x && ( pt.X <= (_x + _width) ) && pt.Y >= _y && ( pt.Y <= (_y + _height) ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}