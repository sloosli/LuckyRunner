using System;
using System.Collections.Generic;
using System.Linq;
using LuckyTower.RoomGeneration;

namespace LuckyRunner.Utils
{
    internal static class SegmentParser
    {
        public static List<string> ParseCurrentSegment(Room startRoom)
        {
            var floors = new List<string>();

            var currentRoom = startRoom;
            while (currentRoom != null)
            {
                var currentRoomExitDoors = string.Empty;
                var doorIndex = 0;
                Room nextRoom = null;
                foreach (var door in currentRoom.ExitDoors)
                {
                    ++doorIndex;
                    if (door.Type != Door.DoorType.Exit)
                    {
                        currentRoomExitDoors += $"{doorIndex}) Other; ";
                        continue;
                    }

                    var currentDoor = GetRoomFlags(door.TargetRoom);
                    currentRoomExitDoors += $"{doorIndex}) {currentDoor};";
                    if (door.TargetRoom.RoomType.HasFlag(RoomType.Exit))
                    {
                        var exitDoor = door.TargetRoom.ExitDoors
                                           .FirstOrDefault(d => (d.Type.HasFlag(Door.DoorType.Exit)));
                        nextRoom = exitDoor?.TargetRoom;
                    }
                }

                floors.Add(currentRoomExitDoors);
                currentRoom = nextRoom;
            }

            return floors;
        }
        
        public static string GetRoomFlags(Room room)
        {
            if (room == null)
                return string.Empty;

            var roomType = room.RoomType;
            var roomFlagNames = Enum.GetValues(roomType.GetType())
                                    .Cast<Enum>()
                                    .Where(value => roomType.HasFlag(value) && !Equals(value, RoomType.None))
                                    .Select(flag => flag.ToString());
            return string.Join(", ", roomFlagNames);
        }
    }
}