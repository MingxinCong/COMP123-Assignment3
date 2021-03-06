﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment3
{
    abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
        }
        public int RingCount
        {
            get
            {
                return _ringCount;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
        }

        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Diameter: {Diameter}, Mass: {Mass}";
        }
    }
}
