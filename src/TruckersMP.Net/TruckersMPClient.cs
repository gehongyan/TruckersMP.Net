using System.Threading.Tasks;

namespace TruckersMP.Net
{
    public class TruckersMPClient
    {
        public static async Task<Player> GetPlayerAsync(int truckersMPId)
        {
            return await new PlayerRequest().SendAsync(truckersMPId).ConfigureAwait(false);
        }

        public static async Task<Player> GetPlayerAsync(long steamId64)
        {
            return await new PlayerRequest().SendAsync(steamId64).ConfigureAwait(false);
        }

        public static async Task<Ban[]> GetBansAsync(int truckersMPId)
        {
            return await new BanRequest().SendAsync(truckersMPId).ConfigureAwait(false);
        }

        public static async Task<Ban[]> GetBansAsync(long steamId64)
        {
            return await new BanRequest().SendAsync(steamId64).ConfigureAwait(false);
        }

        public static async Task<Server[]> GetServersAsync()
        {
            return await new ServerRequest().SendAsync().ConfigureAwait(false);
        }

        public static async Task<int> GetGameTimeAsync()
        {
            return await new GameTimeRequest().SendAsync().ConfigureAwait(false);
        }

        public static async Task<EventsIndex> GetEventsIndexAsync()
        {
            return await new EventsIndexRequest().SendAsync().ConfigureAwait(false);
        }

        public static async Task<Event> GetEventInformationAsync(int id)
        {
            return await new EventRequest().SendAsync(id).ConfigureAwait(false);
        }

        public static async Task<VTCIndex> GetVTCIndexAsync()
        {
            return await new VTCIndexRequest().SendAsync().ConfigureAwait(false);
        }

        public static async Task<VTC> GetVTCInformationAsync(int id)
        {
            return await new VTCInformationRequest().SendAsync(id).ConfigureAwait(false);
        }

        public static async Task<VTC> GetVTCInformationAsync(string vtcSlug)
        {
            return await new VTCInformationRequest().SendAsync(vtcSlug).ConfigureAwait(false);
        }

        public static async Task<VTCNews> GetVTCNewsAsync(int id)
        {
            return await new VTCNewsRequest().SendAsync(id).ConfigureAwait(false);
        }

        public static async Task<VTCNews> GetVTCNewsAsync(string vtcSlug)
        {
            return await new VTCNewsRequest().SendAsync(vtcSlug).ConfigureAwait(false);
        }

        public static async Task<NewsPost> GetVTCNewsPostAsync(int vtcId, int postId)
        {
            return await new VTCNewsPostRequest().SendAsync(vtcId, postId).ConfigureAwait(false);
        }

        public static async Task<NewsPost> GetVTCNewsPostAsync(string vtcSlug, int postId)
        {
            return await new VTCNewsPostRequest().SendAsync(vtcSlug, postId).ConfigureAwait(false);
        }

        public static async Task<VTCRoles> GetVTCRolesAsync(int id)
        {
            return await new VTCRolesRequest().SendAsync(id).ConfigureAwait(false);
        }

        public static async Task<VTCRoles> GetVTCRolesAsync(string vtcSlug)
        {
            return await new VTCRolesRequest().SendAsync(vtcSlug).ConfigureAwait(false);
        }

        public static async Task<Role> GetVTCRoleInformationAsync(int vtcId, int roleId)
        {
            return await new VTCRoleInformationRequest().SendAsync(vtcId, roleId).ConfigureAwait(false);
        }

        public static async Task<Role> GetVTCRoleInformationAsync(string vtcSlug, int roleId)
        {
            return await new VTCRoleInformationRequest().SendAsync(vtcSlug, roleId).ConfigureAwait(false);
        }

        public static async Task<VTCMembers> GetVTCMembersAsync(int id)
        {
            return await new VTCMembersRequest().SendAsync(id).ConfigureAwait(false);
        }

        public static async Task<VTCMembers> GetVTCMembersAsync(string vtcSlug)
        {
            return await new VTCMembersRequest().SendAsync(vtcSlug).ConfigureAwait(false);
        }

        public static async Task<Member> GetVTCMemberInformationAsync(int vtcId, int memberId)
        {
            return await new VTCMemberInformationRequest().SendAsync(vtcId, memberId).ConfigureAwait(false);
        }

        public static async Task<Member> GetVTCMemberInformationAsync(string vtcSlug, int memberId)
        {
            return await new VTCMemberInformationRequest().SendAsync(vtcSlug, memberId).ConfigureAwait(false);
        }

        public static async Task<EventWithSimpleAttendances[]> GetVTCEventsAsync(int id)
        {
            return await new VTCEventsRequest().SendAsync(id).ConfigureAwait(false);
        }

        public static async Task<EventWithSimpleAttendances[]> GetVTCEventsAsync(string vtcSlug)
        {
            return await new VTCEventsRequest().SendAsync(vtcSlug).ConfigureAwait(false);
        }

        public static async Task<Event> GetVTCEventInformationAsync(int vtcId, int memberId)
        {
            return await new VTCEventInformationRequest().SendAsync(vtcId, memberId).ConfigureAwait(false);
        }

        public static async Task<Event> GetVTCEventInformationAsync(string vtcSlug, int memberId)
        {
            return await new VTCEventInformationRequest().SendAsync(vtcSlug, memberId).ConfigureAwait(false);
        }

        public static async Task<GameVersion> GetVersionAsync()
        {
            return await new VersionRequest().SendAsync().ConfigureAwait(false);
        }

        public static async Task<GameRules> GetRulesAsync()
        {
            return await new RulesRequest().SendAsync().ConfigureAwait(false);
        }
    }
}