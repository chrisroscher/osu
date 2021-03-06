﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Rulesets.Mods;

namespace osu.Game.Rulesets.Catch.Mods
{
    public class CatchModHidden : ModHidden
    {
        public override string Description => @"Play with fading notes for a slight score advantage.";
        public override double ScoreMultiplier => 1.06;
    }
}
