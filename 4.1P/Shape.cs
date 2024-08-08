using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected;
        private static Dictionary<string, Type> _shapeClassRegistry = new Dictionary<string, Type>();

        public Shape(Color color)
        {
            _color = color;
            _x = 0;
            _y = 0;
            _selected = false;
        }

        public Shape() : this(Color.Yellow)
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

        public abstract void Draw();

        public abstract void DrawOutline();

        public virtual void SaveTo(StreamWriter writer)
        {
            writer.WriteLine(GetShapeKeyValue(this.GetType()));
            writer.WriteColor(_color);
            writer.WriteLine(_x);
            writer.WriteLine(_y);
        }

        public virtual void LoadFrom(StreamReader reader)
        {
            Color = reader.ReadColor();
            X = reader.ReadInteger();
            Y = reader.ReadInteger();
        }

        public abstract bool IsAt(Point2D pt);
    }
}