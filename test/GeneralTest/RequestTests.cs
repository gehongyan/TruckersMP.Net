using System;
using System.Threading.Tasks;
using TruckersMP.Net.Exceptions;
using TruckersMP.Net.Extensions;
using TruckersMP.Net;
using Xunit;
using Xunit.Abstractions;

namespace GeneralTest
{
    public class RequestTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public RequestTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task PlayerTest()
        {
            PlayerRequest player = new();
            Player response = await player.SendAsync(6818);
            Assert.NotNull(response);

            response = await player.SendAsync(76561198046080290);
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await player.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);
        }

        [Fact]
        public async Task BanTest()
        {
            BanRequest ban = new();
            Ban[] response = await ban.SendAsync(3428452);
            Assert.NotNull(response);

            response = await ban.SendAsync(76561198046080290);
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await ban.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);
        }

        [Fact]
        public async Task ServerTest()
        {
            ServerRequest server = new();
            Server[] response = await server.SendAsync();
            Assert.NotNull(response);
        }

        [Fact]
        public async Task GameTimeTest()
        {
            GameTimeRequest gameTime = new();
            int response = await gameTime.SendAsync();

            DateTime dateTime = TruckersMPUtils.ParseGameTimeAsUTC(response);
            Assert.True(dateTime > DateTime.Now);
        }

        [Fact]
        public async Task EventsIndexTest()
        {
            EventsIndexRequest eventsIndex = new();
            EventsIndex response = await eventsIndex.SendAsync();
            Assert.NotNull(response);
        }

        [Fact]
        public async Task EventTest()
        {
            EventRequest @event = new();
            Event response = await @event.SendAsync(4535);
            Assert.NotNull(response);

            Assert.Equal(response.Attendances.Confirmed, response.Attendances.ConfirmedUsers.Length);
            Assert.Equal(response.Attendances.Unsure, response.Attendances.UnsureUsers.Length);
        }

        [Fact]
        public async Task VTCIndexTest()
        {
            VTCIndexRequest vtcIndex = new();
            VTCIndex response = await vtcIndex.SendAsync();
            Assert.NotNull(response);
        }

        [Fact]
        public async Task VTCTest()
        {
            VTCInformationRequest vtc = new();
            VTC response = await vtc.SendAsync(3645);
            Assert.NotNull(response);

            response = await vtc.SendAsync("snail-transport");
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await vtc.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCNewsTest()
        {
            VTCNewsRequest vtcNews = new();
            VTCNews response = await vtcNews.SendAsync(3645);
            Assert.NotNull(response);

            response = await vtcNews.SendAsync("snail-transport");
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await vtcNews.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCNewsPostTest()
        {
            VTCNewsPostRequest vtcNewsPost = new();
            NewsPost response = await vtcNewsPost.SendAsync(3645, 6360);
            Assert.NotNull(response);

            response = await vtcNewsPost.SendAsync("snail-transport", 6360);
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await vtcNewsPost.SendAsync(-1, -1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCRolesTest()
        {
            VTCRolesRequest vtcRole = new();
            VTCRoles response = await vtcRole.SendAsync(3645);
            Assert.NotNull(response);

            response = await vtcRole.SendAsync("snail-transport");
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await vtcRole.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCRoleInformationTest()
        {
            VTCRoleInformationRequest roles = new();
            Role response = await roles.SendAsync(3645, 10103);
            Assert.NotNull(response);

            response = await roles.SendAsync("snail-transport", 10103);
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await roles.SendAsync(-1, -1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCMembersTest()
        {
            VTCMembersRequest vtcMembers = new();
            VTCMembers response = await vtcMembers.SendAsync(3645);
            Assert.NotNull(response);

            response = await vtcMembers.SendAsync("snail-transport");
            Assert.NotNull(response);

            Assert.Equal(response.MembersCount, response.Members.Length);

            bool isError = false;
            try
            {
                response = await vtcMembers.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCMemberInformationTest()
        {
            VTCMemberInformationRequest member = new();
            Member response = await member.SendAsync(3645, 15449);
            Assert.NotNull(response);

            response = await member.SendAsync("snail-transport", 15449);
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await member.SendAsync(-1, -1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCEventsTest()
        {
            VTCEventsRequest vtcEvents = new();
            EventWithSimpleAttendances[] response = await vtcEvents.SendAsync(3645);
            Assert.NotNull(response);

            response = await vtcEvents.SendAsync("snail-transport");
            Assert.NotNull(response);

            bool isError = false;
            try
            {
                response = await vtcEvents.SendAsync(-1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VTCEventInformationTest()
        {
            VTCEventInformationRequest @event = new();
            Event response = await @event.SendAsync(3645, 4494);
            Assert.NotNull(response);

            response = await @event.SendAsync("snail-transport", 4494);
            Assert.NotNull(response);

            Assert.Equal(response.Attendances.Confirmed, response.Attendances.ConfirmedUsers.Length);
            Assert.Equal(response.Attendances.Unsure, response.Attendances.UnsureUsers.Length);

            bool isError = false;
            try
            {
                response = await @event.SendAsync(-1, -1);
            }
            catch (PageNotFountException)
            {
                isError = true;
            }
            Assert.True(isError);

        }

        [Fact]
        public async Task VersionTest()
        {
            VersionRequest version = new();
            GameVersion response = await version.SendAsync();

            Assert.NotNull(response);
        }

        [Fact]
        public async Task RulesTest()
        {
            RulesRequest rules = new();
            GameRules response = await rules.SendAsync();

            Assert.NotNull(response);
        }
    }
}
