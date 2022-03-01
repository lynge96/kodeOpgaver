using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Vehicle
/// </summary>
public class Vehicle
{
    // defining members
    public string _regno, _colour;
    protected Int32 _year;
    protected string _make, _model;

    // a constructor
    public Vehicle(string r, string c)
    {
        _regno = r;
        _colour = c;
    }

    // another constructor
    public Vehicle(string r, string c, Int32 y, string make, string model)
    {
        _regno = r;
        _colour = c;
        _year = y;
        _make = make;
        _model = model;
    }

    // properties to get and set regno
    public string regno
    {
        get
        {   return _regno; }
        set
        {
            _regno = value;
        }
    }

    // properties to get and set colour
    public string colour
    {
        get
        {
            return _colour;
        }
        set
        {
            _colour = value;
        }
    }

    // a method to get year
    public Int32 getYear()
    {
        return _year;
    }

    // a method to get make
    public string getMake()
    {
        return _make;
    }

    // a method to get model
    public string getModel()
    {
        return _model;
    }
}