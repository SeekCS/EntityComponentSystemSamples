﻿using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

namespace Scenes.TestDuplicateProperties
{
    [GenerateAuthoringComponent]
    [MaterialProperty("_DuplicateColor", MaterialPropertyFormat.Float4)]
    public struct DuplicateTestColorB : IComponentData
    {
        public float4 Value;
    }
}
