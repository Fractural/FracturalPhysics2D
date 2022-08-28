﻿using Volatile;

namespace GodotFixedVolatilePhysics
{
    public struct VoltRect2
    {
        public VoltRect2(VoltVector2 position, VoltVector2 size)
        {
            Size = size;
            Position = position;
        }

        public VoltVector2 Size { get; set; }
        public VoltVector2 Position { get; set; }

        public VoltVector2 TopLeft => Position;
        public VoltVector2 TopRight => new VoltVector2(Position.x + Size.x, Position.y);
        public VoltVector2 BottomRight => new VoltVector2(Position.x + Size.x, Position.y + Size.y);
        public VoltVector2 BottomLeft => new VoltVector2(Position.x, Position.y + Size.y);

        public VoltVector2[] Points => new VoltVector2[]
        {
            TopLeft,
            TopRight,
            BottomRight,
            BottomLeft
        };
    }
}
