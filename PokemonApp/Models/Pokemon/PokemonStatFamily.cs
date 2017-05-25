using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonApp.Models.Pokemon
{
    public class PokemonStatFamily
    {
        private int hp;
        private int atk;
        private int def;
        private int spec_atk;
        private int spec_def;
        private int speed;

        private int Val(int i) { return Functions.Validate.OneOrGreater(i); }

        public int Hp {
            get { return hp; }
            set { hp = Val(value); }
        }

        public int Atk
        {
            get { return atk; }
            set { atk = Val(value);  }
        }

        public int Def
        {
            get { return def; }
            set { def = Val(value);  }
        }

        public int SpecAtk
        {
            get { return spec_atk;  }
            set { spec_atk = Val(value);  }
        }

        public int SpecDef
        {
            get { return spec_def; }
            set { spec_def = Val(value);  }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = Val(value);  }
        }

        public PokemonStatFamily(int hp, int atk, int def, int spec_atk, int spec_def, int speed)
        {
            Hp = hp;
            Atk = atk;
            Def = def;
            SpecAtk = spec_atk;
            SpecDef = spec_def;
            Speed = speed;
        }

        public override string ToString()
        {
            string output = "";
            output += $"\nHP:      {Hp}";
            output += $"\nAtk:     {Atk}";
            output += $"\nDef:     {Def}";
            output += $"\nSpecAtk: {SpecAtk}";
            output += $"\nSpecDef: {SpecDef}";
            output += $"\nSpeed:   {Speed}";

            return output;
        }
    }
}
