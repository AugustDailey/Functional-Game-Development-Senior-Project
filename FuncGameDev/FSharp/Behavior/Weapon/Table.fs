﻿module WeaponBehaviorTable

let Instance : Collections.Map<int, WeaponBehaviorType.T> = 
    Map.empty
        .Add(0, NullWeapon.behavior)
        .Add(1, TestMeleeWeapon.behavior)
        .Add(2, TestRollWeapon.behavior)