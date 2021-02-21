﻿using System;
using Classic.Common;

namespace Classic.World.Messages
{
    public class MSG_SET_DUNGEON_DIFFICULTY : ServerMessageBase<Opcode>
    {
        public MSG_SET_DUNGEON_DIFFICULTY() : base(Opcode.MSG_SET_DUNGEON_DIFFICULTY) { }
        public override byte[] Get() => this.Writer
            .WriteUInt32(0) // Difficulty
            .WriteUInt32((uint)((byte)0x00000001))
            .WriteUInt32(Convert.ToUInt32(false))
            .Build();
    }
}
