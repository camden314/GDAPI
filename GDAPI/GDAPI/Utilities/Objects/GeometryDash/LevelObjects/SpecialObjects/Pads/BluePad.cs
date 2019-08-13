﻿using GDAPI.Utilities.Attributes;
using GDAPI.Utilities.Enumerations.GeometryDash;
using GDAPI.Utilities.Information.GeometryDash;
using GDAPI.Utilities.Objects.GeometryDash.LevelObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDAPI.Utilities.Objects.GeometryDash.LevelObjects.SpecialObjects.Pads
{
    /// <summary>Represents a blue pad.</summary>
    [ObjectID(PadType.BluePad)]
    public class BluePad : Pad
    {
        /// <summary>The object ID of the blue pad.</summary>
        [ObjectStringMappable(ObjectParameter.ID)]
        public override int ObjectID => (int)PadType.BluePad;

        /// <summary>Initializes a new instance of the <seealso cref="BluePad"/> class.</summary>
        public BluePad() : base() { }

        /// <summary>Returns a clone of this <seealso cref="BluePad"/>.</summary>
        public override GeneralObject Clone() => AddClonedInstanceInformation(new BluePad());
    }
}