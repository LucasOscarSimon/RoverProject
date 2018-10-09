using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTest;

namespace Rover.UnitTests
{
    [TestFixture]
    public class RoverTests
    {
        private Position _position;
        private PositionInfo _positionInfo;
        private TechTest.Rover _rover;
        private Dictionary<string, Commands> _equivalenceCommands;
        
        
        [SetUp]
        public void SetUp()
        {
            _position = new Position();
            _positionInfo = new PositionInfo();
            _rover = new TechTest.Rover(_position,_positionInfo);
            _equivalenceCommands = new Dictionary<string,Commands>
            {
                { "L", Commands.TurnLeft},
                { "R", Commands.TurnRight},
                { "F", Commands.Forward}
            };
        }
        
        [Test]
        public void Move_WhenCalled_ModifyPosition()
        {
            
            _rover.Move(Commands.TurnLeft);
            
            Assert.That(_position.Facing, Is.EqualTo(CardinalPoints.West));
        }
        
        [Test]
        [Ignore("Move needs to be refactored ...?")]
        [TestCase(null)]
        public void Move_InputCommandIsInvalid_MsgInvalidCommand(Commands direction)
        {
            
            _rover.Move(direction);
            
            Assert.That(_position.Facing, Is.EqualTo(CardinalPoints.West));
        }
    }
}