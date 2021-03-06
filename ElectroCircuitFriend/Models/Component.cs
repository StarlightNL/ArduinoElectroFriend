﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ElectroCircuitFriend.Models
{
    public enum ComponentCategories
    {
        Misc,
        Transistor,
        PowerSupply,
        Resistor,
        Diode,
        Led,
        CeramicCap,
        ElectrolyticCap,
        Motor,
        Servo,
        Stepper,
        Driver,
        Microcontroller,
        SingleBoardComputer,
        Cables
    }

    public class Component
    {
        public int Id { get; set; }
        public ComponentCategories ComponentCategory { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExtraDescription { get; set; }
        public string ComponentImage { get; set; }
        public string ComponentPinoutImage { get; set; }
        public string DataSheet { get; set; }
        [DefaultValue(0)]
        public int InStock { get; set; }
        [DefaultValue(0)]
        public int Used { get; set; }
        public virtual Battery Battery { get; set; }
        public virtual Capacitor Capacitor { get; set; }
        public virtual Resistor Resistor { get; set; }
        public virtual Transistor Transistor { get; set; }

        internal Component()
        {
        }
    }
}