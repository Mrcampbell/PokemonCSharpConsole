using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonApp.Functions
{
    public static class Validate
    {
        public static int OneOrGreater(int i)
        {
            return (i > 1) ? i : 1;
        }
    }
}
