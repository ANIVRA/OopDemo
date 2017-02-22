using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopDemo.Models
{
    public interface IDirection
    {
        int Up();
        int Down();
        int Left();
        int Right();
    }
}