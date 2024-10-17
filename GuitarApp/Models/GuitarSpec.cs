using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.CustomEnums;
namespace GuitarApp.Models
{
    public class GuitarSpec
{
    public Builder Builder { get; }
    public string Model { get; }
    public GuitarType Type { get; }
    public Wood BackWood { get; }
    public Wood TopWood { get; }
    public int NumStrings { get; }

    public GuitarSpec(Builder builder, string model, GuitarType type, int numStrings,
        Wood backWood, Wood topWood)
    {
        Builder = builder;
        Model = model;
        Type = type;
        NumStrings = numStrings;
        BackWood = backWood;
        TopWood = topWood;
    }

    public bool Matches(GuitarSpec otherSpec)
    {
        if (Builder != otherSpec.Builder) return false;
        if (!string.IsNullOrEmpty(Model) && !Model.Equals(otherSpec.Model)) return false;
        if (Type != otherSpec.Type) return false;
        if (NumStrings != otherSpec.NumStrings) return false;
        if (BackWood != otherSpec.BackWood) return false;
        if (TopWood != otherSpec.TopWood) return false;

        return true;
    }
}

}
