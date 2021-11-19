using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13._11._21
{
    interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
