using System;
using Xunit;

namespace TrainEngine.Tests
{
    public class TrackOrmTests
    {
        [Fact]
        public void When_OnlyAStationIsProvided_Expect_TheResultOnlyToContainAStationWithId1()
        {
            // Arrange
            string track = "[1]";
            EngineOrms trackOrm = new();

            // Act
            var result = trackOrm.ParseTrackDescription(track);

            // Assert
            //Assert.IsType<Station>(result.TackPart[0]);
            //Station s = (Station)result.TackPart[0];
            //Assert.Equal(1, s.Id);
        }

        [Fact]
        public void When_ProvidingTwoStationsWithOneTrackBetween_Expect_TheTrackToConcistOf3Parts()
        {
            // Arrange
            string track = "[1]-[2]";
            EngineOrms trackOrm = new();

            // Act
            var result = trackOrm.ParseTrackDescription(track);

            // Assert
            Assert.Equal(3, result.NumberOfTrackParts);
        }

        [Fact]
        public void Read_TimeTable()
        {

        }

        [Fact]
        public void Write_TimeTable()
        {

        }

    }
}
